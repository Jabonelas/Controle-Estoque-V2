using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Control.Dados
{
    internal class InserirDados : ConectarBanco
    {
        public void InserirCliente(int _codProduto, string _nomeFantasia, DateTime _cadastro, int _cNPJ, string _razaoSocial,
            int _cEP, string _uF, string _cidade, string _endereco, int _numero, string _complemento, string _bairro)
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "insert into Clientes(CodDoProduto,NomeFantasia,Cadastro,CNPJ,RazaoSocial,CEP,UF,Cidade,Endereco,Numero,Complemento,Bairro) " +
               "values(@codproduto,@nomefantasia,@cadastro,@cnpj,@razaosocial,@cep,@uf,@cidade,@endereco,@numero,@complemento,@bairro) ";

                SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                cmd.Parameters.Add("@codproduto", SqlDbType.Int).Value = _codProduto;
                cmd.Parameters.Add("@nomefantasia", SqlDbType.VarChar).Value = _nomeFantasia;
                cmd.Parameters.Add("@cadastro", SqlDbType.DateTime).Value = _cadastro;
                cmd.Parameters.Add("@cnpj", SqlDbType.Int).Value = _cNPJ;
                cmd.Parameters.Add("@razaosocial", SqlDbType.VarChar).Value = _razaoSocial;
                cmd.Parameters.Add("@cep", SqlDbType.Int).Value = _cEP;
                cmd.Parameters.Add("@uf", SqlDbType.VarChar).Value = _uF;
                cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = _cidade;
                cmd.Parameters.Add("@endereco", SqlDbType.VarChar).Value = _endereco;
                cmd.Parameters.Add("@numero", SqlDbType.Int).Value = _numero;
                cmd.Parameters.Add("@complemento", SqlDbType.VarChar).Value = _complemento;
                cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = _bairro;

                cmd.ExecuteNonQuery();
            }
        }
    }
}