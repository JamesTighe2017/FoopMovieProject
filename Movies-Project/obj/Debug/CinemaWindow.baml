   M S B A M L   `   `   `  ����I  EMovies-Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Movies_ProjectMovies_Project  5   	   !    Movies_Project.CinemaWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Movies_Project     5   	   -   5          � Title$  CinemaWindow��5   	   $	��450��6   $	��800��6+   
����� � � 	Resources 5	         listBoxTemplate �� Orientation  
lboxStyle1 �� 
TargetType �� Property �� Value  
tblkStyle1  	lblStyle1  	btnStyle1��%f  &	        &	 �     &	     &	 t    &	 �    �� 5
   
   .R�5      �� $ 
Horizontal=�6   $��5q�62   .+�5      �� $��5q�68   ��6   �� *
CinemaName+6E   5      5      �� 5   
   " ��6#   .�5      ��  � ��
 ���_�6?   �� 5       � ��
 �����6;   5      �� 5   
   " ��6#   .�5      ��  � ��
 ���_�6?   �� 5       � ��
 �����6;   5      �� 5   
   " ��6"   .�5      ��  � ��
 �����6;   5      �� 5   
   " ��6"   .�5      ��  � �� �	#FF0674746?   �� 5       � ��
 �����6;   5      5      .��5      �  � RowDefinitions 5    
   �� 5!      $��40 �6   6*   �� 5"      $��* �6   6)   �� 5#      $��* �6   6)   �� 5$      $��40 �6   6*   �� 5%      $��1 �6   6)    � ColumnDefinitions 5'   
   �� 5(      6!   �� 5)      6!   .+�5,   
   �� -   5        $��
lblCinemas��5,   3   #��[ 6   $��Cinemas��6E   $��16(�6W   $��0��6e   6w   �� 5-   
   -   5        $��lblCinemaDetails��5-   3   #��[ 6   $��Cinema Details��6K   $��16(�6d   $��1��6r   6�   �� 5.   
   -   5        $��lboxCinemas��5.   6   #��[ 6   $��10q�6I   #��[  6U   $��0��6�   $��1��6�   $��2��6�   6�   �� 50   
   -   5        $��spCinemaDetails��50      $��1��6,   $��1��69   $��10q�6I   .+�51      �� -   5        $��tblkCinemaName��51   <   #��[ 6   ��6R   �� *
CinemaName+6p   �� 52      -   5        $��tblkCinemaAddress��52   <   #��[ 6   ��6U   �� *CinemaAddress+6v   �� 53      -   5        $��tblkCinemaNumber��53   <   #��[ 6   ��6T   �� *CinemaNumber+6t   �� 54      -	   5        $��tblkCinemaEmail��54   <   #��[ 6   ��6S   �� *CinemaEmail+6r   55      &   System.Windows.Controls.DataGrid  57   
   -
   5        $��dgAvailableMovies��57      $��2��6,   $��1��69   $��10q�6I   6W   �� 58   
   -   5        $��btnExit��58   x   #��[ 6   $��3��64   $��2��6A   $
��Exit��6Q   $��25��6`   $	��100��6l   $��Right=�6�   $��	0,0,10,10q�6�   6�   59      5:      