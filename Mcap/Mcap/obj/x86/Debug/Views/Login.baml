   M S B A M L   `   `   `  ����?  ;Mcap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Mcap.ViewModelsMcap.ViewModels  5   	   1clr-namespace:Mcap.ValidationMcap.Validation  5   	       Mcap.Views.Login   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Mcap.ViewModels     5   	   4
validationclr-namespace:Mcap.Validation     5   	   $	��450��5	   	   $
��1000��6     � DataContext  5
   	   �� *Login+   Locator �� Source# [  .��5      � ��5   
   �� 5       �� ImageSource$ /Resources/bg/vnpt-bg.jpg��6    j� Stretch$ UniformToFill=�6A     5   
   $   Mcap.ViewModels.LoginViewModel  5      .+�5   
   �� .+�5      �  �� Left$	 420��6   
 �� Top$	 150��6%   $	��550��66   $	��160��6B   
������� � ColumnDefinitions 5      �� 5      $	��45* �6'   65   �� 5      $	��55* �6'   65    � RowDefinitions 5      �� 5      $��* �6$   61   �� 5      $��40 �6$   62    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	   
BlurRadius$	 10Q�6'   
   	Direction$	
 -90Q�67      RenderingBias$ Performance=�6G      ShadowDepth$ 1Q�6c   .+�5      �� ���#096CB3 �� Orientation$ Vertical=�62   $��0��6I   $��2��6Y   $��0��6j   .+�5       �� $��/Resources/logo/mcap.png��6   $
��0,10q�6>   6N   �� 5!      $!��RADIOLOGY INFOMATION SYSTEM��6    $
��Wrap=�6C    �� TextAlignment$ Center=�6W   
�������$��22(�6�   $	��0,5q�6�   �� 5"      $"��© 2018 -www.vnptsoftware.vn��6    $
��Wrap=�6C   $ Center=�6W   
�������$��11(�6�   $	��0,5q�6�   5#      �� 5$      $��0��6   $��1��6*   .+�5%      �� $��Đăng nhập��6    
������� �� Padding$ 10q�6C   6R   �� 5&      $
��10,5q�6   $��3q�6,   .��68   ��5'      �� 5(      $ /Resources/icons/user.png��6)   $ Uniform=�6Q    j� 
AlignmentX$ Right=�6c    �� 	Transform 5)   "   V� 5*   &   .~�5+   *   �� �� 5,   *   �� 5-   *   T� 5.   *    T� X$ -3Q�6=   5/   '   51      .��52   .   ��53      �� 54       �� Path$ UserLogin.UserName�6&    �� UpdateSourceTrigger$ PropertyChanged=�6@    �� Mode$ TwoWay=�6f    �� ValidationRules 55   "   ,  &Mcap.Validation.RequiredValidationRule  56   &   58      .��59   (   5:      )clr-namespace:Mcap.HelperMcap.Helper  5;   !   �� 6   (ffclr-namespace:Mcap.Helper     6!   .+�5<      G� $
��10,5q�6&   $��3q�64   &    Mcap.Helper.PasswordBoxAssistant   BindPassword .    BoundPassword 5>   &   �� *UserLogin.Password+$ TwoWay=�$ PropertyChanged=���5?      �� 5@   "   $ /Resources/icons/lock.png��6-   $ Uniform=�6U   $ Right=�6g    5A   &   V� 5B   *   .~�5C   .   �� �� 5D   .   �� 5E   .   T� 5F   .   $ -3Q�6A   5G   +   5I   #   5K      5L      5N      �� 5O      $��1��6   $��1��6*   .+�5P      � $��10q�6    � 	Resources 5Q        ButtonHover �� Triggers P� Property P� Value �� Property �� Value��%�   &	       �� 5R       5S   "   P� 5T   &    �@J�IsMouseOver . . �5U   *   ��  � �� �#2196f36N   5V   '   5X      5Y       5Z      �� 5[      $��* �6/   6;   �� 5\      $��* �6/   6;   .+�5^      �� $��0��6#   $��	Ghi nhớ��63   6G   �� 5_      $��ĐĂNG NHẬP��6!   $��1��65   ���#0C6CB3#��[ 6Z   
������� � Cursor$
 Hand��6�   ��6   �� $ PersonSaveCommand�5`      5a      5b      5c      5d      5e      5f      