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

namespace Inventory_Control.Dados
{
    internal class BuscarDadosEstoque : ConectarBanco
    {
        private VerificacaoDeExistencia VCP = new VerificacaoDeExistencia();
        private VerificacaoDeExistencia VCB = new VerificacaoDeExistencia();

        public void BuscarCodDoProduto(int _cod_Produto, Guna2DataGridView _tabela)
        {
            try
            {
                if (VCP.BuscarExistenciaProduto(_cod_Produto))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        //SqlDataReader reader;
                        string query = "select * from Estoque where Cod_Produto = @codproduto";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                        adapter.SelectCommand.Parameters.AddWithValue("@codproduto", _cod_Produto);

                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        _tabela.DataSource = dataTable;
                        _tabela.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Produto Não Encontrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public void BuscarCodBarras(int _cod_De_Barras, Guna2DataGridView _tabela)
        {
            try
            {
                if (VCB.BuscarExistenciaCodigoDeBarras(_cod_De_Barras))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        //SqlDataReader reader;
                        string query = "select * from Estoque where Cod_De_Barras = @codDeBarras";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                        adapter.SelectCommand.Parameters.AddWithValue("@codDeBarras", _cod_De_Barras);

                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        _tabela.DataSource = dataTable;
                        _tabela.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Codigo de Barras Não Encontrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}