using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Control.Dados
{
    internal class InserirDadosProduto : ConectarBanco
    {
        public void InserirProduto(string _fornecedor, DateTime _data_Cadastro, string _cNPJ, int _cod_Produto, string _descricao, string _unidade, double _preco_Unitario)
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "insert into Produto(Fornecedor,Data_Cadastro,CNPJ,Descricao,Medidda,Preco_Unitario) " +
               "values(@fornecedor,@datacadastro,@cnpj,@descricao,@unidade,@precounitario) ";
                //            string query = "insert into Produto(Fornecedor,Data_Cadastro,CNPJ,Cod_Produto,Descricao,Medidda,Preco_Unitario) " +
                //"values(@fornecedor,@datacadastro,@cnpj,@codproduto,@descricao,@unidade,@precounitario) ";

                SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                cmd.Parameters.Add("@fornecedor", SqlDbType.VarChar).Value = _fornecedor;
                cmd.Parameters.Add("@datacadastro", SqlDbType.Date).Value = _data_Cadastro;
                cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = _cNPJ;
                //cmd.Parameters.Add("@codproduto", SqlDbType.Int).Value = _cod_Produto;
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = _descricao;
                cmd.Parameters.Add("@unidade", SqlDbType.VarChar).Value = _unidade;
                cmd.Parameters.Add("@precounitario", SqlDbType.Real).Value = _preco_Unitario;

                cmd.ExecuteNonQuery();
            }
        }
    }
}