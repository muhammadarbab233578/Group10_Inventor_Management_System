   M S B A M L   `   `   `  ����\  XInventoryManagementSystem.Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:InventoryManagementSystem.Project!InventoryManagementSystem.Project  5      7    1InventoryManagementSystem.Project.BarcodeScanning   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:InventoryManagementSystem.Project     5        N� Title$  BarcodeScanning��5	      .��5      � ���#2C6B2F.+�5   
   �� -   5        $	��←��5      $��20(�6   
�������
������ $��40��5      $��40��6   $
��Left=�6   $	��Top=�63   $��	10,10,0,0q�5      6   �� 5   
   $��Barcode Scanning��6   $��28(�6,   
�������$��Center=�5      $��0,20,0,0q�61   �� 5   
   $��Center=�6   $	��Top=�62   $��0,80,0,0q�6J   .+�5      �� $��Scan Barcode��6   $��20(�6,   
�������$��Center=�5      $��	0,20,0,10q�65   �� 5      -   5        $��
txtBarcode��5      $	��400��6(   $��40��64   $��5q�6@   $��16(�6K   $��Center=�5      $��Center=�63   5      5      � 5   
   $��20,160,20,20q�6    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5       $��* �6#    � RowDefinitions 5"      �� 5#      $
��Auto �6    �� 5$      $
��Auto �6    �� 5%      $
��Auto �6    �� 5&      $
��Auto �6    �� 5'      $
��Auto �6    �� 5(      $
��Auto �6    .+�5,      �� $��Product Name:��6   
�������$��14(�6?   $��0��6M   $��0��6Z   $��Center=�6j   �� 5-      -   5        $��txtProductName��5-      $	��250��6.   $��30��6:   $��0��6F   $��1��6S   $��5q�6c   
�������6n   �� 50      $
��SKU:��6   
�������$��14(�66   $��1��6D   $��0��6Q   $��Center=�6a   �� 51      -   5        $��txtSKU��51      $	��250��6&   $��30��62   $��1��6>   $��1��6K   $��5q�6[   
�������6f   �� 54      $��	Category:��6   
�������$��14(�6;   $��2��6I   $��0��6V   $��Center=�6f   �� 55      -   5        $��txtCategory��55      $	��250��6+   $��30��67   $��2��6C   $��1��6P   $��5q�6`   
�������6k   �� 58      $��	Quantity:��6   
�������$��14(�6;   $��3��6I   $��0��6V   $��Center=�6f   �� 59      -   5        $��txtQuantity��59      $	��250��6+   $��30��67   $��3��6C   $��1��6P   $��5q�6`   
�������6k   �� 5<      $��Unit Price:��6   
�������$��14(�6=   $��4��6K   $��0��6X   $��Center=�6h   �� 5=      -   5        $��txtUnitPrice��5=      $	��250��6,   $��30��68   $��4��6D   $��1��6Q   $��5q�6a   
�������6l   �� 5@      $��Barcode:��6   
�������$��14(�6:   $��5��6H   $��0��6U   $��Center=�6e   �� 5A      -   5        $��txtBarcodeDisplay��5A      $	��250��61   $��30��6=   $��5��6I   $��1��6V   $��5q�6f   
�������6q   5B      5C      5D      