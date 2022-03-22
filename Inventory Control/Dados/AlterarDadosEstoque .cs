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
    internal class AlterarDadosEstoque : ConectarBanco
    {
        private VerificacaoDeExistencia VE = new VerificacaoDeExistencia();

        public void AlterarEstoque(string _local, int _cod_de_barras)
        {
            try
            {
                if (VE.BuscarExistenciaCodigoDeBarras(_cod_de_barras))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        string query = "update Estoque set Local=@local where Cod_De_Barras = @codDeBarras";
                        SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                        cmd.Parameters.Add("@local", SqlDbType.VarChar).Value = _local;
                        cmd.Parameters.Add("@codDeBarras", SqlDbType.Int).Value = _cod_de_barras;

                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Codigo de Barras Não Encontrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}