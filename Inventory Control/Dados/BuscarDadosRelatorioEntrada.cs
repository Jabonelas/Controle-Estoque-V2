using Bunifu.DataViz.WinForms;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Control
{
    internal class BuscarDadosRelatorioEntrada : ConectarBanco
    {
        private VerificacaoDeExistencia VNFE = new VerificacaoDeExistencia();

        #region Buscar Dados do Relatorio Nota Fiscal de Entrada

        public void BuscarDadosRelatorioNFEntrada(DateTime _data_Inicial, DateTime _data_Final, Guna2DataGridView _tabela)
        {
            try
            {
                if (VNFE.BuscarExistenciaRelatorioNFEntrada(_data_Inicial))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        string query = "select NF, CNPJ, Nome_Razao_Social, Cod_Produto, Descricao_Produto," +
                            " QUANT, UNIDADE, Valor_Unitario, Valor_Total, Data_Emissao, Data_Lancamento," +
                            " Estatus from NF where Estatus <> 'TRANSITO' and Data_Lancamento >= @dataInical and Data_Lancamento <= @dataFinal";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                        adapter.SelectCommand.Parameters.AddWithValue("@dataInical", _data_Inicial);
                        adapter.SelectCommand.Parameters.AddWithValue("@dataFinal", _data_Final);

                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        _tabela.DataSource = dataTable;
                        _tabela.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Data de Entrada Não Encontrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Buscar Dados do Relatorio Nota Fiscal de Entrada

        #region Buscar Dados de Relatorio Codigo do Produto Grafico

        public List<int> BuscarDadosRelatorioNFEntradaGraficoCod_Produto(DateTime _data_Inicial, DateTime _data_Final)
        {
            try
            {
                List<int> DadosGrafico = new List<int>();

                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select top 5 Cod_Produto from NF where Estatus <> 'TRANSITO'" +
                        " and Data_Lancamento >= @dataInical and Data_Lancamento <= @dataFinal";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataInical", _data_Inicial);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataFinal", _data_Final);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        DadosGrafico.Add(dr.GetInt32(0));
                    }

                    return DadosGrafico;
                }
            }
            catch (Exception x)
            {
                return new List<int>();

                MessageBox.Show(x.ToString());
            }
        }

        #endregion Buscar Dados de Relatorio Codigo do Produto Grafico

        #region Buscar Dados de Relatorio Quantidade Grafico

        public List<int> BuscarDadosRelatorioNFEntradaGraficoQuant(DateTime _data_Inicial, DateTime _data_Final, int _cod_Produto)
        {
            try
            {
                List<int> DadosGrafico = new List<int>();

                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select sum (QUANT) from NF where Estatus <> 'TRANSITO'" +
                        " and Data_Lancamento >= @dataInical and Data_Lancamento <= @dataFinal and Cod_Produto = @codProduto";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataInical", _data_Inicial);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataFinal", _data_Final);
                    adapter.SelectCommand.Parameters.AddWithValue("@codProduto", _cod_Produto);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        DadosGrafico.Add(dr.GetInt32(0));
                    }

                    return DadosGrafico;
                }
            }
            catch (Exception x)
            {
                return new List<int>();

                MessageBox.Show(x.ToString());
            }
        }

        #endregion Buscar Dados de Relatorio Quantidade Grafico
    }
}