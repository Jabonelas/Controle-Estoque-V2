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
    internal class DeletarNotaFiscalSaida : ConectarBanco
    {
        private VerificacaoDeExistencia VNFS = new VerificacaoDeExistencia();
        private VerificacaoDeExistencia BNF = new VerificacaoDeExistencia();

        #region Deletar Nota Fiscal de Saida Já Confirmada

        public void DeletarNFSaida(int _nota_Fiscal, Guna2DataGridView _tabela)
        {
            try
            {
                if (VNFS.BuscarExistenciaNotaFiscalSaida(_nota_Fiscal))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        BNF.BuscarExistenciaNotaFiscalSaida(_nota_Fiscal);

                        DialogResult OpcaoDoUsuario = new DialogResult();
                        OpcaoDoUsuario = MessageBox.Show("Deseja Excluir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (OpcaoDoUsuario == DialogResult.Yes)
                        {
                            string query = "update NF_Saida set Estatus = 'CANCELADA' where NF_Saida = @nfsaida";
                            SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                            adapter.SelectCommand.Parameters.AddWithValue("@nfsaida", _nota_Fiscal);

                            DataTable dataTable = new DataTable();

                            adapter.Fill(dataTable);
                            _tabela.DataSource = dataTable;
                            _tabela.Refresh();

                            MessageBox.Show("Nota Fical Excluida Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nota Fiscal Não Encontrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Deletar Nota Fiscal de Saida Já Confirmada

        #region Cancelar Nota Fiscal de Saida que ainda não foram confirmadas

        public void CancelarNFSaida(int _nota_Fiscal)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "delete NF_Saida where NF_Saida = @nfsaida";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.Add("@nfsaida", SqlDbType.VarChar).Value = _nota_Fiscal;
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Cancelar Nota Fiscal de Saida que ainda não foram confirmadas
    }
}