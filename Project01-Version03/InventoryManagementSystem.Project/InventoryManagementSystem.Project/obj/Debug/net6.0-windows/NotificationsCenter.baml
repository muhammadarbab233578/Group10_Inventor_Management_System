   M S B A M L   `   `   `  ����%  !InventoryManagementSystem.Project;    5InventoryManagementSystem.Project.NotificationsCenter   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  Notifications Center��5      $	��557��6$   $	��800��61   .��5	      � ���#2B6B2F$��-102,0,-91,91q�6     � RowDefinitions 5
   
   �� 5      �� 5      $
��Auto �6   .+�5   
   �� -   5        $	��←��5      $��20(�6   
�������
������ $��40��5      $��40��6   $
��Left=�6   $	��Top=�63   $��	10,10,0,0q�5      6   �� 5   
   $��Notifications Center��6   $��28(�60   
�������$��Center=�5      $��0,20,0,0q�61   $��2��6C   &   System.Windows.Controls.DataGrid  5   
   -   5        $��notificationsDataGrid��5      $��20,80,20,20q�60      AutoGenerateColumns$ False��6E      HeadersVisibility$ Column=�5      ���#333333
�������$��2��6V      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ NotificationID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *NotificationID+6`     5      $
 Date��6%   $
 Auto 6L    63   �� *Date+6L     5      $
 Type��6%   $ * 6L    63   �� *Type+6L     5      $ Message��6%   $ * 6R    66   �� *	Message+6R     5      $ Status��6%   $
 Auto 6P    65   �� *Status+6P   5       �� 5#   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $	��Top=�6K   $��	0,342,0,0q�6c   $��1��6v   .+�5$      �� -   5        $��Clear All Notifications��5$      ���#4CAF50
�������$	��200��6_   $��40��6k   $��5q�6w   6�   5%      5&      5'      