   M S B A M L   `   `   `  ����L  HProduct-Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Product_ManagmentProduct_Managment  5   	   $    Product_Managment.frmPublisher   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Product_Managment     5   	     � Title$  	Publisher��5   	   $��648.433��6   $��1079.94��6-    � WindowStartupLocation$ CenterScreen=�6=    � WindowState$ 	Maximized=�6b    � 
ResizeMode$ NoResize=�6z   .��5	      � ��5
   
   �� 5       �� ImageSource$K EMedia/Dark-background-simple-black-and-white-liniar-background-hd.jpg��6   .+�5   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��216��6@   $��	24,69,0,0q�6M   
���   �$	��Top=�6o   $	��491��6�   �� 5   
   ���	#FFF4F4F5$
��Left=�6%   $	��228��6@   $��
24,324,0,0q�6M   
���   �$	��Top=�6p   $	��491��6�   �� 5   
   ���	#FFF4F4F5$
��Left=�6%   $	��228��6@   $��560,312,0,0q�6M   
���   �$	��Top=�6q   $	��491��6�   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $	��112��6T   $��578,409,0,0q�6a   $	��Top=�6v   $	��450��6�   �� 5   
   $��Publisher Name��6   $
��Left=�6)   $��
41,133,0,0q�6D   $	��Top=�6X   �� 5   
   -   5         ��Name$ 
txtPubName��5      $
��Left=�6&   $��23��6A   $��156,133,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��341��6�   �� 5   
   $��
Contact No��6   $
��Left=�6%   $��
41,171,0,0q�6@   $	��Top=�6T   �� 5   
   -   5        $ txtPubContact��5      $
��Left=�6)   $��23��6D   $��156,171,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��341��6�    J� RenderTransformOrigin$ -2.217,4.304&�6�   �� 5   
   
�������$��Publishers:��6(   $
��Left=�6>   $��	24,19,0,0q�6Y   $	��Top=�6l   $��30(�6�   $
��Bold"�6�   $	��179��6�   �� 5   
   -   5         ��Name$ btnClose��5      $
��Back��6#   $
��Left=�62   $��976,545,0,0q�6M   $	��Top=�6b   $��75��6z   $ 
1.413,0.45&�6�   $��52��6�   6�   �� 5   
   -   5        $ btnPublisherUpdate��5   "   $��Update��6   $
��Left=�6>   $��941,444,0,0q�6Y   $	��Top=�6n   $��75��6�   $��57��6�   6�   �� 5   
   -   5        $ btnPublisherSearch��5   "   $��Search��6   $
��Left=�6>   $��304,341,0,0q�6Y   $	��Top=�6n   $��62��6�   $��52��6�   6�   �� 5   
   -   5        $ btnPublisherDelete��5   "   $��Delete��6   $
��Left=�6>   $��941,352,0,0q�6Y   $	��Top=�6n   $��75��6�   $��52��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dgPublisher��5      
   AutoGenerateColumns
 .  $
��Left=�6D   $	��140��6_   $��
38,400,0,0q�6l   $	��Top=�6�   $	��448��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Publisher Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *publisherId+  5      $ Publisher Name��6%    6=   �� *publisherName+  5      $ 
Contact No��6%    69   �� *publisherContact+5       �� 5!   
   -   5        $ btnPublisherSave��5!       $
��Save��6   $
��Left=�6:   $��422,216,0,0q�6U   $	��Top=�6j   $��75��6�   $��52��6�   6�   �� 5"   
   -	   5        $ btnViewAllPublishers��5"   /   $��View All Publishers��6   $
��Left=�6M   $��377,341,0,0q�6h   $	��Top=�6}   $	��109��6�   $��52��6�   6�   �� 5#   
   $
��Left=�6   $��
39,367,0,0q�6+   $	��Top=�6?   $��Search By Id:��6W   $��28��6o   �� 5$   
   -
   5        $��txtSearchPublisher��5$      $
��Left=�6,   $��23��6G   $��121,372,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��150��6�   �� 5%   
   $"��Update and delete publisher:��6   $
��Left=�67   $��591,324,0,0q�6R   $	��Top=�6g   $ -1.237,1&�6   $	��253��6�   $
��Bold"�6�   $��16(�6�   �� 5&   
   $��Add new publisher:��6   $
��Left=�6-   $��	38,84,0,0q�6H   $	��Top=�6[   $ -1.237,1&�6s   $	��205��6�   $
��Bold"�6�   $��16(�6�   �� 5'   
   $!��Search and view publishers:��6   $
��Left=�66   $��
41,328,0,0q�6Q   $	��Top=�6e   $ -1.237,1&�6}   $	��221��6�   $
��Bold"�6�   $��16(�6�   �� 5(   
   $
��Left=�6   $��590,372,0,0q�6+   $	��Top=�6@   $��	Enter Id:��6X   $��28��6l   �� 5)   
   -   5        $ 	txtGiveId��5)      $
��Left=�6%   $��23��6@   $��649,372,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��150��6�   �� 5*   
   $
��Left=�6   $��591,472,0,0q�6+   $	��Top=�6@   $��Enter Contact��6X   $��28��6p   �� 5+   
   -   5        $ txtGiveContact��5+      $
��Left=�6*   $��23��6E   $��702,477,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��206��6�   �� 5,   
   $
��Left=�6   $��591,438,0,0q�6+   $	��Top=�6@   $��
Enter name��6X   $��28��6m   �� 5-   
   -   5        $ txtGiveName��5-      $
��Left=�6'   $��23��6B   $��702,443,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��206��6�   �� 5.   
   $��537,69,330,441q�6   $<��6LDP-logo-Transparent.black_-e1412260270152-370x400.png��6(   $
��Fill=�6h   51      52      