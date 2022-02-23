using Inventory_Control.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Control
{
    public partial class Cadastro_Clientes_e_Fornecedores : Form
    {
        private InserirDados id = new InserirDados();

        private SqlConnection con = new SqlConnection(@"Server=DESKTOP-V79P1T3\SQLEXPRESS;Database=Inventory_Control;Integrated Security=True;");
        private SqlCommand cmd;

        ////public static List<teste> casa = new List<teste>();

        //{ Convert.ToInt32(txtCodProdutoCadastro.Text) };

        public Cadastro_Clientes_e_Fornecedores()
        {
            InitializeComponent();
        }

        private void btnIncluir_CadastroCliente_Click(object sender, EventArgs e)
        {
            //ConectarBanco Cliente = new ConectarBanco();
            //Cliente.AbrirConexao();

            ////casa = new List<teste>()
            ////  {
            ////new teste(Convert.ToInt32(txtCodProdutoCadastro.Text))};

            ////foreach (teste item in casa)
            ////{
            ////    if (item.ToString() != "")
            ////    {
            ////        MessageBox.Show("ate aqui deu certo");
            ////    }
            ////}
            ///

            //Boolean ok = true;

            //foreach (Control ctrl in this.Controls)
            //{
            //    if (ctrl is TextBox)
            //    {
            //        if (ctrl.Text == string.Empty)
            //        {
            //            ok = false;
            //        }

            //    }
            //    else if (ctrl is ComboBox)
            //    {
            //        if (ctrl.Text == string.Empty)
            //            ok = false;
            //    }
            //}

            if (txtTipoCadastro.Text == "" || txtCodProdutoCadastro.Text == "" || txtNomeFantasiaCadastro.Text == "" ||
            txtCNPJCadastro.Text == "" || txtCEPCadastro.Text == "" || txtRazaoSocialCadastro.Text == "" ||
            txtCEPCadastro.Text == "" || txtUFCadastro.Text == "" || txtCidadeCadastro.Text == "" ||
            txtEnderecoCadastro.Text == "" || txtNumeroCadastro.Text == "" || txtComplementoCadastro.Text == "" ||
            txtBairroCadastro.Text == "")
            {
                label1.Text = "*"; label2.Text = "*"; label3.Text = "*"; label4.Text = "*"; label5.Text = "*"; label6.Text = "*";
                label7.Text = "*"; label8.Text = "*"; label9.Text = "*"; label10.Text = "*"; label11.Text = "*";
                label12.Text = "*"; label13.Text = "*";

                MessageBox.Show("Os Campos Com * São Obrigatorios");
                MessageBox.Show("Todos Os Campos São Obrigatorios");
            }
            else
            {
                if (txtTipoCadastro.Text == "Cliente")
                {
                    try
                    {
                        id.InserirCliente(Convert.ToInt32(txtCodProdutoCadastro.Text), txtNomeFantasiaCadastro.Text, Convert.ToDateTime(txtCadastroCadastro.Text),
                        Convert.ToInt32(txtCNPJCadastro.Text), txtRazaoSocialCadastro.Text, Convert.ToInt32(txtCEPCadastro.Text), txtUFCadastro.Text,
                        txtCidadeCadastro.Text, txtEnderecoCadastro.Text, Convert.ToInt32(txtNumeroCadastro.Text), txtComplementoCadastro.Text,
                        txtBairroCadastro.Text);

                        MessageBox.Show("Cliente Cadastrado Com Sucesso!");
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.ToString());
                    }
                }
                else
                {
                    try
                    {
                        id.InserirCliente(Convert.ToInt32(txtCodProdutoCadastro.Text), txtNomeFantasiaCadastro.Text, Convert.ToDateTime(txtCadastroCadastro.Text),
                        Convert.ToInt32(txtCNPJCadastro.Text), txtRazaoSocialCadastro.Text, Convert.ToInt32(txtCEPCadastro.Text), txtUFCadastro.Text,
                        txtCidadeCadastro.Text, txtEnderecoCadastro.Text, Convert.ToInt32(txtNumeroCadastro.Text), txtComplementoCadastro.Text,
                        txtBairroCadastro.Text);

                        MessageBox.Show("Fornecedor Cadastrado Com Sucesso!");
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.ToString());
                    }
                }
            }
        }


        public void txtCodProdutoCadastro_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
