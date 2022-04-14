using Guna.UI.WinForms;
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
using static System.Windows.Forms.DataFormats;

namespace Inventory_Control
{
    public partial class Cadastro_Clientes_e_Fornecedores : Form
    {
        //Daddos Cliente

        private AlterarDadosClientes AC = new AlterarDadosClientes();
        private BuscarDadosClientes BC = new BuscarDadosClientes();
        private DeletarDadosClientes DC = new DeletarDadosClientes();
        private InserirDadosClientes IC = new InserirDadosClientes();

        //Dadros Fornecedor

        private AlterarDadosFornecedor AF = new AlterarDadosFornecedor();
        private BuscarDadosFornecedor BF = new BuscarDadosFornecedor();
        private DeletarDadosFornecedor DF = new DeletarDadosFornecedor();
        private InserirDadosFornecedor IF = new InserirDadosFornecedor();

        //Verificacao

        private VerificacaoTextBox VT = new VerificacaoTextBox();
        private VerificacaoDeExistencia VC = new VerificacaoDeExistencia();

        private VerificacaoDeExistencia VF = new VerificacaoDeExistencia();

        //Preencher os codigo do produto

        private Count CC = new Count();
        private Count CF = new Count();

        //Cancelar Nota Fiscal de Saida

        private DeletarNotaFiscalSaida CNFS = new DeletarNotaFiscalSaida();

        public Cadastro_Clientes_e_Fornecedores()
        {
            InitializeComponent();
        }

        #region Mudanca de Tela Verificacao NF Saida

        private void Cadastro_Clientes_e_Fornecedores_Load(object sender, EventArgs e)
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

        #region Botão Incluir Cadastro

