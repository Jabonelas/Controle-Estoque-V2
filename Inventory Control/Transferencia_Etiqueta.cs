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
    public partial class Transferencia_Etiqueta : Form
    {
        private VerificacaoDeExistencia VCB = new VerificacaoDeExistencia(); // Verificar a existencia do Codigo de barrass na tabela Estoque

        private BuscarDadosEstoque BP = new BuscarDadosEstoque(); // Buscar Produto na tabela Estoque
        private BuscarDadosEstoque BLote = new BuscarDadosEstoque(); // Buscar Lote na tabela Estoque
        private BuscarDadosEstoque BD = new BuscarDadosEstoque(); // Buscar Descricao na tabela Estoque
        private BuscarDadosEstoque BQ = new BuscarDadosEstoque(); // Buscar Quantidade na tabela Estoque
        private BuscarDadosEstoque BLocal = new BuscarDadosEstoque(); // Buscar Local na tabela Estoque

        private AlterarDadosEstoque AEQA = new AlterarDadosEstoque(); // Alterar Estoque Quantidade Adicao
        private AlterarDadosEstoque AEQS = new AlterarDadosEstoque(); // Alterar Estoque Quantidade Subtracao

        private VerificacaoTextBox VT = new VerificacaoTextBox(); // Verificacao se os Textbox estao preenchidos

        public Transferencia_Etiqueta()
        {
            InitializeComponent();
        }

        #region Etiqueta Origem

        private void btnBuscarEtiquetaOrigem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text != "")
                {
                    if (VCB.BuscarExistenciaCodigoDeBarras(Convert.ToInt32(txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text)) == true)
                    {
                        if (BLocal.BuscarLocal(Convert.ToInt32(txtCodDaProdutoOrigem_MovimentacaoEtiqueta.Text)) != "EXCLUIDA" && BLocal.BuscarLocal(Convert.ToInt32(txtCodDaProdutoOrigem_MovimentacaoEtiqueta.Text)) != "FATURADA")
                        {
                            txtCodDaProdutoOrigem_MovimentacaoEtiqueta.Text = BP.BuscarCodProdutoTextBox(Convert.ToInt32(txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text));

                            txtLoteOrigem_MovimentocaoEtiqueta.Text = BLote.BuscarLote(Convert.ToInt32(txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text));

                            txtDescricaoOrigem_MovimentocaoEtiqueta.Text = BD.BuscarDescricao(Convert.ToInt32(txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text));

                            txtQuantidadeOrigem_MovimentocaoEtiqueta.Text = BQ.BuscarQuantidade(Convert.ToInt32(txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text));

                            txtLocalOrigem_MovimentacaoEtiqueta.Text = BLocal.BuscarLocal(Convert.ToInt32(txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text));
                        }
                        else
                        {
                            MessageBox.Show("Etiqueta Excluida Ou Consumida!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Codigo de Barras Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else { MessageBox.Show("O Campo Cód. Barras é Obrigatorio!"); }
            }
            catch (Exception x)
            {
                MessageBox.Show("Erro ao Realizar Busca!\n\n" + x.ToString());
            }
        }

        #endregion Etiqueta Origem

        #region Etiqueta Destino

        private void btnBuscarEtiquetaDestino_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text != "")
                {
                    if (VCB.BuscarExistenciaCodigoDeBarras(Convert.ToInt32(txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text)) == true)
                    {
                        if (BLocal.BuscarLocal(Convert.ToInt32(txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text)) != "EXCLUIDA" &&
                            BLocal.BuscarLocal(Convert.ToInt32(txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text)) != "FATURADA")
                        {
                            txtCodDaProdutoDestino_MovimentacaoEtiqueta.Text = BP.BuscarCodProdutoTextBox(Convert.ToInt32(txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text));

                            txtLoteDestino_MovimentocaoEtiqueta.Text = BLote.BuscarLote(Convert.ToInt32(txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text));

                            txtDescricaoDestino_MovimentocaoEtiqueta.Text = BD.BuscarDescricao(Convert.ToInt32(txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text));

                            txtQuantidadeDestino_MovimentocaoEtiqueta.Text = BQ.BuscarQuantidade(Convert.ToInt32(txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text));

                            txtLocalDestino_MovimentacaoEtiqueta.Text = BLocal.BuscarLocal(Convert.ToInt32(txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text));
                        }
                        else
                        {
                            MessageBox.Show("Etiqueta Excluida Ou Consumida!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Codigo de Barras Não Encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else { MessageBox.Show("O Campo Cód. Barras é Obrigatorio!"); }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Etiqueta Destino

        #region TextBox Codigo de Barras Origem

        private void txtCodDeBarrasOrigem_MovimentacaoEtiqueta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Codigo de Barras Origem

        #region TextBox Transferir Origem

        private void txtTransferirOrigem_MovimentocaoEtiqueta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Transferir Origem

        #region TextBox Codigo de Barras Destino

        private void txtCodDeBarrasDestino_MovimentacaoEtiqueta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Codigo de Barras Destino

        private void btnModificar_CadastroCliente_Click(object sender, EventArgs e)
        {
            if (VT.VerificarTextBoxTransferenciaEtiquetas(this) == false)
            {
            }
            else
            {
                MessageBox.Show("Todos Os Campos Devem Estar Preenchidos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}