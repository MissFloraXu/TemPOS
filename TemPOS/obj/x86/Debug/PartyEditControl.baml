   M S B A M L   `   `   `  ����T  PTemPOS, Version=1.0.4709.35932, Culture=neutral, PublicKeyToken=b60a724858027fa2)clr-namespace:PointOfSalePointOfSale  5   2  R NPosControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b60a724858027fa2>.clr-namespace:PosControls;assembly=PosControlsPosControls 6W  5clr-namespace:PointOfSale.TypesPointOfSale.Types  6�  "    PointOfSale.PartyEditControl   6   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     65   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6w   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   @d2http://schemas.microsoft.com/expression/blend/2008     6�   (myclr-namespace:PointOfSale     62  ?ctrl.clr-namespace:PosControls;assembly=PosControls     6W  -tclr-namespace:PointOfSale.Types     6�  .��5      ]� -   5        $��mainPane��5   #   ��. .+�5      &   PosControls.ConfigurationManager  -   5           Name$  Configuration��5       � 5       � ColumnDefinitions 5      �� 5   
   $
��200* �6   �� 5   
   $
��200* �6   �� 5   
   $
��200* �6    � RowDefinitions 5
      �� 5   
   $��40 �6   �� 5   
   $��40 �6   �� 5   
   $��40 �6   �� 5   
   $��40 �6   �� 5   
   $
��153* �6   �� 5   
   $��80 �6   ��5      �� 5   
    �� ElementName$ Configuration��6    �� Path$$ BindableControlBackgroundBrush�6.   .+�5      �� $��6��6   $��2��6    �� 5      $��2��6   $��6��6   �� 5      $��2��6   $��4��6   $��1��60   $��5,5,5,5q�6=   ._�5   
   �  5      �� 5      $��40 �6   �� 5      $
��400* �6   .+�5        PosControls.CustomTextBox  -   5          Name$ textBoxGuestName��5         UseContextMenuEditing .    
PromptType$ Keyboard=�6V      KeyboardShiftMode$ SoftCapsLock=�6l   $��5q�6�   $��30��6�   6�   #  PosControls.DragScrollListBox  5      -   5        	  Name$	 listBoxGuests��5   #   $��1��6:   $��5q�6G   $��Stretch=�6R   
������ 6�   5      5    	   �� 5!         PointOfSale.Types.Strings
   PartyHostsName#��Z
 6   $��16(�6<   �� 5"         	PartySize#��Z 6   $��16(�67   $��1��6E   �� 5#         Notes#��Z 6   $��16(�63   $��2��6A   �� 5$         InvitedGuestList#��Z 6   $��16(�6>   $��Center=�6L   $��Center=�6i   $��2��6�     5%      -   5        $ textBoxHostName��5%       . $ Keyboard=�6Q   $��1��6g   $��5,5,5,5q�6w   6�     5&      -   5        $ textBoxPartySize��5&       . $ IntegerNumeric=�6R   $��1��6n   $��1��6~   $��	5,5,150,5q�6�   6�     5'      -   5        $ textBoxNotes��5'       . $ Keyboard=�6N      TextWrapping$
 Wrap=�6d   $��2��6x   $��1��6�   $��5,5,5,5q�6�   6�   �� 5(      $��5��6   $��2��6     �� Orientation$ 
Horizontal=�60   $��Center=�6I   $��Center=�6d   .+�5)   
   !  PosControls.TextBlockButton  -   5          Name$ 	buttonAdd��5)      $��0,0,5,0q�62   $��70��6C   $��64��6N   
   Add   Text# Z 6Z   6z     5*   
   -	   5        $ buttonDelete��5*      $��0,0,5,0q�65   $��70��6F   $��64��6Q      Delete# Z 6]   {�.  6�   5+   	   5,      5-      5.      