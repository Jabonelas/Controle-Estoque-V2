using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Control
{
    internal class VerificacaoDeExistencia : ConectarBanco
    {
        #region Cliente

        public bool BuscarExistenciaCliente(string _cNPJ)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    bool isExist = false;
                    string query = "select * from Clientes where CNPJ = @cNPJ";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    SqlDataReader reader;
                    cmd.Parameters.AddWithValue("@cnpj", _cNPJ);
                    reader = cmd.ExecuteReader();

                    reader.Read();

                    if (reader.HasRows == true)
                    {
                        isExist = true;
                    }
                    else
                    {
                        isExist = false;
                    }

                    return isExist;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return false;
            }
        }

        #endregion Cliente

        #region Fornecedor

        public bool BuscarExistenciaFornecedor(string _cNPJ)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    bool isExist = false;
                    string query = "select * from Fornecedor where CNPJ = @cNPJ";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    SqlDataReader reader;
                    cmd.Parameters.AddWithValue("@cnpj", _cNPJ);
                    reader = cmd.ExecuteReader();

                    reader.Read();

                    if (reader.HasRows == true)
                    {
                        isExist = true;
                    }
                    else
                    {
                        isExist = false;
                    }

                    return isExist;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return false;
            }
        }

        #endregion Fornecedor

        #region Produto

        public bool BuscarExistenciaProduto(int _cod_Produto)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    bool isExist = false;
                    string query = "select * from Produto where Cod_Produto = @cod_Produto";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    SqlDataReader reader;
                    cmd.Parameters.AddWithValue("@cod_Produto", _cod_Produto);
                    reader = cmd.ExecuteReader();

                    reader.Read();

                    if (reader.HasRows == true)
                    {
                        isExist = true;
                    }
                    else
                    {
                        isExist = false;
                    }

                    return isExist;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return false;
            }
        }

        #endregion Produto

        #region Nota Fiscal

        public bool BuscarExistenciaNotaFiscal(int _nota_Fiscal)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    bool isExist = false;
                    string query = "select * from NF where NF = @nF";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    SqlDataReader reader;
                    cmd.Parameters.AddWithValue("@nF", _nota_Fiscal);
                    reader = cmd.ExecuteReader();

                    reader.Read();

                    if (reader.HasRows == true)
                    {
                        isExist = true;
                    }
                    else
                    {
                        isExist = false;
                    }

                    return isExist;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return false;
            }
        }

        #endregion Nota Fiscal
    }
}