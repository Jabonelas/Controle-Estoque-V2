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
    internal class DeletarDadosProduto : ConectarBanco
    {
        public void DeletarProduto(int _cod_Produto)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "delete from Produto where Cod_Produto = @codproduto";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.Add("@codproduto", SqlDbType.Int).Value = _cod_Produto;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
    }
}