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

        private VerificacaoDeExistencia VP = new VerificacaoDeExistencia();

        public void BuscarNFSaida(int _nota_Fiscal_Saida, Guna2DataGridView _tabela)
        {
            try
            {
                if (VNF.BuscarExistenciaNotaFiscalSaida(_nota_Fiscal_Saida))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        string query = "select NF_Saida,Cod_Produto,Lote,Descricao,Valor,Quantidade,Emissao" +
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

        public void BuscarNFSaidaConsulta(int _cod_Produto, Guna2DataGridView _tabela)
        {
            try
            {
                if (VP.BuscarExistenciaProduto(_cod_Produto))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        string query = "select Cod_Produto,Descricao,Valor_Unitario" +
                            " from Estoque where Cod_Produto = @codProduto";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                        adapter.SelectCommand.Parameters.AddWithValue("@codProduto", _cod_Produto);

                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        _tabela.DataSource = dataTable;
                        _tabela.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Produto Não Encontrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}