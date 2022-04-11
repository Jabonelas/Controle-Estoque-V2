using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Control
{
    public partial class TelaDeCarregamento : Form
    {
        public TelaDeCarregamento()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value < 100)
            {
                guna2ProgressBar1.Value = guna2ProgressBar1.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                Login logar = new Login();
                logar.ShowDialog();
            }
        }
    }
}