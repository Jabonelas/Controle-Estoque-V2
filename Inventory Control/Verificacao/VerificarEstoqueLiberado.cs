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
        public string VerificarLocalEstoque(int _cod_Produto)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select Local from Estoque where Cod_Produto = @codProduto";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@codProduto", _cod_Produto);
                    SqlDataReader dr = adapter.SelectCommand.ExecuteReader();
                    dr.Read();

                    string x = dr.GetString(0);
                    return x;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return "";
            }
        }
    }
}