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
        private BuscarNotaFiscalEntrada BN = new BuscarNotaFiscalEntrada();

        private DeletarNotaFiscalEntrada DN = new DeletarNotaFiscalEntrada();

        private InserirNotaFiscalEntrada IN = new InserirNotaFiscalEntrada();

        private InserirDadosEstoque IE = new InserirDadosEstoque();

        private VerificacaoDeExistencia VC = new VerificacaoDeExistencia();

        private VerificacaoDeExistencia VF = new VerificacaoDeExistencia();

        private VerificacaoDeExistencia VP = new VerificacaoDeExistencia();

        private VerificacaoDeExistencia VNF = new VerificacaoDeExistencia();

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
            if (txtNotaFiscal_Suprimento.Text == "")
            {
                MessageBox.Show("O Campo Nota Fical é Obrigatorio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (VNF.BuscarExistenciaDeLancamentoNotaFiscal(Convert.ToInt32(txtNotaFiscal_Suprimento.Text)) != "TRANSITO")
                {
                    try
                    {
                        DN.DeletarNotaFiscal(Convert.ToInt32(txtNotaFiscal_Suprimento.Text), gdvNotaFiscal_Suprimento);

                        txtNotaFiscal_Suprimento.Text = "";
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.ToString());
                    }
                }
            }
        }

        #endregion Botão EXcluir Nota Fiscal

        #region Botão Incluir Nota Fiscal

        private void btnIncluir_CadastroCliente_Click(object sender, EventArgs e)
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
                    if (VNF.BuscarExistenciaDeLancamentoNotaFiscal(Convert.ToInt32(txtNotaFiscal_Suprimento.Text)) == "TRANSITO")
                    {
                        try
                        {
                            IN.InserirNotaFiscal(Convert.ToInt32(txtNotaFiscal_Suprimento.Text));

                            IE.InserirEstoque(Convert.ToInt32(txtNotaFiscal_Suprimento.Text));

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

        #endregion Botão Incluir Nota Fiscal
    }
}