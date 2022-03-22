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
    public partial class SuprimentoControleBusca : Form
    {
        private BuscarDadosEstoque BCP = new BuscarDadosEstoque();
        private BuscarDadosEstoque BCB = new BuscarDadosEstoque();

        public SuprimentoControleBusca()
        {
            InitializeComponent();
        }

        private void btnPesquisa_CadastroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodBarras_Buscar.Text != "")
                {
                    BCB.BuscarCodBarras(Convert.ToInt32(txtCodBarras_Buscar.Text), gdvBuscarEstoque_Suprimentos);

                    //Zerar os campos
                    txtCodBarras_Buscar.Text = "";
                    txtCodProduto_Buscar.Text = "";
                }
                else if (txtCodProduto_Buscar.Text != "")
                {
                    BCP.BuscarCodDoProduto(Convert.ToInt32(txtCodProduto_Buscar.Text), gdvBuscarEstoque_Suprimentos);

                    //Zerar os campos
                    txtCodBarras_Buscar.Text = "";
                    txtCodProduto_Buscar.Text = "";
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            //}
        }
    }
}