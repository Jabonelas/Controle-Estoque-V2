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

        private BuscarDadosEstoque BECD = new BuscarDadosEstoque(); // Buscar Estoque Codigo de barras de Duas tiquetas

        private BuscarDadosEstoque BEC = new BuscarDadosEstoque(); // Buscar Estoque Codigo do produto por codigo de barras

        public Transferencia_Etiqueta()
        {
            InitializeComponent();
        }

        //public void loadform(object Form)
        //{
        //    if (gvdMovimentacaoEtiqueta.Controls.Count > 0)
        //        gvdMovimentacaoEtiqueta.Controls.RemoveAt(0);

        //    Form f = Form as Form;
        //    f.TopLevel = false;
        //    f.Dock = DockStyle.Fill;
        //    gvdMovimentacaoEtiqueta.Controls.Add(f);
        //    gvdMovimentacaoEtiqueta.Tag = f;
        //    f.Show();
        //}

        #region Etiqueta Origem

        private void btnBuscarEtiquetaOrigem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text != "")
                {
                    if (VCB.BuscarExistenciaCodigoDeBarras(Convert.ToInt32(txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text)) == true)
                    {
                        if (BLocal.BuscarLocal(Convert.ToInt32(txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text)) != "EXCLUIDA" &&
                            BLocal.BuscarLocal(Convert.ToInt32(txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text)) != "FATURADA")
                        {
                            txtCodDaProdutoOrigem_MovimentacaoEtiqueta.Text = BP.BuscarCodProdutoTextBox(Convert.ToInt32(txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text));

                            txtLoteOrigem_MovimentocaoEtiqueta.Text = BLote.BuscarLote(Convert.ToInt32(txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text));

                            txtDescricaoOrigem_MovimentocaoEtiqueta.Text = BD.BuscarDescricao(Convert.ToInt32(txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text));

                            txtQuantidadeOrigem_MovimentocaoEtiqueta.Text = BQ.BuscarQuantidade(Convert.ToInt32(txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text)).ToString();

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

                            txtQuantidadeDestino_MovimentocaoEtiqueta.Text = BQ.BuscarQuantidade(Convert.ToInt32(txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text)).ToString();

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

        #region Botao Confirmar Transferencia

        private void btnModificar_CadastroCliente_Click(object sender, EventArgs e)
        {
            if (BEC.BuscarCodProdutoTextBox(Convert.ToInt32(txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text)) ==
                BEC.BuscarCodProdutoTextBox(Convert.ToInt32(txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text)))
            {
                if (BLocal.BuscarLocal(Convert.ToInt32(txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text)) != "EXCLUIDA" &&
                    BLocal.BuscarLocal(Convert.ToInt32(txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text)) != "FATURADA" &&
                    BLocal.BuscarLocal(Convert.ToInt32(txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text)) != "EXCLUIDA" &&
                    BLocal.BuscarLocal(Convert.ToInt32(txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text)) != "FATURADA")
                {
                    if (BQ.BuscarQuantidade(Convert.ToInt32(txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text)) >= Convert.ToInt32(txtTransferirOrigem_MovimentocaoEtiqueta.Text))
                    {
                        if (txtTransferirOrigem_MovimentocaoEtiqueta.Text != "" && txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text != "" &&
                            txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text != "")
                        {
                            txtRecebidoDestino_MovimentocaoEtiqueta.Text = txtTransferirOrigem_MovimentocaoEtiqueta.Text;

                            AEQA.AlterarQuantidadeEstoqueAdicao(Convert.ToInt32(txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text),
                            Convert.ToInt32(txtTransferirOrigem_MovimentocaoEtiqueta.Text));

                            AEQS.AlterarQuantidadeEstoqueSubtracao(Convert.ToInt32(txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text),
                            Convert.ToInt32(txtRecebidoDestino_MovimentocaoEtiqueta.Text));

                            BECD.BuscarCodBarrasEtiquetas(Convert.ToInt32(txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text),
                            Convert.ToInt32(txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text), gvdMovimentacaoEtiqueta);

                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                        }
                        else
                        {
                            label1.Text = "*";
                            label2.Text = "*";
                            label3.Text = "*";

                            MessageBox.Show("Os Campos Com * São Obrigadotios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Quantidade Solicitada Maior Que A Disponivel!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Etiquetas Não Acessiveis!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Itens Divergentes!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion Botao Confirmar Transferencia

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

        private void btnBuscarListaOrigem_Click(object sender, EventArgs e)
        {
            //loadform(new ListaEstoque());
        }
    }
}