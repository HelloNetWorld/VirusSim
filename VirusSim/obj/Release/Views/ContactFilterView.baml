   M S B A M L   `   `   `  ���� C  ?VirusSim, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:VirusSim.ViewsVirusSim.Views  &     VirusSim.Views.ContactFilterView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     .localclr-namespace:VirusSim.Views     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � DataContext  ��    ViewModelLocator �� Source# [   �� Path$ ContactFilterViewModel�.���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $��* �.+��� $��5q�$��Center=� �� Orientation$ 
Horizontal=�.+��� $P��JИнтервал времени (целое число в минутах):��$��14(�$
��Bold"��� $	��100�� �� TextAlignment$ Center=�$��Center=����� *ContactDuration+�� $��1��$	��100��$��5,0,5,5q�$��Center=�$��Вывести������ *CountContacts+&   System.Windows.Controls.DataGrid  $��2��$��5q�$��Center=�   AlternatingRowBackground
 �����   AutoGenerateColumns .  
���   �$��14(�   HorizontalGridLinesBrush
 �   �	   
IsReadOnly	 . ���� *
Contacts+
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   MinWidth$ 80Q�   Header$# Начало контакта��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� $
 From�  $ 80Q�$! Конец контакта�� �� $ To�  $ 80Q�$ 1-ый участник�� �� $ 
Member1_ID�  $ 80Q�$ 2-ой участник�� �� $ 
Member2_ID