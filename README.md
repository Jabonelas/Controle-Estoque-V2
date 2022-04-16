# # Controle - Estoque - V2 - C# + SQL Server 

Software para controle, gerenciamento e faturamento de estoque para uma empresa de armazenagem de pneus. Sistema desenvolvido somente por experiência , para aplicação dos conhecimento e habilidade até o momento adquiridos. 

## **Iniciação do Sistema**

![enter image description here](https://i.imgur.com/kd4vvNi.gif)


## **Tela Login**
![enter image description here](https://i.imgur.com/676abFS.png)

 - [X] Login por Usuário e Senha. 

## **Tela Home**

![enter image description here](https://i.imgur.com/ZRfeQ92.png)

## **Tela Cadastro Cliente/Fornecedor**

![enter image description here](https://i.imgur.com/59sAWhl.gif)

 - [X] Incluir dados para cadastro Cliente/Fornecedor. 
 - [X]  Modificar dados de cadastro Cliente/Fornecedor.
 - [X]  Excluir cadastro Cliente/Fornecedor.
 - [X] Buscar cadastro Cliente/Fornecedor.

## **Tela Cadastro Produto**

![enter image description here](https://i.imgur.com/bdEmu4O.gif)

- [X] Incluir dados para cadastro Produto.
 - [X]  Modificar dados de cadastro Produto.
 - [X]  Excluir cadastro Produto.
 - [X] Buscar cadastro Produto.



## **Tela de Transferencia de Local**

![enter image description here](https://i.imgur.com/szrGirE.gif)

  - [X]  Modificar local de estoque do produto.(Obedecendo o FIFO para garantir o giro de estoque)
 - [X]  Buscar dados da etiqueta do produto.
 - [X] Estornar etiqueta para local de origem.

## **Tela de Transferencia Entre Etiquetas**

![enter image description here](https://i.imgur.com/ZniT72t.gif)

  - [X]  Transferência de saldo entre etiquetas do mesmo produto. 
 

## **Tela de Busca**

![enter image description here](https://i.imgur.com/OzWV59z.gif)

  - [X] Buscar status por código de barras. 
  - [X]  Buscar Estatus por código do produto.


## **Tela de Entada de Nota Fiscal**

![enter image description here](https://i.imgur.com/qjN47Ue.gif)


  - [X] Incluir Nota Fiscal no sistema. (Verificação de existência de cadrastro Fornecedor e Produtos).
  - [X] Excluir Nota fiscal do sistema.(Impedindo que seja excluído Nota Fiscal que já tenha saldo consumido ou local modificado).
  - [X] Buscar Nota Fiscal.


## **Tela Relatorio de Nota Fiscal de Entrada**

![enter image description here](https://i.imgur.com/CRoM1MR.gif)

  - [X] Buscar Notas Fiscais que deram entrada no sistema. (Emitir relatório de Nota Fiscais que deram entrada com busca por data e impressão no gráfico mostrando o top 5 dos produtos com maior entrada).



## **Tela Faturamento**

![enter image description here](https://i.imgur.com/VSJNgTP.gif)

  - [X] Incluir Produto na Nota Fiscal faturada. (Verificação de existência cadrastro de Cliente).
  - [X] Confirmar Nota Fiscal.
  - [X] Excluir Nota Fiscal que foi faturada.
  - [X] Buscar Nota Fiscal que foi faturada.

## **Tela de Relatorio de Nota Fiscais Faturadas**

![enter image description here](https://i.imgur.com/qjN47Ue.gif)

  - [X] Buscar Nota Fiscal que foram faturadas no sistema. (Emitir relatório de Notas Fiscais que foram faturadas, com busca por data e impressão no gráfico mostrando os tops 5 dos produtos com maior faturamento).
