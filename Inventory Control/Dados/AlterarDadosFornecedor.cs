using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Control
{
    internal class AlterarDadosFornecedor : ConectarBanco
    {
        private VerificacaoDeExistencia VF = new VerificacaoDeExistencia();

        public void AlterarFornecedor(int _codProduto, string _nomeFantasia, DateTime _cadastro, string _cNPJ, string _razaoSocial,
          string _cEP, string _uF, string _cidade, string _endereco, int _numero, string _complemento, string _bairro)
        {
            try
            {
                if (VF.BuscarExistenciaFornecedor(_cNPJ))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        string query = "update Fornecedor set ID_Fornecedor=@codproduto,Nome_Fantasia = @nomeFantasia,Data_Cadastro = @cadastro,CNPJ = @cNPJ," +
                        "Razao_Social=@razaoSocial,CEP = @cEP,UF=@uF,Cidade=@cidade,Endereco=@endereco,Numero=@numero," +
                        "Complemento=@complemento,Bairro=@bairro where CNPJ = @cNPJ ";

                        SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                        cmd.Parameters.Add("@codproduto", SqlDbType.Int).Value = _codProduto;
                        cmd.Parameters.Add("@nomefantasia", SqlDbType.VarChar).Value = _nomeFantasia;
                        cmd.Parameters.Add("@cadastro", SqlDbType.DateTime).Value = _cadastro;
                        cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = _cNPJ;
                        cmd.Parameters.Add("@razaosocial", SqlDbType.VarChar).Value = _razaoSocial;
                        cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = _cEP;
                        cmd.Parameters.Add("@uf", SqlDbType.VarChar).Value = _uF;
                        cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = _cidade;
                        cmd.Parameters.Add("@endereco", SqlDbType.VarChar).Value = _endereco;
                        cmd.Parameters.Add("@numero", SqlDbType.Int).Value = _numero;
                        cmd.Parameters.Add("@complemento", SqlDbType.VarChar).Value = _complemento;
                        cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = _bairro;

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Modificação Realizada Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Fornecedor Não Encontrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
            }
        }
    }
}