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
    public partial class SuprimentoControleBusca : Form
    {
        private BuscarDadosEstoque BCP = new BuscarDadosEstoque();
        private BuscarDadosEstoque BCB = new BuscarDadosEstoque();

        //Cancelar Nota Fiscal de Saida

        private DeletarNotaFiscalSaida CNFS = new DeletarNotaFiscalSaida();

        public SuprimentoControleBusca()
        {
            InitializeComponent();
        }

        #region Mudanca de Tela Verificacao NF Saida

        private void SuprimentoControleBusca_Load(object sender, EventArgs e)
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

        #region Botao Pesquisar

        private void btnPesquisa_CadastroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodBarras_Buscar.Text != "")
                {
                    BCB.BuscarCodBarras(Convert.ToInt32(txtCodBarras_Buscar.Text), gdvBuscarEstoque_Suprimentos);

                    //Zerar os campos
                    txtCodBarras_Buscar.Text = "";
                    txtCodProduto_Buscar.Text = "";
                }
                else if (txtCodProduto_Buscar.Text != "")
                {
                    BCP.BuscarCodDoProduto(Convert.ToInt32(txtCodProduto_Buscar.Text), gdvBuscarEstoque_Suprimentos);

                    //Zerar os campos
                    txtCodBarras_Buscar.Text = "";
                    txtCodProduto_Buscar.Text = "";
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            //}
        }

        #endregion Botao Pesquisar
    }
}