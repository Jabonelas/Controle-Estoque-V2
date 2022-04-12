namespace Inventory_Control
{
    partial class SuprimentoControleBusca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuprimentoControleBusca));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnPesquisa_CadastroCliente = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtCodProduto_Buscar = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtCodBarras_Buscar = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gdvBuscarEstoque_Suprimentos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.NF_Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_de_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_de_Barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBuscarEstoque_Suprimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(6, 51);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(57, 15);
            this.gunaLabel4.TabIndex = 142;
            this.gunaLabel4.Text = "Pesquisar";
            // 
            // btnPesquisa_CadastroCliente
            // 
            this.btnPesquisa_CadastroCliente.Animated = true;
            this.btnPesquisa_CadastroCliente.AnimationHoverSpeed = 0.4F;
            this.btnPesquisa_CadastroCliente.AnimationSpeed = 0.03F;
            this.btnPesquisa_CadastroCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisa_CadastroCliente.BackgroundImage = global::Inventory_Control.Properties.Resources.Buscar;
            this.btnPesquisa_CadastroCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisa_CadastroCliente.BaseColor = System.Drawing.Color.Transparent;
            this.btnPesquisa_CadastroCliente.BorderColor = System.Drawing.Color.Black;
            this.btnPesquisa_CadastroCliente.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPesquisa_CadastroCliente.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPesquisa_CadastroCliente.CheckedForeColor = System.Drawing.Color.White;
            this.btnPesquisa_CadastroCliente.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisa_CadastroCliente.CheckedImage")));
            this.btnPesquisa_CadastroCliente.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPesquisa_CadastroCliente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPesquisa_CadastroCliente.FocusedColor = System.Drawing.Color.Empty;
            this.btnPesquisa_CadastroCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa_CadastroCliente.ForeColor = System.Drawing.Color.White;
            this.btnPesquisa_CadastroCliente.Image = null;
            this.btnPesquisa_CadastroCliente.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPesquisa_CadastroCliente.LineBottom = 4;
            this.btnPesquisa_CadastroCliente.LineColor = System.Drawing.Color.Transparent;
            this.btnPesquisa_CadastroCliente.Location = new System.Drawing.Point(7, 3);
            this.btnPesquisa_CadastroCliente.Name = "btnPesquisa_CadastroCliente";
            this.btnPesquisa_CadastroCliente.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnPesquisa_CadastroCliente.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPesquisa_CadastroCliente.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPesquisa_CadastroCliente.OnHoverImage = null;
            this.btnPesquisa_CadastroCliente.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisa_CadastroCliente.OnPressedColor = System.Drawing.Color.Black;
            this.btnPesquisa_CadastroCliente.Size = new System.Drawing.Size(44, 47);
            this.btnPesquisa_CadastroCliente.TabIndex = 141;
            this.btnPesquisa_CadastroCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPesquisa_CadastroCliente.Click += new System.EventHandler(this.btnPesquisa_CadastroCliente_Click);
            // 
            // txtCodProduto_Buscar
            // 
            this.txtCodProduto_Buscar.BaseColor = System.Drawing.Color.White;
            this.txtCodProduto_Buscar.BorderColor = System.Drawing.Color.Silver;
            this.txtCodProduto_Buscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodProduto_Buscar.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCodProduto_Buscar.FocusedBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtCodProduto_Buscar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodProduto_Buscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodProduto_Buscar.Location = new System.Drawing.Point(120, 146);
            this.txtCodProduto_Buscar.MaxLength = 10;
            this.txtCodProduto_Buscar.Name = "txtCodProduto_Buscar";
            this.txtCodProduto_Buscar.PasswordChar = '\0';
            this.txtCodProduto_Buscar.SelectedText = "";
            this.txtCodProduto_Buscar.ShortcutsEnabled = false;
            this.txtCodProduto_Buscar.Size = new System.Drawing.Size(162, 26);
            this.txtCodProduto_Buscar.TabIndex = 151;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(10, 157);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(81, 15);
            this.gunaLabel8.TabIndex = 150;
            this.gunaLabel8.Text = "Cód. Produto:";
            // 
            // txtCodBarras_Buscar
            // 
            this.txtCodBarras_Buscar.BaseColor = System.Drawing.Color.White;
            this.txtCodBarras_Buscar.BorderColor = System.Drawing.Color.Silver;
            this.txtCodBarras_Buscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodBarras_Buscar.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCodBarras_Buscar.FocusedBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtCodBarras_Buscar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodBarras_Buscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodBarras_Buscar.Location = new System.Drawing.Point(120, 106);
            this.txtCodBarras_Buscar.MaxLength = 10;
            this.txtCodBarras_Buscar.Name = "txtCodBarras_Buscar";
            this.txtCodBarras_Buscar.PasswordChar = '\0';
            this.txtCodBarras_Buscar.SelectedText = "";
            this.txtCodBarras_Buscar.ShortcutsEnabled = false;
            this.txtCodBarras_Buscar.Size = new System.Drawing.Size(162, 26);
            this.txtCodBarras_Buscar.TabIndex = 149;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(10, 117);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(86, 15);
            this.gunaLabel5.TabIndex = 148;
            this.gunaLabel5.Text = "Cód. de Barras:";
            // 
            // gdvBuscarEstoque_Suprimentos
            // 
            this.gdvBuscarEstoque_Suprimentos.AllowUserToAddRows = false;
            this.gdvBuscarEstoque_Suprimentos.AllowUserToDeleteRows = false;
            this.gdvBuscarEstoque_Suprimentos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gdvBuscarEstoque_Suprimentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvBuscarEstoque_Suprimentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvBuscarEstoque_Suprimentos.BackgroundColor = System.Drawing.Color.White;
            this.gdvBuscarEstoque_Suprimentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvBuscarEstoque_Suprimentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvBuscarEstoque_Suprimentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvBuscarEstoque_Suprimentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdvBuscarEstoque_Suprimentos.ColumnHeadersHeight = 30;
            this.gdvBuscarEstoque_Suprimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NF_Entrada,
            this.Codigo_de_Produto,
            this.Lote,
            this.Descição,
            this.Quantidade,
            this.Local,
            this.Valor_Unitario,
            this.Valor_Total,
            this.Codigo_de_Barras});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvBuscarEstoque_Suprimentos.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdvBuscarEstoque_Suprimentos.EnableHeadersVisualStyles = false;
            this.gdvBuscarEstoque_Suprimentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvBuscarEstoque_Suprimentos.Location = new System.Drawing.Point(34, 194);
            this.gdvBuscarEstoque_Suprimentos.MultiSelect = false;
            this.gdvBuscarEstoque_Suprimentos.Name = "gdvBuscarEstoque_Suprimentos";
            this.gdvBuscarEstoque_Suprimentos.ReadOnly = true;
            this.gdvBuscarEstoque_Suprimentos.RowHeadersVisible = false;
            this.gdvBuscarEstoque_Suprimentos.RowHeadersWidth = 30;
            this.gdvBuscarEstoque_Suprimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvBuscarEstoque_Suprimentos.Size = new System.Drawing.Size(1019, 336);
            this.gdvBuscarEstoque_Suprimentos.TabIndex = 152;
            this.gdvBuscarEstoque_Suprimentos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.Highlight;
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.HeaderStyle.Height = 30;
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.ReadOnly = true;
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.RowsStyle.Height = 22;
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvBuscarEstoque_Suprimentos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // NF_Entrada
            // 
            this.NF_Entrada.DataPropertyName = "NF_Entrada";
            this.NF_Entrada.HeaderText = "NF Entrada";
            this.NF_Entrada.Name = "NF_Entrada";
            this.NF_Entrada.ReadOnly = true;
            // 
            // Codigo_de_Produto
            // 
            this.Codigo_de_Produto.DataPropertyName = "Cod_Produto";
            this.Codigo_de_Produto.HeaderText = "Codigo de Produto";
            this.Codigo_de_Produto.Name = "Codigo_de_Produto";
            this.Codigo_de_Produto.ReadOnly = true;
            // 
            // Lote
            // 
            this.Lote.DataPropertyName = "Lote";
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            // 
            // Descição
            // 
            this.Descição.DataPropertyName = "Descricao";
            this.Descição.HeaderText = "Descrição ";
            this.Descição.Name = "Descição";
            this.Descição.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Local
            // 
            this.Local.DataPropertyName = "Local";
            this.Local.HeaderText = "Local";
            this.Local.Name = "Local";
            this.Local.ReadOnly = true;
            // 
            // Valor_Unitario
            // 
            this.Valor_Unitario.DataPropertyName = "Valor_Unitario";
            this.Valor_Unitario.HeaderText = "Valor Unitario";
            this.Valor_Unitario.Name = "Valor_Unitario";
            this.Valor_Unitario.ReadOnly = true;
            // 
            // Valor_Total
            // 
            this.Valor_Total.DataPropertyName = "Valor_Total";
            this.Valor_Total.HeaderText = "Valor Total";
            this.Valor_Total.Name = "Valor_Total";
            this.Valor_Total.ReadOnly = true;
            // 
            // Codigo_de_Barras
            // 
            this.Codigo_de_Barras.DataPropertyName = "Cod_de_Barras";
            this.Codigo_de_Barras.HeaderText = "Codigo de Barras";
            this.Codigo_de_Barras.Name = "Codigo_de_Barras";
            this.Codigo_de_Barras.ReadOnly = true;
            // 
            // SuprimentoControleBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 542);
            this.Controls.Add(this.gdvBuscarEstoque_Suprimentos);
            this.Controls.Add(this.txtCodProduto_Buscar);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.txtCodBarras_Buscar);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.btnPesquisa_CadastroCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuprimentoControleBusca";
            this.Text = "SuprimentoControleBusca";
            this.Load += new System.EventHandler(this.SuprimentoControleBusca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvBuscarEstoque_Suprimentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaAdvenceButton btnPesquisa_CadastroCliente;
        private Guna.UI.WinForms.GunaTextBox txtCodProduto_Buscar;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTextBox txtCodBarras_Buscar;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI2.WinForms.Guna2DataGridView gdvBuscarEstoque_Suprimentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NF_Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_de_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_de_Barras;
    }
}