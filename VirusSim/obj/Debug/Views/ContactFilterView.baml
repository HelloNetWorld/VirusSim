   M S B A M L   `   `   `  ����C  ?VirusSim, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:VirusSim.ViewsVirusSim.Views  5      &     VirusSim.Views.ContactFilterView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:VirusSim.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � DataContext  5      ��    ViewModelLocator �� Source# [   �� Path$ ContactFilterViewModel�.��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��5q�5      $��Center=�5       �� Orientation$ 
Horizontal=�5      .+�5      �� $P��JИнтервал времени (целое число в минутах):��5      $��14(�5      $
��Bold"�5      �� 5      $	��100��5       �� TextAlignment$ Center=�5      $��Center=�5      ��5      �� *ContactDuration+5      5      �� 5!   
   $��1��5"      $	��100��5#      $��5,0,5,5q�5$      $��Center=�5%      $��Вывести��5'      ��5&      �� *CountContacts+5'      &   System.Windows.Controls.DataGrid  5)   
   $��2��5*      $��5q�5+      $��Center=�5,         AlternatingRowBackground
 �����   AutoGenerateColumns .  
���   �$��14(�50         HorizontalGridLinesBrush
 �   �	   
IsReadOnly	 . ��53      �� *
Contacts+
   Columns
 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn   MinWidth$ 80Q�56         Header$# Начало контакта��58      1  +System.Windows.Controls.DataGridBoundColumn   Binding 57      �� $
 From�58        59      $ 80Q�5:      $! Конец контакта��5<       5;      �� $ To�5<        5=      $ 80Q�5>      $ 1-ый участник��5@       5?      �� $ 
Member1_ID�5@        5A      $ 80Q�5B      $ 2-ой участник��5D       5C      �� $ 
Member2_ID�5D      5F      5G      5H      