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
        #region Inserir dados na Nota Fiscal de Saida

        public void InserirNFSaida(int _cod_Produto)
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "INSERT INTO NF_Saida(Cod_Produto,Lote,Descricao,Valor,Cod_de_Barras)" +
                    "SELECT Cod_Produto,Lote,Descricao,Valor_Unitario,Cod_de_Barras" +
                    " FROM Estoque where Cod_Produto = @codproduto and Cod_de_Barras = " +
                    "(select MIN(Cod_de_Barras) from Estoque where Cod_Produto = @codproduto " +
                    "and Local = 'EXPEDICAO')";

                SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                cmd.Parameters.AddWithValue("@codproduto", _cod_Produto);

                cmd.ExecuteNonQuery();
            }
        }

        #endregion Inserir dados na Nota Fiscal de Saida

        #region Atualizacao dos dados em Nota Fiscal Saida

        // feita para preencher a quantidade, a data de emissao e o valor da Nota Fiscal que foi feita
        public void InserirNFSaidaIncremento(int _nf_Saida, int _quantidade, DateTime _emissao)
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "update NF_Saida set NF_Saida = @nfsaida,Quantidade = @quantidade, " +
                    "Emissao = @emissao, Valor = (Valor * @quantidade), Estatus = 'FATURADA'" +
                   " where NF_Saida is null";
                SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                cmd.Parameters.AddWithValue("@nfsaida", _nf_Saida);
                cmd.Parameters.AddWithValue("@quantidade", _quantidade);
                cmd.Parameters.AddWithValue("@emissao", _emissao);

                cmd.ExecuteNonQuery();
            }
        }

        #endregion Atualizacao dos dados em Nota Fiscal Saida
    }
}