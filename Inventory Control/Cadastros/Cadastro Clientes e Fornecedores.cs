﻿using Guna.UI.WinForms;
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
        private InserirDadosClientes IC = new InserirDadosClientes();

        private InserirDadosFornecedor IF = new InserirDadosFornecedor();

        private BuscarDadosClientes BC = new BuscarDadosClientes();

        private AlterarDadosClientes AC = new AlterarDadosClientes();

        private DeletarDadosClientes DC = new DeletarDadosClientes();

        public Cadastro_Clientes_e_Fornecedores()
        {
            InitializeComponent();
        }

        #region Botão Incluir Cadastro

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
                txtCadastroCadastro.Text = DateTime.Today.ToShortDateString();

                Random randNum = new Random();

                txtCodProdutoCadastro.Text = randNum.Next(100).ToString();

                //Preencher caso o tipo seja Cliente
                if (txtTipoCadastro.Text == "Cliente")
                {
                    try
                    {
                        IC.InserirClientes(Convert.ToInt32(txtCodProdutoCadastro.Text), txtNomeFantasiaCadastro.Text, Convert.ToDateTime(txtCadastroCadastro.Text),
                        txtCNPJCadastro.Text, txtRazaoSocialCadastro.Text, txtCEPCadastro.Text, txtUFCadastro.Text,
                        txtCidadeCadastro.Text, txtEnderecoCadastro.Text, Convert.ToInt32(txtNumeroCadastro.Text), txtComplementoCadastro.Text,
                        txtBairroCadastro.Text);

                        //MessageBox cadastrado com sucesso e limpeza dos TextBox
                        DialogResult OpcaoDoUsuario = new DialogResult();
                        OpcaoDoUsuario = MessageBox.Show("Cliente Cadastrado Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (OpcaoDoUsuario == DialogResult.OK)
                        {
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
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message.ToString());
                    }
                }
                else
                {
                    //Preencher caso seja tipo fornecedor
                    try
                    {
                        IF.InserirFornecedor(Convert.ToInt32(txtCodProdutoCadastro.Text), txtNomeFantasiaCadastro.Text, Convert.ToDateTime(txtCadastroCadastro.Text),
                        txtCNPJCadastro.Text, txtRazaoSocialCadastro.Text, txtCEPCadastro.Text, txtUFCadastro.Text,
                        txtCidadeCadastro.Text, txtEnderecoCadastro.Text, Convert.ToInt32(txtNumeroCadastro.Text), txtComplementoCadastro.Text,
                        txtBairroCadastro.Text);

                        //MessageBox cadastrado com sucesso e limpeza dos TextBox
                        DialogResult OpcaoDoUsuario = new DialogResult();
                        OpcaoDoUsuario = MessageBox.Show("Fornecedor Cadastrado Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (OpcaoDoUsuario == DialogResult.OK)
                        {
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
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message.ToString());
                    }
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
                    BC.BuscarClientes(txtCNPJCadastro.Text, gunaDataGridView1);

                    //Zerar os campos
                    txtTipoCadastro.Text = "";
                    txtCNPJCadastro.Text = "";

                    AvisoDePreenchimentoCNPJ.Text = "";
                    AvisoDePreenchimentoTipo.Text = "";
                }

                if (txtTipoCadastro.Text == "Fornecedor")
                {
                    try
                    {
                        string conexaoString = "Server=DESKTOP-V79P1T3\\SQLEXPRESS;Database=Inventory_Control;Integrated Security=True;";
                        SqlDataAdapter Busca = new SqlDataAdapter("select * from Fornecedor where CNPJ ='" + txtCNPJCadastro.Text + "'", conexaoString);

                        //Preencher o GridView

                        DataTable tabela = new DataTable();
                        Busca.Fill(tabela);
                        gunaDataGridView1.DataSource = tabela;

                        //Zerar os campos
                        txtTipoCadastro.Text = "";
                        txtCNPJCadastro.Text = "";

                        AvisoDePreenchimentoCNPJ.Text = "";
                        AvisoDePreenchimentoTipo.Text = "";
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message.ToString());
                    }
                }
            }
        }

        #endregion Botão Bucar Cadastro

        #region Botão Modificar Cadastro

        private void btnModificar_CadastroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                AC.AlterarClientes(Convert.ToInt32(txtCodProdutoCadastro.Text), txtNomeFantasiaCadastro.Text, Convert.ToDateTime(txtCadastroCadastro.Text),
                                     txtCNPJCadastro.Text, txtRazaoSocialCadastro.Text, txtCEPCadastro.Text, txtUFCadastro.Text,
                                     txtCidadeCadastro.Text, txtEnderecoCadastro.Text, Convert.ToInt32(txtNumeroCadastro.Text), txtComplementoCadastro.Text,
                                     txtBairroCadastro.Text);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Botão Modificar Cadastro

        #region Botão Excluir Cadastro

        private void btnExcluir_CadastroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                DC.DeletarClientes(txtCNPJCadastro.Text);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
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
    }
}