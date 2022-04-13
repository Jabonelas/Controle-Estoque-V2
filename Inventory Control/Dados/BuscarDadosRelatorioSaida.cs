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
    internal class BuscarDadosRelatorioSaida : ConectarBanco
    {
        private VerificacaoDeExistencia VNFS = new VerificacaoDeExistencia(); // Verifiracao de Existencia de Nota Fiscal de Saida

        #region Buscar Dados Relatorio Nota Fiscal Saida

        public void BuscarDadosRelatorioNFSaida(DateTime _data_Inicial, DateTime _data_Final, Guna2DataGridView _tabela)
        {
            try
            {
                if (VNFS.BuscarExistenciaRelatorioNFSaida(_data_Inicial))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        string query = "select * from NF_Saida where Emissao >= @dataInical and Emissao <= @dataFinal" +
                            " and Estatus <> 'NULL'";
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

        #endregion Buscar Dados Relatorio Nota Fiscal Saida

        #region Buscar Dados de Relatorio Codigo do Produto Grafico

        public List<int> BuscarDadosRelatorioNFSaidaGraficoCod_Produto(DateTime _data_Inicial, DateTime _data_Final)
        {
            try
            {
                List<int> DadosGrafico = new List<int>();

                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select top 5 Cod_Produto from NF_Saida where Estatus <> 'NULL'" +
                        " and Emissao >= @dataInical and Emissao <= @dataFinal";
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

        public List<int> BuscarDadosRelatorioNFSaidaGraficoQuant(DateTime _data_Inicial, DateTime _data_Final, int _cod_Produto)
        {
            try
            {
                List<int> DadosGrafico = new List<int>();

                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select sum (Quantidade) from NF_Saida where Estatus <> 'NULL'" +
                        " and Emissao >= @dataInical and Emissao <= @dataFinal and Cod_Produto = @codProduto";
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