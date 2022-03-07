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
    internal class DeletarDadosClientes : ConectarBanco
    {
        private VerificacaoDeExistencia VC = new VerificacaoDeExistencia();
        private BuscarDadosClientes BC = new BuscarDadosClientes();

        public void DeletarClientes(string _cNPJ, GunaDataGridView _tabela)
        {
            try
            {
                //using (SqlConnection conexaoSQL = AbrirConexao())
                //{
                //string query = "delete from Clientes where CNPJ = @CNPJ";

                //SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                //cmd.Parameters.Add("@CNPJ", SqlDbType.VarChar).Value = _cNPJ;
                //cmd.ExecuteNonQuery();

                if (VC.BuscarExistenciaCliente(_cNPJ))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        BC.BuscarClientes(_cNPJ, _tabela);

                        DialogResult OpcaoDoUsuario = new DialogResult();
                        OpcaoDoUsuario = MessageBox.Show("Deseja Excluir o Cliente?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (OpcaoDoUsuario == DialogResult.Yes)
                        {
                            string query = "delete from Clientes where CNPJ = @CNPJ";
                            SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                            cmd.Parameters.AddWithValue("@cNPJ", _cNPJ);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Cliente Excluido Com Sucesso", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cliente Não Encontrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //}
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
    }
}