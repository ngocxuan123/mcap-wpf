   M S B A M L   `   `   `  ����?  ;Mcap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Mcap.Helper.ConverterMcap.Helper.Converter  5      /    )Mcap.Views.Element.DescriptionSample.Grid   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9	converter#clr-namespace:Mcap.Helper.Converter     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      b ^GalaSoft.MvvmLight.Platform, Version=5.4.1.0, Culture=neutral, PublicKeyToken=5f873c45e98af8a1+mvvm http://www.galasoft.ch/mvvmlight  5      $��Stretch=�5
      $��Stretch=�5        � 	Resources  5      1   +Mcap.Helper.Converter.ActualHeightConverter   ActualHeightConverter��%   &	          5   
   6*   5      .��5      ]� -   5         ]�Name$ WorklistContainer��5      .+�5   
   �� $��Bottom=�6   $��40��6-    �� Orientation$ 
Horizontal=�69   .+�5      �� $��Có tất cả (��6   $
��Bold"�6*   $	��0,5q�6<   6K   �� 5      $
��Bold"�68   $	��0,5q�6J   ��6   �� *Templates.Count+6Y   �� 5      $��) mẫu mô tả��6   $
��Bold"�6*   $	��0,5q�6<   6K   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ patientAwait��5   4   $	��400��5      $   HorizontalScrollBarVisibility$
 Auto=�5      "   VerticalScrollBarVisibility$
 Auto=�5      $��1q�5   3      
IsReadOnly .    AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5      	   HorizontalGridLinesBrush	 �#d6d6d6��5      �� 
 �� RelativeSource
 �� *FindAncestor+ �� AncestorType" � �� 	Converter# [   �� ConverterParameter$	 180�� �� Path$ ActualHeight���5      �� *	Templates+ J� InputBindings 5      �� 5       
 �� Key$ N��6    �� 	Modifiers$
 Ctrlf�6%    �� Command 66   �� *
AddCommand+d� 5!       d� MouseAction$ LeftDoubleClicke�6    5"      �� *SendOrderToWorkCommand+ �� CommandParameter 6@   ��  �� ElementName$ patientAwait��$ SelectedItem� � ContextMenu 5$      �� 5%      .@�5&      m� $��Chỉnh sửa��6    m� InputGestureText$ Ctrl+E��6Q    m� Command 62   �� *
AddCommand+6m   5'         ColumnHeaderStyle 5)      �� 5*       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5+      ��  �� Property � �� �� Value
 �����6C   �� 5,       � ��$
 Bold"�64   �� 5-       � ��
 ���F�6G   �� 5.       � ��$	 5,7q�60   �� 5/       � ��$ 1q�68   50         Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ MÃ MẪU MÔ TẢ��6%      Width$	 150 6T   1  +System.Windows.Controls.DataGridBoundColumn    Binding  6;   �� *Code+6T     54      $ TÊN MẪU MÔ TẢ��6%   $ * 6U     6<   �� *Name+!   ElementStyle! 55      �� 56      " ��6    .�57      ��  � ��$
 Wrap=�6=   58      5:      4  .System.Windows.Controls.DataGridTemplateColumn  5;      $ TRẠNG THÁI��6)   $	 100 6=   "   HeaderStyle" 5<      �� 5=      "  6    .�5>      ��  � ��$ Center=�6K   �� 5?       � ��
 �����6K   �� 5@       � ��$
 Bold"�6<   �� 5A       � ��
 ���F�6O   �� 5B       � ��$	 5,7q�68   �� 5C       � ��$ 1q�6@   5D      #   CellTemplate# 5F      �� 5G      .R�5H      �� $ � Cursor$
$ Hand��6$   ���#4caf50
�������$	��0,3q�6Z   $	��100��6g   $��Center=�6s   $��10(�6�   ��6�   �� *Status+6�   5I      5K      .	  (System.Windows.Interactivity.Interaction% 	  Triggers% 5M      /
  )System.Windows.Interactivity.EventTrigger
  5N      & 
  	EventName$& SelectionChanged��6!   .  (System.Windows.Interactivity.TriggerBase'   Actions.' 5O      /  )GalaSoft.MvvmLight.Command.EventToCommand  (   Command( 5P      �� *SendOrderCommand+) �� Mode$) OneWay=�*   CommandParameter* 5Q      �� $ patientAwait��$ SelectedItem�5S      5U      5V      5W      