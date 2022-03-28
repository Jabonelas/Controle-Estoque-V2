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
    internal class BuscarDadosRelatorioSaida : ConectarBanco
    {
        private VerificacaoDeExistencia VNFS = new VerificacaoDeExistencia(); // Verifiracao de Existencia de Nota Fiscal de Saida

        public void BuscarDadosRelatorioNFEntrada(DateTime _data_Inicial, DateTime _data_Final, Guna2DataGridView _tabela)
        {
            try
            {
                if (VNFS.BuscarExistenciaRelatorioNFSaida(_data_Inicial))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        string query = "select * from NF_Saida where Emissao >= @dataInical and Emissao <= @dataFinal";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                        adapter.SelectCommand.Parameters.AddWithValue("@dataInical", _data_Inicial);
                        adapter.SelectCommand.Parameters.AddWithValue("@dataFinal", _data_Final);

                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        _tabela.DataSource = dataTable;
                        _tabela.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Data de Entrada Não Encontrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}