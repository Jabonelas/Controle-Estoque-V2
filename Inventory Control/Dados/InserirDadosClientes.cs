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
    internal class InserirDadosClientes : ConectarBanco
    {
        public void InserirClientes(int _codProduto, string _nomeFantasia, DateTime _cadastro, string _cNPJ, string _razaoSocial,
            string _cEP, string _uF, string _cidade, string _endereco, int _numero, string _complemento, string _bairro, GunaDataGridView _tabela)
        {
            using (SqlConnection conexaoSQL = AbrirConexao())
            {
                string query = "insert into Clientes(Cod_Do_Produto,Nome_Fantasia,Data_Cadastro,CNPJ,Razao_Social,CEP,UF,Cidade,Endereco,Numero,Complemento,Bairro) " +
               "values(@codproduto,@nomefantasia,@cadastro,@cnpj,@razaosocial,@cep,@uf,@cidade,@endereco,@numero,@complemento,@bairro) select * from Clientes where CNPJ = @cnpj";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                adapter.SelectCommand.Parameters.AddWithValue("@codproduto", SqlDbType.Int).Value = _codProduto;
                adapter.SelectCommand.Parameters.AddWithValue("@nomefantasia", SqlDbType.VarChar).Value = _nomeFantasia;
                adapter.SelectCommand.Parameters.AddWithValue("@cadastro", SqlDbType.DateTime).Value = _cadastro;
                adapter.SelectCommand.Parameters.AddWithValue("@cnpj", SqlDbType.VarChar).Value = _cNPJ;
                adapter.SelectCommand.Parameters.AddWithValue("@razaosocial", SqlDbType.VarChar).Value = _razaoSocial;
                adapter.SelectCommand.Parameters.AddWithValue("@cep", SqlDbType.VarChar).Value = _cEP;
                adapter.SelectCommand.Parameters.AddWithValue("@uf", SqlDbType.VarChar).Value = _uF;
                adapter.SelectCommand.Parameters.AddWithValue("@cidade", SqlDbType.VarChar).Value = _cidade;
                adapter.SelectCommand.Parameters.AddWithValue("@endereco", SqlDbType.VarChar).Value = _endereco;
                adapter.SelectCommand.Parameters.AddWithValue("@numero", SqlDbType.Int).Value = _numero;
                adapter.SelectCommand.Parameters.AddWithValue("@complemento", SqlDbType.VarChar).Value = _complemento;
                adapter.SelectCommand.Parameters.AddWithValue("@bairro", SqlDbType.VarChar).Value = _bairro;

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                _tabela.DataSource = dataTable;
                _tabela.Refresh();
            }
        }
    }
}