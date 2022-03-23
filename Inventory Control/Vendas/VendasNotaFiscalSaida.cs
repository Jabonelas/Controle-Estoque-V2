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
    public partial class VendasNotaFiscalSaida : Form
    {
        private VerificacaoTextBox VT = new VerificacaoTextBox();

        private InserirNotaFiscalSaida INFS = new InserirNotaFiscalSaida();

        private Count CNFS = new Count();

        private BuscarNotaFiscalSaida BNFS = new BuscarNotaFiscalSaida();

        public VendasNotaFiscalSaida()
        {
            InitializeComponent();
        }

        #region Bontão Incluir

        private void btnIncluir_CadastroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //if (VT.VerificarTextBoxNFSaida(this) == true)   //Verificar se os textbox estão preenchidos

                if (txtCodProduto_VendasNFSaida.Text != "" && txtQuantidade_VendasNFSaida.Text != "")
                {
                    txtDataDeEmissao_VendasNFSaida.Text = DateTime.Today.ToShortDateString();

                    txtNFSaida_VendasNFSaida.Text = Convert.ToString(CNFS.ContarNFSaida());//gerar o numero da NF de Saida

                    INFS.InserirNFSaida(Convert.ToInt32(txtCodProduto_VendasNFSaida.Text));

                    INFS.InserirNFSaidaIncremento(Convert.ToInt32(txtNFSaida_VendasNFSaida.Text), Convert.ToInt32(txtQuantidade_VendasNFSaida.Text)
                    , Convert.ToDateTime(txtDataDeEmissao_VendasNFSaida.Text));

                    BNFS.BuscarNFSaida(Convert.ToInt32(txtNFSaida_VendasNFSaida.Text), gdvVendasNFSaida);

                    //MessageBox cadastrado com sucesso e limpeza dos TextBox
                    DialogResult OpcaoDoUsuario = new DialogResult();
                    OpcaoDoUsuario = MessageBox.Show("Nota Fiscal Emitida com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (OpcaoDoUsuario == DialogResult.OK)
                    {
                        //BNFS.BuscarNFSaida(Convert.ToInt32(txtNFSaida_VendasNFSaida.Text), gdvVendasNFSaida);

                        txtNFSaida_VendasNFSaida.Text = "";
                        txtDataDeEmissao_VendasNFSaida.Text = "";
                        txtCodProduto_VendasNFSaida.Text = "";
                        txtDescricao_VendasNFSaida.Text = "";
                        txtQuantidade_VendasNFSaida.Text = "";
                        txtValor_VendasNFSaida.Text = "";
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
                MessageBox.Show(x.Message.ToString());
            }
        }

        #endregion Bontão Incluir

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
    }
}