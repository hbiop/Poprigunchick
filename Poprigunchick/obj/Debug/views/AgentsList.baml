   M S B A M L   `   `   `  ����H  DPoprigunchick, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Poprigunchick.viewsPoprigunchick.views  5      $    Poprigunchick.views.AgentsList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Poprigunchick.views     5        N� Title$  
AgentsList��5	       N� 
Background
 �����.��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� -   5         ��Name$ 
ButtonBack��5   .   $��0��6   $��0��6   $��
Назад��6B   6R   �� 5   
   -   5        $ ButtonAddAgents��5   .   $��2��6   $��0��6   $#��Добавить запись��6G   6a   �� 5   
   -   5        $ ButtonDeleteAgents��5   .   $��2��6   $��1��6   $!��Удалить запись��6J   6c   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridAgents��5   D   $��1��6   $��0��6    $��2��60      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �� ��6$   �� *	PhotoPath+5      5!      5#      5$      5%      