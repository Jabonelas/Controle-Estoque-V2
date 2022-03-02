using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Control.Dados
{
    internal class AlterarDadosProduto : ConectarBanco
    {
        public void AlterarProduto(string _fornecedor, DateTime _data_Cadastro, string _cNPJ, int _cod_Produto, string _descrição,
            string _unidade, double _preco_Unidade)

        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "update Produto set Fornecedor=@fornecedor,Data_Cadastro = @data_Cadastro,CNPJ = @cNPJ," +
                "Cod_Produto=@cod_Produto,Descricao = @descricao,Medidda=@medidda,Preco_Unitario=@preco_Unitario where Cod_Produto = @cod_Produto";

                SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                cmd.Parameters.Add("@fornecedor", SqlDbType.VarChar).Value = _fornecedor;
                cmd.Parameters.Add("@data_Cadastro", SqlDbType.DateTime).Value = _data_Cadastro;
                cmd.Parameters.Add("@cNPJ", SqlDbType.VarChar).Value = _cNPJ;
                cmd.Parameters.Add("@cod_Produto", SqlDbType.Int).Value = _cod_Produto;
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = _descrição;
                cmd.Parameters.Add("@medidda", SqlDbType.VarChar).Value = _unidade;
                cmd.Parameters.Add("@preco_Unitario", SqlDbType.Real).Value = _preco_Unidade;

                cmd.ExecuteNonQuery();
            }
        }
    }
}