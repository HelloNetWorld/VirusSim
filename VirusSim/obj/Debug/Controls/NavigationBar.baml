   M S B A M L   `   `   `  ����C  ?VirusSim, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:VirusSim.ControlsVirusSim.Controls  5      /clr-namespace:VirusSim.StateVirusSim.State  5      %    VirusSim.Controls.NavigationBar   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:VirusSim.Controls     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ,navclr-namespace:VirusSim.State     5      .��5
      �    PrimaryBrush1#��[  6     �� EdgeMode$  Aliased=�67    � 	Resources 5   
     	NavButton �� BasedOn �� 
TargetType��%+   '	�       7  �� 5      8   " 	�69   5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��5      $��5��5        NavigationBarHeader#��[ 5      $��Virus Simulator��5      	� 5    
   $��1��5!      $��0��5"         VirusSim.State.ViewType   OverView#��Z 5$      $��Задача 1-1��5%      ��5#      �� *UpdateCurrentViewModel+5%      	� 5&   
   $��1��5'      $��1��5(         ContactFilter#��Z 5*      $��Задача 1-2��5+      ��5)      �� *UpdateCurrentViewModel+5+      	� 5,   
   $��1��5-      $��2��5.      
   Age#��Z 50      $��Задача 1-3��51      ��5/      �� *UpdateCurrentViewModel+51      53      54      