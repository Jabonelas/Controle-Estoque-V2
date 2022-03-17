using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Control.Dados
{
    internal class InserirDadosEstoque : ConectarBanco
    {
        private VerificacaoDeExistencia VNF = new VerificacaoDeExistencia();

        public void InserirEstoque(int _nota_Fiscal)
        {
            if (VNF.BuscarExistenciaNotaFiscal(_nota_Fiscal))
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "INSERT INTO Estoque(Cod_Produto,Lote, Descricao, Quantidade, Local) " +
                        "SELECT  Cod_Produto,Data_Lancamento,Descricao_Produto, QUANT, Estatus FROM NF where NF = @nF";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@nF", _nota_Fiscal);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Se apareceu aqui deu certo", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nota Fiscal Não Encontrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}