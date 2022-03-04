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
        //Dados Produto

        private AlterarDadosProduto AP = new AlterarDadosProduto();
        private BuscarDadosProduto BP = new BuscarDadosProduto();
        private DeletarDadosProduto DP = new DeletarDadosProduto();
        private InserirDadosProduto IP = new InserirDadosProduto();

        //Verificacao TextBox

        private VerificacaoTextBox VT = new VerificacaoTextBox();

        public Cadastro_Produto()
        {
            InitializeComponent();
        }

        #region Botão Incluir Produto

        private void btnIncluir_CadastroProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (VT.VerificarTextBoxProduto(this) == true)   //Verificar se os textbox estão preenchidos
                {
                    txtDataCadastro_CadastroProduto.Text = DateTime.Today.ToShortDateString();

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
                else
                {
                    MessageBox.Show("Todos Os Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        #endregion Botão Incluir Produto

        #region Botão Modificar Produto

        private void btnModificar_CadastroProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (VT.VerificarTextBoxProduto(this) == true)  //Verificar se os textbox estão preenchidos
                {
                    DialogResult OpcaoDoUsuario = new DialogResult();
                    OpcaoDoUsuario = MessageBox.Show("Deseja Realizar a Modificação?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (OpcaoDoUsuario == DialogResult.Yes)
                    {
                        txtDataCadastro_CadastroProduto.Text = DateTime.Today.ToShortDateString();

                        AP.AlterarProduto(txtFornecedor_CadastroProduto.Text, Convert.ToDateTime(txtDataCadastro_CadastroProduto.Text), txtCNPJ_CadastroProduto.Text,
                                             Convert.ToInt32(txtCodProduto_CadastroProduto.Text), txtDescricao_CadastroProduto.Text, txtMedida_CadastroProduto.Text,
                                             Convert.ToDouble(txtPreco_CadastroProduto.Text));

                        //MessageBox modificação realizada com sucesso e limpeza dos TextBox
                        OpcaoDoUsuario = MessageBox.Show("Modificação Realizada Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (OpcaoDoUsuario == DialogResult.No)
                    {
                        MessageBox.Show("Modificação Cancelada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Todos Os Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Botão Modificar Produto

        #region Botão Excluir Produto

        private void btnExcluir_CadastroProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodProduto_CadastroProduto.Text == "")
                {
                    MessageBox.Show("O Campo Cód. Produto é Obrigatorio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult OpcaoDoUsuario = new DialogResult();
                    OpcaoDoUsuario = MessageBox.Show("Deseja Excluir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (OpcaoDoUsuario == DialogResult.Yes)
                    {
                        DP.DeletarProduto(Convert.ToInt32(txtCodProduto_CadastroProduto.Text));

                        //MessageBox modificação realizada com sucesso e limpeza dos TextBox

                        OpcaoDoUsuario = MessageBox.Show("Produto Excluido Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Botão Excluir Produto

        #region Botão Buscar Produto

        private void btnPesquisa_CadastroProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodProduto_CadastroProduto.Text == "")
                {
                    MessageBox.Show("O Campo Cód. Produto é Obrigatorio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    BP.BuscarProduto(Convert.ToInt32(txtCodProduto_CadastroProduto.Text), gdvCadastroProduto);

                    //Zerar os campos
                    txtCodProduto_CadastroProduto.Text = "";

                    AvisoPreenchimentoCodProduto.Text = "";
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        #endregion Botão Buscar Produto

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