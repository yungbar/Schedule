   M S B A M L   `   `   `  ����G  CSchedulePlan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SchedulePlan.BaseDataSchedulePlan.BaseData  5   	        SchedulePlan.BaseData.Auth   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SchedulePlan.BaseData     5   	     � Title$
  Auth��5   	   $	��740��6   $	��500��6#   $	��500��6/   $	��740��6>   .��5	      � ���#52616B � RowDefinitions 5
   
   �� 5      $	��100 �6   �� 5      $	��220 �6   �� 5      -   5         ��Name$ 
RowCaptcha��5   '   $��* �6   6'   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Center=�6"   $��Center=�6=   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      �� $��Авторизация��6   $��40(�6.   ���#F0F5F96<   5      5      �� 5   
   $��1��6   $��Center=�6"   $��Center=�6=   .+�5      �� $ Vertical=�6   $��Right=�60   .+�5      �� $��Login��6   $��24(�6(   ���#F0F5F966   �� 5      -   5         ��Name$ LoginTextBox��5      $��24(�61   ���#F0F5F9���#52616B$	��440��6i   $��63��5      $��admin��6&   $
��10pxq�63   5      �� 5      $ Vertical=�6   $��Right=�60   .+�5      �� $��Password��6   $��24(�6+   ���#F0F5F969   G� 5      -   5         G�Name$ PasswordTextBox��5      $��24(�67   ���#F0F5F9���#52616B$	��440��6o   $��63��5      $
��10pxq�6*    G� Password$ admin��69   5       5!      �� 5"   
   $��2��6   $��Center=�6"   $��Center=�6?   $	��320��6Z   .+�5#      �� -   5        $ CaptchaTextBox��5#      $��30(�5$      $��Italic$�5%      $��Heavy"�5&       �� TextDecorations$ Strikethrough{�5'      $��UltraCondensed&�5(      $��hfshf��5)       �� 
IsReadOnly . 	 �� TextAlignment$	 Center=�5+      ���#F0F5F9���#52616B5,   '   �� 5-      -   5        $ CaptchaTextBoxForUser��5-      $��24(�65   ���#F0F5F9���#52616B6X   5.      �� 5/   
   $��3��6   $��Center=�6"   $��Center=�6?   .+�50      �� -   5        
 ��Name$
 OkButton��50      $��
Войти��6'   ���#F0F5F9���#52616B$��247px��51      $
��71px��6#   $��32(�61   $��0px 0px 0px 20pxq�6?   �� 52      -   5        $
 	RegButton��52      $��Регистрация��6(   ���#52616B���#F0F5F9$��247px��53      $
��71px��6#   $��32(�61   54      55      56      