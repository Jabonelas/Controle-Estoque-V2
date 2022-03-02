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
    internal class DeletarDadosClientes : ConectarBanco
    {
        public void DeletarClientes(string _cNPJ)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "delete from Clientes where CNPJ = @CNPJ";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.Add("@CNPJ", SqlDbType.VarChar).Value = _cNPJ;
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