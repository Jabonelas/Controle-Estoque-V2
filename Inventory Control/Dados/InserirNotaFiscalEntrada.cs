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
    internal class InserirNotaFiscalEntrada : ConectarBanco
    {
        private VerificacaoDeExistencia VNF = new VerificacaoDeExistencia();

        public void InserirNotaFiscal(int _nota_Fiscal, Guna2DataGridView _tabela)
        {
            if (VNF.BuscarExistenciaNotaFiscal(_nota_Fiscal))
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update NF set Estatus = 'RECEBIMENTO' where NF = @nF update NF set Data_Lancamento = GETDATE()   where NF = @nF  select NF,CNPJ,Nome_Razao_Social,Cod_Produto,Descricao_Produto,QUANT,UNIDADE,Valor_Unitario,Valor_Total,Data_Emissao,Data_Lancamento,Estatus from NF where NF = @nF ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexaoSQL);
                    adapter.SelectCommand.Parameters.AddWithValue("@nF", _nota_Fiscal);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    _tabela.DataSource = dataTable;
                    _tabela.Refresh();

                    MessageBox.Show("Nota Fiscal Incluida Com Sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nota Fiscal Não Encontrada!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}