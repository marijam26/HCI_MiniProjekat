   M S B A M L   `   `   `  ����U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5   	   K GHCI-MiniProjekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:HCI_MiniProjekatHCI_MiniProjekat 5   	   !   HCI_MiniProjekat.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	   0localclr-namespace:HCI_MiniProjekat     5   	     � Title$  HCI-mini��5	   	   $	��550��6   $
��1000��6'   .��5
      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��5* �6    � ColumnDefinitions 5   
   �� 5      $
��0.7* �6   �� 5      $��* �6   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   .+�5   
   �� $��0��6   $��0��6   $��Right=�6-   $��Center=�6I   $��15(�6d   .��6r   From currency:6�   �� 5   
   $��1��6   $��0��6   $��Right=�6-   $��Center=�6I   $��15(�6d   .��6r   To currency:6�   �� 5   
   -   5         ��Name$ fromCurrency��5      $��0��6)   $��1��66   $��25��6F   $	��180��6R   $��15(�6^   6o   �� 5   
   -   5        $ 
toCurrency��5      $��1��6'   $��1��64   $��25��6D   $	��180��6P   $��15(�6\   6m   �� 5   
   $��0��6   $��2��6   $��Right=�6-   $��Center=�6I   $��15(�6d   .��6r   	Period:6|   �� 5   
   $��1��6   $��2��6   $��Right=�6-   $��Center=�6I   $��15(�6d   .��6r   	Interval:6}   �� 5   
   -   5        $ cbPeriod��5      $��0��6%   $��3��62   $��25��6B   $	��180��6N   $��15(�6�   6�   �� 5    
   -   5        $ 
cbInterval��5       $��1��6'   $��3��64   $��25��6D   $	��180��6P   $��15(�6\   5!      �� 5"   
   $��0��6   $��4��6   $��Right=�6-   $��Center=�6I   $��15(�6d   .��6r   	Atribute:6~   �� 5#   
   -   5        $ cbAtributes��5#      $��0��6(   $��5��65   $��25��6E   $��2��6Q   $	��120��6e   $
��Left=�6q   $��15(�6�   5$      �� 5'   
   -   5         ��Name$ btnDraw��5'      $��1��6"   $��4��6/   $��8q�6?   
����� �
�������$��SemiBold"�6s   .��6�   Draw6�   �� 5(   
   -   5        $ btnClear��5(      $��1��6#   $��5��60   $��8q�6@   $��50��6K   
����� �
�������$��SemiBold"�6�   .��6�   Clear6�   �� 5)   
   -   5        $ btnTable��5)      $��1��6#   $��6��60   $��8q�6@   $��50��6K   
����� �
�������$��SemiBold"�6�   .��6�   Table6�   #   LiveCharts.Wpf.CartesianChart  5+   
   &    LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$
 Left=�6P   $��3��6f   $��0��6s   $��3��6�      Series 6   ��  �� Path$  LineChart.SeriesCollection�   AxisX 5-         LiveCharts.Wpf.Axis  	   Title$
	 Time��6   
   FontSize$
 15Q�6(      Labels 66   �� $ LineChart.labels�5/        52   
   $��3��6   $��3��6*   $��4��6:   $
 Left=�6N    6d   �� $' !candlestickChart.SeriesCollection� 54         6   �� $ candlestickChart.labels�56      59      5:      