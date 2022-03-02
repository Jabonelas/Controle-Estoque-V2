using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Control
{
    internal class VerificaçãoTextBox : Cadastro_Produto
    {
        public IEnumerable<Control> Controls { get; private set; }

        //public bool  VerificarTextbox()
        //{
        //    try
        //    {
        //        Boolean ok = true;

        //        foreach (Control ctrl in this.Controls)
        //        {
        //            if (ctrl is GunaTextBox)
        //            {
        //                if (ctrl.Text == string.Empty)
        //                {
        //                    ok = false;
        //                }
        //            }
        //            else if (ctrl is ComboBox)
        //            {
        //                if (ctrl.Text == string.Empty)
        //                    ok = false;
        //            }
        //        }
        //        return ok;

        //    }

        //    catch (Exception x)
        //    {
        //        MessageBox.Show(x.Message.ToString());
        //    }

        //}
    }
}