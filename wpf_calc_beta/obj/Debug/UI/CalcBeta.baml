   M S B A M L   `   `   `  ����a  ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes  5      T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5       wpf_calc_beta   wpf_calc_beta.CalcBeta   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      mmicrosoftWindowsThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero     5      Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      -   5        $	��380��5	      $	��500��5
      $	��380��5      $	��500��5      $��0q�5      $��0q�5        � WindowStartupLocation$  CenterScreen=�5       � Title$ 
Calculator��5      (  "MahApps.Metro.Controls.MetroWindow   TitleCharacterCasing$ Normal=�5         WindowTitleBrush
 ��=H�   TitleForeground
 �����    NonActiveWindowTitleBrush
 ���p�   NonActiveGlowBrush
 �Gc��   	GlowBrush
 ��=H�   ShowIconOnTitleBar . 	 � Icon$	 ../Res/calc16.ico��5      ���	#FF111111
   KeepBorderOnMaximize
 .   � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius,   &Microsoft.Windows.Themes.ListBoxChrome  Name   BorderBrush   BorderThickness   
Background J� IsMouseOver   RenderMouseOver J� IsKeyboardFocusWithin   RenderFocused J� SnapsToDevicePixels �� Triggers :� RoutedEvent g� Duration g� FillBehavior �� TargetProperty	 �� To   	SizeAdapt  {�Name  HistoryItem��%�
  '��       &	  �    &	 �    �� 5   
   " ��6   .�5      ��  � ��$ 0q�60   �� 5       � |� .  6*   �� 5        � ��
 �����6+   �� 5!       � ��$ Segoe UI Light)�6+   �� 5"       � ��$ 30(�6)   �� 5#       � ��$ Center=�6;   �� 5$       �@�Cursor$
 Hand��6'   �� 5%       � ��$ Center=�69   �� 5&       � �� �	#001111116+   �� 5'       � �� 5(      �� 5)      " ��6&   .R�5*      �� $��border��5.      #��z��5+      $��2q�5,      $ 3��5-      ._�5/      � $��7,7,7,7q�6#   .+�50   "     $ Bd��6G   # z��51   G   # z��52   G   # z��53   G   # z 54   G   # z 55   G    . $
��Auto��56   b   $
��Auto��57   G   ._�58   &   (� $��Center=�6.   .��59   *   �� $��content��5<   -   $��Center=�5:   -   $��Center=�5;   -   5<   -   5=   '   5>   #   5?      5@      5A      5C       5D      :� 5E      $ Control.MouseEnter��6   .[�5F      �� .��5G      �� .��5H      �� $ 0:0:0.1D�5I   !   $ HoldEnd=�5J   !   $1 +(Button.Background).(SolidColorBrush.Color)�5K   !   $ #222222X�5L   !   5M      5N      5O      :� 5P      $ Control.MouseLeave��6   .[�5Q      �� .��5R      �� .��5S      �� $ 0:0:0.1D�5T   !   $ HoldEnd=�5U   !   $1 +(Button.Background).(SolidColorBrush.Color)�5V   !   $ 	#00111111X�5W   !   5X      5Y      5Z      5\      �� 5]   
   " ��6"   .�5^      ��  � �� �	#001111116+   �� 5_       � ��
 �����6+   �� 5`       � ��$ Segoe UI Light)�6+   �� 5a       � ��$ 20(�6)   �� 5b       � ��$ 	15,0,15,0q�6'   �� 5c       � ��$ 0q�60   �� 5d       � ��$ Bottom=�69   �� 5e       �@��
IsReadOnly . 6+   �� 5f       � |� . 6*   �� 5g       �@��TextAlignment$ Center=�6.   �� 5h       �@��SelectionBrush
 ��=H�6/   �� 5i       � �� 5j      �� 5k      " ��6&   .R�5l        $ Bd��6?   # z��6K   # z��5m   ?   # z��5n   ?   # z 5o   ?   # z 5p   ?    . ._�5r      (� $��Right=�6&   $��Center=�6B   .��5s   "   {� $  PART_ContentHost��6,   # z 5t   ,   5u      5v      5w      5y      5z      �� 5{   
   " ��6$   .�5|      ��  � �� �	#001111116+   �� 5}       � ��$ LeftToRight=�6.   �� 5~       � ��
 �����6+   �� 5       � ��$ Segoe UI Light)�6+   �� 5�       � ��$ 0q�60   �� 5�       � ��$ Bottom=�69   �� 5�       �@��
IsReadOnly . 6+   �� 5�       � |� . 6*   �� 5�       �@��TextAlignment$ Right=�6.   �� 5�       �@��SelectionBrush
 ��=H�6/   5�      5�      .��5�      � .+�5�   
   �� ���	#00111111.@�5�      �� $��
