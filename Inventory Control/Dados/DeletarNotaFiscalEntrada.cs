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
        private BuscarNotaFiscalEntrada BDNF = new BuscarNotaFiscalEntrada();

        public void DeletarNotaFiscal(int _nF)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "delete from NF where NF = @nF";

                    if (BDNF.BuscarExistenciaNotaFiscal(_nF))
                    {
                        SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                        cmd.Parameters.Add("@nF", SqlDbType.Int).Value = _nF;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Nota Fical Excluida Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nota Fiscal Não Encontrada!");
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