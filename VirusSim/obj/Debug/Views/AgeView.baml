   M S B A M L   `   `   `  ����C  ?VirusSim, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:VirusSim.ViewsVirusSim.Views  5          VirusSim.Views.AgeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:VirusSim.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � DataContext  5      ��    ViewModelLocator �� Source# [   �� Path$ AgeViewModel�.��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��5      $	��100��5      $��5q�5      $��Center=�5      $��Рассчитать��5      ��5      �� *	Calculate+5      &   System.Windows.Controls.DataGrid  5   
   $��1��5      $��5q�5      $��Center=�5         AlternatingRowBackground
 �����   AutoGenerateColumns .  
���   �$��14(�5          HorizontalGridLinesBrush
 �   �   
IsReadOnly .    RowBackground
 �������5#      �� *Ages+	   Columns	 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn
   MinWidth$
 80Q�5'         Header$ Имя��5)      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5(      �� $
 Name�5)        5*      $
 80Q�5+      $ Всего, лет��5-       5,      �� $ Total�5-        5.      $
 80Q�5/      $* $Количество, человек��51       50      �� $ Count�51        52      $
 80Q�53      $. (Возраст в среднем, лет��55       54      �� $ Average� �� StringFormat$ F��55      57      58      5:      