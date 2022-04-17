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
    public partial class Login : Form
    {
        private BuscarUsuario BUS = new BuscarUsuario(); // Buscar Usurio e Senha

        public Login()
        {
            InitializeComponent();
        }

        #region Botao Logar

        private void btnLogar_Login_Click(object sender, EventArgs e)
        {
            if (txtLogin_Login.Text == "" && txtSenha_Login.Text == "")
            {
                label3.Text = "*";
                label2.Text = "*";

                MessageBox.Show("Todos os Campos Com * São Obrigatorio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (BUS.Login(txtLogin_Login.Text, txtSenha_Login.Text) == true)
                {
                    Forms Abrirprograma = new Forms();
                    this.Hide();
                    Abrirprograma.Show();

                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario/Senha Não Cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                label3.Text = "";
                label2.Text = "";
            }
        }

        #endregion Botao Logar

        #region TextBox Senha

        private void txtSenha_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSenha_Login.UseSystemPasswordChar = true;
        }

        #endregion TextBox Senha

        #region TextBox Usurio

        private void txtLogin_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
            txtLogin_Login.CharacterCasing = CharacterCasing.Upper;
        }

        #endregion TextBox Usurio

        #region Botao Mostrar Senha

        private void btnMostraSenha_Login_Click(object sender, EventArgs e)
        {
            if (txtSenha_Login.UseSystemPasswordChar == true)
            {
                txtSenha_Login.UseSystemPasswordChar = false;

                btnMostraSenha_Login.BackgroundImage = Image.FromFile(@"C:\Users\israe\source\repos\Inventory Control\Inventory Control\Resources\eye_30px.png");
            }
            else
            {
                txtSenha_Login.UseSystemPasswordChar = true;

                btnMostraSenha_Login.BackgroundImage = Image.FromFile(@"C:\Users\israe\source\repos\Inventory Control\Inventory Control\Resources\hide_24px.png");
            }
        }

        #endregion Botao Mostrar Senha

        private void btnMostraSenha_Login_EnabledChanged(object sender, EventArgs e)
        {
            if (btnMostraSenha_Login.Enabled)
            {
                btnMostraSenha_Login.BackgroundImage =
                Image.FromFile(@"C:\Users\israe\source\repos\Inventory Control\Inventory Control\Resources\Cancelar.png");
            }
            else
            {
                btnMostraSenha_Login.BackgroundImage =
                Image.FromFile(@"C: \Users\israe\source\repos\Inventory Control\Inventory Control\Resources\Buscar.png");
            }
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}