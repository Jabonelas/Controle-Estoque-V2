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
    internal class BuscarDadosFornecedor : ConectarBanco
    {
        private VerificacaoDeExistencia VF = new VerificacaoDeExistencia();

        public void BuscarFornecedor(string _cNPJ, GunaDataGridView _tabela)
        {
            try
            {
                if (VF.BuscarExistenciaFornecedor(_cNPJ))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        //SqlDataReader reader;
                        string query = "select * from Fornecedor where CNPJ =@cNPJ";
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
                    MessageBox.Show("Fornecedor Não Encontrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}