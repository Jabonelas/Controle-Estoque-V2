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
    internal class BuscarUsuario : ConectarBanco
    {
        public bool Login(string _usuario, string _senha)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    bool isExist = false;
                    string query = "select * from Login where Usuario = @usuario and Senha = @senha";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    SqlDataReader reader;
                    cmd.Parameters.AddWithValue("@usuario", _usuario);
                    cmd.Parameters.AddWithValue("@senha", _senha);
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
    }
}