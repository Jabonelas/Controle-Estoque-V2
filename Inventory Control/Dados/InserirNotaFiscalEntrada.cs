using Guna.UI2.WinForms;
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
    internal class InserirNotaFiscalEntrada : ConectarBanco
    {
        public void InserirNotaFiscal(int _nF, Guna2DataGridView _tabela)
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "update NF set Estatus = 'RECEBIMENTO'  where NF = @nF  select * from NF where NF = @nF ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                adapter.SelectCommand.Parameters.AddWithValue("@nF", _nF);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                _tabela.DataSource = dataTable;
                _tabela.Refresh();

                MessageBox.Show("Nota Fiscal Incluida Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}