   M S B A M L   `   `   `  ���� C  ?VirusSim, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:VirusSim.ViewsVirusSim.Views  !    VirusSim.Views.OverViewView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     .localclr-namespace:VirusSim.Views     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � DataContext  ��    ViewModelLocator �� Source# [   �� Path$ OverViewViewModel� � 	Resources   lvPersonsStyle �� 
TargetType �� Property �� Value �� Width �� CellTemplate	 �� Triggers
 �� Binding �� Value  lvContactsStyle��%.  &	       &	 �    �� " ��.���  �@%�IsVirtualizing . ��  �@%�VirtualizationMode$ 	Recycling=��� " �@��IsDeferredScrollingEnabled . ��  � �� �� *	Persons+��  �@��View �� .P��� $ 50��$��Id�� �� .R��� ���� *Id+�� $	 150��$
��Name�� �� .R��� ���� *Name+�� $ 50��$	��Age�� �� .R��� ���� *Age+	 �� 
 �� *	IsLoading+ True.a���  �@�Cursor$
 Wait����  � ��
 ������� " ��.���  �@%�IsVirtualizing . ��  �@%�VirtualizationMode$ 	Recycling=��� " �@��IsDeferredScrollingEnabled . ��  � �� �� *
Contacts+��  �@��View �� .P��� $	 150��$
��From�� �� .R��� ���� *From+�� $	 150��$��To�� �� .R��� ���� *To+�� $ 70��$��
Member1_ID�� �� .R��� ���� *
Member1_ID+�� $ 70��$��
Member2_ID�� �� .R��� ���� *
Member2_ID+	 �� 
 �� *	IsLoading+ True.a���  �@�Cursor$
 Wait����  � ��
 �����.���  � RowDefinitions �� $��* � � ColumnDefinitions �� $��* ��� $��* �.+��� $��0��$��5q�#���  �� $��1��$��5q�#���  