   M S B A M L   `   `   `  ����G  CNewExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:NewExpenseItNewExpenseIt  5          NewExpenseIt.ReportPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:NewExpenseIt     5        N� Title$  
ReportPage��5	      .��5      � ��5   
   �� 5       �� ImageSource$* $wallpaperflare.com_wallpaper (1).jpg��6    � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��1��6   $��Expence Report For��6       
LabelStyle#��[  6=   �� 5   
   $��1��6   $��1��6"    �� Orientation$ 
Horizontal=�62   .+�5      �� $��Name :��6     SubLabelStyle#��[ 6%   �� 5      #��[ 6-   ��6   �� *Name+6-   5      �� 5    
   $��2��6   $��1��6"   $ 
Horizontal=�62   .+�5!      �� $��Department :��6   #��[ 6+   �� 5"      -   5        $��DepartmentData��5"      #��[ 6*   5#      � 5%   
   $��1��6   $��3��6   .+�5&      &   System.Windows.Controls.DataGrid  -   5        $��DataGridName��5&         AutoGenerateColumns .  $	��Top=�6G   $
��Left=�6_     ColumnHeaderStyle   ColumnHeaderStyle# [ 6z      Columns 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn   Header$ Amount��6)   	   
FontFamily$	 Cascadia Code)�6Z   
   FontSize$
 24Q�6u   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *PersonAmount+6u     5)      $ ExpenseType��6)   $	 Cascadia Code)�6d   $
 24Q�6    6>   �� *PersonExpenseType+6   5+      5,      �� 5-   
   $��0��6   $��3��6%   $��Bottom=�63   $
��Left=�6N   $ 
Horizontal=�6j   .+�5.      �� -   5        $
��back��5.        ButtonStyle#��[ 6$   $��20q�6I   6U   �� 5/      -   5        $��Modify��5/      #��[ 6&   $��20q�6K   6W   50      51      52      