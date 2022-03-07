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
    internal class DeletarDadosFornecedor : ConectarBanco
    {
        private VerificacaoDeExistencia VC = new VerificacaoDeExistencia();
        private BuscarDadosFornecedor BF = new BuscarDadosFornecedor();

        public void DeletarFornecedor(string _cNPJ, GunaDataGridView _tabela)
        {
            try
            {
                if (VC.BuscarExistenciaFornecedor(_cNPJ))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        BF.BuscarFornecedor(_cNPJ, _tabela);

                        DialogResult OpcaoDoUsuario = new DialogResult();
                        OpcaoDoUsuario = MessageBox.Show("Deseja Excluir o Fornecedor?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (OpcaoDoUsuario == DialogResult.Yes)
                        {
                            string query = "delete from Fornecedor where CNPJ = @CNPJ";
                            SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                            cmd.Parameters.AddWithValue("@cNPJ", _cNPJ);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Fornecedor Excluido Com Sucesso", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Fornecedor Não Encontrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}