   M S B A M L   `   `   `  ����E  ACryptoTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CryptoTool
CryptoTool  5   	       CryptoTool.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:CryptoTool     5   	     � Title$  
CryptoTool��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6$   $��18(�61   $��Segoe UI)�5       �� TextAlignment$ Center=�5      $��Enter your text file:��5      $
��0,10q�5      �� 5!   
   -   5         ��Name$ txbFileName��5!      $��2��6'   $��1��67   $��20��5"      $	��500��5#      $��10q�6   $��14(�6*   $��Segoe UI Light)�5$       �� TextAlignment$ Center=�5%      4  .System.Windows.Automation.AutomationProperties   Name$ tbxFiles��5&         HelpText$ Chosen File Name��5'      �� 5)   
   -   5        $��3��5)      $��1��6!   $��30��6.   $��80��6:   $
��0,10q�5*      $��Choose��6"   5+      �� 5-   
   $��1��6   $��2��6$   $��18(�61   $��Segoe UI)�5.      $ Center=�5/      $��Encryp / Decrypt :��50      $
��0,10q�51      �� 53   
   $��10q�6   $��2��6!   $��2��61   $��Center=�54      .+�55      	� -   5        $��
encryption��55      .��6I   
Encryption6U   	� 56      -   5        $��
decryption��56      .��6I   
Decryption6U   57      �� 59   
   $��1��6   $��3��6$   $��18(�61   $��Segoe UI)�5:      $ Center=�5;      $��Resulted text:��5<      $
��0,10q�5=      �� 5?   
   -   5        $ txbEncryDecryp��5?      $��2��6*   $��3��6:   $	��150��5@      $	��500��5A      $��10q�6   $��14(�6*   $��Segoe UI Light)�5B      $ Center=�5C      $ tbxFiles��5D      $ Chosen File Name��5E      �� 5G   
   -   5        $��2��5G      $��4��6"   $��30��6/   $	��500��5H      $	��Top=�6    �� SelectionMode$ Single=�5J      .@�5K      �� .��6   AES6   �� 5L      .��6   DES6   �� 5M      .��6   	TripleDES6%   �� 5N      .��6   
Rijndael6$   �� 5O      .��6   RC26   5P      �� 5R   
   -   5        $��2��5R      $��4��6!   $��40��6.   $	��160��6:   $��Bottom=�5S      $
��0,10q�5T      $	��Run��6"   5U      5W      5X      