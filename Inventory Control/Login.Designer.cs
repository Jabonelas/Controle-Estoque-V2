namespace Inventory_Control
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtLogin_Login = new Guna.UI.WinForms.GunaTextBox();
            this.txtSenha_Login = new Guna.UI.WinForms.GunaTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMostraSenha_Login = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogar_Login = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtLogin_Login
            // 
            this.txtLogin_Login.BaseColor = System.Drawing.Color.White;
            this.txtLogin_Login.BorderColor = System.Drawing.Color.Silver;
            this.txtLogin_Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin_Login.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLogin_Login.FocusedBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtLogin_Login.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLogin_Login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLogin_Login.Location = new System.Drawing.Point(241, 193);
            this.txtLogin_Login.MaxLength = 20;
            this.txtLogin_Login.Name = "txtLogin_Login";
            this.txtLogin_Login.PasswordChar = '\0';
            this.txtLogin_Login.SelectedText = "";
            this.txtLogin_Login.ShortcutsEnabled = false;
            this.txtLogin_Login.Size = new System.Drawing.Size(200, 26);
            this.txtLogin_Login.TabIndex = 195;
            this.txtLogin_Login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_Login_KeyPress);
            // 
            // txtSenha_Login
            // 
            this.txtSenha_Login.BaseColor = System.Drawing.Color.White;
            this.txtSenha_Login.BorderColor = System.Drawing.Color.Silver;
            this.txtSenha_Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha_Login.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSenha_Login.FocusedBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtSenha_Login.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSenha_Login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSenha_Login.Location = new System.Drawing.Point(241, 278);
            this.txtSenha_Login.MaxLength = 8;
            this.txtSenha_Login.Name = "txtSenha_Login";
            this.txtSenha_Login.PasswordChar = '\0';
            this.txtSenha_Login.SelectedText = "";
            this.txtSenha_Login.ShortcutsEnabled = false;
            this.txtSenha_Login.Size = new System.Drawing.Size(200, 26);
            this.txtSenha_Login.TabIndex = 196;
            this.txtSenha_Login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_Login_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(-12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 11);
            this.panel1.TabIndex = 197;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(627, -2);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.SystemColors.Highlight;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 192;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(163, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 65);
            this.label1.TabIndex = 198;
            this.label1.Text = "Member Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(238, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 13);
            this.label6.TabIndex = 203;
            this.label6.Text = "Senha com 8 caracteres.";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(442, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 207;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(442, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 208;
            // 
            // btnMostraSenha_Login
            // 
            this.btnMostraSenha_Login.Animated = true;
            this.btnMostraSenha_Login.AnimationHoverSpeed = 0.4F;
            this.btnMostraSenha_Login.AnimationSpeed = 0.03F;
            this.btnMostraSenha_Login.BackColor = System.Drawing.Color.Transparent;
            this.btnMostraSenha_Login.BackgroundImage = global::Inventory_Control.Properties.Resources.hide_24px1;
            this.btnMostraSenha_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostraSenha_Login.BaseColor = System.Drawing.Color.Transparent;
            this.btnMostraSenha_Login.BorderColor = System.Drawing.Color.Black;
            this.btnMostraSenha_Login.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnMostraSenha_Login.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnMostraSenha_Login.CheckedForeColor = System.Drawing.Color.White;
            this.btnMostraSenha_Login.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnMostraSenha_Login.CheckedImage")));
            this.btnMostraSenha_Login.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnMostraSenha_Login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMostraSenha_Login.FocusedColor = System.Drawing.Color.Empty;
            this.btnMostraSenha_Login.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostraSenha_Login.ForeColor = System.Drawing.Color.White;
            this.btnMostraSenha_Login.Image = null;
            this.btnMostraSenha_Login.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMostraSenha_Login.LineBottom = 4;
            this.btnMostraSenha_Login.LineColor = System.Drawing.Color.Transparent;
            this.btnMostraSenha_Login.Location = new System.Drawing.Point(446, 278);
            this.btnMostraSenha_Login.Name = "btnMostraSenha_Login";
            this.btnMostraSenha_Login.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnMostraSenha_Login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMostraSenha_Login.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMostraSenha_Login.OnHoverImage = null;
            this.btnMostraSenha_Login.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMostraSenha_Login.OnPressedColor = System.Drawing.Color.Black;
            this.btnMostraSenha_Login.Size = new System.Drawing.Size(29, 26);
            this.btnMostraSenha_Login.TabIndex = 209;
            this.btnMostraSenha_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMostraSenha_Login.EnabledChanged += new System.EventHandler(this.btnMostraSenha_Login_EnabledChanged);
            this.btnMostraSenha_Login.Click += new System.EventHandler(this.btnMostraSenha_Login_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Inventory_Control.Properties.Resources.user_engagement_male_50px;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(206, 193);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(29, 26);
            this.panel4.TabIndex = 206;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Inventory_Control.Properties.Resources.key_50px1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(203, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(29, 26);
            this.panel2.TabIndex = 205;
            // 
            // btnLogar_Login
            // 
            this.btnLogar_Login.CheckedState.Parent = this.btnLogar_Login;
            this.btnLogar_Login.CustomImages.Parent = this.btnLogar_Login;
            this.btnLogar_Login.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnLogar_Login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar_Login.ForeColor = System.Drawing.Color.White;
            this.btnLogar_Login.HoverState.Parent = this.btnLogar_Login;
            this.btnLogar_Login.Image = global::Inventory_Control.Properties.Resources.enter_512px;
            this.btnLogar_Login.Location = new System.Drawing.Point(261, 351);
            this.btnLogar_Login.Name = "btnLogar_Login";
            this.btnLogar_Login.ShadowDecoration.Parent = this.btnLogar_Login;
            this.btnLogar_Login.Size = new System.Drawing.Size(150, 45);
            this.btnLogar_Login.TabIndex = 204;
            this.btnLogar_Login.Text = "Logar ";
            this.btnLogar_Login.Click += new System.EventHandler(this.btnLogar_Login_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Inventory_Control.Properties.Resources.team_50px;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(261, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 101);
            this.panel3.TabIndex = 206;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(672, 424);
            this.Controls.Add(this.btnMostraSenha_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLogar_Login);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.txtSenha_Login);
            this.Controls.Add(this.txtLogin_Login);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtLogin_Login;
        private Guna.UI.WinForms.GunaTextBox txtSenha_Login;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnLogar_Login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaAdvenceButton btnMostraSenha_Login;
    }
}