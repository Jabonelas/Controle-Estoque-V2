using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Control.Dados
{
    internal class InserirDadosEstoque : ConectarBanco
    {
        private VerificacaoDeExistencia VNF = new VerificacaoDeExistencia();

        public void InserirEstoque(int _nota_Fiscal)
        {
            if (VNF.BuscarExistenciaNotaFiscalEntrada(_nota_Fiscal))
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "INSERT INTO Estoque(NF_Entrada,Cod_Produto,Lote, Descricao, Quantidade, Local,Valor_Unitario,Valor_Total) " +
                        "SELECT  NF,Cod_Produto,Data_Lancamento,Descricao_Produto, QUANT, Estatus,Valor_Unitario,Valor_Total" +
                        " FROM NF where NF = @nF";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.AddWithValue("@nF", _nota_Fiscal);

                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                //MessageBox.Show("Nota Fiscal Não Encontrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}