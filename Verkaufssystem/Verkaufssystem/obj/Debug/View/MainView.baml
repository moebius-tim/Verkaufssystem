   M S B A M L   `   `   `  ????I  EVerkaufssystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Verkaufssystem.ViewModelVerkaufssystem.ViewModel  5   	   9!clr-namespace:Verkaufssystem.ViewVerkaufssystem.View  5   	   "    Verkaufssystem.View.MainView   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5vm&clr-namespace:Verkaufssystem.ViewModel     5   	   3local!clr-namespace:Verkaufssystem.View     5   	     ? Title$  SneakerMovement??5	   	   
???????$
??Auto??64   $
??Auto??6B    ? WindowState$ 	Maximized=?6O    ? 
ResizeMode$ 	CanResize=?6g    ? DataContext 5
      ,   &Verkaufssystem.ViewModel.MainViewModel  5   
   6   .??5      ?  ? ColumnDefinitions 5   
   ?? 5       ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      .+?5   
   ?? $??1??6   ??6&   ?? *CurrentViewModel+?? 5   
   $??0??6    ?? Orientation$ 
Horizontal=?6"   $
??Left=?6;   .+?5      ?? $??5q?6   $??
Startseite??6F   $??
Startseite??6e   $
??Left=?6z   ??6    ?? *UpdateViewCommand+6z   ?? 5      $??5q?6   $
??Nike??6F   $??Lagerzugang??6^      ButtonStyle1#???   6t   ??6    ?? *UpdateViewCommand+6t   ?? 5      $??5q?6   $??Lagerbestand??6F   $??Lagerbestand??6f   #???   6}   ??6    ?? *UpdateViewCommand+6}   5      5      5      