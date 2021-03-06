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
    public partial class Vendas_Nota_Fiscal_Saida : Form
    {
        //Dados Produto

        private AlterarDadosProduto AP = new AlterarDadosProduto();
        private BuscarDadosProduto BP = new BuscarDadosProduto();
        private DeletarDadosProduto DP = new DeletarDadosProduto();
        private InserirDadosProduto IP = new InserirDadosProduto();

        //Verificacao Existencia

        private VerificacaoTextBox VT = new VerificacaoTextBox();
        private VerificacaoDeExistencia VP = new VerificacaoDeExistencia();

        //Preencher os codigo do produto

        private Count CP = new Count();

        //Cancelar Nota Fiscal de Saida

        private DeletarNotaFiscalSaida CNFS = new DeletarNotaFiscalSaida();

        public Vendas_Nota_Fiscal_Saida()
        {
            InitializeComponent();
        }

        #region Mudanca de Tela Verificacao NF Saida

        private void Vendas_Nota_Fiscal_Saida_Load(object sender, EventArgs e)
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

        #region Botão Incluir Produto

        private void btnIncluir_CadastroProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (VT.VerificarTextBoxProduto(this) == true)   //Verificar se os textbox estão preenchidos
                {
                    txtDataCadastro_CadastroProduto.Text = DateTime.Today.ToShortDateString();

                    txtCodProduto_CadastroProduto.Text = Convert.ToString(CP.ContarProduto());

                    IP.InserirProduto(txtFornecedor_CadastroProduto.Text, Convert.ToDateTime(txtDataCadastro_CadastroProduto.Text),
                        txtCNPJ_CadastroProduto.Text, Convert.ToInt32(txtCodProduto_CadastroProduto.Text), txtDescricao_CadastroProduto.Text,
                        txtMedida_CadastroProduto.Text, Convert.ToDouble(txtPreco_CadastroProduto.Text));

                    //MessageBox cadastrado com sucesso e limpeza dos TextBox
                    DialogResult OpcaoDoUsuario = new DialogResult();
                    OpcaoDoUsuario = MessageBox.Show("Produto Cadastrado Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (OpcaoDoUsuario == DialogResult.OK)
                    {
                        BP.BuscarProduto(Convert.ToInt32(txtCodProduto_CadastroProduto.Text), gdvCadastroProduto);

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
                        if (VP.BuscarExistenciaProduto(Convert.ToInt32(txtCodProduto_CadastroProduto.Text)) == true)
                        {
                            txtDataCadastro_CadastroProduto.Text = DateTime.Today.ToShortDateString();

                            AP.AlterarProduto(txtFornecedor_CadastroProduto.Text, Convert.ToDateTime(txtDataCadastro_CadastroProduto.Text), txtCNPJ_CadastroProduto.Text,
                                                 Convert.ToInt32(txtCodProduto_CadastroProduto.Text), txtDescricao_CadastroProduto.Text, txtMedida_CadastroProduto.Text,
                                                 Convert.ToDouble(txtPreco_CadastroProduto.Text));

                            //MessageBox modificação realizada com sucesso e limpeza dos TextBox
                            OpcaoDoUsuario = MessageBox.Show("Modificação Realizada Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (OpcaoDoUsuario == DialogResult.OK)
                            {
                                BP.BuscarProduto(Convert.ToInt32(txtCodProduto_CadastroProduto.Text), gdvCadastroProduto);

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
                            MessageBox.Show("Item Não Localizado!");
                        }
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
                    DP.DeletarProduto(Convert.ToInt32(txtCodProduto_CadastroProduto.Text), gdvCadastroProduto);

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

        #region TextBox Fornecedor

        private void txtFornecedor_CadastroProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Fornecedor

        #region TextBox Descricao

        private void txtDescricao_CadastroProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Descricao
    }
}