   M S B A M L   `   `   `  ����H  DPoprigunchick, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Poprigunchick.viewsPoprigunchick.views  5      (    "Poprigunchick.views.AgentRecordAdd   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Poprigunchick.views     5        N� Title$  AgentRecordAdd��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��40 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��
Агент��6   $��1��6    $��0��6-   �� 5   
   -   5        $��ComboBoxAgents��5      $��1��6)   $��1��69   �� 5   
   $��Дата продажи��6   $��2��6'   $��0��64   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��DatePickerDateSale��5      $��1��6/   $��2��6?   �� 5   
   $-��'Количество продуктов��6   $��3��6/   $��0��6<   �� 5   
   -   5         ��Name$ TextBoxProductCount��5      $��1��6/   $��3��6?   �� 5   
   -   5        $��
ButtonBack��5   >   $��
Назад��6   $��0��6!   $��5��61   6P   �� 5    
   -   5        $��	ButtonAdd��5    A   $��Добавить��6   $��1��6$   $��5��64   6R   5!      5"      