   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      \ XInventoryManagementSystem.Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:InventoryManagementSystem.Project!InventoryManagementSystem.Project 5      <   6InventoryManagementSystem.Project.SalesOrderManagement   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6sys&clr-namespace:System;assembly=mscorlib     5      Alocal/clr-namespace:InventoryManagementSystem.Project     5        N� Title$  Sales Order Management��5
      .��5      � ���#2C6B2F.+�5   
   �� -   5        $	��←��5      $��20(�6   
�������
������ $��40��5      $��40��6   $
��Left=�6   $	��Top=�6:   $��	10,10,0,0q�5      6   �� 5   
   $��Sales Order Management��6   $��28(�62   
�������$��Center=�5      $��0,20,0,0q�61   � 5   
   $��
20,80,20,0q�6    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    .+�5$      �� $��Customer Name:��6   
�������$��14(�6@   $��0��6N   $��0��6[   $��Center=�6k   �� 5%      -   5        $��txtCustomerName��5%      $	��250��6-   $��30��69   $��0��6E   $��1��6R   $��5q�6b   �� 5(      $��Order Date:��6   
�������$��14(�6=   $��1��6K   $��0��6X   $��Center=�6h   (  "System.Windows.Controls.DatePicker  5)      -   5        $��dpOrderDate��5)      $	��250��6,   $��30��68   $��1��6D   $��1��6Q   $��5q�6a   
 �� Now   SelectedDate# Z 6l   �� 5,      $��Order Status:��6   
�������$��14(�6?   $��2��6M   $��0��6Z   $��Center=�6j   �� 5-      -   5        $��cmbOrderStatus��5-      $	��250��6-   $��30��69   $��2��6E   $��1��6R   $��5q�6b   .@�5.      �� $��Pending��6   �� 5/      $��Shipped��6   �� 50      $��	Cancelled��6   51      �� 54      $��Total Amount:��6   
�������$��14(�6?   $��3��6M   $��0��6Z   $��Center=�6j   �� 55      -   5        $��txtTotalAmount��55      $	��250��6,   $��30��68   $��3��6D   $��1��6Q   $��5q�6a   �� 58       �� Orientation$ 
Horizontal=�6   $��4��62   $��2��6?   $��Center=�6S   $��10q�6p   .+�59      �� -   5        $��	Add Order��59      ���#4CAF50
�������$	��100��6U   $��30��6a   $��5q�6m   6x   �� 5:      -   5        $��Update Order��5:      ���#4CAF50
�������$	��100��6X   $��30��6d   $��5q�6p   6{   �� 5;      -   5        $��Delete Order��5;      ���#4CAF50
�������$	��100��6X   $��30��6d   $��5q�6p   6{   5<      5=      &   System.Windows.Controls.DataGrid  5@   
   -	   5        $��salesOrderDataGrid��5@      $��20,350,20,0q�6-      AutoGenerateColumns$ False��6B      HeadersVisibility$ Column=�6^   ���#333333
�������   AlternatingRowBackground
 �����	   RowBackground
	 �����
�������$��1q�5C   '   
   ColumnHeaderStyle
 5D      �� 5E       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5F      ��  �� Property � �� �� Value �#4CAF5063   �� 5G       � ��
 �����63   �� 5H       � ��$
 Bold"�63   5I         Columns 5K      0  *System.Windows.Controls.DataGridTextColumn  5L      ,  &System.Windows.Controls.DataGridColumn   Header$ SalesOrderID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *SalesOrderID+6\     5M      $ Customer Name��6%   $ * 6]    6<   �� *CustomerName+6]     5N      $ 
Order Date��6%   $
 Auto 6W    69   �� *	OrderDate+6W     5O      $ Status��6%   $
 Auto 6U    65   �� *OrderStatus+6U     5P      $ Total Amount��6%   $
 Auto 6[    6;   �� *TotalAmount+6[   5R      5S      5T      