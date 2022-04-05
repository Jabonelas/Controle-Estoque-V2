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
    internal class AlterarDadosEstoque : ConectarBanco
    {
        private VerificacaoDeExistencia VE = new VerificacaoDeExistencia();

        #region Alterar Local Estoque

        // Alterar local de estoque realizando a transeferencia

        #region Alterar local de estoque

        public void AlterarEstoque(string _local, int _cod_de_barras)
        {
            try
            {
                if (VE.BuscarExistenciaCodigoDeBarras(_cod_de_barras))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        string query = "update Estoque set Local=@local where Cod_De_Barras = @codDeBarras";
                        SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                        cmd.Parameters.Add("@local", SqlDbType.VarChar).Value = _local;
                        cmd.Parameters.Add("@codDeBarras", SqlDbType.Int).Value = _cod_de_barras;

                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Codigo de Barras Não Encontrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Alterar local de estoque

        // Alterar local de estoque quando  a Nota Fiscal de entrada for excluida

        #region Alterar Estoque na Exclusão da Nota Fiscal de Entrada

        public void AlterarEstoqueExclusaoNFEntrada(int _nf_Entrada, int _cod_de_barras)
        {
            try
            {
                if (VE.BuscarExistenciaCodigoDeBarras(_cod_de_barras))
                {
                    using (SqlConnection conexaoSQL = AbrirConexao())
                    {
                        string query = "update Estoque set Local= 'EXCLUIDA' where Cod_De_Barras = @codDeBarras";
                        SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                        cmd.Parameters.Add("@nfentrada", SqlDbType.VarChar).Value = _nf_Entrada;
                        cmd.Parameters.Add("@codDeBarras", SqlDbType.Int).Value = _cod_de_barras;

                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Codigo de Barras Não Encontrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Alterar Estoque na Exclusão da Nota Fiscal de Entrada

        // Alterar o local do estoque quando a etiqueta tiver seu saldo todo consumido

        #region Alterar Local Estoque Zerado

        public void AlterarEstoqueZerado()
        {
            try
            {
                //if (VE.BuscarExistenciaCodigoDeBarras(_cod_de_barras))
                //{
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update Estoque set Local= 'FATURADA' where Quantidade = 0 ";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    //cmd.Parameters.Add("@nfentrada", SqlDbType.VarChar).Value = _nf_Entrada;
                    //cmd.Parameters.Add("@codDeBarras", SqlDbType.Int).Value = _cod_de_barras;

                    cmd.ExecuteNonQuery();
                }
                //}
                //else
                //{
                //MessageBox.Show("Codigo de Barras Não Encontrado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Alterar Local Estoque Zerado

        #endregion Alterar Local Estoque

        //Realiza a Subritracao no estoque quando a Nota Fiscal de Saida e gerada

        #region Altera a Quantidade de Estoque Subtracao

        // Nota Fiscal de Saida altera a quantidade subtraindo

        #region Alterar Quantidade Nota Fiscal Saida

        public void AlterarQuantidadeEstoqueSubtracaoSaida(int _cod_Produto, int _quantidade)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update Estoque set Quantidade=(Quantidade - @quantidadeNFS) where Cod_Produto = @codProduto " +
                        "and Cod_de_Barras = (select MIN(Cod_de_Barras) from Estoque where Cod_Produto = @codProduto " +
                        "and Local = 'EXPEDICAO')";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.Add("@codProduto", SqlDbType.VarChar).Value = _cod_Produto;
                    cmd.Parameters.Add("@quantidadeNFS", SqlDbType.Int).Value = _quantidade;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Alterar Quantidade Nota Fiscal Saida

        // Nota Fiscal de Entrada altera a quantidade subtraindo

        #region Alterar Quantidade Nota Fiscal Entrada

        public void AlterarQuantidadeEstoqueEntradaSubtracao(int _nf_Entrada, int _quantidade, int _cod_Barras)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update Estoque set Quantidade=(Quantidade - @quantidadeNFS)" +
                        " where NF_Entrada = @nfentrada and Cod_de_Barras = @codBarras and Local = 'RECEBIMENTO'";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.Add("@nfentrada", SqlDbType.VarChar).Value = _nf_Entrada;
                    //cmd.Parameters.Add("@codProduto", SqlDbType.VarChar).Value = _cod_Produto;
                    cmd.Parameters.Add("@quantidadeNFS", SqlDbType.Int).Value = _quantidade;
                    cmd.Parameters.Add("@codBarras", SqlDbType.Int).Value = _cod_Barras;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Alterar Quantidade Nota Fiscal Entrada

        // Estoque altera a quantidade subtraindo

        #region Alterar Quantidade Estoque

        public void AlterarQuantidadeEstoqueSubtracao(int _cod_Barras, int _quantidade)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update Estoque set Quantidade=(Quantidade - @quantidadeNFS)" +
                        " where Cod_de_Barras = @codBarras";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.Add("@quantidadeNFS", SqlDbType.Int).Value = _quantidade;
                    cmd.Parameters.Add("@codBarras", SqlDbType.Int).Value = _cod_Barras;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Alterar Quantidade Estoque

        #endregion Altera a Quantidade de Estoque Subtracao

        //Realiza a Adicao no estoque quando a Nota Fiscal de Saida e gerada

        #region Altera a Quantidade de Estoque Adicao

        public void AlterarQuantidadeEstoqueAdicao(int _cod_De_Barras, int _quantidade)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update Estoque set Quantidade = (Quantidade + @quantidade) where Cod_De_Barras = @codDeBarras";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.Add("@codDeBarras", SqlDbType.VarChar).Value = _cod_De_Barras;
                    cmd.Parameters.Add("@quantidade", SqlDbType.VarChar).Value = _quantidade;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Altera a Quantidade de Estoque Adicao

        //Realiza a alteracao do coidgo de barras na tabela de NF Entrada para ficar igual ao da tabela Estoque

        #region Alterar Codigo de Barras Nota Fiscal entrada

        public void AlterarCodBarrasNFEntrada(int _nf_Entrada, int _cod_Produto)
        {
            try
            {
                using (SqlConnection conexaoSQL = AbrirConexao())
                {
                    string query = "update NF set Cod_Barras = " +
                        "(select Cod_de_Barras from Estoque where Cod_Produto = @codProduto " +
                        "and NF_Entrada = @nfentrada and Quantidade>0) " +
                        "where Cod_Produto = @codProduto and NF = @nfentrada";
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);
                    cmd.Parameters.Add("@nfentrada", SqlDbType.VarChar).Value = _nf_Entrada;
                    cmd.Parameters.Add("@codProduto", SqlDbType.VarChar).Value = _cod_Produto;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion Alterar Codigo de Barras Nota Fiscal entrada
    }
}