Calculator��6   2  ,MahApps.Metro.Controls.HeaderedControlHelper!   HeaderFontSize$! 15Q�6*   .��5�      � -   5        $��CalcGrid��5�      ���#111111" � ColumnDefinitions" 5�      �� 5�      $	��55* �6+   �� 5�      $	��45* �6+   # � RowDefinitions# 5�      �� 5�      $	��30* �6(   �� 5�      $	��70* �6(   �� 5�      $��0* �6(   .+�5�      � -   5        $��FuncGrid��5�   #   $��2��6   $��0��63   # 5�      �� 5�      $��1* �6,   �� 5�      $��1* �6,   .+�5�      � $��0��6   " 5�      �� 5�   "   $��1* �63   �� 5�   "   $��1* �63   �� 5�   "   $��1* �63   �� 5�   "   $��1* �63   �� 5�   "   $��1* �63   .+�5�      �� -   5        $��BtnSin��5�   !   
����d�$��0��5�   =   .��5�   "   �� $ �� Orientation$$ 
Horizontal=�6-   .+�5�   &   �� % �� TextAlignment$% Center=�60   sin6L   �� 5�   &   
�������$% Center=�6B   $��Center=�6Y   $��20(�5�   0   (x)5�   '   5�   #   5�      �� 5�      -   5        $��BtnCos��5�   !   
����d�$��0��5�   !   $��1��6.   .��5�   "   �� $$ 
Horizontal=�6-   .+�5�   &   �� $% Center=�60   cos6L   �� 5�   &   
�������$% Center=�6B   $��Center=�6Y   $��20(�5�   0   (x)5�   '   5�   #   5�      �� 5�      -   5        $��BtnTan��5�   !   
����d�$��0��5�   !   $��2��6.   .��5�   "   �� $$ 
Horizontal=�6-   .+�5�   &   �� $% Center=�60   tan6L   �� 5�   &   
�������$% Center=�6B   $��Center=�6Y   $��20(�5�   0   (x)5�   '   5�   #   5�      �� 5�      -   5        $��BtnCtg��5�   !   
����d�$��0��5�   !   $��3��6.   .��5�   "   �� $$ 
Horizontal=�6-   .+�5�   &   �� $% Center=�60   ctg6L   �� 5�   &   
�������$% Center=�6B   $��Center=�6Y   $��20(�5�   0   (x)5�   '   5�   #   5�      �� 5�      -   5        $��BtnDeg��5�   !   
�������$��°��5�   !   $��0��6-   $��4��6:   5�      � 5�      $��1��6   " 5�      �� 5�   "   $��1* �63   �� 5�   "   $��1* �63   �� 5�   "   $��1* �63   �� 5�   "   $��1* �63   �� 5�   "   $��1* �63   .+�5�      �� -	   5        $��BtnLg��5�   !   
����ح�$��0��5�   8   .��5�   "   �� $$ 
Horizontal=�6-   .+�5�   &   �� $% Center=�60   lg6K   �� 5�   &   
�������$% Center=�6B   $��Center=�6Y   $��20(�5�   0   (x)5�   '   5�   #   5�      �� 5�      -
   5        $��BtnLn��5�   !   
����ح�$��1��5�   !   .��5�   "   �� $$ 
Horizontal=�6-   .+�5�   &   �� $% Center=�60   ln6K   �� 5�   &   
�������$% Center=�6B   $��Center=�6Y   $��20(�5�   0   (x)5�   '   5�   #   5�      �� 5�      -   5        $��BtnLog��5�   !   
����ح�$��2��5   !   .��5  "   �� $$ 
Horizontal=�6-   .+�5  &   �� $% Center=�60   log6L   �� 5  &   
�������$% Center=�6C   $��Center=�6Z   $��22(�5  0   (5  '   �� 5  &   
�������$% Center=�6B   $��Center=�6Y   $��22(�5  0   x5
  '   �� 5  &   
�������$% Center=�6C   $��Center=�6Z   $��22(�5  0   ,5  '   �� 5  &   
�������$% Center=�6B   $��Center=�6Y   $��22(�5  0   y5  '   �� 5  &   
�������$% Center=�6C   $��Center=�6Z   $��22(�5  0   )5  '   5  #   5     �� 5     -   5        $��BtnExp��5  !   
�����f�$��e��5  !   $��3��6-   �� 5     -   5        $��BtnLogComma��5   !   
�������$��,��5"  !   $��4��6-   5#     5$     � 5%     -   5        $��NumGrid��5%     $��1��6*   $��0��67   " 5&     �� 5'     $��* �6/   �� 5(     $��* �6/   �� 5)     $��* �6/   �� 5*     $��* �6/   �� 5+     $��* �6/   # 5-     �� 5.     $��* �6,   �� 5/     $��* �6,   �� 50     $��* �6,   �� 51     $��* �6,   �� 52     $��* �6,   .+�54     �� -   5        $��Clear��54  -   $��С��6!   
������6N   �� 55     -   5        $��Remove��58     $��0��56     $��1��6*   $	��←��57     
����p��5:     �� 5;     -   5        $��OpenBr��5>     $��0��5<     $��2��6*   $��(��5=     
�������5@     �� 5A     -   5        $��CloseBr��5D     $��0��5B     $��3��6*   $��)��5C     
�������5F     �� 5G     -   5        $��	BtnDivide��5J     $��0��5H     $��4��6*   $��÷��5I     
��� ���5L     �� 5M     -   5        $	��Pow��5P     $��2��5N     $��0��6*   
�������.��5R     �� $$ 
Horizontal=�6)   .+�5S  "   �� 
��������� 5T  &   $�x��6*   5U  #   �� 5V  "   $��14(�6,   �� 5W  &   $�y��6*   5X  #   5Y     5Z     �� 5[     -   5        $��BtnOne��5]     $��1��5\     $��1��5^     $��1��5_     6)   �� 5`     -   5        $��BtnTwo��5b     $��1��5a     $��2��5c     $��2��5d     6)   �� 5e     -   5        $��BtnThree��5h     $��1��5f     $��3��5g     $��3��5j     �� 5k     -   5        $��BtnMult��5n     $��1��5l     $��4��5m     $��×��5o     
��� ���5q     �� 5r     -   5        $��BtnSqrt��5u     $��1��5s     $��0��6*   
�������.��5w     �� $$ 
Horizontal=�6)   .+�5x  "   �� $% Center=�6,   √6F   �� 5y  "   
�������$% Center=�6>   $��Center=�6U   $��20(�5z  ,   (x)5|  #   5}     5~     �� 5     -   5        $��BtnFour��5�     $��2��5�     $��1��5�     $��4��5�     �� 5�     -   5        $��BtnFive��5�     $��2��5�     $��2��5�     $��5��5�     �� 5�     -   5        $��BtnSix��5�     $��2��5�     $��3��5�     $��6��5�     �� 5�     -   5        $��BtnMinus��5�     $��2��5�     $��4��5�     $��-��5�     
��� ���5�     �� 5�     -   5        $��BtnFact��5�     $��3��5�     $��0��6*   
�������.��5�     �� $$ 
Horizontal=�6)   .+�5�  "   �� 
�������$% Center=�6>   x6X   �� 5�  "   $% Center=�6,   !6F   5�     5�     �� 5�     -   5        $��BtnSeven��5�     $��3��5�     $��1��5�     $��7��5�     �� 5�     -    5        $��BtnEight��5�     $��3��5�     $��2��5�     $��8��5�     �� 5�     -!   5        $��BtnNine��5�     $��3��5�     $��3��5�     $��9��5�     �� 5�     -"   5        $��BtnPlus��5�     $��3��5�     $��4��5�     $��+��5�     
��� ���5�     �� 5�     -#   5        $��BtnPi��5�     $��π��5�     
�����f�$��0��5�  ;   $��4��6K   �� 5�     -$   5        $��4��5�     $��1��5�     $��20(�5�     
�������$��funcs��5�     �� 5�     -%   5        $��BtnZero��5�     $��4��5�     $��2��5�     $��0��5�     �� 5�     -&   5        $��BtnDot��5�     $��4��5�     $��3��5�     $��.��5�     �� 5�     -'   5        $��BtnEqual��5�     $��4��5�     $��4��5�     $��=��5�     
��� ���5�     5�     � 5�     -(   5        $��	TextBoxes��5�     $��0��6,   $��0��69   # 5�     �� 5�     $	��50* �6,   �� 5�     $	��50* �6,   .+�5�     �� -)   5        $��ResultTb��5�     #��[  5�     $��1��5�     $��35(�5�     ���#999999$��Result��5�     & �� TextWrapping$
& Wrap=�5�     $
��10,0q�61   �� 5�     -*   5        $��MathTb��5�     $��0��5�     #��[  6*   $��45(�5�     $��
Expression��5�     $
& Wrap=�5�     $
��10,0q�61   5�     � 5�     $��1��6   $��2��6+   .+�5�     �� $
��Auto=�6'   $��Disabled=�6J   .��5�     �� -+   5        $��HistoryList��5�  +   $��RightToLeft=�6\   ��6>   �� *Items+��5�  "   �� 5�  &   .R�5�  *   � ' � Orientation$' Vertical=�64   5�  '   ��5�  "   �� 5�  &   .R�5�  *   � # 5�  .   �� 5�  2   $	��75* �6@   �� 5�  2   $	��25* �6@   .+�5�  .   �� $��0��66   #��[ 6C   $��24(�6h   ��6v   �� *
Expression+�� 5�  .   $��1��66   #��[ 6C   $��12(�6h   
���������6�   �� *Result+5   +   5  '   5     5     5     5     5     �� 5     $��Settings��6   $! 15Q�6(   {�. .��5	     � # 5
     �� 5     $��30 �6(   �� 5     $��30 �6(   �� 5     $
��130* �6(   �� 5     $	��10* �6(   .+�5     �� -,   5        $��	ChBoxSave��5  ,   $��0��6   $��Save calculator state��6=   $��0,0,0,29q�6�   $��2��6�   �� 5     --   5        $��ChBoxUpdate��5  ,   $��1��6   $��Check for updates��6?   $��0,1,0,0q�6�   $��24��6�   $	��Top=�6�   �� 5     -.   5        $
��lVer��5  )   $��3��6   ���#555555$��Version��6K   $��Center=�6]   6�   5     5     5     5     5     