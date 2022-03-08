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
                try
                {
                    BRNFE.BuscarDadosRelatorioNFEntrada(Convert.ToDateTime(txtDataInicioSuprimentosRelarorio.Text),
                    Convert.ToDateTime(txtDataFinalSuprimentosRelarorio.Text), gdvRelatorioNFEntrada_Suprimento);

                    //Zerar os campos
                    txtDataInicioSuprimentosRelarorio.Text = "";
                    txtDataFinalSuprimentosRelarorio.Text = "";
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }
    }
}