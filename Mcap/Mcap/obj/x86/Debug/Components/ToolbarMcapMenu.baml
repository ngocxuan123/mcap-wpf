   M S B A M L   `   `   `  ����  Mcap%    Mcap.Components.ToolbarMcapMenu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      $��33.683��5   3   .��5      � $��35��6   ���#0173C7  � ColumnDefinitions  5	   
   �� 5
      $��2* �6   �� 5      $��* �6    � 	Resources 5   
    �� 
TargetType   MenuItem �� Property �� Value��%T   &	        �� 5      " m�6   .�5      ��  � ��$
 15,2q�6,   5      5      .+�5   
   o� -   5         o�Name$ mainMenu��5      
�������
������  o� 
IsMainMenu . $��35��6_   $��Center=�6k   ��6�   �� *	MenuItems+y�6�   �� *
Visibility+ 5      "  FontAwesome.WPF.ImageAwesome  MenuIconResource   Icon �� Path	   
Foreground
 �� RelativeSource �� Mode �� AncestorType �� Triggers �� Binding �� Value��%h  &	       'm� f     7%�  5      $��16��6;   $��16��6G    6R   �� $ MenuIcon�	 6q   �� $ 
Foreground��� 5      " m�6   .�5      ��  �@m�Command 60   �� $" DataContext.ChangeMenuActive�
 �� $ FindAncestor=�" o��� 5       �@m�CommandParameter 69   �� *Name+�� 5       � ��$ 36��6/   �� 5       � �� 63   �� *BackgroundColor+�� 5       � �� 63   �� *
Foreground+�� 5       � �� 6/   �� *Header+�� 5       � {� 62   �� *	IsEnabled+�� 5       � �� 64   �� *	MenuItems+�� 5       � ��$ Center=�6:   �� 5       �@�Cursor$
 Hand��6/    5       �� 5!       6&   ��  6;   Z� .a�5"      ��  � �� 5#   "   �� 5$   &   .R�5%   *   �� 8��  64   5&   '   5(      5)      5+      5,      5-      �� 5.   
    �� Orientation$ 
Horizontal=�6   $��Right=�6.   $��1��6J   .+�5/      �� 
������ 
�������$��1,0,0,0q�51      ��52      �� 53      $ 
Horizontal=�6!   .+�54      !  FontAwesome.WPF.FontAwesome     Icon$ QuestionCircle=�6)   $��16(�6?   $��0,0,5,0q�6M   �� 55      $��Hướng dẫn��6+   56      58      �� 59      -   5        
������ 
������� �� 	IsEnabled .  $��1,0,0,0q�5<      ��5>      �� 5?      $ 
Horizontal=�6!   .+�5@        $ 
UserCircle=�6)   $��16(�6;   $��0,0,5,0q�6I   �� 5A      $��Ngọc Xuân��6+     5B      $ 	CaretDown=�6)   $��16(�6:   $��10,0,0,0q�6H   5C       � ContextMenu 5E      �� 5F      .@�5G      m� $��Thông tin cá nhân��6#   $
��10,5q�6>   $��30��6M    m� Icon 5H        5I   "   $ 	UserTimes=�61   $��12(�6B   $��0,-5,0,0q�6P   5K      m� 5L      $��Thay đổi tài khoản��6#   $
��10,5q�6?   $��30��6N    5M        5N   "   $ 
UserSecret=�61   $��12(�6C   $��0,-5,0,0q�6Q   5P      m� 5Q      -   5        $��Đăng xuất��5Q   #   $
��10,5q�66   $��30��6E    5R        5S   "   $ SignOut=�61   $��12(�6@   $��0,-5,0,0q�6N   5U      5V      5X      5Y      5Z      5[      