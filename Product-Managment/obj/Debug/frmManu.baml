   M S B A M L   `   `   `  ����L  HProduct-Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Product_ManagmentProduct_Managment  5   	       Product_Managment.frmManu   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Product_Managment     5   	     � Title$  Author��5       � WindowStartupLocation$ CenterScreen=�6�    � WindowState$ 	Maximized=�6�    � 
ResizeMode$ NoResize=�6�   ��6   �� *&$SystemParameters.PrimaryScreenHeight+��6S   �� *%#SystemParameters.PrimaryScreenWidth+.��5	      � ��5
   
   �� 5       �� ImageSource$K EMedia/Dark-background-simple-black-and-white-liniar-background-hd.jpg��6   .+�5   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��212��6@   $��
58,136,0,0q�6M   
���   �$	��Top=�6p   $	��518��6�   �� 5   
   ���	#FFF4F4F5$
��Left=�6%   $	��236��6@   $��
54,387,0,0q�6M   
���   �$	��Top=�6p   $	��522��6�   �� 5   
   ���	#FFF4F4F5$
��Left=�6%   $	��232��6@   $��649,391,0,0q�6M   
���   �$	��Top=�6q   $	��539��6�   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $	��112��6T   $��716,472,0,0q�6a   $	��Top=�6v   $	��450��6�   �� 5   
   $��Author��6   $
��Left=�6!   $��	41,37,0,0q�6<   $	��Top=�6O   $��30(�6g   $
��Bold"�6u   ���	#FFF5F2F2 J� RenderTransformOrigin$ 0.5,0.5&�6�   $	��203��6�   $��65��6�   z�5      V� 5      .~�5      �� �� 5       �� AngleY$ -0.77Q�6$   �� 5      T� 5       T� Y$ -0.733Q�6)   5      5      �� 5   
   $��Author Name��6   $
��Left=�6&   $��
72,191,0,0q�6A   $	��Top=�6U   �� 5   
   $��
Contact No��6   $
��Left=�6%   $��
72,238,0,0q�6@   $	��Top=�6T   �� 5   
   -   5         ��Name$ 
txtAutName��5      $
��Left=�6&   $��23��6A   $��189,194,0,0q�6M   	 �� TextWrapping$
	 Wrap=�6b   $	��Top=�6v   $	��341��6�   �� 5   
   -   5        $ txtAutContact��5      $
��Left=�6)   $��23��6D   $��189,238,0,0q�6P   $
	 Wrap=�6e   $	��Top=�6y   $	��341��6�   �� 5   
   -   5        
 ��Name$
 btnAutClose��5      $
��Back��6&   $
��Left=�65   $��1113,635,0,0q�6P   $	��Top=�6f   $��75��6~   $��52��6�   6�   �� 5    
   -   5        $
 
btnAutSave��5       $
��Save��6%   $
��Left=�64   $��455,284,0,0q�6O   $	��Top=�6d   $��68��6|   $��49��6�   6�   �� 5!   
   -   5        $
 btnAuthorUpdate��5!   "   $��Update��6   $
��Left=�6;   $��1083,511,0,0q�6V   $	��Top=�6l   $��75��6�   $��52��6�   6�   �� 5"   
   -   5        $
 btnAuthorSearch��5"   "   $��Search��6   $
��Left=�6;   $��359,413,0,0q�6V   $	��Top=�6k   $��67��6�   $��52��6�   6�   �� 5#   
   -   5        $
 btnAuthorDelete��5#   "   $��Delete��6   $
��Left=�6;   $��1083,412,0,0q�6V   $	��Top=�6l   $��75��6�   $��52��6�   6�   &   System.Windows.Controls.DataGrid  5$   
   -   5          Name$ dgAuthor��5$         AutoGenerateColumns .  $
��Left=�6A   $	��140��6\   $��
72,468,0,0q�6i   $	��Top=�6}   $	��463��6�      Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Author Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *
authorId+  5'      $ Author Name��6%    6:   �� *
authorName+  5(      $ 
Contact No��6%    69   �� *authorContact+5*      �� 5+   
   $��687,89,159,385q�6   $��
auhtor.ico��6(   $
��Fill=�6<   �� 5,   
   -	   5        $
 btnViewAllAuthors��5,   ,   $��View All Authors��6   $
��Left=�6G   $��431,412,0,0q�6b   $	��Top=�6w   $	��104��6�   $��52��6�   6�   �� 5-   
   $��Search By Id:��6   $
��Left=�6(   $��
72,435,0,0q�6C   $	��Top=�6W   $��79��6o   �� 5.   
   -
   5        $��txtSearchAuthor��5.      $
��Left=�6)   $��23��6D   $��156,439,0,0q�6P   $
	 Wrap=�6e   $	��Top=�6y   $	��114��6�   �� 5/   
   $��Add new Author:��6   $
��Left=�6*   $��
72,140,0,0q�6E   $	��Top=�6Y   $ -1.237,1&�6q   $	��150��6�   $
��Bold"�6�   $��16(�6�   �� 50   
   $��Search and view authors:��6   $
��Left=�63   $��
68,399,0,0q�6N   $	��Top=�6b   $ -1.237,1&�6z   $	��212��6�   $
��Bold"�6�   $��16(�6�   �� 51   
   -   5        $ 	txtGiveId��51      $
��Left=�6%   $��23��6@   $��793,442,0,0q�6L   $
	 Wrap=�6a   $	��Top=�6�   $	��212��6�   ��6u   Z� 6�   �� 52   
   -   5        $ txtGiveContact��52      $
��Left=�6+   $��23��6F   $��839,540,0,0q�6R   $
	 Wrap=�6g   $	��Top=�6�   $	��212��6�   ��6{   Z� 6�   �� 53   
   -   5        $ txtGiveName��53      $
��Left=�6'   $��23��6B   $��839,493,0,0q�6N   $
	 Wrap=�6c   $	��Top=�6�   $	��212��6�   ��6w   Z� 6�   �� 54   
   $��Enter Id��6   $
��Left=�6#   $��718,439,0,0q�6>   $	��Top=�6S   �� 55   
   $��
Enter name��6   $
��Left=�6%   $��739,490,0,0q�6@   $	��Top=�6U   �� 56   
   $��Enter contact��6   $
��Left=�6(   $��739,537,0,0q�6C   $	��Top=�6X   �� 57   
   $ ��Update and delete authors:��6   $
��Left=�65   $��716,403,0,0q�6P   $	��Top=�6e   $ -1.237,1&�6}   $	��217��6�   $
��Bold"�6�   $��16(�6�   59      5:      