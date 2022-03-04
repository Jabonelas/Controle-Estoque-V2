﻿using Guna.UI.WinForms;
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
        #region Teste Cadastro Produto

        public bool VerificarTextBoxProduto(Cadastro_Produto _form)
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

        #endregion Teste Cadastro Produto

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
    }
}