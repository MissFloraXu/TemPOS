   M S B A M L   `   `   `  ���� R  NPosControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=69643bb246de5ece)clr-namespace:PosControlsPosControls  $    PosControls.FileBrowserControl   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     (myclr-namespace:PosControls     -   $��userControl��  � 	Resources     BlueRinseBrush �� EndPoint �� 
StartPoint � Color � Offset  GridViewColumnHeaderGripper �� 
TargetType �� Property �� Value �� 
TargetType	 �� Padding  GridViewColumnHeaderStyle
 J� SnapsToDevicePixels n�Name �� Triggers P� Property P� Value �� 
TargetName��%  &	        &	 {     &	     7   7   7   7  �� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF223B84��$ 1Q�� $ 	#FF57A0F4��$	 0.5Q�� $ 	#FF4B94EC��$	 0.5Q��� " n�.���  � ��$ 18����  � ��
 �������  � �� �� " n�.R��� #	 z��
������ ._��� $��Center=�$��3��#��z���� " ��.���  � ��$ Center=���  � ��$ Center=���  � ��8   ��  � ��# � ����  � �� �� " ��.R�� .+��� $��HeaderBorder��$��0q�8�� 8�� $	 2,0,2,0q�._��� $��HeaderContent��
�������$��0,0,0,1q�#��z��#��z����. #
 z
 n� $ PART_HeaderGripper��$��Right=�$��0,0,-9,0q�8��  P�  �@J�IsMouseOver . . ��� $ HeaderBorder�� � ��
 � ����� $ HeaderContent�� � ��
 �   �.��]� -   $��mainPane����. ����  �� ElementName$ userControl�� �� Path$ ActualWidth����� $ userControl��$ ActualHeight�.+�&    PosControls.ConfigurationManager  -     Name$ Configuration��� -   $��gridControl������ $ Configuration��$$ BindableControlBackgroundBrush�.+��� -   $��	listView1��
������ 
�������$
��Left=�
���   ����� ���� $ gridControl��$ ActualWidth����� $ gridControl��$ ActualHeight����� " �� �� 	Resources   ListItemHoverFill��%`   &	       �� $	 0,1&�$	 0,0&�.��� $ 	#FFF1FBFF��$ 0Q�� $ 	#FFD5F1FE��$ 1Q�.���  � �� �� " ��.R���  �� CornerRadius$ 2��
 . #��z��#��z��#��z��._��� $��InnerBorder��$ 1��$��1q�._��  � RowDefinitions �� $��11���� .+��� $��UpperHighlight��$y�	Collapsed=����	#75FFFFFF�� $��2��#��z��#
 z
  P�  �@J�IsMouseOver . . ���  � �� �	#FF101060��  � �� �	#FFCCF0FF�� $ UpperHighlight�� � y�$ Hidden=�P�  � {� .  . ��� # � �� � ��-    �� View �� .P��� $
��Name�� �� Width$	 250�� �� CellTemplate �� .R���  �� Orientation$ 
Horizontal=�.+��� ���� *	ImagePath+�� ���� *Name+�� $	��Ext��$
 Auto�� �� DisplayMemberBinding �� *Ext+�� $
��Size��$	 120�� �� *Size+�� $
��Date��$
 Auto�� �� *Date+