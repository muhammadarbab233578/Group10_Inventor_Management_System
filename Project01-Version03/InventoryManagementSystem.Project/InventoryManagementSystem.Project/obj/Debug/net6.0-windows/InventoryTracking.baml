   M S B A M L   `   `   `  ����\  XInventoryManagementSystem.Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:InventoryManagementSystem.Project!InventoryManagementSystem.Project  5      9    3InventoryManagementSystem.Project.InventoryTracking   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:InventoryManagementSystem.Project     5        N� Title$  Inventory Tracking��5	      .��5      � ���#2C6B2F.+�5   
   �� -   5        $	��←��5      $��20(�6   
�������
������ $��40��5      $��40��6   $
��Left=�6   $	��Top=�6:   $��	10,10,0,0q�5      6   �� 5   
   $��Inventory Tracking��6   $��28(�6.   
�������$��Center=�5      $��0,20,0,0q�61   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $	��Top=�6K   $��0,70,0,0q�6c   .+�5      �� -   5        $��	txtSearch��5      $	��300��6'   $��30��63   $��5q�6?   
�������
���   �6]   �� 5      -   5        $��Search��5      $	��100��6&   $��30��62   $��5q�6>   ���#4CAF50
�������6q   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��inventoryDataGrid��5      $��20,120,20,20q�6,      AutoGenerateColumns$ False��6B      HeadersVisibility$ Column=�6^   ���#333333
�������   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	ProductID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *	ProductID+6V     5      $
 Name��6%   $ * 6L    63   �� *Name+6L     5      $	 SKU��6%   $ * 6J    62   �� *SKU+6J     5       $ Category��6%   $ * 6T    67   �� *
Category+6T     5!      $ Quantity��6%   $
 Auto 6T    67   �� *
Quantity+6T     5"      $ Location��6%   $
 Auto 6T    67   �� *
Location+6T     5#      $ Batch/Serial��6%   $ * 6]    6;   �� *BatchOrSerial+6]     5$      $ Last Movement��6%   $
 Auto 6a    6<   �� *LastMovementDate+6a   5&      5'      5(      