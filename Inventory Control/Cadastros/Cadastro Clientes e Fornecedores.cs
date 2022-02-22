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
    public partial class Cadastro_Clientes_e_Fornecedores : Form
    {
        public Cadastro_Clientes_e_Fornecedores()
        {
            InitializeComponent();
        }

        private void btnIncluir_CadastroCliente_Click(object sender, EventArgs e)
        {
            ConectarBanco teste = new ConectarBanco();
            teste.AbrirConexao();
        }
    }
}