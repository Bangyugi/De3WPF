   M S B A M L   `   `   `  ����A  =De3WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:De3WPFDe3WPF  5   	       De3WPF.Window2   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:De3WPF     5   	     � Title$  Window2��5   	   $	��399��6   $	��800��6&    � 	Resources 5	       �� 
TargetType   
TitleStyle �� Property �� Value  	GridStyle&   System.Windows.Controls.DataGrid  DatagGridStyle��%�  &	        &	 �     &	 >    �� 5   
   " ��6   .�5      ��  � ��
 � ���6+   �� 5       � ��$ 35(�6)   �� 5       � ��$
 Bold"�6+   �� 5       �@��TextAlignment$ Center=�6.   �� 5       � ��$ 0,0,0,20q�6'   5      �� 5   
   " �6   .�5      ��  � ��
 ��İ�6+   5      �� 5   
   "  6   .�5      ��  � ��$ 5q�6'   5      5      .��5      �� 
��� � �$��2q�6!   ._�5!      � #��[ 6    � ColumnDefinitions 5"   
   �� 5#      $��20 �6   �� 5$      $
��auto �6   �� 5%      $
��auto �6   �� 5&      $
��auto �6   �� 5'      $
��auto �6   �� 5(      $��* �6   �� 5)      $��20 �6    � RowDefinitions 5+   
   �� 5,      $��20 �6   �� 5-      $
��auto �6   �� 5.      $
��auto �6   �� 5/      $
��auto �6   �� 50      $
��auto �6   �� 51      $
��auto �6   �� 52      $
��auto �6   �� 53      $
��auto �6   �� 54      $
��auto �6   �� 55      $��* �6   �� 56      $��20 �6   .+�59      �� $B��<Thông tin nhân viên có số tiền bán hàng cao nhất��6   $
��Wrap=�6P   $��1��6d   $��1��6t   $��5��6�   #��[  6�   �� 5;      
��� � �$��2q�6)   $��1��6=   $��7��6M   $��5��6Z   ._�5=        -   5        $��dgNhanVienMax��5=      $��1��6,   $��7��6<   $��5��6I      AutoGenerateColumns$ False��6]      CanUserAddRows$ False��6y   $	��200��6�   #��[ 6�   	   Columns	 5>      0  *System.Windows.Controls.DataGridTextColumn  5?      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Mã NV��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *MaNV+6Q     5@      $
 	Họ tên��6)   $	 200 6S    69   �� *HoTen+6S     5A      $
 Giới tính��6)   $	 100 6Y    6<   �� *
GioiTinh+6Y     5B      $
 Số tiền bán hàng��6)   $	 200 6e    6C   �� *SoTienBanHang+6e     5C      $
 Số tiền hoa hồng��6)   $	 200 6e    6C   �� *SoTienHoaHong+6e   5E      5F      5H      5I      5J      