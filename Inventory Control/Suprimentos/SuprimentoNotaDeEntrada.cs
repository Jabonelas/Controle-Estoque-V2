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
    public partial class SuprimentoNotaDeEntrada : Form
    {
        private BuscarNotaFiscalEntrada BN = new BuscarNotaFiscalEntrada();

        private DeletarNotaFiscalEntrada DN = new DeletarNotaFiscalEntrada();

        public SuprimentoNotaDeEntrada()
        {
            InitializeComponent();
        }
        #region Botão Buscar Nota Fiscal
        private void btnPesquisa_CadastroCliente_Click_1(object sender, EventArgs e)
        {
            if (txtNotaFiscal_Suprimento.Text == "")
            {
                MessageBox.Show("O Campo Nota Fiscal é Obrigatorio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    BN.BuscarNotaFiscal(Convert.ToInt32(txtNotaFiscal_Suprimento.Text), gdvNotaFiscal_Suprimento);

                    //Zerar os campos
                    txtNotaFiscal_Suprimento.Text = "";
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }
        #endregion

        #region Botão EXcluir Nota Fiscal
        private void btnExcluir_CadastroCliente_Click(object sender, EventArgs e)
        {
            if (txtNotaFiscal_Suprimento.Text == "")
            {
                MessageBox.Show("O Campo Nota Fical é Obrigatorio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Excluir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    try
                    {
                        DN.DeletarNotaFiscal(Convert.ToInt32(txtNotaFiscal_Suprimento.Text));

                        //MessageBox modificação realizada com sucesso e limpeza dos TextBox

                        //OpcaoDoUsuario =

                        txtNotaFiscal_Suprimento.Text = "";
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.ToString());
                    }
                }
            }
        }
        #endregion

        private void btnIncluir_CadastroCliente_Click(object sender, EventArgs e)
        {

        }
    }
}