   M S B A M L   `   `   `  ���� @  <SDE, Version=1.0.3.419, Culture=neutral, PublicKeyToken=null!clr-namespace:SDE.WPFSDE.WPF  G CTokeiLibrary, Version=1.2.0.0, Culture=neutral, PublicKeyToken=nullW;clr-namespace:TokeiLibrary.WPF.Styles;assembly=TokeiLibraryTokeiLibrary.WPF.Styles #clr-namespace:SDE.ViewSDE.View  5clr-namespace:SDE.View.ControlsSDE.View.Controls  #    SDE.View.Controls.SearchPanel   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     8x,http://schemas.microsoft.com/winfx/2006/xaml    Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    >d2http://schemas.microsoft.com/expression/blend/2008    $WPF1clr-namespace:SDE.WPF    LStyles;clr-namespace:TokeiLibrary.WPF.Styles;assembly=TokeiLibrary    %viewclr-namespace:SDE.View    2controlsclr-namespace:SDE.View.Controls    .���� $��32�����#BEBEBE$��1q�$	��Top=�$��Right=�._�� 
�������.+�]� .+�)  #TokeiLibrary.WPF.Styles.FancyButton  -      Name$  _buttonFancyMode��$��3 0 0 0q�$��24��$��24��   	ImagePath$ replace.png��   IsButtonEnabled .  � ToolTip$6 0Toggle to switch between replace and find modes.���� -   $��_border1��$��3 0 3 0q����#8490A1$��Center=�$��1q�$	��160��._�� .+�$   SDE.View.Controls.LeftComboBox  -     Name$ 
_cbSubMenu��$��0��$��Bottom=�.@��� $��-4, -2, -4, -2q�$	��170��|�.  $��1q����#9AA6B6 � FocusVisualStyle Z� ����  �� 
StartPoint$	 0,0&� �� EndPoint$	 0,1&�.���  � Offset$ 0Q�	 � Color$	 #DEDEDE��� $	 0.5Q�$	 White��._�� 
 � RowDefinitions
 �� �� �� �� .+��� $��2 6 2 2q�$��Search options��
��������� $��2q�$��1��$��Use Regular Expression�� d� 	IsChecked ��  �� RelativeSource ��  �� AncestorType#   SDE.View.Controls.SearchPanel"   �� Path$ UseRegex�$2 ,Search using .NET regular expression syntax.���� $��2q�$��2��$��Match Whole Words�� ��  �� "  $ 
WholeWords�$- 'Only find results that are whole words.���� $��2 2 2 6q�$��3��$��
Match Case�� ��  �� "  $ 	MatchCase�$&  Perform case sensitive searches.���� -   $��_searchTextBox�� �� AcceptsReturn .   �� 
AcceptsTab .  $��3q�$��0q�$��Center=�$
��Left=�$	��145��.������ $ SearchPattern� �� UpdateSourceTrigger$ PropertyChanged=� �� *TemplatedParent+ �� ValidationRules 5  /System.Windows.Controls.ExceptionValidationRule  .���� -   $��
_labelFind��$��3 0 0 0q�$��Center=�$��Find...��$��Italic$�
������� J� IsHitTestVisible .  �� $��Right=�
�������$��15��
�������$��0q�._�  -   $  _buttonOpenSubMenu��$��Right=�$��15��$ smallArrow.png��  -   $  _buttonPrev��$��24��$��24��$ arrowup.png�� . $ Find Preview (Shift+F3)��  -   $  _buttonNext��$��24��$��24��$ arrowdown.png�� . $ Find Next (F3)���� -	   $��_border2��$��3 0 3 0q����#8490A1$��Center=�$��1q�y���  �� ElementName$ _replaceTextBox��$ 
Visibility�._�� .+��� -
   $��_replaceTextBox�� .   .  $��3q�$y�	Collapsed=�$��0q�$��Center=�$	��150��.���� -   $��_labelReplace��$��3 0 0 0q�$��Center=�$��
Replace...��$��Italic$�
������� .    -   $  _buttonReplaceSingle��$��24��$��24��$ replaceSingle.png�� . y��� $ _replaceTextBox��$ 
Visibility�$ Replace Next��  -   $  _buttonReplaceAll��$��24��$��24��$ replaceAll.png�� . y��� $ _replaceTextBox��$ 
Visibility�$ Replace All��  -   $  _buttonClose��$��3q�$��24��$��24��$ 
delete.png�� . $ Close��