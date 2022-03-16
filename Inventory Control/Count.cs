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

        public string ContarCliente()
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "select IDENT_CURRENT('Clientes')";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                dr.Read();

                Decimal x = dr.GetDecimal(0);
                return (x + 1).ToString();
            }
        }

        #endregion Clinete

        #region Fornecedor

        public string ContarFornecedor()
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "select IDENT_CURRENT('Fornecedor')";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                dr.Read();

                Decimal x = dr.GetDecimal(0);
                return (x + 1).ToString();
            }
        }

        #endregion Fornecedor

        #region Produto

        public string ContarProduto()
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "select IDENT_CURRENT('Produto')";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                dr.Read();

                Decimal x = dr.GetDecimal(0);
                return (x + 1).ToString();
            }
        }

        #endregion Produto

        #region Nota Fiscal Entrada

        public string ContarNFEntrada()
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "select IDENT_CURRENT('NF')";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                dr.Read();

                Decimal x = dr.GetDecimal(0);
                return (x + 1).ToString("D8");
            }
        }

        #endregion Nota Fiscal Entrada
    }
}