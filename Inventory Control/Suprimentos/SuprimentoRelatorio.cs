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

        public SuprimentoRelatorio()
        {
            InitializeComponent();
        }

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
    }
}