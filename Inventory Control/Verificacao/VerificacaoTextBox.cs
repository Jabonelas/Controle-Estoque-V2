using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Control
{
    internal class VerificacaoTextBox
    {
        #region Cliente/Fornecedor

        public bool VerificarTextBoxClienteFornecedor(Cadastro_Clientes_e_Fornecedores _form)
        {
            try
            {
                bool isExit = true;
                foreach (Control ctrl in _form.Controls)
                {
                    if (ctrl is GunaTextBox)
                    {
                        if (ctrl.Text == string.Empty)
                        {
                            isExit = false;
                        }
                    }
                    else if (ctrl is ComboBox)
                    {
                        if (ctrl.Text == string.Empty)
                            isExit = false;
                    }
                }
                return isExit;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return false;
            }
        }

        internal bool VerificarTextBoxNFSaida(VendasNotaFiscalSaida vendasNotaFiscalSaida)
        {
            throw new NotImplementedException();
        }

        #endregion Cliente/Fornecedor

        #region Produto

        public bool VerificarTextBoxProduto(Vendas_Nota_Fiscal_Saida _form)
        {
            try
            {
                bool isExit = true;
                foreach (Control ctrl in _form.Controls)
                {
                    if (ctrl is GunaTextBox)
                    {
                        if (ctrl.Text == string.Empty)
                        {
                            isExit = false;
                        }
                    }
                    else if (ctrl is ComboBox)
                    {
                        if (ctrl.Text == string.Empty)
                            isExit = false;
                    }
                }
                return isExit;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return false;
            }
        }

        #endregion Produto

        #region Nota Fiscal Saida

        public bool VerificarTextBoxNFSaida(Vendas_Nota_Fiscal_Saida _form)
        {
            try
            {
                bool isExit = true;
                foreach (Control ctrl in _form.Controls)
                {
                    if (ctrl is GunaTextBox)
                    {
                        if (ctrl.Text == string.Empty)
                        {
                            isExit = false;
                        }
                    }
                    else if (ctrl is ComboBox)
                    {
                        if (ctrl.Text == string.Empty)
                            isExit = false;
                    }
                }
                return isExit;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return false;
            }
        }

        #endregion Nota Fiscal Saida

        #region Tranferencia Entre Etiquetas

        public bool VerificarTextBoxTransferenciaEtiquetas(Transferencia_Etiqueta _form)
        {
            try
            {
                bool isExit = true;
                foreach (Control ctrl in _form.Controls)
                {
                    if (ctrl is GunaTextBox)
                    {
                        if (ctrl.Text == string.Empty)
                        {
                            isExit = false;
                        }
                    }
                    else if (ctrl is ComboBox)
                    {
                        if (ctrl.Text == string.Empty)
                            isExit = false;
                    }
                }
                return isExit;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return false;
            }
        }

        #endregion Tranferencia Entre Etiquetas
    }
}