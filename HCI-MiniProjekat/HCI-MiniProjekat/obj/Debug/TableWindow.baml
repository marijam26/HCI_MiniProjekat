   M S B A M L   `   `   `  ����K  GHCI-MiniProjekat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:HCI_MiniProjekatHCI_MiniProjekat  5   	   "    HCI_MiniProjekat.TableWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:HCI_MiniProjekat     5   	     � Title$  Currency Table��5   	   $	��450��6    $	��850��6-   
����� �.��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   6)   �� 5      $��9* �6   6*    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��4* �6   6,   .+�5   
   �� $��0��6   $��0��6   $��Center=�6-   $��Center=�6J   $��15(�6e   
�������$��DemiBold"�6�   .��6�   Choose currancy pair:6�   �� 5   
   -   5         ��Name$ cbPair��5      $��0��6#   $��1��60   $	��150��6@   $��25��6L   $
��Left=�6X   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ table��5      $��1��6"   $��0��6/   $��2��6?      
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   $��15(�6�   $��5q�6�   ��6S   �� *tableElements+ � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType	 �� Property
 �� Value��%?  '        �� 5      "  6   .�5      �� 	 � ��

 �����63   �� 5      	 � ��

 ��� �63   �� 5      	 � ��$
 23��6/   �� 5      	 � ��$
 SemiBold"�63   �� 5      	 � ��

 �   �64   �� 5      	 � ��$
 0 0 0 1q�68   �� 5      	 � ��$
 Center=�6C   5      5      5       5!      5"      