using Bunifu.DataViz.WinForms;
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
    public partial class VendasRelatorio : Form
    {
        private BuscarDadosRelatorioSaida BRNFS = new BuscarDadosRelatorioSaida(); // Buscar Relatorio de Nota Fiscal de Saida

        private BuscarDadosRelatorioSaida BRSG = new BuscarDadosRelatorioSaida(); // Buscar Relatorio de Saida para preencher o Grafico

        private DeletarNotaFiscalSaida CNFS = new DeletarNotaFiscalSaida(); // Cancelar Nota Fiscal de Saida

        private DataPoint dataPoint;

        public VendasRelatorio()
        {
            InitializeComponent();
        }

        #region Mudanca de Tela Verificacao NF Saida

        private void VendasRelatorio_Load(object sender, EventArgs e)
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
                BRNFS.BuscarDadosRelatorioNFSaida(Convert.ToDateTime(dtpDataInicio_Relatorio.Text),
                Convert.ToDateTime(dtpDataFinal_Relatorio.Text), gdvRelatorioNFSaida_Vendas);

                dataPoint = new DataPoint(BunifuDataViz._type.Bunifu_spline);

                Canvas canvas = new Canvas();

                foreach (var Cod_Produto in BRSG.BuscarDadosRelatorioNFSaidaGraficoCod_Produto(Convert.ToDateTime(dtpDataInicio_Relatorio.Text),
                Convert.ToDateTime(dtpDataFinal_Relatorio.Text)))
                {
                    foreach (var QUANT in BRSG.BuscarDadosRelatorioNFSaidaGraficoQuant(Convert.ToDateTime(dtpDataInicio_Relatorio.Text),
                    Convert.ToDateTime(dtpDataFinal_Relatorio.Text), Cod_Produto))
                    {
                        dataPoint.addLabely(Cod_Produto.ToString(), QUANT);

                        GraficoSaida.colorSet.Add(Color.Aqua);

                        canvas.addData(dataPoint);

                        //Grafico.Title = "Top 10 Produtos Com Maior Entrada";

                        break;
                    }

                    //break;
                }
                GraficoSaida.Render(canvas);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Botao Pesquisar

        #region TextBox Data Inicio

        private void txtDataInicio_VendasRelatorio_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        #endregion TextBox Data Inicio

        #region TextBox Data Final

        private void txtDataFinal_VendasRelatorio_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        #endregion TextBox Data Final
    }
}