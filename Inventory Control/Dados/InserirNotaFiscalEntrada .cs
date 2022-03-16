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
        private VerificacaoDeExistencia VNF = new VerificacaoDeExistencia();

        public void InserirNotaFiscal(int _nota_Fiscal)
        {
            if (VNF.BuscarExistenciaNotaFiscal(_nota_Fiscal))
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update NF set Estatus = 'RECEBIMENTO' where NF = @nF" +
                        " update NF set Data_Lancamento = GETDATE() where NF = @nF  " +
                        " update NF set Cod_Barras = select IDENT_CURRENT('NF') where NF = @nF  ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@nF", _nota_Fiscal);

                    MessageBox.Show("Nota Fiscal Incluida Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nota Fiscal Não Encontrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}