   M S B A M L   `   `   `  ����\  XInventoryManagementSystem.Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:InventoryManagementSystem.Project!InventoryManagementSystem.Project  5      ?    9InventoryManagementSystem.Project.PurchaseOrderManagement   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:InventoryManagementSystem.Project     5        N� Title$  Purchase Order Management��5      $	��600��6)   $	��800��66   .��5
      � ���#2C6B2F.+�5   
   �� -   5        $	��←��5      $��20(�6   
�������
������ $��40��5      $��40��6   $
��Left=�6   $	��Top=�6:   $��	10,10,0,0q�5      6   �� 5   
   $��Purchase Order Management��6   $��28(�65   
�������$��Center=�5      $��0,20,0,0q�61   � 5   
   $��
20,80,20,0q�6    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    .+�5$      �� $��	Supplier:��6   
�������$��14(�6;   $��0��6I   $��0��6V   $��Center=�6f   �� 5%      -   5        $��cmbSupplier��5%      $	��250��6*   $��30��66   $��0��6B   $��1��6O   $��5q�6_   5'      �� 5*      $��Order Date:��6   
�������$��14(�6=   $��1��6K   $��0��6X   $��Center=�6h   (  "System.Windows.Controls.DatePicker  5+      -   5        $��dpOrderDate��5+      $	��250��6,   $��30��68   $��1��6D   $��1��6Q   $��5q�6a   �� 5.      $��Status:��6   
�������$��14(�69   $��2��6G   $��0��6T   $��Center=�6d   �� 5/      -   5        $��	cmbStatus��5/      $	��250��6(   $��30��64   $��2��6@   $��1��6M   $��5q�6]   .@�50      �� $��Pending��6   �� 51      $��	Completed��6   �� 52      $��	Cancelled��6   53      �� 56      $��Total Amount:��6   
�������$��14(�6?   $��3��6M   $��0��6Z   $��Center=�6j   �� 57      -   5        $��txtTotalAmount��57      $	��250��6,   $��30��68   $��3��6D   $��1��6Q   $��5q�6a   
�������
���   �6   �� 5:      -   5        $��Submit��5:      $	��100��6&   $��30��62   $��4��6>   $��1��6K   $��5q�6[   ���#4CAF50
�������6�   5;      5<      5=      