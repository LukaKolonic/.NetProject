   M S B A M L   `   `   `  ????X  TWindowsPresentationFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:WindowsPresentationFoundationWindowsPresentationFoundation  5   	   c6clr-namespace:WindowsPresentationFoundation.Properties(WindowsPresentationFoundation.Properties  5   	   /    )WindowsPresentationFoundation.InfoPlayers   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:WindowsPresentationFoundation     5   	   Glang6clr-namespace:WindowsPresentationFoundation.Properties     5   	     ? Title$  InfoPlayers??5	   	   $	??700??6   $	??800??6*   $??18(?66    ? WindowStartupLocation$ CenterScreen=?6D   .??5      ?    Pozadina#??[  6    ? ColumnDefinitions 5   
   ?? 5      ?? 5       ? RowDefinitions 5   
   ?? 5      $??80 ?6   ?? 5      $??80 ?6   ?? 5      $??80 ?6   ?? 5      $??80 ?6   ?? 5      $??80 ?6   ?? 5      $??80 ?6   ?? 5      $??80 ?6   ?? 5      $??80 ?6   .+?5   
   ?? $??0??6   $??0??6!   $??Center=?6/   8   2WindowsPresentationFoundation.Properties.Resources   	ImeIgraca#??Z 6M   $??0,30,0,0q?6{   
???   ?$??
ExtraBlack"?6?   6?   ?? 5   
   $??0??6   $??1??6!   $??Center=?6/      	BrojDresa#??Z 6L   $??0,30,0,0q?6z   
???   ?$??
ExtraBlack"?6?   6?   ?? 5    
   $??0??6   $??2??6!   $??Center=?6/      Pozicija#??Z 6L   $??0,30,0,0q?6y   
???   ?$??
ExtraBlack"?6?   6?   ?? 5!   
   $??0??6   $??3??6!   $??Center=?6/      Kapetan#??Z 6L   $??0,30,0,0q?6x   
???   ?$??
ExtraBlack"?6?   6?   ?? 5"   
   $??0??6   $??4??6!   $??Center=?6/      BrojZabijenihGolova#??Z 6L   $??0,30,0,0q?6?   
???   ?$??
ExtraBlack"?6?   6?   ?? 5#   
   $??0??6   $??5??6!   $??Center=?6/   	   BrojZutihKartona#??Z	 6L   $??0,30,0,0q?6?   
???   ?$??
ExtraBlack"?6?   6?   ?? 5$   
   $??0??6   $??6??6!   $??Center=?6/   
   Slika#??Z
 6L   $??0,30,0,0q?6v   
???   ?$??
ExtraBlack"?6?   6?   ?? 5%   
   -   5         ??Name$ btnIzadi??5%      $??0??6#   $??7??63   $??Center=?6@      Izadi#??Z 6]   $??10,20,10,10q?6?   $	??100??6?   
????  ?$??
ExtraBlack"?6?    ? Triggers 5&      :? 5'       :? RoutedEvent$ Button.MouseEnter??6   [?5(      ?? 5)      .??5*      ?? .??5+   "   W?  ?? TargetProperty$ (Button.Opacity)?5,   %    W? From$	 1.0X?5-   %   	 W? To$	 0.0X?60    g? Duration$ 0:0:0.5D?69    g? AutoReverse . 6L   5.      5/      51      53      ?? 56   
   -   5         ??Name$ lblPlayerName??56      $??1??6'   $??0??67   $??Center=?6E   $?? ??6c   $??0,30,0,0q?6n   
???  ??$??
ExtraBlack"?6?   6?   ?? 57   
   -   5        $ lblShirtNumber??57      $??1??6(   $??1??68   $??Center=?6F   $?? ??6c   $??0,30,0,0q?6n   
???  ??$??
ExtraBlack"?6?   6?   ?? 58   
   -   5        $ lblPosition??58      $??1??6%   $??2??65   $??Center=?6C   $?? ??6`   $??0,30,0,0q?6k   
???  ??$??
ExtraBlack"?6?   6?   ?? 59   
   -   5        $ 
lblCaptain??59      $??1??6$   $??3??64   $??Center=?6B   $??0,30,0,0q?6_   
???  ??$??
ExtraBlack"?6?   6?   ?? 5:   
   -   5        $ lblGoalsScored??5:      $??1??6(   $??4??68   $??Center=?6F   $?? ??6c   $??0,30,0,0q?6n   
???  ??$??
ExtraBlack"?6?   6?   ?? 5;   
   -   5        $ lblYellowCard??5;      $??1??6'   $??5??67   $??Center=?6E   $?? ??6b   $??0,30,0,0q?6m   
???  ??$??
ExtraBlack"?6?   6?   ?? 5<   
   -   5         ??Name$ 	imgPlayer??5<      $??1??6#   $??6??63   $??2??6@   $	??190??6Q   $	??200??6^   $??Resources/Player.jpg??6k   $??Center=?6?   6?   5?      5@      