using Guna.UI2.WinForms;
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
    internal class DeletarNotaFiscalEntrada : ConectarBanco
    {
        private VerificacaoDeExistencia VNF = new VerificacaoDeExistencia();
        private VerificacaoDeExistencia BNF = new VerificacaoDeExistencia();

        public void DeletarNotaFiscal(int _nota_Fiscal, Guna2DataGridView _tabela)
        {
            try
            {
                //string query = "update NF set Estatus = 'TRANSITO' where NF = @nF";

                if (VNF.BuscarExistenciaNotaFiscal(_nota_Fiscal))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        //SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                        //cmd.Parameters.Add("@nF", SqlDbType.Int).Value = _nota_Fiscal;
                        //cmd.ExecuteNonQuery();
                        //MessageBox.Show("Nota Fical Excluida Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //string query = "select * from NF where NF = @nF";

                        BNF.BuscarExistenciaNotaFiscal(_nota_Fiscal);

                        DialogResult OpcaoDoUsuario = new DialogResult();
                        OpcaoDoUsuario = MessageBox.Show("Deseja Excluir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (OpcaoDoUsuario == DialogResult.Yes)
                        {
                            string query = "update NF set Estatus = 'TRANSITO'  where NF = @nF  select NF,CNPJ,Nome_Razao_Social,Cod_Produto,Descricao_Produto,QUANT,UNIDADE,Valor_Unitario,Valor_Total,Data_Emissao,Data_Lancamento,Estatus from NF where NF = @nF ";
                            SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                            adapter.SelectCommand.Parameters.AddWithValue("@nF", _nota_Fiscal);

                            DataTable dataTable = new DataTable();

                            adapter.Fill(dataTable);
                            _tabela.DataSource = dataTable;
                            _tabela.Refresh();

                            MessageBox.Show("Nota Fical Excluida Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nota Fiscal Não Encontrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}