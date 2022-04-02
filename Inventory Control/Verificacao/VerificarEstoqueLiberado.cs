using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Control.Verificacao
{
    internal class VerificarEstoqueLiberado : ConectarBanco
    {
        public bool VerificarLocalEstoque(int _cod_Produto)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    bool isExist = false;
                    string query = "select Local from Estoque where Cod_Produto = @codProduto and Local = 'EXPEDICAO'";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    SqlDataReader reader;
                    cmd.Parameters.AddWithValue("@codProduto", _cod_Produto);
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

            //try
            //{
            //    using (SqlConnection conexaoSQL = AbrirConexao())
            //    {
            //        string query = "select Local from Estoque where Cod_Produto = @codProduto " +
            //            "and Local = 'EXPEDICAO' and Cod_de_Barras = " +
            //            "(select MIN(Cod_de_Barras) from Estoque where Local = 'EXPEDICAO')";
            //        SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
            //        adapter.SelectCommand.Parameters.AddWithValue("@codProduto", _cod_Produto);
            //        SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
            //        dr.Read();

            //        string x = dr.GetString(0);
            //        return x;
            //    }
            //}
            //catch (Exception x)
            //{
            //    MessageBox.Show(x.ToString());
            //    return "";
            //}
        }
    }
}