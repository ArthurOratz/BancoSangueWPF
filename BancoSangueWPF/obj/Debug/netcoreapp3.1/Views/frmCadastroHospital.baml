   M S B A M L   `   `   `  ����I  EBancoSangueWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:BancoSangueWPF.ViewsBancoSangueWPF.Views  5   	   .    (BancoSangueWPF.Views.frmCadastroHospital   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:BancoSangueWPF.Views     5   	     � Title$  Cadastro de Hospitais��5   	   $	��335��6'   $	��394��64    � WindowStartupLocation$ CenterOwner=�6@    � WindowStyle$ ThreeDBorderWindow=�6d   .��5	      � .+�5
   
   �� $��Dados do Hospital��6   $��18(�6,   $
��Left=�6:   $��	10,10,0,0q�6U   $	��Top=�6h   �� 5   
   $	��Id:��6   $
��Left=�6   $��	10,49,0,0q�69   $	��Top=�6L   �� 5   
   $��
Criado em:��6   $
��Left=�6%   $��	11,77,0,0q�6@   $	��Top=�6S   �� 5   
   $��Nome:��6   $
��Left=�6    $��
10,117,0,0q�6;   $	��Top=�6O   �� 5   
   $��
Endereço:��6   $
��Left=�6$   $��
10,153,0,0q�6?   $	��Top=�6S   �� 5   
   $��	Telefone:��6   $
��Left=�6$   $��
10,189,0,0q�6?   $	��Top=�6S   �� 5   
   $��Nome do Responsavel:��6   $
��Left=�6/   $��
10,219,0,0q�6J   $	��Top=�6^   �� 5   
   -   5         ��Name$ txtId��5      $
��Left=�6!   $��
114,53,0,0q�6<    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��146��6|   ${�False��6�   �� 5   
   -   5        $ txtNome��5      $
��Left=�6#   $��114,121,0,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $	��187��6   $��0��6�   �� 5   
   -   5        $ txtEndereco��5      $
��Left=�6'   $��114,157,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��231��6�   $��2��6�   �� 5   
   -   5        $ txtTelefone��5      $
��Left=�6'   $��114,193,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��231��6�   $��3��6�   �� 5   
   -   5        $ txtNomeResponsavel��5      $
��Left=�6.   $��146,227,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��199��6�   $��4��6�   �� 5   
   -   5        $ txtCriadoEm��5      $
��Left=�6'   $��
115,81,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $	��145��6�   ${�False��6�   �� 5   
   -   5         ��Name$ btnCadastrar��5      $��	Cadastrar��6'   $
��Left=�6;   $��181,250,0,0q�6V   $	��Top=�6k   $��7��6�   $��81��6�   $��24��6�   �� 5   
   -   5        $ 	btnBuscar��5      $��Buscar��6$   $
��Left=�65   $��306,119,0,0q�6P   $	��Top=�6e   $��1��6�   �� 5   
   -	   5        $ 	btnLimpar��5      $��Limpar��6$   $
��Left=�65   $��267,250,0,0q�6P   $	��Top=�6e   $��8��6}   $��81��6�   $��24��6�   6�   �� 5   
   -
   5        $ 
btnRemover��5      $��Remover��6%   $
��Left=�67   $��
95,250,0,0q�6R   $	��Top=�6f   $��6��6   $��81��6�   $��24��6�   6�   �� 5   
   -   5        $ 
btnAlterar��5      $��Alterar��6%   $
��Left=�67   $��
10,250,0,0q�6R   $	��Top=�6f   $��5��6   $��81��6�   $��24��6�   6�   5      5      