   M S B A M L   `   `   `  ����\  XInventoryManagementSystem.Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:InventoryManagementSystem.Project!InventoryManagementSystem.Project  5      :    4InventoryManagementSystem.Project.SupplierManagement   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:InventoryManagementSystem.Project     5        N� Title$  Supplier Management��5   0   .��5	      � ���#2C6B2F.+�5   
   �� -   5        $	��←��5      $��20(�6   
�������
������ $��40��5      $��40��6   $
��Left=�6'   $	��Top=�6B   $��	10,10,0,0q�5      6#   �� 5   
   $��Supplier Management��6   $��28(�6/   
�������$��Center=�5      $��0,20,0,0q�61   � 5   
   $��
20,80,20,0q�6    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5"      �� $��Supplier Name:��6   
�������$��14(�6@   $��0��6N   $��0��6[   $��Center=�6k   �� 5#      -   5        $��txtSupplierName��5#      $	��250��6-   $��30��69   $��0��6E   $��1��6R   $��5q�6b   �� 5&      $��Contact Name:��6   
�������$��14(�6?   $��1��6M   $��0��6Z   $��Center=�6j   �� 5'      -   5        $��txtContactName��5'      $	��250��6,   $��30��68   $��1��6D   $��1��6Q   $��5q�6a   �� 5*      $��Phone:��6   
�������$��14(�68   $��2��6F   $��0��6S   $��Center=�6c   �� 5+      -   5        $��txtPhone��5+      $	��250��6&   $��30��62   $��2��6>   $��1��6K   $��5q�6[   �� 5.      $��Email:��6   
�������$��14(�68   $��3��6F   $��0��6S   $��Center=�6c   �� 5/      -   5        $��txtEmail��5/      $	��250��6&   $��30��62   $��3��6>   $��1��6K   $��5q�6[   �� 52      $��Address:��6   
�������$��14(�6:   $��4��6H   $��0��6U   $��Center=�6e   �� 53      -   5        $��
txtAddress��53      $	��250��6(   $��4��64   $��1��6A   $��202,5,203,55q�6Q    �� TextWrapping$
 Wrap=�6g    �� AcceptsReturn$
 True��6{   $��2��6�   �� 56       �� Orientation$ 
Horizontal=�6   $��5��62   $��2��6?   $��Center=�6S   $��10q�6p   .+�57      �� -   5        $��Add Supplier��57      ���#4CAF50
�������$	��100��6X   $��30��6d   $��5q�6p   6{   �� 58      -   5        $��Update Supplier��58      ���#4CAF50
�������$	��100��6[   $��30��6g   $��5q�6s   6~   �� 59      -	   5        $��Delete Supplier��59      ���#4CAF50
�������$	��100��6[   $��30��6g   $��5q�6s   6~   5:      5;      &   System.Windows.Controls.DataGrid  5>   
   -
   5        $��supplierDataGrid��5>      $��20,326,20,0q�6+      AutoGenerateColumns$ False��6@      HeadersVisibility$ Column=�6\   ���#333333
�������   Columns 5?      0  *System.Windows.Controls.DataGridTextColumn  5@      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
SupplierID��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 Auto 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *
SupplierID+6X     5A      $	 Supplier Name��6%   $
 * 6]    6<   �� *SupplierName+6]     5B      $	 Contact Name��6%   $
 * 6[    6;   �� *ContactName+6[     5C      $	 Phone��6%   $

 Auto 6N    64   �� *Phone+6N     5D      $	 Email��6%   $
 * 6N    64   �� *Email+6N     5E      $	 Address��6%   $
 * 6R    66   �� *	Address+6R   5G      5H      5I      