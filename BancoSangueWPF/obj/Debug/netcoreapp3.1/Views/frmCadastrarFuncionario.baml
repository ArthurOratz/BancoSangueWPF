   M S B A M L   `   `   `  ����I  EBancoSangueWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:BancoSangueWPF.ViewsBancoSangueWPF.Views  5   	   2    ,BancoSangueWPF.Views.frmCadastrarFuncionario   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:BancoSangueWPF.Views     5   	     � Title$  Cadastro de Funcionario��5   	   $	��350��6)   $	��410��66    � WindowStartupLocation$ CenterOwner=�6B    � WindowStyle$ ThreeDBorderWindow=�6f   .��5	      � .+�5
   
   �� $��Dados do Funcionario��6   $��18(�6/   $
��Left=�6=   $��	10,10,0,0q�6X   $	��Top=�6k   �� 5   
   $	��Id:��6   $
��Left=�6   $��	10,49,0,0q�69   $	��Top=�6L   �� 5   
   $��Nome:��6   $
��Left=�6    $��	9,116,0,0q�6;   $	��Top=�6N   �� 5   
   $
��CPF:��6   $
��Left=�6   $��
10,172,0,0q�6:   $	��Top=�6N   �� 5   
   $��	Telefone:��6   $
��Left=�6$   $��
10,208,0,0q�6?   $	��Top=�6S   �� 5   
   $��Email:��6   $
��Left=�6!   $��
10,238,0,0q�6<   $	��Top=�6P   �� 5   
   $��
Criado em:��6   $
��Left=�6%   $��	11,77,0,0q�6@   $	��Top=�6S   �� 5   
   -   5         ��Name$ txtId��5      $
��Left=�6!   $��
114,53,0,0q�6<    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��146��6|   ${�False��6�   �� 5   
   -   5        $ txtNome��5      $
��Left=�6#   $��113,120,0,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $	��231��6   $��0��6�   �� 5   
   -   5        $ txtCpf��5      $
��Left=�6"   $��114,176,0,0q�6=   $
 Wrap=�6R   $	��Top=�6f   $	��173��6~   $��2��6�   �� 5   
   -   5        $ txtTelefone��5      $
��Left=�6'   $��114,212,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��231��6�   $��4��6�   �� 5   
   -   5        $ txtEmail��5      $
��Left=�6$   $��114,246,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $	��231��6�   $��5��6�   �� 5   
   -   5        $ txtCriadoEm��5      $
��Left=�6'   $��
115,81,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $	��230��6�   ${�False��6�   �� 5   
   -   5         ��Name$ btnCadastrar��5      $��	Cadastrar��6'   $
��Left=�6;   $��181,269,0,0q�6V   $	��Top=�6k   $��8��6�   $��81��6�   $��24��6�   �� 5   
   -   5        $ 	btnBuscar��5      $��Buscar��6$   $
��Left=�65   $��292,174,0,0q�6P   $	��Top=�6e   $��3��6�   �� 5   
   -	   5        $ 	btnLimpar��5      $��Limpar��6$   $
��Left=�65   $��267,269,0,0q�6P   $	��Top=�6e   $��9��6}   $��81��6�   $��24��6�   6�   �� 5   
   -
   5        $ 
btnRemover��5      $��Remover��6%   $
��Left=�67   $��
95,269,0,0q�6R   $	��Top=�6f   $��7��6   $��81��6�   $��24��6�   6�   �� 5   
   -   5        $ 
btnAlterar��5      $��Alterar��6%   $
��Left=�67   $��
10,269,0,0q�6R   $	��Top=�6f   $��6��6   $��81��6�   $��24��6�   6�   �� 5   
   $��
Sobrenome:��6   $
��Left=�6%   $��
10,142,0,0q�6@   $	��Top=�6T   �� 5   
   -   5        $ txtSobrenome��5      $
��Left=�6(   $��114,146,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��231��6�   $��1��6�   5      5      