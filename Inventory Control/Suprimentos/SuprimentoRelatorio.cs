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
    public partial class SuprimentoRelatorio : Form
    {
        private BuscarDadosRelatorioEntrada BRNFE = new BuscarDadosRelatorioEntrada();

        //Cancelar Nota Fiscal de Saida

        private DeletarNotaFiscalSaida CNFS = new DeletarNotaFiscalSaida();

        public SuprimentoRelatorio()
        {
            InitializeComponent();
        }

        #region Mudanca de Tela Verificacao NF Saida

        private void SuprimentoRelatorio_Load(object sender, EventArgs e)
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
            if (txtDataInicioSuprimentosRelarorio.Text == "" || txtDataFinalSuprimentosRelarorio.Text == "")
            {
                MessageBox.Show("Todos os Campos São Obrigatorio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtDataFinalSuprimentosRelarorio.Text == "")
                {
                    txtDataFinalSuprimentosRelarorio.Text = Convert.ToString(DateTime.Today);
                }

                try
                {
                    BRNFE.BuscarDadosRelatorioNFEntrada(Convert.ToDateTime(txtDataInicioSuprimentosRelarorio.Text),
                    Convert.ToDateTime(txtDataFinalSuprimentosRelarorio.Text), gdvRelatorioNFEntrada_Suprimento);

                    //Zerar os campos
                    txtDataInicioSuprimentosRelarorio.Text = "";
                    txtDataFinalSuprimentosRelarorio.Text = "";
                }
                catch (Exception)
                {
                    //MessageBox.Show(x.ToString());
                    MessageBox.Show("Formato de Data incorreto!");
                }
            }
        }

        #endregion Botao Pesquisar

        #region Data Inicial

        private void txtDataInicioSuprimentosRelarorio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtDataInicioSuprimentosRelarorio.TextLength)
                {
                    case 0:
                        txtDataInicioSuprimentosRelarorio.Text = "";
                        break;

                    case 2:
                        txtDataInicioSuprimentosRelarorio.Text = txtDataInicioSuprimentosRelarorio.Text + "/";
                        txtDataInicioSuprimentosRelarorio.SelectionStart = 3;
                        break;

                    case 5:
                        txtDataInicioSuprimentosRelarorio.Text = txtDataInicioSuprimentosRelarorio.Text + "/";
                        txtDataInicioSuprimentosRelarorio.SelectionStart = 6;
                        break;
                }
            }
        }

        #endregion Data Inicial

        #region TexBox Data Final

        private void txtDataFinalSuprimentosRelarorio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            switch (txtDataFinalSuprimentosRelarorio.TextLength)
            {
                case 0:
                    txtDataFinalSuprimentosRelarorio.Text = "";
                    break;

                case 2:
                    txtDataFinalSuprimentosRelarorio.Text = txtDataFinalSuprimentosRelarorio.Text + "/";
                    txtDataFinalSuprimentosRelarorio.SelectionStart = 3;
                    break;

                case 5:
                    txtDataFinalSuprimentosRelarorio.Text = txtDataFinalSuprimentosRelarorio.Text + "/";
                    txtDataFinalSuprimentosRelarorio.SelectionStart = 6;
                    break;
            }
        }

        #endregion TexBox Data Final
    }
}