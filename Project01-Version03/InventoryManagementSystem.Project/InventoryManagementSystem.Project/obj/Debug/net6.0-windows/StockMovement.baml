   M S B A M L   `   `   `  ����\  XInventoryManagementSystem.Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:InventoryManagementSystem.Project!InventoryManagementSystem.Project  5      5    /InventoryManagementSystem.Project.StockMovement   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:InventoryManagementSystem.Project     5        N� Title$  StockMovement��5   0   .��5	      � ���#2C6B2F$��	0,0,0,-70q�6    .+�5
   
   �� -   5        $	��←��5
      $��20(�6   
�������
������ $��40��5      $��40��6   $
��Left=�6(   $	��Top=�6C   $��	10,10,0,0q�5      6$   �� 5   
   $��Stock Movement��6   $��28(�6*   
�������$��Center=�5      $��0,20,0,0q�61   � 5   
   $��20,80,20,-54q�6    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5!      �� $��Product:��6   
�������$��14(�6:   $��0��6H   $��0��6U   $��Center=�6e   �� 5"      -   5        $��
cmbProduct��5"      $	��250��6)   $��30��65   $��0��6A   $��1��6N   $��5q�6^   5$      �� 5'      $��Movement Type:��6   
�������$��14(�6@   $��1��6N   $��0��6[   $��Center=�6k   �� 5(      -   5        $��cmbMovementType��5(      $	��250��6.   $��30��6:   $��1��6F   $��1��6S   $��5q�6c   .@�5)      �� $��IN��6   �� 5*      $	��OUT��6   �� 5+      $��
ADJUSTMENT��6   5,      �� 5/      $��	Quantity:��6   
�������$��14(�6;   $��2��6I   $��0��6V   $��Center=�6f   �� 50      -   5        $��txtQuantity��50      $	��250��6)   $��30��65   $��2��6A   $��1��6N   $��5q�6^   51      �� 54      $��Movement Date:��6   
�������$��14(�6@   $��3��6N   $��0��6[   $��Center=�6k   (  "System.Windows.Controls.DatePicker  55      -   5        $��dpMovementDate��55      $��198,0,199,70q�6/    J� RenderTransformOrigin$ 1.075,0.657&�6s   $��1��6�   $��2��6�   $��3��6�      SelectedDate 6E   �� *SelectedMovementDate+z�56      V� 57      .~�58      ��  �� ScaleX$ 1Q�6)   �� 59      �� 5:      T� 5;      5<      5>      �� 5A      $��Description:��6   
�������$��14(�6>   $��4��6L   $��0��6Y   $��Center=�6i   �� 5B      -   5        $��txtDescription��5B      $	��250��6,   $��3��68   $��1��6E   $��198,29,199,21q�6U    �� TextWrapping$
 Wrap=�5C       �� AcceptsReturn$
 True��6*   $��2��6?   �� 5F       �� Orientation$ 
Horizontal=�6   $��5��62   $��2��6?   $��Center=�6S   $��10q�6p   .+�5G      �� -   5        $��Add Movement��5G      ���#4CAF50
�������$	��100��6X   $��30��6d   $��5q�6p   $ 0.533,-0.731&�6�   �� 5H      -   5        $��Update Movement��5H      ���#4CAF50
�������$	��100��6[   $��30��6g   $��5q�6s   $ 0.611,0.996&�6�   �� 5I      -	   5        $��Delete Movement��5I      ���#4CAF50
�������$	��100��6[   $��30��6g   $��5q�6s   6~   5J      5K      &   System.Windows.Controls.DataGrid  5N   
   -
   5        $��stockMovementDataGrid��5N      $��20,350,20,0q�60   	   AutoGenerateColumns$	 False��6E   
   HeadersVisibility$
 Column=�6a   ���#333333
�������   AlternatingRowBackground
 �����   RowBackground
 �����
�������$��1q�5Q   '   $	��160��6;   $	��Top=�6H      ColumnHeaderStyle 5R      �� 5S       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5T      ��  �� Property � �� �� Value �#4CAF5063   �� 5U       � ��
 �����63   �� 5V       � ��$
 Bold"�63   5W         Columns 5Y      0  *System.Windows.Controls.DataGridTextColumn  5Z      ,  &System.Windows.Controls.DataGridColumn   Header$ Movement ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *
MovementID+6Y     5[      $ 
Product ID��6%   $	 150 6Y    69   �� *ProductName+6Y     5\      $ Movement Type��6%   $	 150 6]    6<   �� *MovementType+6]     5]      $ Quantity��6%   $	 100 6T    67   �� *
Quantity+6T     5^      $ Movement Date��6%   $	 150 6]    6<   �� *MovementDate+6]     5_      $ Description��6%   $	 250 6[    6:   �� *Descriptions+6[   5a      5b      5c      