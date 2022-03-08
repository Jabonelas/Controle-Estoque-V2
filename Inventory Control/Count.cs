using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Control
{
    internal class Count : ConectarBanco
    {
        #region Clinete

        public int ContarCliente(string _cNPJ)
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "select IDENT_CURRENT('Clientes')";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                adapter.SelectCommand.Parameters.AddWithValue("@cNPJ", _cNPJ);

                SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                dr.Read();

                int x = dr.GetInt32(0);
                return x;
            }
        }

        #endregion Clinete

        #region Fornecedor

        public int ContarFornecedor(string _cNPJ)
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "select IDENT_CURRENT('Fornecedor')";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                adapter.SelectCommand.Parameters.AddWithValue("@cNPJ", _cNPJ);

                SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                dr.Read();

                int x = dr.GetInt32(0);
                return x;
            }
        }

        #endregion Fornecedor

        #region Produto

        public int ContarProduto(string _cNPJ)
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "select IDENT_CURRENT('Produto')";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                adapter.SelectCommand.Parameters.AddWithValue("@cNPJ", _cNPJ);

                SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                dr.Read();

                int x = dr.GetInt32(0);
                return x;
            }
        }

        #endregion Produto
    }
}