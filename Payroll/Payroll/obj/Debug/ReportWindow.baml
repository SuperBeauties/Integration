   M S B A M L   `   `   `  ����g  cMicrosoft.ReportViewer.WinForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91tSclr-namespace:Microsoft.Reporting.WinForms;assembly=Microsoft.ReportViewer.WinFormsMicrosoft.Reporting.WinForms  5   	   B >Payroll, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MakePayrollMakePayroll 5   	      MakePayroll.ReportWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   brvSclr-namespace:Microsoft.Reporting.WinForms;assembly=Microsoft.ReportViewer.WinForms     5   	   +localclr-namespace:MakePayroll     5   	     � Title$  
Отчет��5	   	   $	��300��6   $	��300��6$   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��27 �6   �� 5      $	��119 �6   �� 5      $��27 �6   �� 5      $	��119 �6   �� 5      $��5* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $	��49* �6   .+�5   
   �� $
��от��6   �� 5   
   $
��до��6   $��2��6   (  "System.Windows.Controls.DatePicker  5   
   $��1��6   $��2q�6%     5   
   $��3��6   $��2q�6%   �� 5   
   -   5        $��1��5      $��2��6   $��2q�62   $��Вывести��6=   6O   7  1System.Windows.Forms.Integration.WindowsFormsHost  5   
   $��2��6   $��5��6(      Child. 5      /   )Microsoft.Reporting.WinForms.ReportViewer  -   5        _reportViewer��5      5      5      5       