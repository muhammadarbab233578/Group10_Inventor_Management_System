   M S B A M L   `   `   `  ����\  XInventoryManagementSystem.Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:InventoryManagementSystem.Project!InventoryManagementSystem.Project  5      /    )InventoryManagementSystem.Project.Product   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:InventoryManagementSystem.Project     5        N� Title$  Product Management��5	      .��5      � ���#2C6B2F.+�5   
   �� -   5        $	��←��5      $��20(�6   
�������
������ $��40��5      $��40��6   $
��Left=�6(   $	��Top=�6C   $��	10,10,0,0q�5      6$   �� 5   
   $��Product Management��6   $��28(�6.   
�������$��Center=�5      $��0,20,0,0q�61   � 5   
   $��
20,80,20,0q�6    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    �� 5#      $
��Auto �6    .+�5'      �� $��Name:��6   
�������$��14(�67   $��0��6E   $��0��6R   $��Center=�6b   �� 5(      -   5        $��txtName��5(      $	��250��6%   $��30��61   $��0��6=   $��1��6J   $��5q�6Z   �� 5+      $
��SKU:��6   
�������$��14(�66   $��1��6D   $��0��6Q   $��Center=�6a   �� 5,      -   5        $��txtSKU��5,      $	��250��6$   $��30��60   $��1��6<   $��1��6I   $��5q�6Y   �� 5/      $��	Category:��6   
�������$��14(�6;   $��2��6I   $��0��6V   $��Center=�6f   �� 50      -   5        $��txtCategory��50      $	��250��6)   $��30��65   $��2��6A   $��1��6N   $��5q�6^   �� 53      $��	Quantity:��6   
�������$��14(�6;   $��3��6I   $��0��6V   $��Center=�6f   �� 54      -   5        $��txtQuantity��54      $	��250��6)   $��30��65   $��3��6A   $��1��6N   $��5q�6^   �� 57      $��Unit Price:��6   
�������$��14(�6=   $��4��6K   $��0��6X   $��Center=�6h   �� 58      -   5        $��txtUnitPrice��58      $	��250��6*   $��30��66   $��4��6B   $��1��6O   $��5q�6_   �� 5;      $��Barcode:��6   
�������$��14(�6:   $��5��6H   $��0��6U   $��Center=�6e   �� 5<      -   5        $��
txtBarcode��5<      $	��250��6(   $��30��64   $��5��6@   $��1��6M   $��5q�6]   �� 5?       �� Orientation$ 
Horizontal=�6   $��6��62   $��2��6?   $��Center=�6S   $��10q�6p   .+�5@      �� -   5        $��Add Product��5@      ���#4CAF50
�������$	��100��6W   $��30��6c   $��5q�6o   6z   �� 5A      -	   5        $��Update Product��5A      ���#4CAF50
�������$	��100��6Z   $��30��6f   $��5q�6r   6}   �� 5B      -
   5        $��Delete Product��5B      ���#4CAF50
�������$	��100��6Z   $��30��6f   $��5q�6r   6}   5C      5D      &   System.Windows.Controls.DataGrid  5G   
   -   5        $��productDataGrid��5G      $��20,394,87,20q�6*      AutoGenerateColumns$ False��6@      HeadersVisibility$ Column=�6\   ���#333333
�������   AlternatingRowBackground
 �����   RowBackground
 �����
�������$��1q�5L         ColumnHeaderStyle 5M      �� 5N      	 �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"	  6   .�5O      �� 
 �� Property
 � �� �� Value �#4CAF5063   �� 5P      
 � ��
 �����63   �� 5Q      
 � ��$
 Bold"�63   5R         Columns 5T      0  *System.Windows.Controls.DataGridTextColumn  5U      ,  &System.Windows.Controls.DataGridColumn   Header$ 	ProductID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *	ProductID+6V     5V      $
 Name��6%   $ * 6T    63   �� *Prodectsname+6T     5W      $	 SKU��6%   $ * 6J    62   �� *SKU+6J     5X      $ Category��6%   $ * 6T    67   �� *
Category+6T     5Y      $ Quantity��6%   $
 Auto 6T    67   �� *
Quantity+6T     5Z      $ 
Unit Price��6%   $
 Auto 6W    69   �� *	UnitPrice+6W     5[      $ Barcode��6%   $ * 6R    66   �� *	Barcode+6R   5]      5^      5_      