   M S B A M L   `   `   `  ����M  I生产监控系统, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:生产监控系统.UserControls生产监控系统.UserControls  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      6    0生产监控系统.UserControls.WorkShopDetailUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:生产监控系统.UserControls     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5      $	��585��5	      $
��1200��6     � 	Resources  5
       �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Triggers P� Property P� Value	 �� 
TargetName��%4  '	�       �� 5   
   " 	�6   .�5      ��  � �� �#ddd6:   �� 5       � �� �#8886:   �� 5       � ��$ 50��6&   63   �� 5       � ��$ 22��6'   64   �� 5       � �� 5      �� 5      " 	�6&   .R�5      �� $ border��6!   #��z��63   ._�5      �� $��Center=�6/   $��Center=�6L   6i   5       5      P� 5       �@d�	IsChecked$
 TrueY�6=   . �5   "   �� $	 border��6)    � ��
 � ���6d   �� 5   "    � ��
 �����6O   5      5      5      5       5!      .��5"      � -   5        
 �Name$
 
LayoutGrid��5"       � RowDefinitions 5#   
   �� 5$      $��40 �6   6*   �� 5%      6   .+�5'   
   �� ���	#1118aabd$��0��6(   $
��10,5q�65   ._�5(      �� $��返回��6   
 � Tag$	 ��6"      BtnStyle#��[  61   $��70��6T   $��30��6`   $
��Left=�6l   ��6�   �� *ReturnCommand+ �� RelativeSource ��  �� AncestorType$ WindowL�6�   5)      �� 5*   
   $��0��6    �� Orientation$ 
Horizontal=�6$   $��Right=�6=   $��Center=�6Z   $��0,0,10,0q�6u   .+�5+      �� $��机器状态:��6   
�������$��0,0,5,0q�6:   $��Center=�6L   6i   	� 5,      $��全部��6    d� 	IsChecked$
 TrueY�6'   6:   	� 5-      $��工作��6   6)   	� 5.      $��待机��6   6)   	� 5/      $��故障��6   6)   	� 50      $��停机��6   6)   51      �� 53   
   $��1��6   $��Hidden=�6$   .��54      �� ��6   �� *MachineList+��55      �� 56      .R�57      A�  A� Columns$ 5��6*   68   58      ��5:      �� 5;      .R�5<      �� $ border��69   ���	#9918aabd���	#0a18aabd$��0,1,0,0q�6`   $	��260��6z   $
