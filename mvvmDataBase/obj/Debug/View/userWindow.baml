   M S B A M L   `   `   `  ����G  CmvvmDataBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:mvvmDataBase.ViewmvvmDataBase.View  5   	   "    mvvmDataBase.View.userWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:mvvmDataBase.View     5   	     � Title$  
userWindow��5   	   $	��267��6   $	��500��6)    � WindowStartupLocation$ CenterScreen=�65    � WindowStyle$
 None=�6Z    � 
ResizeMode$ NoResize=�6m   .��5	      �    
Background#���   6    � RowDefinitions 5
   
   �� 5      $��30 �6   �� 5      .+�5   
   �� -   5        $��/Resources/closeIco.png��5      $��0��61     
ImageClose#���  6>    K� ZIndex$ 2��6{   �� 5   
     SettingsButton#���  6   $��30��6:   $��30��6I   $	��Top=�6X   $
��Left=�6p   ��6�   �� *OpenSettings+�� 5   
   $��1��6    �� CornerRadius$ 15��6   $��1q�60   
�������$��25,10,25,25q�6X   ���	#59FF4E4E._�5      �� -   5        $��UserList��5        DataBase#���  6'   ��6K   �� *Users+ �� SelectedItem 6i   �� *SelectedUser+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�
 � 	Resources
 5       �� 
TargetType �� Property �� Value��%�   '��       '�� p     �� 5      " ��6   .�5      ��  � ��
 ���� 63   �� 5       � ��
 �����63   5      �� 5      " ��6   .�5      ��  � ��
 �����63   5      5       �� View 5      �� 5      .P�5      �� $��ID��6%    �� Width$
 auto��61    �� DisplayMemberBinding 6>   �� *id+$ TwoWay=�$	 PropertyChanged=��� 5      $��	User Name��6%   $
 auto��68    6E   �� *
Username+$ TwoWay=�$	 PropertyChanged=��� 5      $��Password��6%   $
 auto��67    6D   �� *
Password+$ TwoWay=�$	 PropertyChanged=��� 5       $
��Name��6%   $
 auto��63    6@   �� *Name+$ TwoWay=�$	 PropertyChanged=�5!      5#      5$      5&      5'      