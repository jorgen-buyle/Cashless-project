   M S B A M L   `   `   `  ����S  Ocashless project klanten, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:cashless_project_klanten.viewmodel"cashless_project_klanten.viewmodel  5      4    .cashless_project_klanten.view.KlantRegistratie   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?vm0clr-namespace:cashless_project_klanten.viewmodel     5        � DataContext  5	      ;  5cashless_project_klanten.viewmodel.KlantRegistratieVM  5
   
   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $<��6welkom bij het registratie. druk oke om verder te gaan��6   $��2��6R   $
��Wrap=�6f   $��Center=�6z   $��5,0,0,0q�6�   �� 5   
   $��Naam:��6   $��0��6!   $��1��61   $��	5 25 0 25q�6>   $��Center=�6Q    �� TextAlignment$ Center=�6l   �� 5   
   -   5        $��txbKlantRegNaam��5      $��1��6+   $��1��6;   $��	0 25 0 25q�6H   $��Center=�6[   �� 5   
   $��0��6   $��2��6$   $��	5 25 0 25q�61   $��Center=�6D   $ Center=�6_   �� 6w   $�Addres��6{   �� 6�   $�:��6�   6�   �� 5   
   -   5        $��txbKlantRegAddress��5      $��1��6.   $��2��6>   $��	0 25 0 25q�6K   $��Center=�6^   �� 5   
   $��2��6   $��1��6$   $��	5 25 5 25q�61   $ Center=�6D   $��Center=�6[   �� 6w   $
�foto��6{   �� 6�   $�:��6�   6�   �� 5   
   -   5        $��imgKlantRegFoto��5      $��2��6'   $��2��67   $	��150��6D   $	��150��6P   $��2��6]   $��	 0 0 0 90q�6n   6�   �� 5!   
   -   5        $��btnKlantRegRegistreer��5!      $��0��6.   $��3��6>   $��	5 25 5 25q�6K   $��
registreer��6_   �� 5"   
   -   5        $��btnKlantRegCancel��5"      $��1��6*   $��3��6:   $��	5 25 5 25q�6G   $��cancel��6Z   5#      5$      