   M S B A M L   `   `   `  ����G  CmvvmDataBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:mvvmDataBase.ViewmvvmDataBase.View  5   	   "    mvvmDataBase.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:mvvmDataBase.View     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��600��6)    � WindowStartupLocation$ CenterScreen=�66    � WindowStyle$
 None=�6[    � 
ResizeMode$ NoResize=�6n   .��5	      �    
Background#���   6   .+�5
   
   �� -   5        $��/Resources/closeIco.png��5
      $��2��61     
ImageClose#���  6A    K� ZIndex$ 2��6~   � 5   
   
������ $��1��6(   $��25,40,25,15q�65   .+�5      ��   SettingsButton#���  6   $��30��6>   $��30��6M   $	��Top=�6\   $
��Left=�6t   ��6�   �� *OpenSettings+�� 5      $��55��6   $��Add User��6!   $	��100��64   $��Center=�6@   $��	0,10,10,0q�6b   $	��Top=�6u   $��Right=�6�     
mainButton#���  6�   ��6�   �� *OpenAddWindow+�� 5       �� CornerRadius$ 15��6   $��1q�6'   
�������$��25,70,25,25q�6O   ���	#59FF4E4E._�5      �� -   5        $��UserList��5        DataBase#���  6+   ��6N   �� *Users+ �� SelectedItem 6l   �� *SelectedUser+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�	 � 	Resources	 5      
 �� 
TargetType �� Property �� Value��%�   '��       '�� v     �� 5      "
 ��6    .�5      ��  � ��
 ���� 6;   �� 5       � �� �	#FF00F7F26;   5      �� 5      "
 ��6    .�5      ��  � �� �	#FF00F7F26;   5      5       �� View 5      �� 5      .P�5      �� $��ID��6-    �� Width$
 auto��69    �� DisplayMemberBinding 6F   �� *id+$ TwoWay=�$ PropertyChanged=��� 5       $��	User Name��6-   $
 auto��6@    6M   �� *
Username+$ TwoWay=�$ PropertyChanged=��� 5!      $��Password��6-   $
 auto��6?    6L   �� *
Password+$ TwoWay=�$ PropertyChanged=��� 5"      $
��Name��6-   $
 auto��6;    6H   �� *Name+$ TwoWay=�$ PropertyChanged=��� 5#      $��Access Level��6-   $
 auto��6C    6P   �� *AccessLevel+$ TwoWay=�$ PropertyChanged=��� 5$      $��Actions��6-   $
 auto��6>    �� CellTemplate 5%   "   �� 5&   &   .R�5'   *   ��  �� Orientation$ 
Horizontal=�65   .+�5(   .   ��   deleteButton#���  65   $��20��6\   $��20��6h   ��6s   �� *DataContext.DeleteComand+ �� RelativeSource ��  �� AncestorType" ��5)   /   �� 5*   .     updateButton#���  65   $��20��6\   $��20��6h   ��6t   �� *DataContext.UpdateComand+ �� " ��5+   +   5,   '   5.      5/      51      52      53      55      56      