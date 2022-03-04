using Guna.UI.WinForms;
using Guna.UI2.WinForms;
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
    internal class BuscarNotaFiscalEntrada : ConectarBanco
    {
        public void BuscarNotaFiscal(int _nota_Fiscal, Guna2DataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "select * from NF where NF = @nF";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@nF", _nota_Fiscal);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    _tabela.DataSource = dataTable;
                    _tabela.Refresh();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

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
    }
}