using Guna.UI.WinForms;
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
    internal class BuscarNotaFiscalSaida : ConectarBanco
    {
        private VerificacaoDeExistencia VNF = new VerificacaoDeExistencia();

        public void BuscarNFSaida(int _nota_Fiscal_Saida, Guna2DataGridView _tabela)
        {
            try
            {
                if (VNF.BuscarExistenciaNotaFiscal(_nota_Fiscal_Saida))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        string query = "select NF,CNPJ,Nome_Razao_Social,Cod_Produto,Descricao_Produto,QUANT,UNIDADE,Valor_Unitario,Valor_Total,Data_Emissao,Data_Lancamento,Estatus" +
                            " from NF_Saida where NF_Saida = @nF";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                        adapter.SelectCommand.Parameters.AddWithValue("@nF", _nota_Fiscal_Saida);

                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        _tabela.DataSource = dataTable;
                        _tabela.Refresh();
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