   M S B A M L   `   `   `  ????I  EVerkaufssystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:VerkaufssystemVerkaufssystem  5      9!clr-namespace:Verkaufssystem.ViewVerkaufssystem.View  5      C&clr-namespace:Verkaufssystem.ViewModelVerkaufssystem.ViewModel  5          Verkaufssystem.App   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      .localclr-namespace:Verkaufssystem     5      2view!clr-namespace:Verkaufssystem.View     5      <	viewmodel&clr-namespace:Verkaufssystem.ViewModel     5        ?? 	Resources  5       ?? DataType,  &Verkaufssystem.ViewModel.HomeViewModel"   Verkaufssystem.View.HomeView,  &Verkaufssystem.ViewModel.NikeViewModel"   Verkaufssystem.View.NikeView4  .Verkaufssystem.ViewModel.LagerbestandViewModel*   $Verkaufssystem.View.LagerbestandView   FocusVisual ?? Property ?? Value J? SnapsToDevicePixels ?? StrokeDashArray  Button.Static.Background ?? Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1 ?? 
TargetType ?? 
TargetType	 ??Name
 ??Name ?? Triggers P? Property P? Value ?? 
TargetName??%  (??       5	      *, +)(?? 2     5      *, +)(?? d     5      *, +)&	  ?     &	 @    &	 c    &	 ?    &	 ?    &	 ?    &	 ?    &	     &	 5    &		 X    &	
 {    7   7  7  7  7  7  7  7  7  7 	 ?? 5	   
   "  6   .R?5
        5      ?? 5   
   "  6   .R?5        5      ?? 5   
   "  6   .R?5        5      ?? 5   
   .?5      ??  ? ?? 5      ?? 5      .R?5      ?? $??2q?6$    . #??? ??6J   $??1??6?   $	 1 2R?6?   5      5      5      ?? 5   
   $ 	#FFDDDDDD??6;   ?? 5   
   $ 	#FF707070??67   ?? 5   
   $ 	#FFBEE6FD??6>   ?? 5   
   $ 	#FF3C7FB1??6:   ?? 5   
   $ 	#FFC4E5F6??6<   ?? 5    
   $ 	#FF2C628B??68   ?? 5!   
   $ 	#FFF4F4F4??6=   ?? 5"   
   $ 	#FFADB2B5??69   ?? 5#   
   $ 	#FF838383??6=   ?? 5$   
   " ??6%   .?5%      ??  ?@?FocusVisualStyle8   61   ?? 5&       ? ??8  6+   ?? 5'       ? ??8  6,   ?? 5(       ? ??# ? ??6+   ?? 5)       ? ??$ 1q?60   ?? 5*       ? ??$ Center=?6;   ?? 5+       ? ??$ Center=?69   ?? 5,       ? ??$ 1q?6(   ?? 5-       ? ?? 5.      ?? 5/      " ??6&   .R?50      ?? $	 border??6!   #??z??61   #??z??6]   #??z??6?    . ._?51      ?? $
 contentPresenter??6/   |?.  #??z??6[   #??z??6?   ??. # z 6?   #??z??6  52       53      P? 54       ?@??IsDefaulted . . ?55   "   ?? $ border??6@   # ? ??6T    ? ??56      P? 57       ?@J?IsMouseOver . . ?58   "   ?? $ border??6?   8   ? ??6S   ?? 59   "   $ border??6@   8   ? ??6T   5:      P? 5;       ? ?? . . ?5<   "   ?? $ border??6?   8   ? ??6S   ?? 5=   "   $ border??6@   8   ? ??6T   5>      P? 5?       ? {? .  . ?5@   "   ?? $ border??6?   8   ? ??6S   ?? 5A   "   $ border??6@   8   ? ??6T   ?? 5B   "   $ contentPresenter??6K   8 	  ? ??6i   5C      5E      5G      5H      5I      5J      