   M S B A M L   `   `   `  ����E  AnmctBaWPF1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:nmctBaWPF1.viewmodelnmctBaWPF1.viewmodel  5      !    nmctBaWPF1.view.LoginScreen   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1vm"clr-namespace:nmctBaWPF1.viewmodel     5      $	��160��5      $	��470��6     � DataContext  5	      (  "nmctBaWPF1.viewmodel.LoginScreenVM  5
   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��30 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      .+�5   
   �� -   5        $��lblInlogNaam��5      $
��Naam��6$   $��1��63   $��1��6@   $	��100��6P   $��30��6\   �� 5   
   -   5        $��txtInlogNaam��5      $��1��6&   $��2��63   $��30��6C   �� 5   
   -   5        $��lblInlogPas��5      $��	Passwoord��6#   $��2��67   $��1��6D   $	��100��6T   $��30��6`   �� 5   
   -   5        $��txtInlogPas��5      $��2��6%   $��2��62   $��30��6B   �� 5   
   -   5        $��btnInlogLogin��5      $��1��6&   $��3��66   $��10q�6C   $��50��6O   $	��Top=�6[   $��Log in��6�   ��6s   �� *LoginCommand+6�   �� 5    
   -   5        $��btnInlogStop��5       $��2��6%   $��3��65   $��10q�6B   $��50��6N   $	��Top=�6Z   $��beëndig het programma��6r   5!      5"      