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
    internal class BuscarNotaFiscalEntrada : ConectarBanco
    {
        private VerificacaoDeExistencia VNF = new VerificacaoDeExistencia();

        #region Buscar Nota Fiscal Entrada

        public void BuscarNotaFiscal(int _nota_Fiscal, Guna2DataGridView _tabela)
        {
            try
            {
                if (VNF.BuscarExistenciaNotaFiscalEntrada(_nota_Fiscal))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        string query = "select * from NF where NF = @nF";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                        adapter.SelectCommand.Parameters.AddWithValue("@nF", _nota_Fiscal);

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

        #endregion Buscar Nota Fiscal Entrada

        // Buscar o codigo do produto da NF de entrada que vai ser excluida

        #region Buscar Nota Fiscal Entrada Codigo Produto

        public List<int> BuscarNFEntradaCodProduto(int _nf_Entrada)
        {
            try
            {
                List<int> CodProduto = new List<int>();

                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select Cod_Produto from NF where NF = @nfentrada";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@nfentrada", _nf_Entrada);

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

        #endregion Buscar Nota Fiscal Entrada Codigo Produto

        // Buscar a quantidade da Nota Fiscal de entrda, usado para cancelamento

        #region Buscar Nota Fiscal Entrada Quantidade

        public List<int> BuscarNFEntradaQuantidade(int _nf_Entrada, int _cod_Produto)
        {
            try
            {
                List<int> QuantidadeProduto = new List<int>();

                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select QUANT from NF where NF = @nfentrada and Cod_Produto = @codProduto";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@nfentrada", _nf_Entrada);
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

        #endregion Buscar Nota Fiscal Entrada Quantidade

        //// Buscar o numero do Codigo de barras para prencher Nota Fiscal de entrda, usado para cancelamento

        #region Buscar Numero da Codigo de Barras Nota Fiscal Entrada

        public List<int> BuscarNFEntradaCodBarras(int _nf_Entrada, int _cod_Produto)
        {
            try
            {
                List<int> QuantidadeProduto = new List<int>();

                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select Cod_de_Barras from Estoque where NF_Entrada = @nfentrada and Cod_Produto = @codProduto " +
                        "and Quantidade > 0";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@nfentrada", _nf_Entrada);
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

        #endregion Buscar Numero da Codigo de Barras Nota Fiscal Entrada
    }
}