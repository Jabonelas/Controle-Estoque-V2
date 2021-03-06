namespace Inventory_Control
{
    partial class ListaEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvdListaEstoque = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Cod_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_de_Barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodProduto_MovimentacaoEtiqueta = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarEtiqueta = new Guna.UI.WinForms.GunaAdvenceButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvdListaEstoque)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvdListaEstoque
            // 
            this.gvdListaEstoque.AllowUserToAddRows = false;
            this.gvdListaEstoque.AllowUserToDeleteRows = false;
            this.gvdListaEstoque.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.gvdListaEstoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gvdListaEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvdListaEstoque.BackgroundColor = System.Drawing.Color.White;
            this.gvdListaEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvdListaEstoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvdListaEstoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvdListaEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gvdListaEstoque.ColumnHeadersHeight = 30;
            this.gvdListaEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Produto,
            this.Cod_de_Barras,
            this.Lote,
            this.Descricao,
            this.Quantidade,
            this.Local});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvdListaEstoque.DefaultCellStyle = dataGridViewCellStyle9;
            this.gvdListaEstoque.EnableHeadersVisualStyles = false;
            this.gvdListaEstoque.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvdListaEstoque.Location = new System.Drawing.Point(10, 79);
            this.gvdListaEstoque.MultiSelect = false;
            this.gvdListaEstoque.Name = "gvdListaEstoque";
            this.gvdListaEstoque.ReadOnly = true;
            this.gvdListaEstoque.RowHeadersVisible = false;
            this.gvdListaEstoque.RowHeadersWidth = 30;
            this.gvdListaEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvdListaEstoque.Size = new System.Drawing.Size(585, 245);
            this.gvdListaEstoque.TabIndex = 188;
            this.gvdListaEstoque.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gvdListaEstoque.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvdListaEstoque.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvdListaEstoque.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvdListaEstoque.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvdListaEstoque.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvdListaEstoque.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvdListaEstoque.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvdListaEstoque.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.Highlight;
            this.gvdListaEstoque.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvdListaEstoque.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvdListaEstoque.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvdListaEstoque.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvdListaEstoque.ThemeStyle.HeaderStyle.Height = 30;
            this.gvdListaEstoque.ThemeStyle.ReadOnly = true;
            this.gvdListaEstoque.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvdListaEstoque.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvdListaEstoque.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvdListaEstoque.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvdListaEstoque.ThemeStyle.RowsStyle.Height = 22;
            this.gvdListaEstoque.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvdListaEstoque.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvdListaEstoque.DoubleClick += new System.EventHandler(this.gvdListaEstoque_DoubleClick);
            // 
            // Cod_Produto
            // 
            this.Cod_Produto.DataPropertyName = "Cod_Produto";
            this.Cod_Produto.HeaderText = "Codigo Produto";
            this.Cod_Produto.Name = "Cod_Produto";
            this.Cod_Produto.ReadOnly = true;
            this.Cod_Produto.Width = 130;
            // 
            // Cod_de_Barras
            // 
            this.Cod_de_Barras.DataPropertyName = "Cod_de_Barras";
            this.Cod_de_Barras.HeaderText = "Codigo de Barras";
            this.Cod_de_Barras.Name = "Cod_de_Barras";
            this.Cod_de_Barras.ReadOnly = true;
            this.Cod_de_Barras.Width = 137;
            // 
            // Lote
            // 
            this.Lote.DataPropertyName = "Lote";
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            this.Lote.Width = 59;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 90;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 104;
            // 
            // Local
            // 
            this.Local.DataPropertyName = "Local";
            this.Local.HeaderText = "Local";
            this.Local.Name = "Local";
            this.Local.ReadOnly = true;
            this.Local.Width = 63;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(586, 1);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.SystemColors.Highlight;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(-6, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 10);
            this.panel1.TabIndex = 193;
            // 
            // txtCodProduto_MovimentacaoEtiqueta
            // 
            this.txtCodProduto_MovimentacaoEtiqueta.BaseColor = System.Drawing.Color.White;
            this.txtCodProduto_MovimentacaoEtiqueta.BorderColor = System.Drawing.Color.Silver;
            this.txtCodProduto_MovimentacaoEtiqueta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodProduto_MovimentacaoEtiqueta.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCodProduto_MovimentacaoEtiqueta.FocusedBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtCodProduto_MovimentacaoEtiqueta.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodProduto_MovimentacaoEtiqueta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodProduto_MovimentacaoEtiqueta.Location = new System.Drawing.Point(93, 17);
            this.txtCodProduto_MovimentacaoEtiqueta.Name = "txtCodProduto_MovimentacaoEtiqueta";
            this.txtCodProduto_MovimentacaoEtiqueta.PasswordChar = '\0';
            this.txtCodProduto_MovimentacaoEtiqueta.SelectedText = "";
            this.txtCodProduto_MovimentacaoEtiqueta.ShortcutsEnabled = false;
            this.txtCodProduto_MovimentacaoEtiqueta.Size = new System.Drawing.Size(161, 26);
            this.txtCodProduto_MovimentacaoEtiqueta.TabIndex = 0;
            this.txtCodProduto_MovimentacaoEtiqueta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProduto_MovimentacaoEtiqueta_KeyPress);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(6, 28);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(81, 15);
            this.gunaLabel8.TabIndex = 195;
            this.gunaLabel8.Text = "Cód. Produto:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnBuscarEtiqueta);
            this.panel2.Controls.Add(this.txtCodProduto_MovimentacaoEtiqueta);
            this.panel2.Controls.Add(this.gunaLabel8);
            this.panel2.Controls.Add(this.gvdListaEstoque);
            this.panel2.Location = new System.Drawing.Point(12, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 339);
            this.panel2.TabIndex = 196;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(254, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 197;
            // 
            // btnBuscarEtiqueta
            // 
            this.btnBuscarEtiqueta.Animated = true;
            this.btnBuscarEtiqueta.AnimationHoverSpeed = 0.4F;
            this.btnBuscarEtiqueta.AnimationSpeed = 0.03F;
            this.btnBuscarEtiqueta.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarEtiqueta.BackgroundImage = global::Inventory_Control.Properties.Resources.Lupa;
            this.btnBuscarEtiqueta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarEtiqueta.BaseColor = System.Drawing.Color.Transparent;
            this.btnBuscarEtiqueta.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarEtiqueta.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBuscarEtiqueta.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBuscarEtiqueta.CheckedForeColor = System.Drawing.Color.White;
            this.btnBuscarEtiqueta.CheckedImage = global::Inventory_Control.Properties.Resources.Lupa;
            this.btnBuscarEtiqueta.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBuscarEtiqueta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarEtiqueta.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarEtiqueta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEtiqueta.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEtiqueta.Image = null;
            this.btnBuscarEtiqueta.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscarEtiqueta.LineBottom = 4;
            this.btnBuscarEtiqueta.LineColor = System.Drawing.Color.Transparent;
            this.btnBuscarEtiqueta.Location = new System.Drawing.Point(270, 18);
            this.btnBuscarEtiqueta.Name = "btnBuscarEtiqueta";
            this.btnBuscarEtiqueta.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnBuscarEtiqueta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarEtiqueta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarEtiqueta.OnHoverImage = null;
            this.btnBuscarEtiqueta.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscarEtiqueta.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarEtiqueta.Size = new System.Drawing.Size(21, 26);
            this.btnBuscarEtiqueta.TabIndex = 1;
            this.btnBuscarEtiqueta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscarEtiqueta.Click += new System.EventHandler(this.btnBuscarEtiqueta_Click);
            this.btnBuscarEtiqueta.MouseEnter += new System.EventHandler(this.btnBuscarEtiqueta_MouseEnter);
            this.btnBuscarEtiqueta.MouseLeave += new System.EventHandler(this.btnBuscarEtiqueta_MouseLeave);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // ListaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(631, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.gvdListaEstoque)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gvdListaEstoque;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaTextBox txtCodProduto_MovimentacaoEtiqueta;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnBuscarEtiqueta;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_de_Barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local;
    }
}