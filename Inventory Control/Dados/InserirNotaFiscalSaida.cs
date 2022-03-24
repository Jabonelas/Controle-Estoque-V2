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
    internal class InserirNotaFiscalSaida : ConectarBanco
    {
        public void InserirNFSaida(int _cod_Produto)
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "INSERT INTO NF_Saida(Cod_Produto,Lote,Descricao,Valor)" +
                    "SELECT Cod_Produto,Lote,Descricao,Valor_Unitario" +
                    " FROM Estoque where Cod_Produto = @codproduto";

                SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                cmd.Parameters.AddWithValue("@codproduto", _cod_Produto);

                cmd.ExecuteNonQuery();
            }
        }

        // feita para preencher a quantidade, emissao e o valor
        public void InserirNFSaidaIncremento(int _nf_Saida, int _quantidade, DateTime _emissao)
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "update NF_Saida set Quantidade=@quantidade, Emissao=@emissao, Valor=(Valor* @quantidade)" +
                    " where NF_Saida = @nfsaida";
                SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                cmd.Parameters.AddWithValue("@nfsaida", _nf_Saida);
                cmd.Parameters.AddWithValue("@quantidade", _quantidade);
                cmd.Parameters.AddWithValue("@emissao", _emissao);

                cmd.ExecuteNonQuery();
            }
        }

        public void InserirNFSaidaNumeroDeNF(int _nf_Saida)
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "insert into NF_Saida(NF_Saida) values(@nfSaida)";
                SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                cmd.Parameters.AddWithValue("@nfsaida", _nf_Saida);

                cmd.ExecuteNonQuery();
            }
        }
    }
}