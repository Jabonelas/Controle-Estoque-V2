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
    public partial class ListaEstoque : Form
    {
        private BuscarDadosEstoque BEP = new BuscarDadosEstoque();// Buscar no Estoque por Produto

        private Transferencia_Etiqueta formTransferencia;

        private BuscarDadosEstoque BP = new BuscarDadosEstoque(); // Buscar Produto na tabela Estoque

        private BuscarDadosEstoque BLote = new BuscarDadosEstoque(); // Buscar Lote na tabela Estoque

        private BuscarDadosEstoque BD = new BuscarDadosEstoque(); // Buscar Descricao na tabela Estoque

        private BuscarDadosEstoque BQ = new BuscarDadosEstoque(); // Buscar Quantidade na tabela Estoque

        private BuscarDadosEstoque BLocal = new BuscarDadosEstoque(); // Buscar Local na tabela Estoque

        private string formPrincipal = "";

        public ListaEstoque(Transferencia_Etiqueta _transferencia_Etiqueta, string _form)
        {
            InitializeComponent();

            formTransferencia = _transferencia_Etiqueta;

            formPrincipal = _form;
        }

        #region Botao Buscar

        private void btnBuscarEtiqueta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodProduto_MovimentacaoEtiqueta.Text != "")
                {
                    BEP.BuscarCodDoProdutoListar(Convert.ToInt32(txtCodProduto_MovimentacaoEtiqueta.Text), gvdListaEstoque);

                    label1.Text = "";
                }
                else
                {
                    label1.Text = "*";

                    MessageBox.Show("O Campo Com * è Obrigatorio", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        // Setar Cor ao Passa Mouse
        private void btnBuscarEtiqueta_MouseEnter(object sender, EventArgs e)
        {
            btnBuscarEtiqueta.BackColor = Color.LightBlue;
        }

        // Setar Cor ao Passa Mouse
        private void btnBuscarEtiqueta_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarEtiqueta.BackColor = Color.Transparent;
        }

        #endregion Botao Buscar

        #region TextBox Codigo Produto

        private void txtCodProduto_MovimentacaoEtiqueta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion TextBox Codigo Produto

        #region GridView

        private void gvdListaEstoque_DoubleClick(object sender, EventArgs e)
        {
            if (formPrincipal == "Origem")
            {
                formTransferencia.txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text = gvdListaEstoque.SelectedCells[1].Value.ToString();

                formTransferencia.txtCodDaProdutoOrigem_MovimentacaoEtiqueta.Text = BP.BuscarCodProdutoTextBox(Convert.ToInt32(formTransferencia.txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text));

                formTransferencia.txtLoteOrigem_MovimentocaoEtiqueta.Text = BLote.BuscarLote(Convert.ToInt32(formTransferencia.txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text));

                formTransferencia.txtDescricaoOrigem_MovimentocaoEtiqueta.Text = BD.BuscarDescricao(Convert.ToInt32(formTransferencia.txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text));

                formTransferencia.txtQuantidadeOrigem_MovimentocaoEtiqueta.Text = BQ.BuscarQuantidade(Convert.ToInt32(formTransferencia.txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text)).ToString();

                formTransferencia.txtLocalOrigem_MovimentacaoEtiqueta.Text = BLocal.BuscarLocal(Convert.ToInt32(formTransferencia.txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text));

                this.Close();
            }
            else if (formPrincipal == "Destino")
            {
                formTransferencia.txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text = gvdListaEstoque.SelectedCells[1].Value.ToString();

                formTransferencia.txtCodDaProdutoDestino_MovimentacaoEtiqueta.Text = BP.BuscarCodProdutoTextBox(Convert.ToInt32(formTransferencia.txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text));

                formTransferencia.txtLoteDestino_MovimentocaoEtiqueta.Text = BLote.BuscarLote(Convert.ToInt32(formTransferencia.txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text));

                formTransferencia.txtDescricaoDestino_MovimentocaoEtiqueta.Text = BD.BuscarDescricao(Convert.ToInt32(formTransferencia.txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text));

                formTransferencia.txtQuantidadeDestino_MovimentocaoEtiqueta.Text = BQ.BuscarQuantidade(Convert.ToInt32(formTransferencia.txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text)).ToString();

                formTransferencia.txtLocalDestino_MovimentacaoEtiqueta.Text = BLocal.BuscarLocal(Convert.ToInt32(formTransferencia.txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text));

                this.Close();
            }
        }

        #endregion GridView
    }
}