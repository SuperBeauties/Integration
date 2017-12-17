using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakePayroll
{
    public class Queries
    {
        DataClassesDataContext db;
        public Queries()
        {
            db = new DataClassesDataContext();
        }

        public List<PayrollView> getPayrollView()
        {
            return db.PayrollView.ToList();
        }

        public PayrollView addPayroll(PayrollView payrollView)
        {
            Payroll payroll = new Payroll();
            payroll.number = payrollView.number;
            payroll.date = payrollView.date;
            db.Payroll.InsertOnSubmit(payroll);
            db.SubmitChanges();
            payrollView.id = payroll.id;
            return payrollView;
        }

        public PayrollView editPayroll(PayrollView payrollView)
        {
            Payroll payroll = db.Payroll.Where(c => c.id == payrollView.id).FirstOrDefault();
            payroll.number = payrollView.number;
            payroll.date = payrollView.date;
            db.SubmitChanges();
            return payrollView;
        }

        public void removePayroll(PayrollView payrollView)
        {
            Payroll payroll = db.Payroll.Where(c => c.id == payrollView.id).FirstOrDefault();
            List<TablePayroll> tablePayroll = db.TablePayroll.Where(c => c.payroll == payrollView.id).ToList();
            db.TablePayroll.DeleteAllOnSubmit(tablePayroll);
            db.Payroll.DeleteOnSubmit(payroll);
            db.SubmitChanges();
        }

        public List<TablePayrollView> getTablePayroll(int idPayroll)
        {
            return db.TablePayrollView.Where(c => c.payroll == idPayroll).ToList();
        }

        public TablePayrollView addRowTablePayroll(TablePayrollView rowTable)
        {
            TablePayroll rowTablePayroll = new TablePayroll();
            rowTablePayroll.payroll = rowTable.payroll;
            rowTablePayroll.employee = rowTable.employee;
            rowTablePayroll.sum = rowTable.sum;
            rowTablePayroll.ndfl = rowTable.ndfl;
            db.TablePayroll.InsertOnSubmit(rowTablePayroll);
            db.SubmitChanges();
            rowTable.id = rowTablePayroll.id;
            return rowTable;
        }

        public void removeTablePayroll(TablePayrollView rowTable)
        {
            TablePayroll rowTablePayroll = db.TablePayroll.Where(c => c.id == rowTable.id).FirstOrDefault();
            db.TablePayroll.DeleteOnSubmit(rowTablePayroll);
            db.SubmitChanges();
        }

        public bool saveTablePayroll(List<TablePayrollView> tablePayroll)
        {
            int emptyFieldsCount = tablePayroll.Where(c => c.employee == null || c.sum == null || c.ndfl == null).Count();
            if (emptyFieldsCount != 0)
            {
                return false;
            }

            foreach (var rowTable in tablePayroll)
            {
                TablePayroll rowTablePayroll = db.TablePayroll.Where(c => c.id == rowTable.id).FirstOrDefault();
                rowTablePayroll.employee = rowTable.employee;
                rowTablePayroll.sum = rowTable.sum;
                rowTablePayroll.ndfl = rowTable.ndfl;
                db.SubmitChanges();
            }
            return true;
        }

        public List<EmployeeView> getEmployees(DateTime date)
        {
            List<EmployeeView> list = db.EmployeeView
                .Where(l => (db.EmployeesSalary.Where(c => c.employee == l.id
                    && db.Salary.Where(q => q.id == c.salary).FirstOrDefault().dateStart <= date
                    && (db.Salary.Where(q => q.id == c.salary).FirstOrDefault().dateEnd == null
                    || db.Salary.Where(q => q.id == c.salary).FirstOrDefault().dateEnd >= date)).FirstOrDefault() != null))
                .ToList();

            return list;
        }

        public int getTabelNumber()
        {
            if (db.Payroll.Count() == 0)
            {
                return 1;
            }
            return db.Payroll.Max(c => Convert.ToInt32(c.number)) + 1;
        }

        public double? getSum(int emp, DateTime date)
        {
            EmployeesSalary employeesSalary = db.EmployeesSalary.Where(c => c.employee == emp
            && db.Salary.Where(q => q.id == c.salary).FirstOrDefault().dateStart <= date
            && (db.Salary.Where(q => q.id == c.salary).FirstOrDefault().dateEnd == null
            || db.Salary.Where(q => q.id == c.salary).FirstOrDefault().dateEnd >= date)).FirstOrDefault();
            return db.Salary.Where(c => c.id == employeesSalary.salary).FirstOrDefault().sum;
        }
    }
}
