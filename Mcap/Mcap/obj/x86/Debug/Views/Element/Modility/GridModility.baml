   M S B A M L   `   `   `  ����?  ;Mcap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Mcap.Helper.ConverterMcap.Helper.Converter  5      .    (Mcap.Views.Element.Modility.GridModility   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9	converter#clr-namespace:Mcap.Helper.Converter     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      b ^GalaSoft.MvvmLight.Platform, Version=5.4.1.0, Culture=neutral, PublicKeyToken=5f873c45e98af8a1+mvvm http://www.galasoft.ch/mvvmlight  5      $��Stretch=�5
      $��Stretch=�5        � 	Resources  5      1   +Mcap.Helper.Converter.ActualHeightConverter   ActualHeightConverter��%   &	          5   
   6*   5      .��5      ]� -   5         ]�Name$ WorklistContainer��5      .+�5   
   �� $��Bottom=�6   $��40��6-    �� Orientation$ 
Horizontal=�69   .+�5      �� $��Có tất cả (��6   $
��Bold"�6*   $	��0,5q�6<   6K   �� 5      $
��Bold"�69   $	��0,5q�6K   ��6   �� *Modilities.Count+6Z   �� 5      $��) thiết bị��6   $
��Bold"�6)   $	��0,5q�6;   6J   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ patientAwait��5   4   $	��400��5      $   HorizontalScrollBarVisibility$
 Auto=�5      "   VerticalScrollBarVisibility$
 Auto=�5      $��1q�5   4      
IsReadOnly .    AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5      	   HorizontalGridLinesBrush	 �#d6d6d6��5      �� 
 �� RelativeSource
 �� *FindAncestor+ �� AncestorType" � �� 	Converter# [   �� ConverterParameter$	 180�� �� Path$ ActualHeight���5      �� *
Modilities+ J� InputBindings 5      �� 5       
 �� Key$ N��6    �� 	Modifiers$
 Ctrlf�6%    �� Command 66   �� *
AddCommand+d� 5!       d� MouseAction$ LeftDoubleClicke�6    5"      �� *SendOrderToWorkCommand+ �� CommandParameter 6@   ��  �� ElementName$ patientAwait��$ SelectedItem� � ContextMenu 5$      �� 5%      .@�5&      m� $��Chỉnh sửa��6    m� InputGestureText$ Ctrl+E��6Q    m� Command 62   �� *
AddCommand+6m   5'         ColumnHeaderStyle 5)      �� 5*       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5+      ��  �� Property � �� �� Value
 �����6C   �� 5,       � ��$
 Bold"�64   �� 5-       � ��
 ���F�6G   �� 5.       � ��$	 5,7q�60   �� 5/       � ��$ 1q�68   50         Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$
 TÊN��6%      Width$ * 6K   1  +System.Windows.Controls.DataGridBoundColumn    Binding  62   �� *Name+!   ElementStyle! 54      �� 55      " ��6    .�56      ��  � ��$
 Wrap=�6=   57      59        5:      $	 AET��6%   $ * 6J     62   �� *AET+6J     5;      $ MÃ MÁY��6%   $	 150 6N     65   �� *Code+6N     5<      $ LOẠI MÁY��6%   $	 150 6P     67   �� *Type+6P   4  .System.Windows.Controls.DataGridTemplateColumn  5=      $ TRẠNG THÁI��6)   $	 100 6=   "   HeaderStyle" 5>      �� 5?      "  6    .�5@      ��  � ��$ Center=�6K   �� 5A       � ��
 �����6K   �� 5B       � ��$
 Bold"�6<   �� 5C       � ��
 ���F�6O   �� 5D       � ��$	 5,7q�68   �� 5E       � ��$ 1q�6@   5F      #   CellTemplate# 5H      �� 5I      .R�5J      �� $ � Cursor$
$ Hand��6$   ���#4caf50
�������$	��0,3q�6Z   $	��100��6g   $��Center=�6s   $��10(�6�   .��6�   	CHO PHÉP6�   5K      5M      .	  (System.Windows.Interactivity.Interaction% 	  Triggers% 5O      /
  )System.Windows.Interactivity.EventTrigger
  5P      & 
  	EventName$& SelectionChanged��6!   .  (System.Windows.Interactivity.TriggerBase'   Actions.' 5Q      /  )GalaSoft.MvvmLight.Command.EventToCommand  (   Command( 5R      �� *SendOrderCommand+) �� Mode$) OneWay=�*   CommandParameter* 5S      �� $ patientAwait��$ SelectedItem�5U      5W      5X      5Y      