        private void btnIncluir_CadastroCliente_Click(object sender, EventArgs e)
        {
            //Zerar os Labels * que informam que precisam ser preenchidos os textbox
            AvisoDePreenchimentoCNPJ.Text = "";
            AvisoDePreenchimentoTipo.Text = "";

            if (VT.VerificarTextBoxClienteFornecedor(this) == true) //Verificar se os textbox estão preenchidos
            {
                txtCadastroCadastro.Text = DateTime.Today.ToShortDateString();

                try
                {
                    if (txtTipoCadastro.Text == "Cliente")
                    {
                        if (VC.BuscarExistenciaCliente(txtCNPJCadastro.Text) == false)
                        {
                            txtCodProdutoCadastro.Text = CC.ContarCliente().ToString();// Gerar ID cliente

                            IC.InserirClientes(txtNomeFantasiaCadastro.Text, Convert.ToDateTime(txtCadastroCadastro.Text),
                            txtCNPJCadastro.Text, txtRazaoSocialCadastro.Text, txtCEPCadastro.Text, txtUFCadastro.Text,
                            txtCidadeCadastro.Text, txtEnderecoCadastro.Text, Convert.ToInt32(txtNumeroCadastro.Text), txtComplementoCadastro.Text,
                            txtBairroCadastro.Text, gvdCadastroClienteFornecedor);

                            DialogResult OpcaoDoUsuario = new DialogResult();
                            OpcaoDoUsuario = MessageBox.Show("Cliente Cadastrado Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (OpcaoDoUsuario == DialogResult.OK)
                            {
                                BC.BuscarClientes(txtCNPJCadastro.Text, gvdCadastroClienteFornecedor);

                                txtTipoCadastro.Text = "";
                                txtCodProdutoCadastro.Text = "";
                                txtNomeFantasiaCadastro.Text = "";
                                txtCadastroCadastro.Text = "";
                                txtCNPJCadastro.Text = "";
                                txtRazaoSocialCadastro.Text = "";
                                txtCEPCadastro.Text = "";
                                txtUFCadastro.Text = "";
                                txtCidadeCadastro.Text = "";
                                txtEnderecoCadastro.Text = "";
                                txtNumeroCadastro.Text = "";
                                txtComplementoCadastro.Text = "";
                                txtBairroCadastro.Text = "";

                                AvisoDePreenchimentoCNPJ.Text = "";
                                AvisoDePreenchimentoTipo.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("CNPJ já Cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Erro ao Incluir Cliente!\n\n" + x.ToString());
                }

                try
                {
                    if (txtTipoCadastro.Text == "Fornecedor")
                    {
                        if (VF.BuscarExistenciaFornecedor(txtCNPJCadastro.Text) == false)
                        {
                            txtCodProdutoCadastro.Text = CF.ContarFornecedor().ToString();//Gerar o ID fornecedor

                            IF.InserirFornecedor(txtNomeFantasiaCadastro.Text, Convert.ToDateTime(txtCadastroCadastro.Text),
                            txtCNPJCadastro.Text, txtRazaoSocialCadastro.Text, txtCEPCadastro.Text, txtUFCadastro.Text,
                            txtCidadeCadastro.Text, txtEnderecoCadastro.Text, Convert.ToInt32(txtNumeroCadastro.Text), txtComplementoCadastro.Text,
                            txtBairroCadastro.Text);

                            DialogResult OpcaoDoUsuario = new DialogResult();
                            OpcaoDoUsuario = MessageBox.Show("Fornecedor Cadastrado Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (OpcaoDoUsuario == DialogResult.OK)
                            {
                                BF.BuscarFornecedor(txtCNPJCadastro.Text, gvdCadastroClienteFornecedor);

                                txtTipoCadastro.Text = "";
                                txtCodProdutoCadastro.Text = "";
                                txtNomeFantasiaCadastro.Text = "";
                                txtCadastroCadastro.Text = "";
                                txtCNPJCadastro.Text = "";
                                txtRazaoSocialCadastro.Text = "";
                                txtCEPCadastro.Text = "";
                                txtUFCadastro.Text = "";
                                txtCidadeCadastro.Text = "";
                                txtEnderecoCadastro.Text = "";
                                txtNumeroCadastro.Text = "";
                                txtComplementoCadastro.Text = "";
                                txtBairroCadastro.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("CNPJ já Cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Erro ao Incluir Fornecedor!\n\n" + x.ToString());
                }
            }
            else
            {
                MessageBox.Show("Todos Os Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion Botão Incluir Cadastro

        #region Botão Bucar Cadastro

        private void btnPesquisa_CadastroCliente_Click(object sender, EventArgs e)
        {
            //Zerar os Labels * que informam que precisam ser preenchidos os textbox
            AvisoDePreenchimentoCNPJ.Text = "";
            AvisoDePreenchimentoTipo.Text = "";

            if (txtTipoCadastro.Text == "" || txtCNPJCadastro.Text == "")  //Verificar se os textbox estão preenchidos
            {
                AvisoDePreenchimentoCNPJ.Text = "*";
                AvisoDePreenchimentoTipo.Text = "*";

                MessageBox.Show("Os Campos Com * São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtTipoCadastro.Text == "Cliente")
                {
                    try
                    {
                        BC.BuscarClientes(txtCNPJCadastro.Text, gvdCadastroClienteFornecedor);

                        txtTipoCadastro.Text = "";
                        txtCNPJCadastro.Text = "";

                        AvisoDePreenchimentoCNPJ.Text = "";
                        AvisoDePreenchimentoTipo.Text = "";
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Erro ao Alterar Cliente!\n\n" + x.ToString());
                    }
                }
                else if (txtTipoCadastro.Text == "Fornecedor")
                {
                    try
                    {
                        BF.BuscarFornecedor(txtCNPJCadastro.Text, gvdCadastroClienteFornecedor);

                        txtTipoCadastro.Text = "";
                        txtCNPJCadastro.Text = "";

                        AvisoDePreenchimentoCNPJ.Text = "";
                        AvisoDePreenchimentoTipo.Text = "";
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Erro ao Alterar Cliente!\n\n" + x.ToString());
                    }
                }
            }
        }

        #endregion Botão Bucar Cadastro

        #region Botão Modificar Cadastro

        private void btnModificar_CadastroCliente_Click(object sender, EventArgs e)
        {
            //Zerar os Labels * que informam que precisam ser preenchidos os textbox
            AvisoDePreenchimentoCNPJ.Text = "";
            AvisoDePreenchimentoTipo.Text = "";

            if (VT.VerificarTextBoxClienteFornecedor(this) == true) //Verificar se os textbox estão preenchidos
            {
                DialogResult OpcaoDoUsuario = new DialogResult();
                OpcaoDoUsuario = MessageBox.Show("Deseja Realizar a Modificação?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (OpcaoDoUsuario == DialogResult.Yes)
                {
                    try
                    {
                        if (txtTipoCadastro.Text == "Cliente")
                        {
                            if (VC.BuscarExistenciaCliente(txtCNPJCadastro.Text) == true)
                            {
                                txtCadastroCadastro.Text = DateTime.Today.ToShortDateString();

                                AC.AlterarCliente(txtNomeFantasiaCadastro.Text, Convert.ToDateTime(txtCadastroCadastro.Text),
                                    txtCNPJCadastro.Text, txtRazaoSocialCadastro.Text, txtCEPCadastro.Text, txtUFCadastro.Text, txtCidadeCadastro.Text, txtEnderecoCadastro.Text,
                                    Convert.ToInt32(txtNumeroCadastro.Text), txtComplementoCadastro.Text, txtBairroCadastro.Text, gvdCadastroClienteFornecedor);

                                BC.BuscarClientes(txtCNPJCadastro.Text, gvdCadastroClienteFornecedor);

                                txtTipoCadastro.Text = "";
                                txtCodProdutoCadastro.Text = "";
                                txtNomeFantasiaCadastro.Text = "";
                                txtCadastroCadastro.Text = "";
                                txtCNPJCadastro.Text = "";
                                txtRazaoSocialCadastro.Text = "";
                                txtCEPCadastro.Text = "";
                                txtUFCadastro.Text = "";
                                txtCidadeCadastro.Text = "";
                                txtEnderecoCadastro.Text = "";
                                txtNumeroCadastro.Text = "";
                                txtComplementoCadastro.Text = "";
                                txtBairroCadastro.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("CNPJ Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Erro ao Alterar Cliente!\n\n" + x.ToString());
                    }

                    try
                    {
                        if (txtTipoCadastro.Text == "Fornecedor")
                        {
                            txtCadastroCadastro.Text = DateTime.Today.ToShortDateString();
                            if (VF.BuscarExistenciaFornecedor(txtCNPJCadastro.Text) == true)
                            {
                                AF.AlterarFornecedor(Convert.ToInt32(txtCodProdutoCadastro.Text), txtNomeFantasiaCadastro.Text, Convert.ToDateTime(txtCadastroCadastro.Text),
                                             txtCNPJCadastro.Text, txtRazaoSocialCadastro.Text, txtCEPCadastro.Text, txtUFCadastro.Text, txtCidadeCadastro.Text,
                                             txtEnderecoCadastro.Text, Convert.ToInt32(txtNumeroCadastro.Text), txtComplementoCadastro.Text, txtBairroCadastro.Text);

                                BF.BuscarFornecedor(txtCNPJCadastro.Text, gvdCadastroClienteFornecedor);

                                txtTipoCadastro.Text = "";
                                txtCodProdutoCadastro.Text = "";
                                txtNomeFantasiaCadastro.Text = "";
                                txtCadastroCadastro.Text = "";
                                txtCNPJCadastro.Text = "";
                                txtRazaoSocialCadastro.Text = "";
                                txtCEPCadastro.Text = "";
                                txtUFCadastro.Text = "";
                                txtCidadeCadastro.Text = "";
                                txtEnderecoCadastro.Text = "";
                                txtNumeroCadastro.Text = "";
                                txtComplementoCadastro.Text = "";
                                txtBairroCadastro.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("CNPJ Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Erro ao Alterar Fornecedor!\n\n" + x.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Todos Os Campos São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion Botão Modificar Cadastro

        #region Botão Excluir Cadastro

        private void btnExcluir_CadastroCliente_Click(object sender, EventArgs e)
        {
            //Zerar os Labels * que informam que precisam ser preenchidos os textbox
            AvisoDePreenchimentoCNPJ.Text = "";
            AvisoDePreenchimentoTipo.Text = "";

            if (txtTipoCadastro.Text == "" || txtCNPJCadastro.Text == "")
            {
                AvisoDePreenchimentoCNPJ.Text = "*";
                AvisoDePreenchimentoTipo.Text = "*";
                MessageBox.Show("Os Campos Com * São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtTipoCadastro.Text == "Cliente")
                {
                    try
                    {
                        DC.DeletarClientes(txtCNPJCadastro.Text, gvdCadastroClienteFornecedor);

                        txtTipoCadastro.Text = "";
                        txtCNPJCadastro.Text = "";
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Erro ao Alterar Cliente!\n\n" + x.ToString());
                    }
                }
                else if (txtTipoCadastro.Text == "Fornecedor")
                {
                    try
                    {
                        DF.DeletarFornecedor(txtCNPJCadastro.Text, gvdCadastroClienteFornecedor);

                        txtTipoCadastro.Text = "";
                        txtCNPJCadastro.Text = "";
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Erro ao Alterar Cliente!\n\n" + x.ToString());
                    }
                }
            }
        }

        #endregion Botão Excluir Cadastro

        //TextBox

        #region TextBox CNPJ

        private void txtCNPJCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCNPJCadastro.TextLength)
                {
                    case 0:
                        txtCNPJCadastro.Text = "";
                        break;

                    case 2:
                        txtCNPJCadastro.Text = txtCNPJCadastro.Text + ".";
                        txtCNPJCadastro.SelectionStart = 3;
                        break;

                    case 6:
                        txtCNPJCadastro.Text = txtCNPJCadastro.Text + ".";
                        txtCNPJCadastro.SelectionStart = 7;
                        break;

                    case 10:
                        txtCNPJCadastro.Text = txtCNPJCadastro.Text + "/";
                        txtCNPJCadastro.SelectionStart = 11;
                        break;

                    case 15:
                        txtCNPJCadastro.Text = txtCNPJCadastro.Text + "-";
                        txtCNPJCadastro.SelectionStart = 16;
                        break;
                }
            }
        }

        #endregion TextBox CNPJ

        #region TextBox CEP

        private void txtCEPCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCEPCadastro.TextLength)
                {
                    case 0:
                        txtCEPCadastro.Text = "";
                        break;

                    case 5:
                        txtCEPCadastro.Text = txtCEPCadastro.Text + "-";
                        txtCEPCadastro.SelectionStart = 6;
                        break;
                }
            }
        }

        #endregion TextBox CEP

        #region TextBox Numero

        private void txtNumeroCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Numero

        #region TextBox Endereco

        private void txtEnderecoCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Endereco

        #region TextBox Complemento

        private void txtComplementoCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Complemento

        #region TextBox Nome Fantasia

        private void txtNomeFantasiaCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Nome Fantasia

        #region TextBox RAzao Social

        private void txtRazaoSocialCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox RAzao Social

        #region TextBox Cidade

        private void txtCidadeCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Cidade

        #region TextBox Bairro

        private void txtBairroCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Bairro
    }
}