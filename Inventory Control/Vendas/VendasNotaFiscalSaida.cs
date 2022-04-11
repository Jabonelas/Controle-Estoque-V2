using Inventory_Control.Dados;
using Inventory_Control.Verificacao;
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
    public partial class VendasNotaFiscalSaida : Form
    {
        private InserirNotaFiscalSaida INFS = new InserirNotaFiscalSaida(); // Inserir Nota Fiscal de Saida

        private Count CONFS = new Count(); // Contar Nota Fiscal Saida - gerando o valor da NF saida

        private BuscarNotaFiscalSaida BNFS = new BuscarNotaFiscalSaida(); // Buscar Nota Fiscal Saida

        private BuscarDadosEstoque BE = new BuscarDadosEstoque(); // Bucar Estoque

        private DeletarNotaFiscalSaida DNFS = new DeletarNotaFiscalSaida(); // Deletar a Nota Fiscal de Saida

        private VerificarEstoqueLiberado VEL = new VerificarEstoqueLiberado(); // Verificar se o local do estoque é EXPEDICA    O

        private AlterarDadosEstoque AQES = new AlterarDadosEstoque(); // Alterar a quantidade do estoque subtraindo

        private AlterarDadosEstoque AQEA = new AlterarDadosEstoque(); // Alterar a quantidade do estoque adicionando

        private BuscarNotaFiscalSaida BNFSQ = new BuscarNotaFiscalSaida(); // Buscar a quandidade de produto na NF de saida

        private BuscarNotaFiscalSaida BNFSP = new BuscarNotaFiscalSaida(); // Buscar NF de Saida o codigo do Produto

        private VerificacaoDeExistencia BENFSE = new VerificacaoDeExistencia(); // Buscar Existencia Nota Fiscal de Saida e retorna o Estatus

        private BuscarDadosEstoque BEQV = new BuscarDadosEstoque(); // Buscar no Estoque a Quantiade Valida para saber se esta zerada

        private AlterarDadosEstoque ALEZ = new AlterarDadosEstoque(); // Alterar o Local de Estoque Zerado

        private VerificacaoDeExistencia VEC = new VerificacaoDeExistencia(); // Verificar Existencia de Cleinte

        //Cancelar Nota Fiscal de Saida

        private DeletarNotaFiscalSaida CNFS = new DeletarNotaFiscalSaida();

        public VendasNotaFiscalSaida()
        {
            InitializeComponent();
        }

        #region Mudanca de Tela Verificacao NF Saida

        private void VendasNotaFiscalSaida_Load(object sender, EventArgs e)
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

        #region Bontão Incluir

        private void btnIncluir_CadastroCliente_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";

            try
            {
                if (txtCodProduto_VendasNFSaida.Text != "" && txtQuantidade_VendasNFSaida.Text != "" &&
                    txtCNPJCliente_VendasNFSaida.Text != "")
                {
                    if (VEC.BuscarExistenciaCliente(txtCNPJCliente_VendasNFSaida.Text) == true)
                    {
                        txtDataDeEmissao_VendasNFSaida.Text = DateTime.Today.ToShortDateString();

                        if (VEL.VerificarLocalEstoque(Convert.ToInt32(txtCodProduto_VendasNFSaida.Text)) == true)
                        {
                            if (BEQV.BuscarQuantidadeValida(Convert.ToInt32(txtCodProduto_VendasNFSaida.Text)) >= 0 &&
                                BEQV.BuscarQuantidadeValida(Convert.ToInt32(txtCodProduto_VendasNFSaida.Text)) >= Convert.ToInt32(txtQuantidade_VendasNFSaida.Text))

                            {
                                if (txtNFSaida_VendasNFSaida.Text == "") //gerar o numero da NF de Saida
                                {
                                    txtNFSaida_VendasNFSaida.Text = Convert.ToString(CONFS.ContarNFSaidaGerando());
                                }
                                else //manter  o numero da NF de Saida que já foi gerado
                                {
                                    txtNFSaida_VendasNFSaida.Text = Convert.ToString(CONFS.ContarNFSaidaContinuacao());
                                }

                                ConfimarcaoNFSaida.PassouTela = true;

                                ConfimarcaoNFSaida.NFsaida = Convert.ToInt32(txtNFSaida_VendasNFSaida.Text);

                                AQES.AlterarQuantidadeEstoqueSubtracaoSaida(Convert.ToInt32(txtCodProduto_VendasNFSaida.Text), Convert.ToInt32(txtQuantidade_VendasNFSaida.Text));

                                INFS.InserirNFSaida(Convert.ToInt32(txtCodProduto_VendasNFSaida.Text));

                                INFS.InserirNFSaidaIncremento(Convert.ToInt32(txtNFSaida_VendasNFSaida.Text), Convert.ToInt32(txtQuantidade_VendasNFSaida.Text),
                                Convert.ToDateTime(txtDataDeEmissao_VendasNFSaida.Text), txtCNPJCliente_VendasNFSaida.Text);

                                txtDescricao_VendasNFSaida.Text = BE.BuscarDescricaoNFSaida(Convert.ToInt32(txtCodProduto_VendasNFSaida.Text));

                                // Verificação de saldo no estoque caso esteja zerado, tranferi o loccal de estoque para FATURADO
                                if (BEQV.BuscarQuantidadeValida(Convert.ToInt32(txtCodProduto_VendasNFSaida.Text)) <= 0)
                                {
                                    ALEZ.AlterarEstoqueZerado();
                                }

                                DialogResult OpcaoDoUsuario = new DialogResult();
                                OpcaoDoUsuario = MessageBox.Show("Item Adicionado com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (OpcaoDoUsuario == DialogResult.OK)
                                {
                                    BNFS.BuscarNFSaida(Convert.ToInt32(txtNFSaida_VendasNFSaida.Text), gdvVendasNFSaida);

                                    txtDataDeEmissao_VendasNFSaida.Text = "";
                                    txtCodProduto_VendasNFSaida.Text = "";
                                    txtDescricao_VendasNFSaida.Text = "";
                                    txtQuantidade_VendasNFSaida.Text = "";
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Quantidade Disponivel {BEQV.BuscarQuantidadeValida(Convert.ToInt32(txtCodProduto_VendasNFSaida.Text))}", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Item Não Disponivel!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente Não Cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    label1.Text = "*";
                    label2.Text = "*";
                    label4.Text = "*";

                    MessageBox.Show("Todos Os Campos Com * São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Bontão Incluir

        #region Botão Buscar

        private void btnPesquisa_CadastroCliente_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";

            try
            {
                if (txtNFSaida_VendasNFSaida.Text != "")
                {
                    BNFS.BuscarNFSaida(Convert.ToInt32(txtNFSaida_VendasNFSaida.Text), gdvVendasNFSaida);
                }
                else if (txtCodProduto_VendasNFSaida.Text != "")
                {
                    txtDescricao_VendasNFSaida.Text = BE.BuscarDescricaoNFSaida(Convert.ToInt32(txtCodProduto_VendasNFSaida.Text));

                    BNFS.BuscarNFSaidaConsulta(Convert.ToInt32(txtCodProduto_VendasNFSaida.Text), gdvVendasNFSaida);
                }
                else if (txtNFSaida_VendasNFSaida.Text == "" && txtCodProduto_VendasNFSaida.Text == "")
                {
                    label1.Text = "*";
                    label3.Text = "*";
                    MessageBox.Show("Todos Os Campos Com * São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Botão Buscar

        #region Botao Confirmar

        private void btnModificar_CadastroCliente_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";

            try
            {
                if (txtNFSaida_VendasNFSaida.Text != "")
                {
                    MessageBox.Show("NF Emitida com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCNPJCliente_VendasNFSaida.Text = "";
                    txtNFSaida_VendasNFSaida.Text = "";
                    txtDataDeEmissao_VendasNFSaida.Text = "";
                    txtCodProduto_VendasNFSaida.Text = "";
                    txtDescricao_VendasNFSaida.Text = "";
                    txtQuantidade_VendasNFSaida.Text = "";

                    ConfimarcaoNFSaida.PassouTela = false;

                    object Nothing = null;
                    gdvVendasNFSaida.DataSource = Nothing;
                }
                else
                {
                    label3.Text = "*";
                    MessageBox.Show("Todos Os Campos Com * São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Botao Confirmar

        #region Botao Excluir

        private void btnExcluir_CadastroCliente_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";

            try
            {
                if (txtNFSaida_VendasNFSaida.Text != "")
                {
                    if (BENFSE.BuscarExistenciaNotaFiscalSaidaEstatus(Convert.ToInt32(txtNFSaida_VendasNFSaida.Text)) == "FATURADA")
                    {
                        foreach (var CodDeBarras in BNFSP.BuscarNFSaidaCodDeBarras(Convert.ToInt32(txtNFSaida_VendasNFSaida.Text)))
                        {
                            foreach (var Quantidade in BNFSQ.BuscarNFSaidaQuantidade(Convert.ToInt32(txtNFSaida_VendasNFSaida.Text), CodDeBarras))
                            {
                                AQEA.AlterarQuantidadeEstoqueAdicao(CodDeBarras, Quantidade);

                                break;
                            }
                        }

                        DNFS.DeletarNFSaida(Convert.ToInt32(txtNFSaida_VendasNFSaida.Text), gdvVendasNFSaida);

                        txtNFSaida_VendasNFSaida.Text = "";
                        txtDataDeEmissao_VendasNFSaida.Text = "";
                        txtCodProduto_VendasNFSaida.Text = "";
                        txtDescricao_VendasNFSaida.Text = "";
                        txtQuantidade_VendasNFSaida.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Nota Fiscal Indisponivel", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    label3.Text = "*";
                    MessageBox.Show("Todos Os Campos Com * São Obrigatorios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Botao Excluir

        #region TextBox NF Saida

        private void txtNFSaida_VendasNFSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox NF Saida

        #region Textbox Cod Produto

        private void txtCodProduto_VendasNFSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion Textbox Cod Produto

        #region TextBox Quantidade

        private void txtQuantidade_VendasNFSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Quantidade

        #region TextBox CNPJ Cliente

        private void txtCNPJCliente_VendasNFSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCNPJCliente_VendasNFSaida.TextLength)
                {
                    case 0:
                        txtCNPJCliente_VendasNFSaida.Text = "";
                        break;

                    case 2:
                        txtCNPJCliente_VendasNFSaida.Text = txtCNPJCliente_VendasNFSaida.Text + ".";
                        txtCNPJCliente_VendasNFSaida.SelectionStart = 3;
                        break;

                    case 6:
                        txtCNPJCliente_VendasNFSaida.Text = txtCNPJCliente_VendasNFSaida.Text + ".";
                        txtCNPJCliente_VendasNFSaida.SelectionStart = 7;
                        break;

                    case 10:
                        txtCNPJCliente_VendasNFSaida.Text = txtCNPJCliente_VendasNFSaida.Text + "/";
                        txtCNPJCliente_VendasNFSaida.SelectionStart = 11;
                        break;

                    case 15:
                        txtCNPJCliente_VendasNFSaida.Text = txtCNPJCliente_VendasNFSaida.Text + "-";
                        txtCNPJCliente_VendasNFSaida.SelectionStart = 16;
                        break;
                }
            }
        }

        #endregion TextBox CNPJ Cliente
    }
}