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

        public ListaEstoque()
        {
            InitializeComponent();
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

        private void gvdListaEstoque_SelectionChanged(object sender, EventArgs e)
        {
            //gvdListaEstoque row = gvdListaEstoque.SelectedRows;
            //txtCodProduto_MovimentacaoEtiqueta.Text = row.Cells[1].Text;
        }

        private void gvdListaEstoque_DoubleClick(object sender, EventArgs e)
        {
            guna2DataGridView1 row = gvdListaEstoque.SelectedRows;
            txtCodProduto_MovimentacaoEtiqueta.Text = row.Cells[1].Text;
        }
    }
}