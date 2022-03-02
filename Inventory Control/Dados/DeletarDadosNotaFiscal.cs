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
    internal class DeletarDadosNotaFiscal : ConectarBanco
    {
        public void DeletarClientes(int _nF)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "delete from NF where NF = @nF";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.Add("@nF", SqlDbType.Int).Value = _nF;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}