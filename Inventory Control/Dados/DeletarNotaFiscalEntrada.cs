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
    internal class DeletarNotaFiscalEntrada : ConectarBanco
    {
        private VerificacaoDeExistencia VNF = new VerificacaoDeExistencia();

        public void DeletarNotaFiscal(int _nF, Guna2DataGridView _tabela)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    //string query = "update NF set Estatus = 'TRANSITO' where NF = @nF";

                    if (VNF.BuscarExistenciaNotaFiscal(_nF))
                    {
                        //SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                        //cmd.Parameters.Add("@nF", SqlDbType.Int).Value = _nF;
                        //cmd.ExecuteNonQuery();
                        //MessageBox.Show("Nota Fical Excluida Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //string query = "select * from NF where NF = @nF";
                        string query = "update NF set Estatus = 'TRANSITO'  where NF = @nF  select * from NF where NF = @nF ";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                        adapter.SelectCommand.Parameters.AddWithValue("@nF", _nF);

                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        _tabela.DataSource = dataTable;
                        _tabela.Refresh();

                        MessageBox.Show("Nota Fical Excluida Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nota Fiscal Não Encontrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}