   M S B A M L   `   `   `  ����M  I生产监控系统, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:生产监控系统生产监控系统  5   	   #    生产监控系统.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:生产监控系统     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$ 生产监控平台��5   	   $	��650��6   $
��1200��6%   '  !System.Windows.Shell.WindowChrome   WindowChrome 5
        5   
      GlassFrameThickness$ 0q�6   61   .��5      � ��5   
   
� 5      .��5      �  � Color$ 	#ff285273��6    � Offset$ 0Q�61   6>   � 5      $ 	#ff244967��6   $	 0.5Q�61   6@   � 5      $ 	#ff14273a��6   $ 1Q�61   6>   5       � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5       $
��auto �6   6,   �� 5!      $��15 �6   6*   .+�5$   
   �� $��0,0,0,1q�6   ���	#5518aabd._�5%      �  � ColumnDefinitions 5&      �� 5'      $��60 �6#   60   �� 5(      $
��auto �6#   62   �� 5)      6%   .+�5,      �� $��/Resource/Images/Logo.png��6   $
��10,7q�67   �� 5.      $��1��6    �� Orientation$ Vertical=�6)   .+�5/      �� $��生产监控平台��6   
�������$��16(�6=   6M   �� 50      $0��*阻碍你前行的，其实是你自己！��6   
�������$��12(�6E   $��0,5,0,0q�6S   6f   51      � 53      $��2��6    54      �� 55      6&   �� 56      $��15 �6$   62   .+�59      �� $ 
Horizontal=�6   $��Right=�66   $��0��6R   	   IsHitTestVisibleInChrome	 . .+�5:      �� -   5        
 ��Name$	
 min��5:      $	����6*      OptBtnStyleDic#��[  6=   6y   �� 5;      -   5        $
 default��5;      $	����6.   #��[  6A   6�   �� 5<      -   5        $
 close��5<      $	����6,   #��[  6?   
���  ��6�   5=      �� 5>      $��1��6   $��0,1,0,0q�6&   ���	#5518aabd��5?      !� 5@       j� TileMode$ FlipXY=�6&    j� Viewport$ 10,0,7,7�69    j� ViewportUnits$ Absolute=�6M    !� Visual 5A      �� 5B   "   	 �� X1$ 0��6'   	 �� Y1$ 10��6.   	 �� X2$ 10��66   	 �� Y2$ 0��6>   
�������$��1��6S   6i   5D      5F      5G      5H      5I      �� 5M   
   $��1��6   ��6&   �� *	MonitorUC+5N      �� 5P   
   $��0,1,0,0q�6   $��2��6+   ���	#5518aabd._�5Q      �  5R      �� 5S      6)   �� 5T      $
��auto �6'   66   .+�5V      �� $��0��6   ��5W      !� 5X      $ FlipX=�6&   $ 10,0,7,5�67   $ Absolute=�6K    5Y      �� 5Z   "   $ 0��6'   $ 10��6.   $ 10��66   $ 0��6>   
�������$��1��6S   6i   5\      5^      �� 5_      $*��$我的第一个程序，版权所有��6   $��1��60   $��0,0,5,2q�6@   
�������$��11(�6d   $
��Bold"�6r   6�   5`      5a      5b      5c      