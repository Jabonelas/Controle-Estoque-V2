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
    internal class DeletarDadosProduto : ConectarBanco
    {
        private VerificacaoDeExistencia VC = new VerificacaoDeExistencia();
        private BuscarDadosProduto BP = new BuscarDadosProduto();

        public void DeletarProduto(int _cod_Produto, GunaDataGridView _tabela)
        {
            try
            {
                if (VC.BuscarExistenciaProduto(_cod_Produto))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        BP.BuscarProduto(_cod_Produto, _tabela);

                        DialogResult OpcaoDoUsuario = new DialogResult();
                        OpcaoDoUsuario = MessageBox.Show("Deseja Excluir o Produto?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (OpcaoDoUsuario == DialogResult.Yes)
                        {
                            string query = "delete from Produto where Cod_Produto = @Cod_Produto";
                            SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                            cmd.Parameters.AddWithValue("@Cod_Produto", _cod_Produto);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Produto Excluido Com Sucesso", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Produto Não Encontrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}