��10,5q�6�   ._�5=      �  5>      �� 5?   "   $��22 �60   6>   �� 5@   "   64   �� 5A   "   $��22 �60   6>   �� 5B   "   $��22 �60   6>   �� 5C   "   $��22 �60   6>   .+�5E   "   �� $��11(�6,   $��0��6:   $
��Left=�6G   $	��5,0q�6b   �� 5F   "   $	���6&   
�������$!��../Resource/Fonts/#iconfont)�6I   6t    �� 5G   "   ���	#99ffffff�6&   �� *MachineName+6]   5H   #   �� 5I   "   $��11(�6-   
������$��0��6S   $��Right=�6`   $��5,0,10,0q�6|   �� 5J   &   $	���6*   $!��../Resource/fonts/#iconfont)�6:   6g    �� 5K   &   �6*   �� *MachineStatus+6K   5L   #   ,   &生产监控系统.UserControls.RingUC  5M   "   $��1��6/      Percent 6<   �� *	Percent+6]   �� 5N   "   $��2��6-   $ 
Horizontal=�6:   $
��Left=�6S   $��Center=�6n   .+�5O   &   �� $��任务状态:��60   ���	#55ffffff$��Center=�6T   $��11(�6q   $	��5,0q�6   6�   �� 5P   &   
������$��Center=�6f   $��Center=�6�   $��11(�6�   $��1q�6�   $	��5,1q�6�   
��������6,   �� *MachineStatus+6�   5Q   #   �� 5R   "   $��Right=�6,   $��2��6H   $��0,0,10,0q�6U   �� 6h   ���	#55ffffff �� TextDecorations$
 None{�6�    �� Command 6�   �� *TrendCommand+ �� $ WindowL�.�6�   
[详情]6�   6	  �� 5T   !   $��3��6,   $ 
Horizontal=�69   .+�5U   &   �� $��任务进度:��60   ���	#55ffffff$��11(�6T   $	��5,0q�6b   6q   �� 5V   &   
�������$��11(�6D   �� 5W   *   �6.   �� *	PlanCount+6K    �� 5X   *   $�/��6.   69    �� 5Y   *   �6.   �� *FinishedCount+6O   5Z   '   5[   #   �� 5\   "   $��4��6-   $ 
Horizontal=�6:   .+�5]   &   �� $��工单:��60   $��11(�6;   ���	#55ffffff$	��5,0q�6`   6o   �� 5^   &   
�������$��11(�6[   ��60   �� *Order+6k   5_   #   5`      5a      5c      5e      5f      �� 5j   
   -   5        $��detail��5j      $��2��6   ���	#22000000$y�	Collapsed=�6I   ._�5l      �� -   5        $ detailCotent��5l      ���	#f5f7f9fa$	��260��6C   $��Bottom=�6P   ���	#aa3bedf1$��0,1,0,0q�6�   ._�5m      �  5n      �� 5o      $��20 �6(   66   �� 5p      $��20 �6(   66   �� 5q      6*   .+�5s      �� $��机台效率趋势图��6!   $��0��60   $
��Left=�6=   ���#555$��10,0,0,0q�6j   6�   �� 5t      $	����6     OptBtnStyleDic#��[ 61   ���#333$��0��6�   $��Right=�6�   $	��Top=�6�   $��20��6  $	��0,0q�6  ��6Z   �� *CloseTrendCommand+ �� $ WindowL�6$  �� 5u      $��1��6!   $
��Left=�6.   $
��40,0q�6I   �� 5v      $	���6   $!��../Resource/Fonts/#iconfont)�6.   
������$��15(�6o   6�    �� 5w      $�作业��6   
���   �6>    �� 5x      $	���6   $!��../Resource/Fonts/#iconfont)�6.   
��� ���$��15(�6k   .�6y   6|    �� 5y      $�等待��6   6*    �� 5z      $	���6   $!��../Resource/Fonts/#iconfont)�6.   
���\\��$��15(�6n   6~    �� 5{      $�故障��6   6*    �� 5|      $	���6   $!��../Resource/Fonts/#iconfont)�6.   
�������$��15(�6o   6    �� 5}      $�停机��6   6*   5~      �� 5      $ 
Horizontal=�6!   $��1��6:   $��Right=�6G   $
��40,0q�6c   $��Center=�6q   .+�5�      	� $��当日��6&   65   	� 5�      $��当周��6&   65   	� 5�      $��当月��6&   65   	� 5�      $��当年��6&   65   5�      #  LiveCharts.Wpf.CartesianChart  5�      $
��40,0q�6)   $��2��67   &   LiveCharts.Wpf.Charts.Base.Chart   AxisX 5�        LiveCharts.Wpf.Axis     Labels9  3LiveCharts.Wpf.Converters.StringCollectionConverter$} w21-12,22-01,22-02,22-03,22-04,22-05,22-06,22-07,22-08,22-09,22-10,22-11,22-12,23-01,23-02,23-03,23-04,23-05,23-06,23-07 6'      	Separator 5�   "     LiveCharts.Wpf.Separator  5�   &      Step$ 1Q�64      StrokeThickness$ 1Q�6=   6S   5�         AxisY 5�           MinValue$ 0Q�6'      MaxValue$	 100Q�64    5�   "     5�   &      Stroke �	#08000000$ 0Q�6G   $ 20Q�6[   6g   5�         Series 5�      (  "LiveCharts.Wpf.StackedColumnSeries    LiveCharts.Wpf.Series   Fill
 ����    MaxColumnWidth$  15Q�6H   !   Title$! 作业��6]   "   StrokeThickness$" 0Q�6h   #   Values;	  5LiveCharts.Wpf.Converters.NumericChartValuesConverter$}# w34.02,36.72,73.80,54.18,87.73,61.63,71.22,56.96,47.21,42.67,49.14,76.79,77.42,68.08,62.95,73.94,44.93,39.66,55.21,33.18	 6|   6�     5�      
 � ���$  15Q�6G   $! 等待��6[   $W# Q3.4,3.6,7.8,5.1,2.1,3.2,4.2,6.2,4.7,4.7,4.9,7.5,7.4,5.4,6.2,3.7,10.2,3.9,5.5,10.1	 6f   6�     5�      
 �\\��$  15Q�6J   $! 等待��6^   $[# U20.1,30.5,6.2,6.5,4.8,6.5,4.5,6.8,8.9,4.6,10.4,6.9,7.8,8.9,6.3,7.8,20.1,6.2,10.8,20.3	 6i   6�     5�      
 �����$  15Q�6J   $! 等待��6^   $y# s42.48,29.18,12.2,34.22,5.37,28.67,20.08,30.04,39.19,48.03,35.56,8.81,7.38,17.62,24.55,14.56,24.77,50.24,28.49,36.42	 6i   6�   5�      5�      5�      5�      5�      5�      