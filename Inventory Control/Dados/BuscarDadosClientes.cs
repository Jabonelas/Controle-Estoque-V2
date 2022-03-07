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
        private VerificacaoDeExistencia VC = new VerificacaoDeExistencia();

        public void BuscarClientes(string _cNPJ, GunaDataGridView _tabela)
        {
            try
            {
                if (VC.BuscarExistenciaCliente(_cNPJ))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        string query = "select * from Clientes where CNPJ =@cNPJ";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                        adapter.SelectCommand.Parameters.AddWithValue("@cNPJ", _cNPJ);

                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        _tabela.DataSource = dataTable;
                        _tabela.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Cliente Não Encontrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}