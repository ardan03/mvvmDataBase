   M S B A M L   `   `   `  ����G  CmvvmDataBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:mvvmDataBase.ViewmvvmDataBase.View  5   	   =#clr-namespace:mvvmDataBase.VewModelmvvmDataBase.VewModel  67   A%clr-namespace:DataBase.CustomControlsDataBase.CustomControls  6m   !    mvvmDataBase.View.LoginView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:mvvmDataBase.View     5   	   9	viewModel#clr-namespace:mvvmDataBase.VewModel     67   @customcontrols%clr-namespace:DataBase.CustomControls     6m     � Title$  	LoginView��5   	   $	��447��6   $	��500��6(    � WindowStartupLocation$ CenterScreen=�64    � WindowStyle$
 None=�6Y    � 
ResizeMode$ NoResize=�6l   .��5	      �    
Background#���   6    � ColumnDefinitions 5
   
   �� 5      �� 5      $
��auto �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      $
��auto �6   �� 5      .+�5   
   �� -   5        $��/Resources/closeIco.png��5      $��2��61     
ImageClose#���  6A    K� ZIndex$ 2��6~   �� 5   
   $��1��6   $��1��6!   $	��250��6.     	substrate#���  6=   ._�5      �� $��Center=�6   .+�5      �� $��Sign In��6     
HederStyle#���  6+   $��0,10,0,0q�6P   �� 5      $��1q�6   
������� �� CornerRadius$ 5��6B   $��
10,40,10,0q�6S   ._�5      � $	��7 9q�6    5      �� 5      $
��auto �6/   �� 5      $��* �6/   .+�5      �� $��/Resources/loginIco.png��6    $��20��6A   �� 5      -   5         ��Name$ 	textLogin��5   $   $��Login��6W     textHint#���  6d   �� 5       -   5        	 ��Name$	 txtLogin��5    "     TextBoxStyle#���  64   ��6~   �� *
Username+
 �� UpdateSourceTrigger$
 PropertyChanged=�5"      5#      �� 5$      $��1q�6   
�������$ 5��6B   $��
10,40,10,0q�6S   ._�5%      � $	��7 9q�6    5&      �� 5'      $
��auto �6/   �� 5(      $��* �6/   .+�5*      �� $ ��/Resources/passwordIco.png��6    $��20��6D   �� 5+      -   5        $ textPassword��5+   $   $��Password��6]   #���  6m   
������ 6�   �� 5,      -   5        $	 txtPassword��5,   "   #���  67   
������ $��0q�6�   ��6�   �� *
Password+$
 PropertyChanged=�5-      5.      �� 5/        ErrrorMassage#���  6;   ��6   �� *ErrorMessage+6;   �� 50      $��Sign In��6     
mainButton#���  6+   ��6Q   �� *LoginCommand+�� 51      $��4,8,4,4q�6   
������ ��6C   �� *	OpenSigIN+.��52      �� $c��]У вас нет аккаунта? Нажмите сюда и зарегистрируйся!��6    ���	#FF009CFF6[   53      54      55      56      57      