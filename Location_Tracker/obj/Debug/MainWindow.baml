   M S B A M L   `   `   `  ����K  GLocation_Tracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Location_TrackerLocation_Tracker  5   	   !    Location_Tracker.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Location_Tracker     5   	   -   5          � Title$  
MainWindow��5   	   $	��700��6   $
��1100��6)   .��5	      ]� -   5        .+�5
   
   �� $	��Top=�6   ���#21394f$	��Top=�6=   .��5      �� $��30(�6   $��LOCATION_TRACKER��6$   ���#21394f$��0q�6Q   
������� �� TextAlignment$ Center=�6x   $��Center=�6�   $��Center=�6�   6�   5      � 5   
   -   5        $��
Infomation��5      $	��386��6!   $
��Left=�6-    � ColumnDefinitions 5      �� 5      $	��200 �6#   61   �� 5      $��20 �6#   60   �� 5      $	��261 �6#   61   .+�5      �� .+�5      �� -   5        $��	label_com��5   /   ���	#00000000.��6@   Select Com:6M   �� 5      -   5        $��combo_box_COM��5   )    J� Opacity$	 0.5Q�6   6)   �� 5      .��6   Baud6   �� 5      -   5        $��combo_box_BaudRate��5   )   $	 0.5Q�6   6E   �� 5      .��6   
Databits6"   �� 5      -   5        $��combo_box_Databits��5   )   $	 0.5Q�6   6E   �� 5      .��6   Parity6    �� 5      -   5        $��combo_box_Parity��5   )   $	 0.5Q�6   6C   �� 5      .��6   	Stopbit6!   �� 5      -	   5        $��combo_box_Stopbit��5   )   $	 0.5Q�6   6D   �� 5      -
   5        $��btn_Serial_Connect��5   ;   $��0q�6   ���	#FFFF4B4B��5      �� 5        �� EndPoint$ 0.5,1&�6.    �� 
StartPoint$ 0.5,0&�6?   .��5!      �  � Color$ 	#FF4E4EF1��6+    � Offset$ 0Q�6=   � 5"      $ 	#FF1A2ACB��6+   $ 1Q�6=   5#      .��5$   )   	Connect5%      �� 5&      -   5        $��btn_Serial_Refresh��5&   ;   $��0q�6   ���	#FFFF4B4B��5'      �� 5(      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5)      � $ 	#FF4E4EF1��6+   $ 0Q�6=   � 5*      $ 	#FF1A2ACB��6+   $ 1Q�6=   5+      .��5,   )   	Refresh5-      5.      � 5/      .+�50      � -   5        $#��ProgressBar_Connection_Status��50   D    � Minimum$ 0Q�6   	 � Maximum$		 100Q�6*   $��20��68   6k   �� 51      -   5        $��Text_ProgressBar��51      $��Center=�6�   $��Center=�6�   ��64   �� 
 �� ElementName$#
 ProgressBar_Connection_Status�� �� Path$ Value� �� StringFormat$ {0:0}%��6�   52      �� 53      -   5        $��
TimeRemain��53       �� TextWrapping$ WrapWithOverflow=�6(   $��0q�6H   $"��   Thời Gian Đến Bến:��6\   $��20(�6y   
�������$��0,360,0,219q�6�    J� RenderTransformOrigin$ 
0.66,0.517&�6�    � Cursor$
 None��6�   .��6�   z�54      V� 55      .~�56      �� �� 57       �� AngleY$ 0.339Q�6(   �� 58      T� 59       T� Y$ 0.652Q�6-   5:      .��5;   +   ��5<      �� 5=      6(   .��5>   &   5?      �� 5A      -   5        $��Text2��5A      $ WrapWithOverflow=�6#   $��0q�6C   $��   Vận Tốc:��6W   $��20(�6j   
�������$��0,400,0,181q�6�   $ 
0.66,0.517&�6�   $
 None��6�   .��6�   z�5B      V� 5C      .~�5D      �� �� 5E      $ 0.339Q�6(    �� AngleX$ -0.883Q�67   �� 5F      T� 5G      $ 0.652Q�6-    T� X$ -0.02Q�67   5H      .��5I   +   ��5J      �� 5K      6(   .��5L   &   5M      �� 5O      -   5        $��Text3��5O      $ WrapWithOverflow=�6#   $��0q�6C   $ ��   Vị Trí Hiện Tại:��6W   $��20(�6r   
�������$��1,438,19,141q�6�   $ 
0.66,0.517&�6�   $
 None��6�   $��2��6�   .��6�   z�5P      V� 5Q      .~�5R      �� �� 5S      $ 0.339Q�6(   �� 5T      T� 5U      $ 0.652Q�6-   5V      .��5W   +   ��5X      �� 5Y      6(   .��5Z   &   5[      �� 5\      -   5        $��Text4��5\      $ WrapWithOverflow=�6#   $��0q�6C   $��   Khoảng Cách Còn:��6W   $��20(�6r   
�������$��
0,502,0,77q�6�   $ 0.67,-0.017&�6�   $
 None��6�   .��6�   z�5]      V� 5^      .~�5_      �� �� 5`      $ 0.339Q�6(   �� 5a      T� 5b      $ 0.664Q�6-   5c      .��5d   +   ��5e      �� 5f      6(   .��5g   &   5h      �� 5i      -   5         ��Name$ refresh_button��5i      $��20(�6-   $��Refresh Location��6;   $
��Left=�6V   $��
28,557,0,0q�6q   $	��Top=�6�   $	��162��6�   $��38��6�   6�   �� 5j      -   5         ��Name$ Current_Location��5j      $��0q�60   $��20(�6D   
�������$��2��6f   $
��Left=�6v   $��66��6�   $��
12,441,0,0q�6�   $ WrapWithOverflow=�6�   $��TextBox��6�   $	��Top=�6�   $	��120��6�   .��6  ��5k      �� 5l      6(   .��5m   &   5n      �� 5o      -   5        $ Current_Speed��5o      $��0q�6-   $��20(�6A   
�������$��2��6c   $
��Left=�6s   $��66��6�   $��
12,399,0,0q�6�   $ WrapWithOverflow=�6�   $��TextBox��6�   $	��Top=�6�   $	��120��6�   .��6  ��5p      �� 5q      6(   .��5r   &   5s      �� 5t      -   5        $ Remain_Distance��5t      $��0q�6/   $��20(�6C   
�������$��2��6e   $
��Left=�6u   $��66��6�   $��
12,507,0,0q�6�   $ WrapWithOverflow=�6�   $��TextBox��6�   $	��Top=�6�   $	��120��6�   .��6  ��5u      �� 5v      6(   .��5w   &   5x      	� 5y      -   5         	�Name$ radio_btn_Terran��5y      $��Terran��64   $��2��6E   $
��Left=�6U   $��	71,10,0,0q�6p   $	��Top=�6�   6�   	� 5z      -   5        $ radio_btn_satellite��5z      $��	Satellite��67   $��2��6K   $
��Left=�6[   $��	71,30,0,0q�6v   $	��Top=�6�   6�   ��5|      �� 5}      $ 1,0.5&�6&   $ 0,0.5&�67   .��5~      � $ 	#FF0D2462��6#   $ 0Q�65   � 5      $ 	#FF4A95BA��6#   $ 1Q�65   5�      5�      (  "System.Windows.Controls.WebBrowser  5�   
   -   5        $��webBrowser1��5�   M   $��Right=�6   6M   5�      5�      