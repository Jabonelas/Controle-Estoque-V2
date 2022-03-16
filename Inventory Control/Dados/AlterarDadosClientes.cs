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
    internal class AlterarDadosClientes : ConectarBanco
    {
        private VerificacaoDeExistencia VC = new VerificacaoDeExistencia();

        public DialogResult OpcaoDoUsuario { get; private set; }

        public void AlterarCliente(string _nomeFantasia, DateTime _cadastro, string _cNPJ, string _razaoSocial,
   string _cEP, string _uF, string _cidade, string _endereco, int _numero, string _complemento, string _bairro, GunaDataGridView _tabela)

        {
            try
            {
                if (VC.BuscarExistenciaCliente(_cNPJ))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        string query = "update Clientes set Nome_Fantasia = @nomeFantasia,Data_Cadastro = @cadastro,CNPJ = @cNPJ," +
                        "Razao_Social=@razaoSocial,CEP = @cEP,UF=@uF,Cidade=@cidade,Endereco=@endereco,Numero=@numero," +
                        "Complemento=@complemento,Bairro=@bairro where CNPJ = @cNPJ";

                        SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);

                        //adapter.SelectCommand.Parameters.AddWithValue("@codproduto", SqlDbType.Int).Value = _codProduto;
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

                        MessageBox.Show("Modificação Realizada Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                        //cmd.Parameters.Add("@codproduto", SqlDbType.Int).Value = _codProduto;
                        //cmd.Parameters.Add("@nomefantasia", SqlDbType.VarChar).Value = _nomeFantasia;
                        //cmd.Parameters.Add("@cadastro", SqlDbType.DateTime).Value = _cadastro;
                        //cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = _cNPJ;
                        //cmd.Parameters.Add("@razaosocial", SqlDbType.VarChar).Value = _razaoSocial;
                        //cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = _cEP;
                        //cmd.Parameters.Add("@uf", SqlDbType.VarChar).Value = _uF;
                        //cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = _cidade;
                        //cmd.Parameters.Add("@endereco", SqlDbType.VarChar).Value = _endereco;
                        //cmd.Parameters.Add("@numero", SqlDbType.Int).Value = _numero;
                        //cmd.Parameters.Add("@complemento", SqlDbType.VarChar).Value = _complemento;
                        //cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = _bairro;

                        //cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Cliente Não Encontrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}