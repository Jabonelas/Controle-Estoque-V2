using Inventory_Control.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Control
{
    public partial class SuprimentosControleTransferencia : Form
    {
        private VerificacaoDeExistencia VCB = new VerificacaoDeExistencia(); // Verificar a existencia do Codigo de
                                                                             //
                                                                             //
                                                                             // s na tabela Estoque

        private VerificacaoDeExistencia VCP = new VerificacaoDeExistencia(); // Verificar a existencia do Codigo do Produto na tabela Estoque

        private BuscarDadosEstoque BE = new BuscarDadosEstoque(); // buscar existencia dos dados na tabela Estoque

        private BuscarDadosEstoque BECP = new BuscarDadosEstoque(); // Buscar por Codigo de Barras na tabela Estoque o campo Lote

        private BuscarDadosEstoque BEL = new BuscarDadosEstoque(); // Buscar por Codigo de Barras na tabela Estoque o campo Lote

        private BuscarDadosEstoque BED = new BuscarDadosEstoque(); // Buscar por Codigo de Barras na tabela Estoque o campo Lote

        private BuscarDadosEstoque BEQ = new BuscarDadosEstoque(); // Buscar por Codigo de Barras na tabela Estoque o campo Lote

        private BuscarDadosEstoque BELO = new BuscarDadosEstoque(); // Buscar por Codigo de Barras na tabela Estoque o campo Lote

        private AlterarDadosEstoque AE = new AlterarDadosEstoque();

        public SuprimentosControleTransferencia()
        {
            InitializeComponent();
        }

        #region Botão Modificar

        private void btnModificar_CadastroCliente_Click(object sender, EventArgs e)
        {
            //Zerar os Labels * que informam que precisam ser preenchidos os textbox
            //AvisoDePreenchimentoCNPJ.Text = "";
            //AvisoDePreenchimentoTipo.Text = "";

            //if (VT.VerificarTextBoxClienteFornecedor(this) == true) //Verificar se os textbox estão preenchidos
            //{
            try
            {
                if (txtCodDeBarras_MovimentacaoEstoque.Text != "" && cmbDestino_MovimentacaoEstoque.Text != "")
                {
                    if (VCB.BuscarExistenciaCodigoDeBarras(Convert.ToInt32(txtCodDeBarras_MovimentacaoEstoque.Text)) == true)
                    {
                        txtCodDaProduto_MovimentacaoEstoque.Text = BECP.BuscarCodProdutoTextBox(Convert.ToInt32(txtCodDeBarras_MovimentacaoEstoque.Text));//Preencher o textbox Codigo do Produto

                        txtLote_MovimentocaoEstoque.Text = BEL.BuscarLote(Convert.ToInt32(txtCodDeBarras_MovimentacaoEstoque.Text));//Preencher o textbox Lote

                        txtDescricao_MovimentocaoEstoque.Text = BED.BuscarDescricao(Convert.ToInt32(txtCodDeBarras_MovimentacaoEstoque.Text)); //Preencher o textbox Descrição

                        txtQuantidade_MovimentocaoEstoque.Text = BEQ.BuscarQuantidade(Convert.ToInt32(txtCodDeBarras_MovimentacaoEstoque.Text));//Preencher o textbox Quantidade

                        txtLocal_MovimentacaoEstoque.Text = BELO.BuscarLocal(Convert.ToInt32(txtCodDeBarras_MovimentacaoEstoque.Text));//Preencher o textbox Local

                        DialogResult OpcaoDoUsuario = new DialogResult();
                        OpcaoDoUsuario = MessageBox.Show("Deseja Realizar a Modificação?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (OpcaoDoUsuario == DialogResult.Yes)
                        {
                            AE.AlterarEstoque(cmbDestino_MovimentacaoEstoque.Text, Convert.ToInt32(txtCodDeBarras_MovimentacaoEstoque.Text));

                            OpcaoDoUsuario = MessageBox.Show("Modificação Realizada Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (OpcaoDoUsuario == DialogResult.OK)
                            {
                                BE.BuscarCodBarras(Convert.ToInt32(txtCodDeBarras_MovimentacaoEstoque.Text), gvdMovimentacaoEstoque);

                                txtCodDeBarras_MovimentacaoEstoque.Text = "";
                                txtCodDaProduto_MovimentacaoEstoque.Text = "";
                                txtLote_MovimentocaoEstoque.Text = "";
                                txtDescricao_MovimentocaoEstoque.Text = "";
                                txtQuantidade_MovimentocaoEstoque.Text = "";
                                txtLocal_MovimentacaoEstoque.Text = "";
                                cmbDestino_MovimentacaoEstoque.Text = "";

                                label1.Text = "";
                                label2.Text = "";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Codigo de Barras Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    label1.Text = "*";
                    label2.Text = "*";

                    MessageBox.Show("Os Campos Com * é Obrigatorio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Erro ao Movimentação de Estoque!\n\n" + x.ToString());
            }
        }

        #endregion Botão Modificar

        #region Botão Buscar

        private void btnPesquisa_CadastroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodDeBarras_MovimentacaoEstoque.Text != "")
                {
                    if (VCB.BuscarExistenciaCodigoDeBarras(Convert.ToInt32(txtCodDeBarras_MovimentacaoEstoque.Text)) == true)
                    {
                        BE.BuscarCodBarras(Convert.ToInt32(txtCodDeBarras_MovimentacaoEstoque.Text), gvdMovimentacaoEstoque);

                        txtCodDeBarras_MovimentacaoEstoque.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Codigo de Barras Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else { MessageBox.Show("O Campo Cód. Barras é Obrigatorio!"); }
            }
            catch (Exception x)
            {
                MessageBox.Show("Erro ao Realizar Busca!\n\n" + x.ToString());
            }
        }

        #endregion Botão Buscar

        #region TextBox Codigo de Barras

        private void txtCodDeBarras_MovimentacaoEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Codigo de Barras
    }
}