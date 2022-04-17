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

        //Cancelar Nota Fiscal de Saida

        private DeletarNotaFiscalSaida CNFS = new DeletarNotaFiscalSaida();

        public Transferencia_Etiqueta()
        {
            InitializeComponent();
        }

        #region Mudanca de Tela Verificacao NF Saida

        private void Transferencia_Etiqueta_Load(object sender, EventArgs e)
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

                            label1.Text = "";
                            label3.Text = "";
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
                else
                {
                    label1.Text = "*";
                    label3.Text = "*";
                    MessageBox.Show("Os Campos Com * São Obrigadotios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Erro ao Realizar Busca!\n\n" + x.ToString());
            }
        }

        // Setar Cor ao Passar o Mouse
        private void btnBuscarEtiquetaOrigem_MouseEnter(object sender, EventArgs e)
        {
            btnBuscarEtiquetaOrigem.BackColor = Color.LightBlue;
        }

        //Setar Cor ao Passar o Mouse
        private void btnBuscarEtiquetaOrigem_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarEtiquetaOrigem.BackColor = Color.Transparent;
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

                            label2.Text = "";
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
                else
                {
                    label2.Text = "*";
                    MessageBox.Show("Os Campos Com * São Obrigadotios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        // Setar Cor ao Passar o Mouse

        private void btnBuscarEtiquetaDestino_MouseEnter(object sender, EventArgs e)
        {
            btnBuscarEtiquetaDestino.BackColor = Color.LightBlue;
        }

        // Setar Cor ao Passar o Mouse

        private void btnBuscarEtiquetaDestino_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarEtiquetaDestino.BackColor = Color.Transparent;
        }

        #endregion Etiqueta Destino

        #region Botao Confirmar Transferencia

        private void btnModificar_CadastroCliente_Click(object sender, EventArgs e)
        {
            if (txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text != "" && txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text != ""
                && txtTransferirOrigem_MovimentocaoEtiqueta.Text != "")
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

                            DialogResult OpcaoDoUsuario = new DialogResult();
                            OpcaoDoUsuario = MessageBox.Show("Modificação Realizada Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (OpcaoDoUsuario == DialogResult.OK)
                            {
                                txtCodDaProdutoOrigem_MovimentacaoEtiqueta.Text = "";

                                txtLoteOrigem_MovimentocaoEtiqueta.Text = "";

                                txtDescricaoOrigem_MovimentocaoEtiqueta.Text = "";

                                txtQuantidadeOrigem_MovimentocaoEtiqueta.Text = "";

                                txtLocalOrigem_MovimentacaoEtiqueta.Text = "";

                                txtCodDaProdutoDestino_MovimentacaoEtiqueta.Text = "";

                                txtLoteDestino_MovimentocaoEtiqueta.Text = "";

                                txtDescricaoDestino_MovimentocaoEtiqueta.Text = "";

                                txtQuantidadeDestino_MovimentocaoEtiqueta.Text = "";

                                txtLocalDestino_MovimentacaoEtiqueta.Text = "";

                                txtTransferirOrigem_MovimentocaoEtiqueta.Text = "";

                                txtCodDeBarrasOrigem_MovimentacaoEtiqueta.Text = "";

                                txtCodDeBarrasDestino_MovimentacaoEtiqueta.Text = "";

                                txtRecebidoDestino_MovimentocaoEtiqueta.Text = "";
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
            else
            {
                label1.Text = "*";
                label2.Text = "*";
                label3.Text = "*";

                MessageBox.Show("Os Campos Com * São Obrigadotios!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion Botao Confirmar Transferencia

        #region Botao Buscar Lista

        #region Origem

        private void btnBuscarListaOrigem_Click(object sender, EventArgs e)
        {
            ListaEstoque ListarProdutos = new ListaEstoque(this, "Origem");
            ListarProdutos.ShowDialog();
        }

        // Setar Cor ao Passar o Mouse
        private void btnBuscarListaOrigem_MouseEnter(object sender, EventArgs e)
        {
            btnBuscarListaOrigem.BackColor = Color.LightBlue;
        }

        // Setar Cor ao Passar o Mouse
        private void btnBuscarListaOrigem_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarListaOrigem.BackColor = Color.Transparent;
        }

        #endregion Origem

        #region Destino

        private void btnBuscarListaDestino_Click(object sender, EventArgs e)
        {
            ListaEstoque ListarProdutos = new ListaEstoque(this, "Destino");
            ListarProdutos.ShowDialog();
        }

        // Setar Cor ao Passar o Mouse

        private void btnBuscarListaDestino_MouseEnter(object sender, EventArgs e)
        {
            btnBuscarListaDestino.BackColor = Color.LightBlue;
        }

        // Setar Cor ao Passar o Mouse

        private void btnBuscarListaDestino_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarListaDestino.BackColor = Color.Transparent;
        }

        #endregion Destino

        #endregion Botao Buscar Lista

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
    }
}