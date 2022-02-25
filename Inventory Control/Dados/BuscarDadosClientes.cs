using Guna.UI.WinForms;
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
    internal class BuscarDadosClientes : ConectarBanco
    {
        public void BuscarClientes(string _cNPJ, GunaDataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    //SqlDataReader reader;
                    string query = "select * from Clientes where CNPJ ='_cNPJ'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    _tabela.DataSource = dataTable;
                    _tabela.Refresh();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}