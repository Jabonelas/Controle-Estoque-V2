using Inventory_Control.Dados;
using Inventory_Control.Verificacao;
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
    public partial class VendasNotaFiscalSaida : Form
    {
        private VerificacaoTextBox VT = new VerificacaoTextBox();

        private InserirNotaFiscalSaida INFS = new InserirNotaFiscalSaida();

        private Count CNFS = new Count();

        private BuscarNotaFiscalSaida BNFS = new BuscarNotaFiscalSaida();

        private BuscarDadosEstoque BE = new BuscarDadosEstoque();

        private DeletarNotaFiscalSaida DNFS = new DeletarNotaFiscalSaida();

        private VerificarEstoqueLiberado VEL = new VerificarEstoqueLiberado(); // Verificar se o local do estoque é EXPEDICA    O

        private AlterarDadosEstoque AQES = new AlterarDadosEstoque(); // Alterar a quantidade do estoque subtraindo

        private AlterarDadosEstoque AQEA = new AlterarDadosEstoque(); // Alterar a quantidade do estoque adicionando

        public VendasNotaFiscalSaida()
        {
            InitializeComponent();
        }

        #region Bontão Incluir

        private void btnIncluir_CadastroCliente_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";

            try
            {
                if (txtCodProduto_VendasNFSaida.Text != "" && txtQuantidade_VendasNFSaida.Text != "")
                {
                    txtDataDeEmissao_VendasNFSaida.Text = DateTime.Today.ToShortDateString();

                    if (VEL.VerificarLocalEstoque(Convert.ToInt32(txtCodProduto_VendasNFSaida.Text)) == "EXPEDICAO")
                    {
                        if (txtNFSaida_VendasNFSaida.Text == "") //gerar o numero da NF de Saida
                        {
                            txtNFSaida_VendasNFSaida.Text = Convert.ToString(CNFS.ContarNFSaidaGerando());
                        }
                        else //manter  o numero da NF de Saida que já foi gerado
                        {
                            txtNFSaida_VendasNFSaida.Text = Convert.ToString(CNFS.ContarNFSaidaContinuacao());
                        }

                        AQES.AlterarQuantidadeEstoqueSubtracao(Convert.ToInt32(txtCodProduto_VendasNFSaida.Text), Convert.ToInt32(txtQuantidade_VendasNFSaida.Text));

                        INFS.InserirNFSaida(Convert.ToInt32(txtCodProduto_VendasNFSaida.Text));

                        INFS.InserirNFSaidaIncremento(Convert.ToInt32(txtNFSaida_VendasNFSaida.Text), Convert.ToInt32(txtQuantidade_VendasNFSaida.Text),
                     Convert.ToDateTime(txtDataDeEmissao_VendasNFSaida.Text));

                        txtDescricao_VendasNFSaida.Text = BE.BuscarDescricaoNFSaida(Convert.ToInt32(txtCodProduto_VendasNFSaida.Text));

                        DialogResult OpcaoDoUsuario = new DialogResult();
                        OpcaoDoUsuario = MessageBox.Show("Item Adicionado com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (OpcaoDoUsuario == DialogResult.OK)
                        {
                            BNFS.BuscarNFSaida(Convert.ToInt32(txtNFSaida_VendasNFSaida.Text), gdvVendasNFSaida);

                            txtDataDeEmissao_VendasNFSaida.Text = "";
                            txtCodProduto_VendasNFSaida.Text = "";
                            txtDescricao_VendasNFSaida.Text = "";
                            txtQuantidade_VendasNFSaida.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Item Não Disponivel!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    label1.Text = "*";
                    label2.Text = "*";

                    MessageBox.Show("Todos Os Campos Com * São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Bontão Incluir

        #region Botão Buscar

        private void btnPesquisa_CadastroCliente_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            try
            {
                if (txtNFSaida_VendasNFSaida.Text != "")
                {
                    BNFS.BuscarNFSaida(Convert.ToInt32(txtNFSaida_VendasNFSaida.Text), gdvVendasNFSaida);
                }
                else if (txtCodProduto_VendasNFSaida.Text != "")
                {
                    txtDescricao_VendasNFSaida.Text = BE.BuscarDescricaoNFSaida(Convert.ToInt32(txtCodProduto_VendasNFSaida.Text));

                    BNFS.BuscarNFSaidaConsulta(Convert.ToInt32(txtCodProduto_VendasNFSaida.Text), gdvVendasNFSaida);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Botão Buscar

        #region TextBox NF Saida

        private void txtNFSaida_VendasNFSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox NF Saida

        #region Textbox Cod Produto

        private void txtCodProduto_VendasNFSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion Textbox Cod Produto

        #region TextBox Quantidade

        private void txtQuantidade_VendasNFSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Quantidade

        #region Botao Confirmar

        private void btnModificar_CadastroCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NF Emitida com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNFSaida_VendasNFSaida.Text = "";
            txtDataDeEmissao_VendasNFSaida.Text = "";
            txtCodProduto_VendasNFSaida.Text = "";
            txtDescricao_VendasNFSaida.Text = "";
            txtQuantidade_VendasNFSaida.Text = "";

            object Nothing = null;
            gdvVendasNFSaida.DataSource = Nothing;
        }

        #endregion Botao Confirmar

        #region Botao Excluir

        private void btnExcluir_CadastroCliente_Click(object sender, EventArgs e)
        {
            DNFS.DeletarNFSaida(Convert.ToInt32(txtNFSaida_VendasNFSaida.Text), gdvVendasNFSaida);

            AQEA.AlterarQuantidadeEstoqueAdicao(Convert.ToInt32(txtNFSaida_VendasNFSaida.Text));

            txtNFSaida_VendasNFSaida.Text = "";
            txtDataDeEmissao_VendasNFSaida.Text = "";
            txtCodProduto_VendasNFSaida.Text = "";
            txtDescricao_VendasNFSaida.Text = "";
            txtQuantidade_VendasNFSaida.Text = "";
        }

        #endregion Botao Excluir
    }
}