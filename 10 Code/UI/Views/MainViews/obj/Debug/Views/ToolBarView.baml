   M S B A M L   `   `   `  ����T  PFFTApp.UI.Views.MainViews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FFTApp.UI.ViewsFFTApp.UI.Views  5      !    FFTApp.UI.Views.ToolBarView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:FFTApp.UI.Views     5      P LPrism.Wpf, Version=6.3.0.0, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  . .��5
      ]� .+�5   
   `� $
��Left=�6   .�5      c� .@�5      ��  �� Orientation$ Vertical=�6   .+�5      �� $��Save All��6=    c� OverflowMode$ Always=�6P   ��6   �� *SaveCommand+��5      �� 5       �� 
TargetType" ��6.   .R�5   "   A�  A�Name$ 
faceButton��6*   
���  ��$��20��6I   $��20��6T    �� Triggers 5   "   P� 5   &    P� Property �@J�IsMouseOver P� Value . . �5   *   ��  �� 
TargetName$ 
faceButton��61   	 �� Property	 � ��
 �� Value

 ��  �6Y   5   '   P� 5   &    � �� . . �5   *   �� $ 
faceButton��61   	 � ��

 ��� �6Z   5   '   5      5      �� 5      $
��Open��6=   $ AsNeeded=�6L   ��6   �� *SaveCommand+6L   5      5      5       5!      5"      