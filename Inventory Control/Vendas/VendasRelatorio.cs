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
    public partial class VendasRelatorio : Form
    {
        private BuscarDadosRelatorioSaida BRNFS = new BuscarDadosRelatorioSaida(); // Buscar Relatorio de Nota Fiscal de Saida

        //Cancelar Nota Fiscal de Saida

        private DeletarNotaFiscalSaida CNFS = new DeletarNotaFiscalSaida();

        public VendasRelatorio()
        {
            InitializeComponent();
        }

        #region Mudanca de Tela Verificacao NF Saida

        private void VendasRelatorio_Load(object sender, EventArgs e)
        {
            if (ConfimarcaoNFSaida.PassouTela == true)
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Nota Fiscal de Saida Não Foi Confirmada, Deseja Salva-la?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.No)
                {
                    CNFS.CancelarNFSaida(ConfimarcaoNFSaida.NFsaida);

                    MessageBox.Show("Nota Fiscal de Saida Cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ConfimarcaoNFSaida.PassouTela = false;
                }
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    MessageBox.Show("Nota Fiscal de Saida Confirmada com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ConfimarcaoNFSaida.PassouTela = false;
                }
            }
        }

        #endregion Mudanca de Tela Verificacao NF Saida

        #region Botao Pesquisar

        private void btnPesquisa_CadastroCliente_Click(object sender, EventArgs e)
        {
            if (txtDataInicio_VendasRelatorio.Text == "" || txtDataFinal_VendasRelatorio.Text == "")
            {
                MessageBox.Show("Todos os Campos São Obrigatorio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtDataFinal_VendasRelatorio.Text == "")
                {
                    txtDataFinal_VendasRelatorio.Text = Convert.ToString(DateTime.Today);
                }

                try
                {
                    BRNFS.BuscarDadosRelatorioNFEntrada(Convert.ToDateTime(txtDataInicio_VendasRelatorio.Text),
                    Convert.ToDateTime(txtDataFinal_VendasRelatorio.Text), gdvRelatorioNFSaida_Vendas);

                    //Zerar os campos
                    txtDataInicio_VendasRelatorio.Text = "";
                    txtDataFinal_VendasRelatorio.Text = "";
                }
                catch (Exception)
                {
                    //MessageBox.Show(x.ToString());
                    MessageBox.Show("Formato de Data incorreto!");
                }
            }
        }

        #endregion Botao Pesquisar

        #region TextBox Data Inicio

        private void txtDataInicio_VendasRelatorio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtDataInicio_VendasRelatorio.TextLength)
                {
                    case 0:
                        txtDataInicio_VendasRelatorio.Text = "";
                        break;

                    case 2:
                        txtDataInicio_VendasRelatorio.Text = txtDataInicio_VendasRelatorio.Text + "/";
                        txtDataInicio_VendasRelatorio.SelectionStart = 3;
                        break;

                    case 5:
                        txtDataInicio_VendasRelatorio.Text = txtDataInicio_VendasRelatorio.Text + "/";
                        txtDataInicio_VendasRelatorio.SelectionStart = 6;
                        break;
                }
            }
        }

        #endregion TextBox Data Inicio

        #region TextBox Data Final

        private void txtDataFinal_VendasRelatorio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            switch (txtDataFinal_VendasRelatorio.TextLength)
            {
                case 0:
                    txtDataFinal_VendasRelatorio.Text = "";
                    break;

                case 2:
                    txtDataFinal_VendasRelatorio.Text = txtDataFinal_VendasRelatorio.Text + "/";
                    txtDataFinal_VendasRelatorio.SelectionStart = 3;
                    break;

                case 5:
                    txtDataFinal_VendasRelatorio.Text = txtDataFinal_VendasRelatorio.Text + "/";
                    txtDataFinal_VendasRelatorio.SelectionStart = 6;
                    break;
            }
        }

        #endregion TextBox Data Final
    }
}