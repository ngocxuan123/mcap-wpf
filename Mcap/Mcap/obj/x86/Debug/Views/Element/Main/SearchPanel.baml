   M S B A M L   `   `   `  ����?  ;Mcap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Mcap.Views.Element.MainMcap.Views.Element.Main  5      )    #Mcap.Views.Element.Main.SearchPanel   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Mcap.Views.Element.Main     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5        � 	Resources  5
       �� BasedOn �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '	�       7d��� 5   
   8   " 	�6A    5      P� 5       �@d�	IsChecked$
 trueY�6/   . �5      ��  � ��
 ���F�63   �� 5       � ��
 �����6C   5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��3 �6   �� 5      $��20 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��20 �6   .+�5   
   �� 	 �� Orientation$	 
Horizontal=�6   .+�5      !  FontAwesome.WPF.FontAwesome  
   Icon$
 ListUl=�6   $��16(�6+   �� 5      $��Danh sách chờ��6   $	��5,0q�6,   5       �� 5!   
   ���#d6d6d6$��0,0,0,1q�6'   $��1��6A   �� 5"   
   $��Loại ca chụp��6   $
��Bold"�6'   $	��3,0q�69   $��2��6F   �� 5#   
   $	 
Horizontal=�6   $��3��6.   $	��3,0q�6;   .+�5$      	�  	� 	GroupName$
 Time��6   .��6+   Tích hợp65   	� 5%      $
 Time��6   .��6+   Local62   	� 5&      $
 Time��6   .��6+   
Tất cả63   5'      �� 5(   
   $��Tìm kiếm ca chụp...��6   $��4��6.   $��3q�6;   �� 5)   
   $��Tự động làm mới��6   $��5��6-   $	��3,0q�6:   5*      5+      