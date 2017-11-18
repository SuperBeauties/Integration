﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MakePayroll {
    /// <summary>
    /// Логика взаимодействия для Начисление_заработной_платы.xaml
    /// </summary>
    public partial class PayrollWindow : Window {
        PayrollWindowViewModel view;
        public PayrollWindow() {
            InitializeComponent();
            view = new PayrollWindowViewModel();
            DataContext = view;
        }

        private void add_Click(object sender, RoutedEventArgs e) {
            view.add();
        }

        private void remove_Click(object sender, RoutedEventArgs e) {
            view.remove();
        }
    }
}