   M S B A M L   `   `   `  ����C  ?VirusSim, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:VirusSim.ViewsVirusSim.Views  5      !    VirusSim.Views.OverViewView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:VirusSim.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � DataContext  5      ��    ViewModelLocator �� Source# [   �� Path$ OverViewViewModel� � 	Resources 5        lvPersonsStyle �� 
TargetType �� Property �� Value �� Width �� CellTemplate	 �� Triggers
 �� Binding �� Value  lvContactsStyle��%�  &	       &	 m    �� 5   
   " ��6'   .�5      ��  �@%�IsVirtualizing . 6F   �� 5       �@%�VirtualizationMode$ 	Recycling=�6J   �� 5      " �@��IsDeferredScrollingEnabled . 6H   �� 5       � �� 65   �� *	Persons+�� 5       �@��View 5      �� 5      .P�5      �� $ 50��6)   $��Id��64    5      �� 5   "   .R�5   &   �� ��60   �� *Id+5   #   5      �� 5      $	 150��6)   $
��Name��65    5      �� 5   "   .R�5   &   �� ��60   �� *Name+5   #   5!      �� 5"      $ 50��6)   $	��Age��64    5#      �� 5$   "   .R�5%   &   �� ��60   �� *Age+5&   #   5(      5)      5+      	 5,      �� 5-      
 6   �� *	IsLoading+ True6<   .a�5.      ��  �@�Cursor$
 Wait��68   �� 5/       � ��
 �����6<   50      52      �� 54   
   " ��6(   .�55      ��  �@%�IsVirtualizing . 6F   �� 56       �@%�VirtualizationMode$ 	Recycling=�6J   �� 57      " �@��IsDeferredScrollingEnabled . 6H   �� 58       � �� 65   �� *
Contacts+�� 59       �@��View 5:      �� 5;      .P�5<      �� $	 150��6)   $
��From��65    5=      �� 5>   "   .R�5?   &   �� ��60   �� *From+5@   #   5B      �� 5C      $	 150��6)   $��To��65    5D      �� 5E   "   .R�5F   &   �� ��60   �� *To+5G   #   5I      �� 5J      $ 70��6)   $��
Member1_ID��64    5K      �� 5L   "   .R�5M   &   �� ��60   �� *
Member1_ID+5N   #   5P      �� 5Q      $ 70��6)   $��
Member2_ID��64    5R      �� 5S   "   .R�5T   &   �� ��60   �� *
Member2_ID+5U   #   5W      5X      5Z      	 5[      �� 5\      
 6   �� *	IsLoading+ True6<   .a�5]      ��  �@�Cursor$
 Wait��68   �� 5^       � ��
 �����6<   5_      5a      5c      .��5e      �  � RowDefinitions 5f   
   �� 5g      $��* �6    � ColumnDefinitions 5i   
   �� 5j      $��* �6   �� 5k      $��* �6   .+�5n   
   �� $��0��5o      $��5q�5p      #���  5q      �� 5s   
   $��1��5t      $��5q�5u      #���  5v      5w      5x      