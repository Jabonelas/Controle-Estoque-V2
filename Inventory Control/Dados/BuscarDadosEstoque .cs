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
        private SqlConnection conexaoSQL;

        #region Buscar Codigo do Produto

        public void BuscarCodDoProduto(int _cod_Produto, Guna2DataGridView _tabela)
        {
            try
            {
                if (VCP.BuscarExistenciaProduto(_cod_Produto))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        string query = "select * from Estoque where Cod_Produto = @codproduto and Local <> 'TRANSITO' " +
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
                MessageBox.Show(x.Message);
            }
        }

        #endregion Buscar Codigo do Produto

        #region Buscar Codigo de Barras

        public void BuscarCodBarras(int _cod_De_Barras, Guna2DataGridView _tabela)
        {
            try
            {
                if (VCB.BuscarExistenciaCodigoDeBarras(_cod_De_Barras))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        string query = "select * from Estoque where Cod_De_Barras = @codDeBarras ";
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
                MessageBox.Show(x.Message);
            }
        }

        #endregion Buscar Codigo de Barras

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
                MessageBox.Show(x.Message);
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
                MessageBox.Show(x.Message);
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
                MessageBox.Show(x.Message);
                return "";
            }
        }

        #endregion Buscar Quantidade por Codigo de Barras

        // Buscar quantiade para verificar se ainda possui saldo na etiqueta

        #region Buscar Quantidade verificando saldo

        public int BuscarQuantidadeValida()
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select Quantidade from Estoque where Cod_De_Barras = " +
                        "(select MIN(Cod_de_Barras) from Estoque where Local='EXPEDICAO')";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    //adapter.SelectCommand.Parameters.AddWithValue("@codDeBarras", _cod_De_Barras);
                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    int x = dr.GetInt32(0);
                    return x;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
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
                MessageBox.Show(x.Message);
                return "";
            }
        }

        #endregion Buscar Local
    }
}