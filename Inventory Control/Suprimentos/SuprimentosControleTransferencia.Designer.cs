namespace Inventory_Control
{
    partial class SuprimentosControleTransferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuprimentosControleTransferencia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCodDeBarras_MovimentacaoEstoque = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.cmbDestino_MovimentacaoEstoque = new System.Windows.Forms.ComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnPesquisa_CadastroCliente = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnModificar_CadastroCliente = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.txtCodDaProduto_MovimentacaoEstoque = new Guna.UI.WinForms.GunaTextBox();
            this.txtLocal_MovimentacaoEstoque = new Guna.UI.WinForms.GunaTextBox();
            this.txtQuantidade_MovimentocaoEstoque = new Guna.UI.WinForms.GunaTextBox();
            this.txtDescricao_MovimentocaoEstoque = new Guna.UI.WinForms.GunaTextBox();
            this.txtLote_MovimentocaoEstoque = new Guna.UI.WinForms.GunaTextBox();
            this.gvdMovimentacaoEstoque = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvdMovimentacaoEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodDeBarras_MovimentacaoEstoque
            // 
            this.txtCodDeBarras_MovimentacaoEstoque.BaseColor = System.Drawing.Color.White;
            this.txtCodDeBarras_MovimentacaoEstoque.BorderColor = System.Drawing.Color.Silver;
            this.txtCodDeBarras_MovimentacaoEstoque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodDeBarras_MovimentacaoEstoque.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCodDeBarras_MovimentacaoEstoque.FocusedBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtCodDeBarras_MovimentacaoEstoque.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodDeBarras_MovimentacaoEstoque.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodDeBarras_MovimentacaoEstoque.Location = new System.Drawing.Point(103, 109);
            this.txtCodDeBarras_MovimentacaoEstoque.Name = "txtCodDeBarras_MovimentacaoEstoque";
            this.txtCodDeBarras_MovimentacaoEstoque.PasswordChar = '\0';
            this.txtCodDeBarras_MovimentacaoEstoque.SelectedText = "";
            this.txtCodDeBarras_MovimentacaoEstoque.Size = new System.Drawing.Size(162, 26);
            this.txtCodDeBarras_MovimentacaoEstoque.TabIndex = 119;
            this.txtCodDeBarras_MovimentacaoEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodDeBarras_MovimentacaoEstoque_KeyPress);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(10, 117);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(86, 15);
            this.gunaLabel5.TabIndex = 118;
            this.gunaLabel5.Text = "Cód. de Barras:";
            // 
            // cmbDestino_MovimentacaoEstoque
            // 
            this.cmbDestino_MovimentacaoEstoque.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestino_MovimentacaoEstoque.FormattingEnabled = true;
            this.cmbDestino_MovimentacaoEstoque.Items.AddRange(new object[] {
            "RECEBIMENTO",
            "EST. A - 1 - 1",
            "EST. A - 1 - 2",
            "EST. A - 2 - 1",
            "EST. A - 2 - 2",
            "EST. B - 1 - 1",
            "EST. B - 1 - 2",
            "EST. B - 2 - 1",
            "EST. B - 2 - 2",
            "EST. C - 1 - 1",
            "EST. C - 1 - 2",
            "EST. C - 2 - 1",
            "EST. C - 2 - 2",
            "PRODUÇÃO"});
            this.cmbDestino_MovimentacaoEstoque.Location = new System.Drawing.Point(103, 349);
            this.cmbDestino_MovimentacaoEstoque.Name = "cmbDestino_MovimentacaoEstoque";
            this.cmbDestino_MovimentacaoEstoque.Size = new System.Drawing.Size(162, 23);
            this.cmbDestino_MovimentacaoEstoque.TabIndex = 136;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(74, 53);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(57, 15);
            this.gunaLabel4.TabIndex = 140;
            this.gunaLabel4.Text = "Pesquisar";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(4, 53);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(58, 15);
            this.gunaLabel2.TabIndex = 139;
            this.gunaLabel2.Text = "Modificar";
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
            this.btnPesquisa_CadastroCliente.Location = new System.Drawing.Point(77, 3);
            this.btnPesquisa_CadastroCliente.Name = "btnPesquisa_CadastroCliente";
            this.btnPesquisa_CadastroCliente.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnPesquisa_CadastroCliente.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPesquisa_CadastroCliente.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPesquisa_CadastroCliente.OnHoverImage = null;
            this.btnPesquisa_CadastroCliente.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisa_CadastroCliente.OnPressedColor = System.Drawing.Color.Black;
            this.btnPesquisa_CadastroCliente.Size = new System.Drawing.Size(44, 47);
            this.btnPesquisa_CadastroCliente.TabIndex = 138;
            this.btnPesquisa_CadastroCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPesquisa_CadastroCliente.Click += new System.EventHandler(this.btnPesquisa_CadastroCliente_Click);
            // 
            // btnModificar_CadastroCliente
            // 
            this.btnModificar_CadastroCliente.Animated = true;
            this.btnModificar_CadastroCliente.AnimationHoverSpeed = 0.4F;
            this.btnModificar_CadastroCliente.AnimationSpeed = 0.03F;
            this.btnModificar_CadastroCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar_CadastroCliente.BackgroundImage = global::Inventory_Control.Properties.Resources.Editar;
            this.btnModificar_CadastroCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar_CadastroCliente.BaseColor = System.Drawing.Color.Transparent;
            this.btnModificar_CadastroCliente.BorderColor = System.Drawing.Color.Black;
            this.btnModificar_CadastroCliente.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnModificar_CadastroCliente.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnModificar_CadastroCliente.CheckedForeColor = System.Drawing.Color.White;
            this.btnModificar_CadastroCliente.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnModificar_CadastroCliente.CheckedImage")));
            this.btnModificar_CadastroCliente.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnModificar_CadastroCliente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModificar_CadastroCliente.FocusedColor = System.Drawing.Color.Empty;
            this.btnModificar_CadastroCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar_CadastroCliente.ForeColor = System.Drawing.Color.White;
            this.btnModificar_CadastroCliente.Image = null;
            this.btnModificar_CadastroCliente.ImageSize = new System.Drawing.Size(20, 20);
            this.btnModificar_CadastroCliente.LineBottom = 4;
            this.btnModificar_CadastroCliente.LineColor = System.Drawing.Color.Transparent;
            this.btnModificar_CadastroCliente.Location = new System.Drawing.Point(7, 3);
            this.btnModificar_CadastroCliente.Name = "btnModificar_CadastroCliente";
            this.btnModificar_CadastroCliente.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnModificar_CadastroCliente.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificar_CadastroCliente.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModificar_CadastroCliente.OnHoverImage = null;
            this.btnModificar_CadastroCliente.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnModificar_CadastroCliente.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificar_CadastroCliente.Size = new System.Drawing.Size(44, 47);
            this.btnModificar_CadastroCliente.TabIndex = 137;
            this.btnModificar_CadastroCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificar_CadastroCliente.Click += new System.EventHandler(this.btnModificar_CadastroCliente_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(10, 317);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(38, 15);
            this.gunaLabel1.TabIndex = 141;
            this.gunaLabel1.Text = "Local:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(10, 277);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(72, 15);
            this.gunaLabel3.TabIndex = 142;
            this.gunaLabel3.Text = "Quantidade:";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(10, 237);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(61, 15);
            this.gunaLabel6.TabIndex = 143;
            this.gunaLabel6.Text = "Descrição:";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(10, 197);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(33, 15);
            this.gunaLabel7.TabIndex = 144;
            this.gunaLabel7.Text = "Lote:";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(10, 157);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(81, 15);
            this.gunaLabel8.TabIndex = 145;
            this.gunaLabel8.Text = "Cód. Produto:";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel9.Location = new System.Drawing.Point(10, 357);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(50, 15);
            this.gunaLabel9.TabIndex = 146;
            this.gunaLabel9.Text = "Destino:";
            // 
            // txtCodDaProduto_MovimentacaoEstoque
            // 
            this.txtCodDaProduto_MovimentacaoEstoque.BaseColor = System.Drawing.Color.White;
            this.txtCodDaProduto_MovimentacaoEstoque.BorderColor = System.Drawing.Color.Silver;
            this.txtCodDaProduto_MovimentacaoEstoque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodDaProduto_MovimentacaoEstoque.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCodDaProduto_MovimentacaoEstoque.FocusedBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtCodDaProduto_MovimentacaoEstoque.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodDaProduto_MovimentacaoEstoque.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodDaProduto_MovimentacaoEstoque.Location = new System.Drawing.Point(103, 146);
            this.txtCodDaProduto_MovimentacaoEstoque.Name = "txtCodDaProduto_MovimentacaoEstoque";
            this.txtCodDaProduto_MovimentacaoEstoque.PasswordChar = '\0';
            this.txtCodDaProduto_MovimentacaoEstoque.ReadOnly = true;
            this.txtCodDaProduto_MovimentacaoEstoque.SelectedText = "";
            this.txtCodDaProduto_MovimentacaoEstoque.Size = new System.Drawing.Size(162, 26);
            this.txtCodDaProduto_MovimentacaoEstoque.TabIndex = 147;
            // 
            // txtLocal_MovimentacaoEstoque
            // 
            this.txtLocal_MovimentacaoEstoque.BaseColor = System.Drawing.Color.White;
            this.txtLocal_MovimentacaoEstoque.BorderColor = System.Drawing.Color.Silver;
            this.txtLocal_MovimentacaoEstoque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocal_MovimentacaoEstoque.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLocal_MovimentacaoEstoque.FocusedBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtLocal_MovimentacaoEstoque.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLocal_MovimentacaoEstoque.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLocal_MovimentacaoEstoque.Location = new System.Drawing.Point(103, 306);
            this.txtLocal_MovimentacaoEstoque.Name = "txtLocal_MovimentacaoEstoque";
            this.txtLocal_MovimentacaoEstoque.PasswordChar = '\0';
            this.txtLocal_MovimentacaoEstoque.ReadOnly = true;
            this.txtLocal_MovimentacaoEstoque.SelectedText = "";
            this.txtLocal_MovimentacaoEstoque.Size = new System.Drawing.Size(162, 26);
            this.txtLocal_MovimentacaoEstoque.TabIndex = 148;
            // 
            // txtQuantidade_MovimentocaoEstoque
            // 
            this.txtQuantidade_MovimentocaoEstoque.BaseColor = System.Drawing.Color.White;
            this.txtQuantidade_MovimentocaoEstoque.BorderColor = System.Drawing.Color.Silver;
            this.txtQuantidade_MovimentocaoEstoque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantidade_MovimentocaoEstoque.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQuantidade_MovimentocaoEstoque.FocusedBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtQuantidade_MovimentocaoEstoque.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQuantidade_MovimentocaoEstoque.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantidade_MovimentocaoEstoque.Location = new System.Drawing.Point(103, 266);
            this.txtQuantidade_MovimentocaoEstoque.Name = "txtQuantidade_MovimentocaoEstoque";
            this.txtQuantidade_MovimentocaoEstoque.PasswordChar = '\0';
            this.txtQuantidade_MovimentocaoEstoque.ReadOnly = true;
            this.txtQuantidade_MovimentocaoEstoque.SelectedText = "";
            this.txtQuantidade_MovimentocaoEstoque.Size = new System.Drawing.Size(97, 26);
            this.txtQuantidade_MovimentocaoEstoque.TabIndex = 149;
            // 
            // txtDescricao_MovimentocaoEstoque
            // 
            this.txtDescricao_MovimentocaoEstoque.BaseColor = System.Drawing.Color.White;
            this.txtDescricao_MovimentocaoEstoque.BorderColor = System.Drawing.Color.Silver;
            this.txtDescricao_MovimentocaoEstoque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao_MovimentocaoEstoque.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescricao_MovimentocaoEstoque.FocusedBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtDescricao_MovimentocaoEstoque.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescricao_MovimentocaoEstoque.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescricao_MovimentocaoEstoque.Location = new System.Drawing.Point(103, 226);
            this.txtDescricao_MovimentocaoEstoque.Name = "txtDescricao_MovimentocaoEstoque";
            this.txtDescricao_MovimentocaoEstoque.PasswordChar = '\0';
            this.txtDescricao_MovimentocaoEstoque.ReadOnly = true;
            this.txtDescricao_MovimentocaoEstoque.SelectedText = "";
            this.txtDescricao_MovimentocaoEstoque.Size = new System.Drawing.Size(556, 26);
            this.txtDescricao_MovimentocaoEstoque.TabIndex = 150;
            // 
            // txtLote_MovimentocaoEstoque
            // 
            this.txtLote_MovimentocaoEstoque.BaseColor = System.Drawing.Color.White;
            this.txtLote_MovimentocaoEstoque.BorderColor = System.Drawing.Color.Silver;
            this.txtLote_MovimentocaoEstoque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLote_MovimentocaoEstoque.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLote_MovimentocaoEstoque.FocusedBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtLote_MovimentocaoEstoque.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLote_MovimentocaoEstoque.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLote_MovimentocaoEstoque.Location = new System.Drawing.Point(103, 186);
            this.txtLote_MovimentocaoEstoque.Name = "txtLote_MovimentocaoEstoque";
            this.txtLote_MovimentocaoEstoque.PasswordChar = '\0';
            this.txtLote_MovimentocaoEstoque.ReadOnly = true;
            this.txtLote_MovimentocaoEstoque.SelectedText = "";
            this.txtLote_MovimentocaoEstoque.Size = new System.Drawing.Size(162, 26);
            this.txtLote_MovimentocaoEstoque.TabIndex = 151;
            // 
            // gvdMovimentacaoEstoque
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.gvdMovimentacaoEstoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gvdMovimentacaoEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvdMovimentacaoEstoque.BackgroundColor = System.Drawing.Color.White;
            this.gvdMovimentacaoEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvdMovimentacaoEstoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvdMovimentacaoEstoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvdMovimentacaoEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gvdMovimentacaoEstoque.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvdMovimentacaoEstoque.DefaultCellStyle = dataGridViewCellStyle9;
            this.gvdMovimentacaoEstoque.EnableHeadersVisualStyles = false;
            this.gvdMovimentacaoEstoque.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvdMovimentacaoEstoque.Location = new System.Drawing.Point(12, 394);
            this.gvdMovimentacaoEstoque.Name = "gvdMovimentacaoEstoque";
            this.gvdMovimentacaoEstoque.RowHeadersVisible = false;
            this.gvdMovimentacaoEstoque.RowHeadersWidth = 30;
            this.gvdMovimentacaoEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvdMovimentacaoEstoque.Size = new System.Drawing.Size(1019, 136);
            this.gvdMovimentacaoEstoque.TabIndex = 153;
            this.gvdMovimentacaoEstoque.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gvdMovimentacaoEstoque.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvdMovimentacaoEstoque.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvdMovimentacaoEstoque.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvdMovimentacaoEstoque.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvdMovimentacaoEstoque.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvdMovimentacaoEstoque.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvdMovimentacaoEstoque.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvdMovimentacaoEstoque.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gvdMovimentacaoEstoque.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvdMovimentacaoEstoque.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvdMovimentacaoEstoque.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvdMovimentacaoEstoque.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvdMovimentacaoEstoque.ThemeStyle.HeaderStyle.Height = 30;
            this.gvdMovimentacaoEstoque.ThemeStyle.ReadOnly = false;
            this.gvdMovimentacaoEstoque.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvdMovimentacaoEstoque.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvdMovimentacaoEstoque.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvdMovimentacaoEstoque.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvdMovimentacaoEstoque.ThemeStyle.RowsStyle.Height = 22;
            this.gvdMovimentacaoEstoque.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvdMovimentacaoEstoque.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(264, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 154;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(265, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 155;
            // 
            // SuprimentosControleTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvdMovimentacaoEstoque);
            this.Controls.Add(this.txtLote_MovimentocaoEstoque);
            this.Controls.Add(this.txtDescricao_MovimentocaoEstoque);
            this.Controls.Add(this.txtQuantidade_MovimentocaoEstoque);
            this.Controls.Add(this.txtLocal_MovimentacaoEstoque);
            this.Controls.Add(this.txtCodDaProduto_MovimentacaoEstoque);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.btnPesquisa_CadastroCliente);
            this.Controls.Add(this.btnModificar_CadastroCliente);
            this.Controls.Add(this.cmbDestino_MovimentacaoEstoque);
            this.Controls.Add(this.txtCodDeBarras_MovimentacaoEstoque);
            this.Controls.Add(this.gunaLabel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuprimentosControleTransferencia";
            this.Text = "SuprimentosControleTransferencia";
            ((System.ComponentModel.ISupportInitialize)(this.gvdMovimentacaoEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox txtCodDeBarras_MovimentacaoEstoque;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.ComboBox cmbDestino_MovimentacaoEstoque;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnPesquisa_CadastroCliente;
        private Guna.UI.WinForms.GunaAdvenceButton btnModificar_CadastroCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaTextBox txtCodDaProduto_MovimentacaoEstoque;
        private Guna.UI.WinForms.GunaTextBox txtLocal_MovimentacaoEstoque;
        private Guna.UI.WinForms.GunaTextBox txtQuantidade_MovimentocaoEstoque;
        private Guna.UI.WinForms.GunaTextBox txtDescricao_MovimentocaoEstoque;
        private Guna.UI.WinForms.GunaTextBox txtLote_MovimentocaoEstoque;
        private Guna.UI2.WinForms.Guna2DataGridView gvdMovimentacaoEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}