   M S B A M L   `   `   `  ����L  HProduct-Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Product_ManagmentProduct_Managment  5   	   G CMaterialMenu, Version=0.0.4.5, Culture=neutral, PublicKeyToken=nullA0clr-namespace:MaterialMenu;assembly=MaterialMenuMaterialMenu 5   	   "    Product_Managment.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Product_Managment     5   	   ImaterialMenu0clr-namespace:MaterialMenu;assembly=MaterialMenu     5   	     � Title$  Product Managment System��5	   	   $��697.015��6*   $��1404.104��6;    � WindowStartupLocation$ CenterScreen=�6L    � WindowState$ 	Maximized=�6q    � 
ResizeMode$ NoResize=�6�   .��5
      � $��0,0,0,9q�6   .+�5   
     MaterialMenu.SideMenu  -   5          Name$ 
CustomMenu��5   ;   $
��Left=�6       	MenuWidth$	 500Q�5          State$ Hidden=�5          Theme$
 None=�5          ButtonBackground
 �����	   ButtonHover
	 �����
   ShadowBackground

 �   �$��499,101,0,0q�5   9   $	��382��6N      Menu 5      �� 5      $��Hidden=�6   
�������$��
0,0,61,-12q�6V   .��5      ��  �� Orientation$ Vertical=�6!   .+�5      �� -   5        ���	#FF020202.��5        MaterialMenu.MenuButton     Text$g a                                  Product(Book)                                                  ��66   6�   5      �� 5      -   5        .��5        $f `                             Issue Product(Book)                                                ��66   6�   5      �� 5      -   5        .��5         $i c                            Manufacture(Author)                                                    ��66   6�   5!      �� 5#      -   5        .��5$        $^ X                            Category                                                    ��66   6�   5%      �� 5'      -   5        .��5(        $_ Y                             Employees                                                   ��66   6�   5)      �� 5+      -   5        .��5,        $] W                              Members                                                  ��66   6�   5-      �� 5/      -   5        .��50        $j d                             Product Publishers                                                     ��66   6�   51      �� 53      -	   5        .��54        $` Z                                Users                                                     ��66   6�   55      �� 57      -
   5        .��58        $` Z                                 Fine                                                     ��66   6�   59      �� 5;      -   5        .��5<        $d ^                                  Rack                                                        ��66   6�   5=      �� 5>      -   5        .��5?        $d ^                                  Exit                                                        ��66   6�   5@      5A      5B      5D      � 5E   
   
�������$
��Left=�6!   $	��101��6<   $	��Top=�6I   $
��1398��6a   .+�5F      �� $��Center=�6   $��Center=�65   $��48(�6Q   $��Perpetua Titling MT)�6_   $
��Bold"�6�   Product Management System6�   5G      � 5H   
   -   5        $��decissionGrid��5H      
�������$
��Left=�6<   $��382,101,0,0q�6W   $	��Top=�6l   $	��558��6�   $
��1016��6�   .+�5I      �� $��royal-escorial.jpg��6   $
��Fill=�60   5J      5K      5L      