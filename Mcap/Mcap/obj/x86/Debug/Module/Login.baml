   M S B A M L   `   `   `  ����?  ;Mcap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Mcap.ViewModelsMcap.ViewModels  5   	   1clr-namespace:Mcap.ValidationMcap.Validation  5   	       Mcap.Module.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Mcap.ViewModels     5   	   4
validationclr-namespace:Mcap.Validation     5   	     � Title$'  !MCAP - Đăng nhập hệ thống��5
   	   $	��480��6+   $	��950��68    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�6    � Icon$D >/Mcap;component/ckeditor/plugins/smiley/images/angel_smile.png��6D    � DataContext 5	   	   �� *Login+   Locator �� Source# [  .��5      � ��5   
   �� 5       �� ImageSource$ /Resources/bg/vnpt-bg.jpg��6    j� Stretch$ UniformToFill=�6A    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $	��600 �6   6-   .+�5   
   �� .+�5      � 	 �� Left$		 450��6   

 �� Top$	
 100��6%   $	��450��66   $	��160��6B   
������� 5      �� 5      $	��45* �6'   65   �� 5      $	��55* �6'   65    � RowDefinitions 5      �� 5      $��* �6$   61   �� 5      $��40 �6$   62    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6'      	Direction$	 -90Q�67      RenderingBias$ Performance=�6G      ShadowDepth$ 1Q�6c   .+�5!      �� ���#096CB3 �� Orientation$ Vertical=�62   $��0��6I   $��2��6Y   $��0��6j   .+�5"      �� $��/Resources/logo/mcap.png��6   $
��0,10q�6>   6N   �� 5#      $!��RADIOLOGY INFOMATION SYSTEM��6    $
��Wrap=�6C    �� TextAlignment$ Center=�6W   
�������$��16(�6�   $��
0,5,-0.4,5q�6�   �� 5$      $"��© 2018 -www.vnptsoftware.vn��6    $
��Wrap=�6C   $ Center=�6W   
�������$��11(�6�   $
��0,30q�6�   5%      �� 5&      $��0��6   $��1��6*   .+�5'      �� $��Đăng nhập��6    
������� �� Padding$ 10q�6C   6R   �� 5(      $
��10,5q�6   $��3q�6,   .��68   ��5)      �� 5*      $ /Resources/icons/user.png��6)   $ Uniform=�6Q    j� 
AlignmentX$ Right=�6c    �� 	Transform 5+   "   V� 5,   &   .~�5-   *   �� �� 5.   *   �� 5/   *   T� 50   *    T� X$ -3Q�6=   51   '   53      .��54   .   ��55      �� 56       �� Path$ UserLogin.UserName�6&    �� UpdateSourceTrigger$ PropertyChanged=�6@    �� Mode$ TwoWay=�6f    �� ValidationRules 57   "   ,  &Mcap.Validation.RequiredValidationRule  58   &   5:      .��5;   (   5<      )clr-namespace:Mcap.HelperMcap.Helper  5=   !   �� 6   (ffclr-namespace:Mcap.Helper     6!   .+�5>      G� $
��10,5q�6&   $��3q�64   &    Mcap.Helper.PasswordBoxAssistant   BindPassword .    BoundPassword 5@   &   �� *UserLogin.Password+$ TwoWay=�$ PropertyChanged=���5A      �� 5B   "   $ /Resources/icons/lock.png��6-   $ Uniform=�6U   $ Right=�6g    5C   &   V� 5D   *   .~�5E   .   �� �� 5F   .   �� 5G   .   T� 5H   .   $ -3Q�6A   5I   +   5K   #   5M      5N      5P      �� 5Q      $��1��6   $��1��6*   .+�5R      � $��10q�6    � 	Resources 5S        ButtonHover �� Triggers P� Property  P� Value! �� Property" �� Value��%�   &	       �� 5T       5U   "   P� 5V   &    �@J�IsMouseOver  . . �5W   *   �� ! � ��" �#2196f36N   5X   '   5Z      5[       5\      �� 5]      $��* �6/   6;   �� 5^      $��* �6/   6;   .+�5`      �� $��0��6#   $��	Ghi nhớ��63   6G   �� 5a      -   5        $��ĐĂNG NHẬP��5a   !   $��1��65   ���#0C6CB3#��[ 6Z   
�������# � Cursor$
# Hand��5b   4   5d      5e      5f      5g      5h      5i      5j      