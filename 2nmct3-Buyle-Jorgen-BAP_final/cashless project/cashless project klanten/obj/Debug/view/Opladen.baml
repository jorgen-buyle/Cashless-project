   M S B A M L   `   `   `  ����S  Ocashless project klanten, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:cashless_project_klanten.viewmodel"cashless_project_klanten.viewmodel  5      +    %cashless_project_klanten.view.Opladen   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?vm0clr-namespace:cashless_project_klanten.viewmodel     5        � DataContext  5	      2  ,cashless_project_klanten.viewmodel.OpladenVM  5
   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��10px �6   �� 5      �� 5      �� 5      $
��10px �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $*��$u kan maximaal voor 100 euro opladen��6   $��0��6@   $��1��6M   $��2��6]   $��Center=�6q   $��Center=�6�   �� 5   
   $��op uw kaart staat: ��6   $��1��6/   $��1��6<   $��Center=�6L   $��Right=�6g   �� 5   
   $
�� €��6   $��1��6   $��2��6+   $��Center=�6;   $
��Left=�6V   �� 5   
   $��op uw kaart staat: ��6   $��2��6/   $��1��6<   $��Center=�6L   $��Right=�6g   �� 5   
   $�� ��6   $��2��6   $��2��6'   $��Center=�67   $��10q�6R   �� 5   
   $��terug��6   $��1��6!   $��3��61   $��15q�6>   ��6J   �� *TerugCommand+�� 5   
   $��opladen��6   $��2��6#   $��3��63   $��15q�6@   ��6L   �� *OpladenCommand+5       5!      