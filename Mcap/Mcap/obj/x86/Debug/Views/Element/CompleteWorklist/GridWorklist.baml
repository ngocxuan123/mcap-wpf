   M S B A M L   `   `   `  ����?  ;Mcap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Mcap.Views.Element.CompleteWorklist#Mcap.Views.Element.CompleteWorklist  5      =#clr-namespace:Mcap.Helper.ConverterMcap.Helper.Converter  5      6    0Mcap.Views.Element.CompleteWorklist.GridWorklist   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:Mcap.Views.Element.CompleteWorklist     5      9	converter#clr-namespace:Mcap.Helper.Converter     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      b ^GalaSoft.MvvmLight.Platform, Version=5.4.1.0, Culture=neutral, PublicKeyToken=5f873c45e98af8a1+mvvm http://www.galasoft.ch/mvvmlight  5	        � 	Resources  5      1   +Mcap.Helper.Converter.ActualHeightConverter   ActualHeightConverter��%   &	          5   
   6*   5      .��5      ]� -   5         ]�Name$ WorklistContainer��5      .+�5   
   �� $��Bottom=�6   $��40��6-    �� Orientation$ 
Horizontal=�69   .+�5      �� $��Có tất cả (��6   $
��Bold"�6*   $	��0,5q�6<   6K   �� 5      $
��Bold"�67   $	��0,5q�6I   ��6   �� *Worklist.Count+6X   �� 5      $$��) ca chụp đã thực hiện��6   $
��Bold"�65   $	��0,5q�6G   6V   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ patientAwait��5   4   $	��400��5      $   HorizontalScrollBarVisibility$
 Auto=�5      "   VerticalScrollBarVisibility$
 Auto=�5      $��1q�5   2      
IsReadOnly .    AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5      	   HorizontalGridLinesBrush	 �#d6d6d6��5      �� 
 �� RelativeSource
 �� *FindAncestor+ �� AncestorType" � �� 	Converter# [   �� ConverterParameter$	 230�� �� Path$ ActualHeight���5      �� *
Worklist+ J� InputBindings 5      �� 5       
 �� Key$ N��6    �� 	Modifiers$
 Ctrlf�6%    �� Command 66   �� *
AddCommand+d� 5!       d� MouseAction$ LeftDoubleClicke�6    5"      �� *SendOrderToWorkCommand+ �� CommandParameter 6@   ��  �� ElementName$ patientAwait��$ SelectedItem� � ContextMenu 5$      �� 5%      .@�5&      m� $��Xem chi tiết��6    m� InputGestureText$ Ctrl+W��6U    m� Command 65   �� *ViewCommand+6q   m� 5'      $��Chỉnh sửa��6   $ Ctrl+E��6Q    62   �� *
AddCommand+6m   5(         ColumnHeaderStyle 5*      �� 5+       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5,      ��  �� Property � �� �� Value
 �����6C   �� 5-       � ��$
 Bold"�64   �� 5.       � ��
 ���F�6G   �� 5/       � ��$	 5,7q�60   �� 50       � ��$ 1q�68   51         Columns 53      4  .System.Windows.Controls.DataGridTemplateColumn  54      ,  &System.Windows.Controls.DataGridColumn   Width$ 70 6)      Header$ 
Nội trú��64       CellTemplate  55      �� 56      .R�57      �� {�.  $
��Left=�6Z   ! d� 	IsChecked! 6'   �� *
IsBoarding+6w   58      5:      0  *System.Windows.Controls.DataGridTextColumn  5;      $	 STT��6%   $	 100 6K   1  +System.Windows.Controls.DataGridBoundColumn"   Binding" 62   �� *Name+6K     5<      $ NGÀY CHỈ ĐỊNH��6%   $	 150 6U   " 6<   �� *Name+6U     5=      $ TÊN BỆNH NHÂN��6%   $	 150 6U   " 6<   �� *Name+6U     5>      $ 	NĂM SINH��6%   $	 100 6W   " 67   �� *RequestCode+6W     5?      $ TÊN DỊCH VỤ��6%   $ * 6Z   " 6:   �� *RequestCode+6Z     5@      $ TRẠNG THÁI��6)   $	 150 6=   #   HeaderStyle# 5A      �� 5B      "  6    .�5C      ��  � ��$ Center=�6K   �� 5D       � ��
 �����6K   �� 5E       � ��$
 Bold"�6<   �� 5F       � ��
 ���F�6O   �� 5G       � ��$	 5,7q�68   �� 5H       � ��$ 1q�6@   5I        5K      �� 5L      .R�5M      �� $ � Cursor$
$ Hand��6$   ���#4caf50
�������$	��0,3q�6Z   $	��120��6g   $��Center=�6s   .��6�   ĐÃ GỬI KẾT QUẢ6�   5N      5P      .	  (System.Windows.Interactivity.Interaction% 	  Triggers% 5R      /
  )System.Windows.Interactivity.EventTrigger
  5S      & 
  	EventName$& SelectionChanged��6!   .  (System.Windows.Interactivity.TriggerBase'   Actions.' 5T      /  )GalaSoft.MvvmLight.Command.EventToCommand  (   Command( 5U      �� *SendOrderCommand+) �� Mode$) OneWay=�*   CommandParameter* 5V      �� $ patientAwait��$ SelectedItem�5X      5Z      5[      5\      