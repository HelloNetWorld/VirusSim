   M S B A M L   `   `   `  ���� C  ?VirusSim, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:VirusSim.ViewsVirusSim.Views      VirusSim.Views.AgeView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     .localclr-namespace:VirusSim.Views     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � DataContext  ��    ViewModelLocator �� Source# [   �� Path$ AgeViewModel�.���  � RowDefinitions �� $
��Auto ��� $��* �.+��� $��0��$	��100��$��5q�$��Center=�$��Рассчитать������ *	Calculate+&   System.Windows.Controls.DataGrid  $��1��$��5q�$��Center=�   AlternatingRowBackground
 �����   AutoGenerateColumns .  
���   �$��14(�   HorizontalGridLinesBrush
 �   �   
IsReadOnly .    RowBackground
 ��������� *Ages+	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   MinWidth$
 80Q�   Header$ Имя��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� $
 Name�  $
 80Q�$ Всего, лет�� �� $ Total�  $
 80Q�$* $Количество, человек�� �� $ Count�  $
 80Q�$. (Возраст в среднем, лет�� �� $ Average� �� StringFormat$ F��