   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5       wpf_calc_beta   wpf_calc_beta.UI.Updater   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5        � WindowStartupLocation$  CenterScreen=�5       � Title$ updater��5	      $	��100��5
      $	��300��5      ���	#FF111111 � WindowStyle$
 None=�5       � 
ResizeMode$ NoResize=�5      (   "MahApps.Metro.Controls.MetroWindow   ShowTitleBar .     ShowCloseButton .     ShowMinButton .     IsCloseButtonEnabled .   � Topmost . 	 � 	Resources	 5      
 �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers :� RoutedEvent g� Duration g� FillBehavior �� TargetProperty	 �� To��%�  '��       �� 5   
   "
 ��6   .�5      ��  � ��$ 0q�60   �� 5       � |� .  6*   �� 5       � ��
 �����6+   �� 5       � ��$ Segoe UI Light)�6+   �� 5       � ��$ 12(�6)   �� 5       � ��$ Center=�6;   �� 5       �@�Cursor$
 Hand��6'   �� 5       � ��$ 	30,7,30,7q�6'   �� 5       � ��$ Center=�69   �� 5       � �� �#1111116+   �� 5        � �� 5!      �� 5"      " ��6&   .R�5#      �� #��z��6!   
���   �$��0q�6_   ._�5$      �� $��Center=�6/   $��Center=�6L   5%      5&      5(       5)      :� 5*      $ Control.MouseEnter��6   .[�5+      �� .��5,      �� .��5-      �� $ 0:0:0.1D�5.   !   $ HoldEnd=�5/   !   $1 +(Button.Background).(SolidColorBrush.Color)�50   !   $ #222222X�51   !   52      53      54      :� 55      $ Control.MouseLeave��6   .[�56      �� .��57      �� .��58      �� $ 0:0:0.1D�59   !   $ HoldEnd=�5:   !   $1 +(Button.Background).(SolidColorBrush.Color)�5;   !   $ #111111X�5<   !   5=      5>      5?      5A      5B         NonActiveGlowBrush 5C      �� 5D   
    �� Color# � ��6      	GlowBrush 5F      �� 5G   
   # � ��6   .��5I      �  � RowDefinitions 5J   
   �� 5K      $��6* �6   �� 5L      $��4* �6   .+�5N   
   � $��0��6   .+�5O      �� -   5        $��nfoText��5O   8   $��10,5,0,0q�6   $��16(�6*   $��New version is available��6G   
�������6|   5P      � 5R   
   $��1��6    � ColumnDefinitions 5S      �� 5T      $��1* �6#   �� 5U      $��1* �6#   .+�5W      �� -   5        $��
installBtn��5W   0   $��Install update��6C   $��0��6\   6n   �� 5X      -   5        $��	cancelBtn��5X   .   $��Remind me later��6?   $��1��6Y   6k   5Y      5Z      5[      