using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Control
{
    internal class ConectarBanco
    {
        private SqlConnection con = null;

        public SqlConnection AbrirConexao()
        {
            try
            {
                string conexaoString = "Server=DESKTOP-V79P1T3\\SQLEXPRESS;Database=Inventory_Control;Integrated Security=True;";
                con = new SqlConnection(conexaoString);
                con.Open();
                return con;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return con;
            }
        }
    }
}