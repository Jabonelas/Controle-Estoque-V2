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
    internal class BuscarNotaFiscalSaida : ConectarBanco
    {
        private VerificacaoDeExistencia VNF = new VerificacaoDeExistencia(); // Verificar existencia de Nota Fiscal de entrada

        private VerificacaoDeExistencia VP = new VerificacaoDeExistencia(); // Verificar existencia de produto

        // Busca a ultima Nota Fiscal de saida que foi feita para iniciar uma nova

        #region Buscar Nota Fiscal de Saida

        public void BuscarNFSaida(int _nota_Fiscal_Saida, Guna2DataGridView _tabela)
        {
            try
            {
                if (VNF.BuscarExistenciaNotaFiscalSaida(_nota_Fiscal_Saida))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        string query = "select NF_Saida,Cod_Produto,Lote,Descricao,Valor,Quantidade,Emissao,Estatus" +
                            " from NF_Saida where NF_Saida = @nF";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                        adapter.SelectCommand.Parameters.AddWithValue("@nF", _nota_Fiscal_Saida);

                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        _tabela.DataSource = dataTable;
                        _tabela.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Nota Fiscal Não Encontrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Buscar Nota Fiscal de Saida

        // Buscar a Nota Fiscal que já esta sendo feita para manter o mesmo numero da nota fiscal

        #region Buscar Nota Fiscal de Saida Consulta

        public void BuscarNFSaidaConsulta(int _cod_Produto, Guna2DataGridView _tabela)
        {
            try
            {
                if (VP.BuscarExistenciaProduto(_cod_Produto))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        string query = "select Cod_Produto,Descricao,Valor_Unitario" +
                            " from Estoque where Cod_Produto = @codProduto";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                        adapter.SelectCommand.Parameters.AddWithValue("@codProduto", _cod_Produto);

                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        _tabela.DataSource = dataTable;
                        _tabela.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Produto Não Encontrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Buscar Nota Fiscal de Saida Consulta

        // Buscar a quantidade da Nota Fiscal de Saida, usado para cancelamento

        #region Buscar Nota Fiscal de Saida Quantidade

        public List<int> BuscarNFSaidaQuantidade(int _nf_Saida, int _cod_Produto)
        {
            try
            {
                List<int> QuantidadeProduto = new List<int>();

                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select Quantidade from NF_Saida where NF_Saida = @nfsaida and Cod_Produto = @codProduto";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@nfsaida", _nf_Saida);
                    adapter.SelectCommand.Parameters.AddWithValue("@codProduto", _cod_Produto);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        QuantidadeProduto.Add(dr.GetInt32(0));
                    }

                    return QuantidadeProduto;
                }
            }
            catch (Exception x)
            {
                return new List<int>();

                MessageBox.Show(x.ToString());
            }
        }

        #endregion Buscar Nota Fiscal de Saida Quantidade

        // Buscar o codigo do produto da NF de saida que vai ser excluida

        #region Bucar Nota Fiscal de Saida Produto

        public List<int> BuscarNFSaidaCodProduto(int _nf_Saida)
        {
            try
            {
                List<int> CodProduto = new List<int>();

                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select Cod_Produto from NF_Saida where NF_Saida = @nfsaida";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@nfsaida", _nf_Saida);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        CodProduto.Add(dr.GetInt32(0));
                    }

                    return CodProduto;
                }
            }
            catch (Exception x)
            {
                return new List<int>();

                MessageBox.Show(x.ToString());
            }
        }

        #endregion Bucar Nota Fiscal de Saida Produto
    }
}