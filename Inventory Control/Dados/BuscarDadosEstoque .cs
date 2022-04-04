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

namespace Inventory_Control.Dados
{
    internal class BuscarDadosEstoque : ConectarBanco
    {
        private VerificacaoDeExistencia VCP = new VerificacaoDeExistencia();
        private VerificacaoDeExistencia VCB = new VerificacaoDeExistencia();

        #region Buscar Codigo do Produto

        public void BuscarCodDoProduto(int _cod_Produto, Guna2DataGridView _tabela)
        {
            try
            {
                if (VCP.BuscarExistenciaProduto(_cod_Produto))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        string query = "select * from Estoque where Cod_Produto = @codproduto" +
                            " and Local <> 'TRANSITO' and Local <> 'EXCLUIDA' " +
                            "and Quantidade > 0 ";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                        adapter.SelectCommand.Parameters.AddWithValue("@codproduto", _cod_Produto);

                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        _tabela.DataSource = dataTable;
                        _tabela.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Produto Não Encontrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Buscar Codigo do Produto

        #region Bucar Codigo de Barras

        #region Buscar por Codigo de Barras para preencher o GridView

        public void BuscarCodBarras(int _cod_De_Barras, Guna2DataGridView _tabela)
        {
            try
            {
                if (VCB.BuscarExistenciaCodigoDeBarras(_cod_De_Barras))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        string query = "select * from Estoque where Cod_de_Barras = @codDeBarras ";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                        adapter.SelectCommand.Parameters.AddWithValue("@codDeBarras", _cod_De_Barras);

                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        _tabela.DataSource = dataTable;
                        _tabela.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Codigo de Barras Não Encontrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Buscar por Codigo de Barras para preencher o GridView

        #region Buscar o Codigo de Barras da Vez

        // Buscar o codigo de barras da vez para seguir o FIFO na transferencia de local
        public int BuscarCodBarrasDaVez(int _cod_de_Barras)

        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select MIN(Cod_de_Barras) from Estoque where Local <> 'EXPEDICAO' " +
                        "and Local<> 'EXCLUIDA' and Local<> 'FATURADA' and " +
                        "Cod_Produto = (select Cod_Produto from Estoque where Cod_de_Barras = @codDeBarras)";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@codDeBarras", _cod_de_Barras);
                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    int x = dr.GetInt32(0);
                    return x;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return 0;
            }
        }

        #endregion Buscar o Codigo de Barras da Vez

        #endregion Bucar Codigo de Barras

        #region Buscar Lote

        public string BuscarLote(int _cod_De_Barras)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select Lote from Estoque where Cod_De_Barras = @codDeBarras";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@codDeBarras", _cod_De_Barras);
                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    DateTime x = dr.GetDateTime(0);
                    return x.ToShortDateString();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return "";
            }
        }

        #endregion Buscar Lote

        #region Buscar Codigo do Produto TextBox

        public string BuscarCodProdutoTextBox(int _cod_De_Barras)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select Cod_Produto from Estoque where Cod_De_Barras = @codDeBarras";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@codDeBarras", _cod_De_Barras);
                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    int x = dr.GetInt32(0);
                    return x.ToString();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return "";
            }
        }

        #endregion Buscar Codigo do Produto TextBox

        #region Buscar Descrição

        public string BuscarDescricao(int _cod_De_Barras) //usado na aba Suprimento tranferencias
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select Descricao from Estoque where Cod_De_Barras = @codDeBarras";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@codDeBarras", _cod_De_Barras);
                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    string x = dr.GetString(0);
                    return x.ToString();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return "";
            }
        }

        public string BuscarDescricaoNFSaida(int _cod_Produto) //usado na aba Vendas
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select Descricao from Estoque where Cod_Produto = @codProduto";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@codProduto", _cod_Produto);
                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    string x = dr.GetString(0);
                    return x.ToString();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                return "";
            }
        }

        #endregion Buscar Descrição

        #region Buscar Quantidade

        // Buscar a quantidade por codigo de barras, para informar a quantidade na etiqueta

        #region Buscar Quantidade por Codigo de Barras

        public string BuscarQuantidade(int _cod_De_Barras)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select Quantidade from Estoque where Cod_De_Barras = @codDeBarras";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@codDeBarras", _cod_De_Barras);
                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    int x = dr.GetInt32(0);
                    return x.ToString();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return "";
            }
        }

        #endregion Buscar Quantidade por Codigo de Barras

        // Buscar a quantidade por codigo de barras, para preencher a lista

        #region Buscar Quantidade Estoque

        public List<int> BuscarQuantidadeEstoque(int _cod_De_Barras)
        {
            try
            {
                List<int> QuantidadeEstoque = new List<int>();

                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select Quantidade from Estoque where Cod_De_Barras = @codDeBarras";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@codDeBarras", _cod_De_Barras);
                    //adapter.SelectCommand.Parameters.AddWithValue("@codProduto", _cod_Produto);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        QuantidadeEstoque.Add(dr.GetInt32(0));
                    }

                    return QuantidadeEstoque;
                }
            }
            catch (Exception x)
            {
                return new List<int>();

                MessageBox.Show(x.ToString());
            }
        }

        #endregion Buscar Quantidade Estoque

        // Buscar quantiade para verificar se ainda possui saldo na etiqueta

        #region Buscar Quantidade verificando saldo

        public int BuscarQuantidadeValida(int _cod_Produto)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select Quantidade from Estoque where Cod_De_Barras = " +
                        "(select MIN(Cod_de_Barras) from Estoque where Cod_Produto = @codProduto " +
                        "and Local = 'EXPEDICAO')";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@codProduto", _cod_Produto);
                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    int x = dr.GetInt32(0);
                    return x;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return 0;
            }
        }

        #endregion Buscar Quantidade verificando saldo

        #endregion Buscar Quantidade

        #region Buscar Local

        public string BuscarLocal(int _cod_De_Barras)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select Local from Estoque where Cod_De_Barras = @codDeBarras";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@codDeBarras", _cod_De_Barras);
                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    string x = dr.GetString(0);
                    return x.ToString();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return "";
            }
        }

        #endregion Buscar Local

        #region Buscar Local Estoque

        public List<string> BuscarLocalEstoque(int _nf_Entrada, int _cod_De_Barras)
        {
            try
            {
                List<string> LocalProduto = new List<string>();

                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select Local from Estoque where NF_Entrada = @nfentrada and Cod_de_Barras = @codDeBarras " +
                        "and Quantidade > 0";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@nfentrada", _nf_Entrada);
                    adapter.SelectCommand.Parameters.AddWithValue("@codDeBarras", _cod_De_Barras);

                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        LocalProduto.Add(dr.GetString(0));
                    }

                    return LocalProduto;
                }
            }
            catch (Exception x)
            {
                return new List<string>();

                MessageBox.Show(x.ToString());
            }
        }

        #endregion Buscar Local Estoque
    }
}