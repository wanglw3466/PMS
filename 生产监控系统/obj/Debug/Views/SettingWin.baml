   M S B A M L   `   `   `  ����M  I生产监控系统, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:生产监控系统.Views生产监控系统.Views  5   	   )    #生产监控系统.Views.SettingWin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:生产监控系统.Views     5   	     � WindowStartupLocation$  CenterOwner=�5   	   
������ $��Microsoft YaHei)�6I   $��
ExtraLight"�6f    � Title$ 系统配置信息��5	   	   $	��450��6   $	��800��6%    � 
ResizeMode$ NoResize=�61   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      GlassFrameThickness$ -1q�6   63    � 	Resources 5       �� 
TargetType �� Property �� Value	 �� 
TargetType
 �� Triggers P� Property P� Value��%�  '	�       �� 5   
   " 	�6   .�5      ��  � ��
 ���� 6A   �� 5       � �� 5      �� 5      "	 	�6&   .R�5      �� #��z��6#   $��30��6M   ._�5      �� $
��Left=�60   $��Center=�6K   $
��10,0q�6f   6v   5      
 5      P� 5       �@d�	IsChecked$
 TrueY�6<   . �5   "   ��  � �� �#18aabd6Q   �� 5   "    � ��
 �����6Q   5      5      5       5'      5(      .��5)      �  � RowDefinitions 5+   
   �� 5,      $��30 �6   6*   �� 5-      6    � ColumnDefinitions 5/   
   �� 50      $	��130 �6   6.   �� 51      6!   .+�53   
   �� $	��5,5q�6   �� 54      $	���6   $!��../Resource/Fonts/#iconfont)�6"   6M    �� 55      $�系统配置信息��6   6"   56      �� 57   
   ���#ddd$��0,0,1,0q�6$   $��1��6>   6M   �� 58   
   $��1��6   .+�59      	� -   5        
 � Tag$ data1��59      $��设备清单��6&    d� 	IsChecked$
 TrueY�65   6[   	� 5:      -   5        $ data2��5:      $��环境监测��6&   6J   	� 5;      -   5        $ data3��5;      $��设备监测��6&   6J   	� 5<      -   5        $ data4��5<      $��	配置一��6&   6I   	� 5=      -   5        $ data5��5=      $��	配置二��6&   6I   5>      �� 5?   
   $��1��6   $��1��6$   $��Hidden=�64   .��5@       � -   5        $��frame��5@   .     � Source$ SettingPage.xaml?�6     � NavigationUIVisibility$ Hidden=�6<   6^   5A      5B      5C      