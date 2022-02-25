using Guna.UI.WinForms;
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
    public partial class Cadastro_Produto : Form
    {
        private InserirDadosProduto IP = new InserirDadosProduto();

        public Cadastro_Produto()
        {
            InitializeComponent();
        }

        private void btnIncluir_CadastroCliente_Click(object sender, EventArgs e)
        {
            // Teste para vertificação se todos os TextBox estão preenchidos
            Boolean ok = true;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is GunaTextBox)
                {
                    if (ctrl.Text == string.Empty)
                    {
                        ok = false;
                    }
                }
                else if (ctrl is ComboBox)
                {
                    if (ctrl.Text == string.Empty)
                        ok = false;
                }
            }
            if (ok)
            {
                txtDataCadastro_CadastroProduto.Text = DateTime.Today.ToShortDateString();

                Random randNum = new Random();

                txtCodProduto_CadastroProduto.Text = randNum.Next(200).ToString();

                //Preencher caso o tipo seja Cliente

                try
                {
                    IP.InserirProduto(txtFornecedor_CadastroProduto.Text, Convert.ToDateTime(txtDataCadastro_CadastroProduto.Text),
                        txtCNPJ_CadastroProduto.Text, Convert.ToInt32(txtCodProduto_CadastroProduto.Text), txtDescricao_CadastroProduto.Text,
                        txtMedida_CadastroProduto.Text, Convert.ToDouble(txtPreco_CadastroProduto.Text));

                    //MessageBox cadastrado com sucesso e limpeza dos TextBox
                    DialogResult OpcaoDoUsuario = new DialogResult();
                    OpcaoDoUsuario = MessageBox.Show("Produto Cadastrado Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (OpcaoDoUsuario == DialogResult.OK)
                    {
                        txtFornecedor_CadastroProduto.Text = "";
                        txtDataCadastro_CadastroProduto.Text = "";
                        txtCNPJ_CadastroProduto.Text = "";
                        txtCodProduto_CadastroProduto.Text = "";
                        txtDescricao_CadastroProduto.Text = "";
                        txtMedida_CadastroProduto.Text = "";
                        txtPreco_CadastroProduto.Text = "";
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Todos Os Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region TextBox CNPJ

        private void txtCNPJ_CadastroProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCNPJ_CadastroProduto.TextLength)
                {
                    case 0:
                        txtCNPJ_CadastroProduto.Text = "";
                        break;

                    case 2:
                        txtCNPJ_CadastroProduto.Text = txtCNPJ_CadastroProduto.Text + ".";
                        txtCNPJ_CadastroProduto.SelectionStart = 3;
                        break;

                    case 6:
                        txtCNPJ_CadastroProduto.Text = txtCNPJ_CadastroProduto.Text + ".";
                        txtCNPJ_CadastroProduto.SelectionStart = 7;
                        break;

                    case 10:
                        txtCNPJ_CadastroProduto.Text = txtCNPJ_CadastroProduto.Text + "/";
                        txtCNPJ_CadastroProduto.SelectionStart = 11;
                        break;

                    case 15:
                        txtCNPJ_CadastroProduto.Text = txtCNPJ_CadastroProduto.Text + "-";
                        txtCNPJ_CadastroProduto.SelectionStart = 16;
                        break;
                }
            }
        }

        #endregion TextBox CNPJ

        #region TextBox Preço Unico

        private void txtPreco_CadastroProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Preço Unico
    }
}