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

        //Realizar a movimentacao na quantidade do Estoque com forme a Nota Fiscal de Saida
        // Tirando a quantidade

        public void AlterarQuantidadeEstoqueSubtracao(int _cod_Produto, int _quantidade)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update Estoque set Quantidade=(Quantidade - @quantidadeNFS) where Cod_Produto = @codProduto";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.Add("@codProduto", SqlDbType.VarChar).Value = _cod_Produto;
                    cmd.Parameters.Add("@quantidadeNFS", SqlDbType.Int).Value = _quantidade;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        public void AlterarQuantidadeEstoqueAdicao(int _nf_Saida)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update Estoque  set Quantidade = (Quantidade +" +
                        " (select B.Quantidade from  NF_Saida B " +
                        "where Cod_Produto = B.Cod_Produto and B.NF_Saida = @nfsaida ))";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.Add("@nfsaida", SqlDbType.VarChar).Value = _nf_Saida;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}