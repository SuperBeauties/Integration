   M S B A M L   `   `   `  ����B  >Payroll, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MakePayrollMakePayroll  5   	       MakePayroll.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:MakePayroll     5   	     � Title$:  4Начисление заработной платы��5   	   $	��360��6-   $	��635��6:   .��5	      �� .+�5
   
   �  � ColumnDefinitions 5      �� 5      $��31 �6#   �� 5      $��31 �6#   �� 5      $��31 �6#   �� 5      $
��500* �6#   .+�5      �� -   5        $��+��5      $
��Bold"�6!   $��2q�63   6>   �� 5      -   5        $��1��5      $��-��6%   $
��Bold"�61   $��2q�6C   6N   �� 5      -   5        $��2��5      $��/��6%   $
��Bold"�61   $��2q�6C   6N   5      &   System.Windows.Controls.DataGrid  5   
   $	��271��6      CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .  ��5      �� *payrollView+ �� SelectedItem 5      �� *
rowPayroll+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
Номер��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 64   �� *number+  5      $	 
Месяц��6%   
 64   �� *month+5      �� 5    
   -   5        $��2q�5       $��Вывести отчет��6   64   5!      5"      