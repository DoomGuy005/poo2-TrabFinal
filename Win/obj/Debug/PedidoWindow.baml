   M S B A M L   `   `   `  ����B  >Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WindowsWindows  5   	       Windows.PedidoWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Windows     5   	     � Title$  Pedidos de Peças��5   	   $	��452��6"   $	��373��6/   .��5	      � .+�5
   
   �� $��Pedidos dos Clientes��6   $
��Left=�61   $	��402��6L   $��	10,10,0,0q�6Y   $	��Top=�6l   $	��346��6�   .��5      � $��0,0,-2,1q�6   .+�5      �� $��Cliente:��6   $
��Left=�6+   $��	10,10,0,0q�6F   $	��Top=�6Y   �� 5      $��Tipo da peça:��6   $
��Left=�60   $��	10,41,0,0q�6K   $	��Top=�6^   �� 5      $��Preço/Peça:��6   $
��Left=�6.   $��	10,73,0,0q�6I   $	��Top=�6\   $��79��6t   �� 5      $��Pedidos deste cliente:��6   $
��Left=�69   $��
10,104,0,0q�6T   $	��Top=�6h   �� 5      $��Componentes do pedido:��6   $
��Left=�69   $��
10,237,0,0q�6T   $	��Top=�6h   $	��147��6�   �� 5      -   5        $��txtTipoPeça��5      $
��Left=�6-   $��23��6H   $��	94,45,0,0q�6T    �� TextWrapping$
 Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��225��6�   �� 5      -   5        $��txtPreçoPeça��5      $
��Left=�6.   $��23��6I   $��	94,73,0,0q�6U   $
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��225��6�   �� 5      -   5        $��
cmbCliente��5      $
��Left=�6-   $��	94,14,0,0q�6H   $	��Top=�6[   $	��225��6s   6   &   System.Windows.Controls.DataGrid  5      -   5        $��Clientelist��5      $
��Left=�6/   $	��102��6J   $��
10,130,0,0q�6W   $	��Top=�6k   $	��309��6�   6�     5      -   5        $��	Peçalist��5      $
��Left=�6,   $	��102��6G   $��
10,263,0,0q�6T   $	��Top=�6h   $	��309��6�   6�   �� 5      -   5        $��Adcionar��5   *   $
��Left=�6=   $��159,110,0,0q�6X   $	��Top=�6m   $��80��6�   �� 5      -   5        $��Remover��5   *   $
��Left=�6<   $��239,110,0,0q�6W   $	��Top=�6l   $��80��6�   5      5      5      5      