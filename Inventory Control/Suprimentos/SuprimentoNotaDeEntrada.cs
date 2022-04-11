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

        private AlterarDadosEstoque AEENFE = new AlterarDadosEstoque(); // Alterar estoque quando excluir a nota fiscal de entrada

        private BuscarDadosEstoque BEL = new BuscarDadosEstoque(); // Buscar Local em Estoque

        private BuscarDadosEstoque BEQ = new BuscarDadosEstoque(); // Buscar Estoque Quantiade

        private BuscarNotaFiscalEntrada BENFE = new BuscarNotaFiscalEntrada(); // Buscar o Estatus da Nota Fiscal de Entrada

        //Cancelar Nota Fiscal de Saida

        private DeletarNotaFiscalSaida CNFS = new DeletarNotaFiscalSaida();

        public SuprimentoNotaDeEntrada()
        {
            InitializeComponent();
        }

        #region Mudanca de Tela Verificacao NF Saida

        private void SuprimentoNotaDeEntrada_Load(object sender, EventArgs e)
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

        private bool IndicadorDeLocal = true;
        private bool IndicadorQuantidade = true;

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
                    foreach (var CodBarras in BNFEC.BuscarNFEntradaCodBarras(Convert.ToInt32(txtNotaFiscal_Suprimento.Text)))
                    {
                        foreach (var Local in BEL.BuscarLocalEstoque(Convert.ToInt32(txtNotaFiscal_Suprimento.Text), CodBarras))
                        {
                            if (Local != "RECEBIMENTO")
                            {
                                IndicadorDeLocal = false;
                                break;
                            }
                            break;
                        }

                        if (IndicadorDeLocal == false)
                        {
                            break;
                        }
                    }

                    foreach (var CodBarras in BNFEC.BuscarNFEntradaCodBarras(Convert.ToInt32(txtNotaFiscal_Suprimento.Text)))
                    {
                        foreach (var QuantidadeEstoque in BEQ.BuscarQuantidadeEstoque(CodBarras))
                        {
                            foreach (var QuantidadeNFEntrada in BNFEQ.BuscarNFEntradaQuantidade(CodBarras))
                            {
                                if (QuantidadeEstoque != QuantidadeNFEntrada)
                                {
                                    IndicadorQuantidade = false;
                                    break;
                                }
                                break;
                            }
                            break;
                        }

                        if (IndicadorQuantidade == false)
                        {
                            break;
                        }
                    }

                    if (VNF.BuscarExistenciaNotaFiscalEntrada(Convert.ToInt32(txtNotaFiscal_Suprimento.Text)) == true)
                    {
                        if (IndicadorDeLocal == true && IndicadorQuantidade == true)
                        {
                            //foreach (var CodProduto in BNFEP.BuscarNFEntradaCodProduto(Convert.ToInt32(txtNotaFiscal_Suprimento.Text)))
                            //{
                            foreach (var CodBarras in BNFEC.BuscarNFEntradaCodBarras(Convert.ToInt32(txtNotaFiscal_Suprimento.Text)))
                            {
                                foreach (var Quantidade in BNFEQ.BuscarNFEntradaQuantidade(Convert.ToInt32(txtNotaFiscal_Suprimento.Text)))
                                {
                                    AQEES.AlterarQuantidadeEstoqueEntradaSubtracao(Convert.ToInt32(txtNotaFiscal_Suprimento.Text), Quantidade, CodBarras);

                                    AEENFE.AlterarEstoqueExclusaoNFEntrada(Convert.ToInt32(txtNotaFiscal_Suprimento.Text), CodBarras);

                                    break;
                                }
                                //break;
                            }
                            //}

                            DNFE.DeletarNotaFiscal(Convert.ToInt32(txtNotaFiscal_Suprimento.Text), gdvNotaFiscal_Suprimento);
                        }
                        else
                        {
                            MessageBox.Show("Itens Não Disponiveis Local/Quantidade!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nota Fiscal Não Encontrada!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        if (VNF.BuscarExistenciaNotaFiscalEntrada(Convert.ToInt32(txtNotaFiscal_Suprimento.Text)) == true)
                        {
                            if (BENFE.BuscarNotaFiscalEntradaEstatus(Convert.ToInt32(txtNotaFiscal_Suprimento.Text)) == "TRANSITO")
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
                                MessageBox.Show("Nota Fiscal Já Inclusa!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nota Fiscal Não Encontrada!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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