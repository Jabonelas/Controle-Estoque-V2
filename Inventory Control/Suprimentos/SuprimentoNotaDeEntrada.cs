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
    public partial class SuprimentoNotaDeEntrada : Form
    {
        private BuscarNotaFiscalEntrada BN = new BuscarNotaFiscalEntrada(); // Buscar Nota Fiscal de entrada

        private InserirNotaFiscalEntrada IN = new InserirNotaFiscalEntrada(); // Inserir Nota Fiscal de entrada

        private InserirDadosEstoque IE = new InserirDadosEstoque(); // Inserir dados no Estoque

        private VerificacaoDeExistencia VF = new VerificacaoDeExistencia(); // Verificar a existencia do Fornecedor

        private VerificacaoDeExistencia VP = new VerificacaoDeExistencia(); // Verificar a existencia do Produto

        private VerificacaoDeExistencia VNF = new VerificacaoDeExistencia(); // Verificar a existencia da Nota fiscal de entrada

        private BuscarNotaFiscalEntrada BNFEP = new BuscarNotaFiscalEntrada(); // Buscar a Nota Fiscal de Entrada o Codigo do Produto

        private BuscarNotaFiscalEntrada BNFEQ = new BuscarNotaFiscalEntrada(); // Buscar a Nota Fiscal de Entrada a Quantidade

        private BuscarNotaFiscalEntrada BNFEC = new BuscarNotaFiscalEntrada(); // Buscar o Codigo de Barras para preencher a Nota ficsal

        private AlterarDadosEstoque AQEES = new AlterarDadosEstoque(); // Alterar a quantidade de estoque de entrada subtraindo

        private AlterarDadosEstoque ACNFE = new AlterarDadosEstoque(); // Alterar a codigo de barras Nota Fiscal de entrada

        private DeletarNotaFiscalEntrada DNFE = new DeletarNotaFiscalEntrada(); // Deletar Nota Fiscal de entrada

        public SuprimentoNotaDeEntrada()
        {
            InitializeComponent();
        }

        #region Botão Buscar Nota Fiscal

        private void btnPesquisa_CadastroCliente_Click_1(object sender, EventArgs e)
        {
            if (txtNotaFiscal_Suprimento.Text == "")
            {
                MessageBox.Show("O Campo Nota Fiscal é Obrigatorio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    BN.BuscarNotaFiscal(Convert.ToInt32(txtNotaFiscal_Suprimento.Text), gdvNotaFiscal_Suprimento);

                    //Zerar os campos
                    txtNotaFiscal_Suprimento.Text = "";
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        #endregion Botão Buscar Nota Fiscal

        #region Botão EXcluir Nota Fiscal

        private void btnExcluir_CadastroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNotaFiscal_Suprimento.Text == "")
                {
                    MessageBox.Show("O Campo Nota Fical é Obrigatorio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (VNF.BuscarExistenciaDeLancamentoNotaFiscalEntrada(Convert.ToInt32(txtNotaFiscal_Suprimento.Text)) == "RECEBIMENTO")
                    {
                        foreach (var CodProduto in BNFEP.BuscarNFEntradaCodProduto(Convert.ToInt32(txtNotaFiscal_Suprimento.Text)))
                        {
                            foreach (var CodBarras in BNFEC.BuscarNFEntradaCodBarras(Convert.ToInt32(txtNotaFiscal_Suprimento.Text), CodProduto))
                            {
                                foreach (var Quantidade in BNFEQ.BuscarNFEntradaQuantidade(Convert.ToInt32(txtNotaFiscal_Suprimento.Text), CodProduto))
                                {
                                    AQEES.AlterarQuantidadeEstoqueSubtracaoEntrada(Convert.ToInt32(txtNotaFiscal_Suprimento.Text), CodProduto, Quantidade, CodBarras);

                                    break;
                                }
                            }
                        }

                        DNFE.DeletarNotaFiscal(Convert.ToInt32(txtNotaFiscal_Suprimento.Text), gdvNotaFiscal_Suprimento);
                    }
                    else
                    {
                        MessageBox.Show("O Saldo Deve Estar Disponivel Em RECEBIMENTO!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Botão EXcluir Nota Fiscal

        #region Botão Incluir Nota Fiscal

        private void btnIncluir_CadastroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNotaFiscal_Suprimento.Text == "")
                {
                    MessageBox.Show("O Campo Nota Fiscal é Obrigatorio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //BCP.BuscarCodDoProduto(Convert.ToInt32(txtCodProduto_Buscar.Text), gdvBuscarEstoque_Suprimentos);

                    if (VF.BuscarExistenciaDeFornecedorNaTabela(txtNotaFiscal_Suprimento.Text) == true &&
                        VP.BuscarExistenciaDeProdutoNaTabela(txtNotaFiscal_Suprimento.Text) == true)
                    {
                        if (VNF.BuscarExistenciaDeLancamentoNotaFiscalEntrada(Convert.ToInt32(txtNotaFiscal_Suprimento.Text)) == "TRANSITO")
                        {
                            try
                            {
                                IN.InserirNotaFiscal(Convert.ToInt32(txtNotaFiscal_Suprimento.Text));

                                IE.InserirEstoque(Convert.ToInt32(txtNotaFiscal_Suprimento.Text));

                                foreach (var CodProduto in BNFEP.BuscarNFEntradaCodProduto(Convert.ToInt32(txtNotaFiscal_Suprimento.Text)))
                                {
                                    //foreach (var CodBarras in BNFEC.BuscarNFEntradaCodBarras(Convert.ToInt32(txtNotaFiscal_Suprimento.Text), CodProduto))
                                    //{
                                    ACNFE.AlterarCodBarrasNFEntrada(Convert.ToInt32(txtNotaFiscal_Suprimento.Text), CodProduto);

                                    //break;
                                    //}
                                }

                                BN.BuscarNotaFiscal(Convert.ToInt32(txtNotaFiscal_Suprimento.Text), gdvNotaFiscal_Suprimento);
                            }
                            catch (Exception x)
                            {
                                MessageBox.Show(x.ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nota Fiscal´Já Inclusa no Sistema!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fornecedor ou Produto Não Cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Botão Incluir Nota Fiscal
    }
}