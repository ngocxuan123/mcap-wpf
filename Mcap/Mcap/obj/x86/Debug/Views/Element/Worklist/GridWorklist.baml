   M S B A M L   `   `   `  ����?  ;Mcap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Mcap.Helper.ConverterMcap.Helper.Converter  5      .    (Mcap.Views.Element.Worklist.GridWorklist   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9	converter#clr-namespace:Mcap.Helper.Converter     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      b ^GalaSoft.MvvmLight.Platform, Version=5.4.1.0, Culture=neutral, PublicKeyToken=5f873c45e98af8a1+mvvm http://www.galasoft.ch/mvvmlight  5      $��Stretch=�5
      $��Stretch=�5        � 	Resources  5      1   +Mcap.Helper.Converter.ActualHeightConverter   ActualHeightConverter��%   &	          5   
   6*   5      .��5      ]� -   5         ]�Name$ WorklistContainer��5      .+�5   
   �� $��Bottom=�6   $��40��6-    �� Orientation$ 
Horizontal=�69   .+�5      �� $��Có tất cả (��6   $
��Bold"�6*   $	��0,5q�6<   6K   �� 5      $
��Bold"�6@   $	��0,5q�6R   ��6   �� *Worklist.Worklist.Count+6a   �� 5      $%��) ca chụp cần thực hiện��6   $
��Bold"�66   $	��0,5q�6H   6W   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ patientAwait��5   4   $	��400��5      $   HorizontalScrollBarVisibility$
 Auto=�5      "   VerticalScrollBarVisibility$
 Auto=�5      $��1q�5   ;      
IsReadOnly .    AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5      	   HorizontalGridLinesBrush	 �#d6d6d6��5      �� 
 �� RelativeSource
 �� *FindAncestor+ �� AncestorType" � �� 	Converter# [   �� ConverterParameter$	 280�� �� Path$ ActualHeight���5      �� *Worklist.Worklist+ J� InputBindings 5      �� 5       
 �� Key$ N��6    �� 	Modifiers$
 Ctrlf�6%    �� Command 66   �� *
AddCommand+d� 5!       d� MouseAction$ LeftDoubleClicke�6    5"      �� *SendOrderToWorkCommand+ �� CommandParameter 6@   ��  �� ElementName$ patientAwait��$ SelectedItem� � ContextMenu 5$      �� 5%      .@�5&      m� $��
Gọi tên��6    m� InputGestureText$ Ctrl+K��6O    m� Command 60   �� *
AddCommand+6k   m� 5'      $��Đồng bộ��6   $ Ctrl+B��6O    60   �� *
AddCommand+6k   m� 5(      $��Vào chụp��6   $ Ctrl+B��6P    61   �� *
AddCommand+6l   m� 5)      $��Hủy kết quả��6   $ Ctrl+B��6S    64   �� *
AddCommand+6o   m� 5*      $��Thoát ca chụp��6   $ Ctrl+B��6U    66   �� *
AddCommand+6q   5+         ColumnHeaderStyle 5-      �� 5.       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5/      ��  �� Property � �� �� Value
 �����6C   �� 50       � ��$
 Bold"�64   �� 51       � ��
 ���F�6G   �� 52       � ��$	 5,7q�60   �� 53       � ��$ 1q�68   54         Columns 56      4  .System.Windows.Controls.DataGridTemplateColumn  57      ,  &System.Windows.Controls.DataGridColumn   Width$ 70 6)      Header$ 
Nội trú��64       CellTemplate  58      �� 59      .R�5:      �� {�.  $
��Left=�6Z   ! d� 	IsChecked! 6'   �� *
IsBoarding+6w   5;      5=      0  *System.Windows.Controls.DataGridTextColumn  5>      $	 STT��6%   $	 100 6K   1  +System.Windows.Controls.DataGridBoundColumn"   Binding" 62   �� *Name+6K     5?      $ NGÀY CHỈ ĐỊNH��6%   $	 150 6U   " 6<   �� *Name+6U     5@      $ TÊN BỆNH NHÂN��6%   $	 150 6U   " 6<   �� *Name+6U     5A      $ 	NĂM SINH��6%   $	 100 6W   " 67   �� *RequestCode+6W     5B      $ TÊN DỊCH VỤ��6%   $ * 6Z   " 6:   �� *RequestCode+6Z     5C      $ TRẠNG THÁI��6)   $	 150 6=   #   HeaderStyle# 5D      �� 5E      "  6    .�5F      ��  � ��$ Center=�6K   �� 5G       � ��
 �����6K   �� 5H       � ��$
 Bold"�6<   �� 5I       � ��
 ���F�6O   �� 5J       � ��$	 5,7q�68   �� 5K       � ��$ 1q�6@   5L        5N      �� 5O      .R�5P      �� $ � Cursor$
$ Hand��6$   ���#999
�������$	��0,3q�6W   $	��120��6d   $��Center=�6p   .��6�   ĐANG CHỜ6�   5Q      5S      .	  (System.Windows.Interactivity.Interaction% 	  Triggers% 5U      /
  )System.Windows.Interactivity.EventTrigger
  5V      & 
  	EventName$& SelectionChanged��6!   .  (System.Windows.Interactivity.TriggerBase'   Actions.' 5W      /  )GalaSoft.MvvmLight.Command.EventToCommand  (   Command( 5X      �� *SendOrderCommand+) �� Mode$) OneWay=�*   CommandParameter* 5Y      �� $ patientAwait��$ SelectedItem�5[      5]      5^      5_      