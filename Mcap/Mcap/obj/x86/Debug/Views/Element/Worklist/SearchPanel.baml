   M S B A M L   `   `   `  ����?  ;Mcap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Mcap.Views.Element.WorklistMcap.Views.Element.Worklist  5      -    'Mcap.Views.Element.Worklist.SearchPanel   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Mcap.Views.Element.Worklist     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      Z VFirstFloor.ModernUI, Version=1.0.9.0, Culture=neutral, PublicKeyToken=bc9b0c37bf06c6a90mui&http://firstfloorsoftware.com/ModernUI  5        � 	Resources  5
       �� BasedOn �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%  '	�       7d�'�� �     �� 5   
   8   " 	�6A    5      P� 5       �@d�	IsChecked$
 trueY�6/   . �5      ��  � ��
 ���F�63   �� 5       � ��
 �����6C   5      5      �� 5   
   " ��6   .�5      ��  � ��$
 Bold"�6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   	 � ColumnDefinitions	 5   
   �� 5       $	��150 �6   �� 5!      $	��150 �6   �� 5"      $	��120 �6   �� 5#      $	��150 �6   �� 5$      $��* �6   .+�5&   
   �� $��Ngày bắt đầu:��6   $	��3,0q�6(   67   �� 5'   
   $��Ngày Kết thúc:��6   $��1��6)   $	��3,0q�69   6H   �� 5(   
   $��Loại bệnh nhân:��6   $��2��6*   $��2��6:   $	��3,0q�6N   6]   �� 5)   
   $��4��6   $��2��6!   $��1��65   $	��3,0q�6B   $	��100��6O   $
��Left=�6[   $��0q�6v   
 � Cursor$

 Hand��6�   .��5*      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�62   .+�5+      !  FontAwesome.WPF.FontAwesome     Icon$ Database=�6!   $��15(�61   $��15��6?   6L   �� 5,      $��20,0,0,0q�6   Đồng bộ67   5-      5.      (  "System.Windows.Controls.DatePicker  5/   
   $��1��6   $	��3,0q�6#   63     50   
   $��1��6   $��1��6"   $	��3,0q�62   6A   �� 51   
   -   5         ��Name$ searchPatient��51   Q   $��1��6   $��2��6    $��2��64   $	��3,0q�6D   6j   �� 52   
   $��Thời gian:��6   $��2��6%   $��2��62   6H   �� 53   
   $��3��6   $ 
Horizontal=�6"   $	��3,0q�6;   $��2��6H   .+�54      	�  	� 	GroupName$
 Time��6   .��6+   
Hôm nay64   	� 55      $
 Time��6   .��6+   
Hôm qua64   	� 56      $
 Time��6   .��6+   Tùy chọn65   57      �� 58   
   $��Trạng thái:��6   $��2��6&   $��2��63   $	��3,0q�6C   $��2��6P   6f   �� 59   
   $��3��6   $��2��6"   $ 
Horizontal=�62   $	��3,0q�6K   $��2��6X   .+�5:      	� $ State��6   $��Đang chờ��6,    � ToolTip 5;      _� 5<      .��5=      �� .+�5>      �� $
��Bold"�6(   Phiếu đang chờ6J   �� 5?      DBTìm kiếm phiếu đang có trạng thái đang chờ (Ctrl + W)6_   5@      5A      5C      	� 5D      $ State��6   .��6,   Đang xử lý68   	� 5E      $ State��6   .��6,   
Tất cả64   5F      � 5G   
   $��4��6   $��3��6   $	��3,0q�6,   	 5H      �� 5I      $��* �6#   �� 5J      $	��100 �6#   �� 5K      $��70 �6#   .+�5M      �� $!��Tìm kiếm bệnh nhân...��6   65   �� 5N      $��1��6   .��6%   Tìm kiếm6/   �� 5O      $��2��6   $��5,0,0,0q�6%   .��66   Xóa6;   5P      �� 5Q   
   $)��#Tự động làm mới dữ liệu��6   $��4��65   $	��3,0q�6B   $��2��6O   6e   5R      5S      