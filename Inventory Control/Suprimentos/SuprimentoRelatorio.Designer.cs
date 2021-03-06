namespace Inventory_Control
{
    partial class SuprimentoRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuprimentoRelatorio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnPesquisa_CadastroCliente = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gdvRelatorioNFEntrada_Suprimento = new Guna.UI2.WinForms.Guna2DataGridView();
            this.NF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Razao_Social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Lancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDataInicio_Relatorio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpDataFinal_Relatorio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.GraficoEntrada = new Bunifu.DataViz.WinForms.BunifuDataViz();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRelatorioNFEntrada_Suprimento)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(4, 53);
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
            this.btnPesquisa_CadastroCliente.TabIndex = 2;
            this.btnPesquisa_CadastroCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPesquisa_CadastroCliente.Click += new System.EventHandler(this.btnPesquisa_CadastroCliente_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(10, 117);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(66, 15);
            this.gunaLabel5.TabIndex = 143;
            this.gunaLabel5.Tag = "103; 109";
            this.gunaLabel5.Text = "Data Início:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(10, 162);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(62, 15);
            this.gunaLabel1.TabIndex = 145;
            this.gunaLabel1.Tag = "103; 109";
            this.gunaLabel1.Text = "Data Final:";
            // 
            // gdvRelatorioNFEntrada_Suprimento
            // 
            this.gdvRelatorioNFEntrada_Suprimento.AllowUserToAddRows = false;
            this.gdvRelatorioNFEntrada_Suprimento.AllowUserToDeleteRows = false;
            this.gdvRelatorioNFEntrada_Suprimento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gdvRelatorioNFEntrada_Suprimento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvRelatorioNFEntrada_Suprimento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gdvRelatorioNFEntrada_Suprimento.BackgroundColor = System.Drawing.Color.White;
            this.gdvRelatorioNFEntrada_Suprimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvRelatorioNFEntrada_Suprimento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvRelatorioNFEntrada_Suprimento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvRelatorioNFEntrada_Suprimento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdvRelatorioNFEntrada_Suprimento.ColumnHeadersHeight = 30;
            this.gdvRelatorioNFEntrada_Suprimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NF,
            this.CNPJ,
            this.Nome_Razao_Social,
            this.Cod_Produto,
            this.Descricao_Produto,
            this.QUANT,
            this.UNIDADE,
            this.Valor_Unitario,
            this.Valor_Total,
            this.Data_Emissao,
            this.Data_Lancamento});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvRelatorioNFEntrada_Suprimento.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdvRelatorioNFEntrada_Suprimento.EnableHeadersVisualStyles = false;
            this.gdvRelatorioNFEntrada_Suprimento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvRelatorioNFEntrada_Suprimento.Location = new System.Drawing.Point(13, 339);
            this.gdvRelatorioNFEntrada_Suprimento.MultiSelect = false;
            this.gdvRelatorioNFEntrada_Suprimento.Name = "gdvRelatorioNFEntrada_Suprimento";
            this.gdvRelatorioNFEntrada_Suprimento.RowHeadersVisible = false;
            this.gdvRelatorioNFEntrada_Suprimento.RowHeadersWidth = 45;
            this.gdvRelatorioNFEntrada_Suprimento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvRelatorioNFEntrada_Suprimento.Size = new System.Drawing.Size(975, 191);
            this.gdvRelatorioNFEntrada_Suprimento.TabIndex = 148;
            this.gdvRelatorioNFEntrada_Suprimento.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.Highlight;
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.HeaderStyle.Height = 30;
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.ReadOnly = false;
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.RowsStyle.Height = 22;
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvRelatorioNFEntrada_Suprimento.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // NF
            // 
            this.NF.DataPropertyName = "NF";
            this.NF.HeaderText = "Nota Fiscal";
            this.NF.Name = "NF";
            this.NF.Width = 98;
            // 
            // CNPJ
            // 
            this.CNPJ.DataPropertyName = "CNPJ";
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.Width = 63;
            // 
            // Nome_Razao_Social
            // 
            this.Nome_Razao_Social.DataPropertyName = "Nome_Razao_Social";
            this.Nome_Razao_Social.HeaderText = "Nome Razao Social";
            this.Nome_Razao_Social.Name = "Nome_Razao_Social";
            this.Nome_Razao_Social.Width = 147;
            // 
            // Cod_Produto
            // 
            this.Cod_Produto.DataPropertyName = "Cod_Produto";
            this.Cod_Produto.HeaderText = "Codigo Produto";
            this.Cod_Produto.Name = "Cod_Produto";
            this.Cod_Produto.Width = 130;
            // 
            // Descricao_Produto
            // 
            this.Descricao_Produto.DataPropertyName = "Descricao_Produto";
            this.Descricao_Produto.HeaderText = "Descricao Produto";
            this.Descricao_Produto.Name = "Descricao_Produto";
            this.Descricao_Produto.Width = 144;
            // 
            // QUANT
            // 
            this.QUANT.DataPropertyName = "QUANT";
            this.QUANT.HeaderText = "Quantidade";
            this.QUANT.Name = "QUANT";
            this.QUANT.Width = 104;
            // 
            // UNIDADE
            // 
            this.UNIDADE.DataPropertyName = "UNIDADE";
            this.UNIDADE.HeaderText = "Unidade";
            this.UNIDADE.Name = "UNIDADE";
            this.UNIDADE.Width = 83;
            // 
            // Valor_Unitario
            // 
            this.Valor_Unitario.DataPropertyName = "Valor_Unitario";
            this.Valor_Unitario.HeaderText = "Valor Unitario";
            this.Valor_Unitario.Name = "Valor_Unitario";
            this.Valor_Unitario.Width = 116;
            // 
            // Valor_Total
            // 
            this.Valor_Total.DataPropertyName = "Valor_Total";
            this.Valor_Total.HeaderText = "Valor Total";
            this.Valor_Total.Name = "Valor_Total";
            this.Valor_Total.Width = 96;
            // 
            // Data_Emissao
            // 
            this.Data_Emissao.DataPropertyName = "Data_Emissao";
            this.Data_Emissao.HeaderText = "Data de Emissao";
            this.Data_Emissao.Name = "Data_Emissao";
            this.Data_Emissao.Width = 133;
            // 
            // Data_Lancamento
            // 
            this.Data_Lancamento.DataPropertyName = "Data_Lancamento";
            this.Data_Lancamento.HeaderText = "Data de Lancamento";
            this.Data_Lancamento.Name = "Data_Lancamento";
            this.Data_Lancamento.Width = 159;
            // 
            // dtpDataInicio_Relatorio
            // 
            this.dtpDataInicio_Relatorio.CheckedState.Parent = this.dtpDataInicio_Relatorio;
            this.dtpDataInicio_Relatorio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpDataInicio_Relatorio.ForeColor = System.Drawing.Color.White;
            this.dtpDataInicio_Relatorio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDataInicio_Relatorio.HoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.dtpDataInicio_Relatorio.HoverState.ForeColor = System.Drawing.Color.White;
            this.dtpDataInicio_Relatorio.HoverState.Parent = this.dtpDataInicio_Relatorio;
            this.dtpDataInicio_Relatorio.Location = new System.Drawing.Point(91, 96);
            this.dtpDataInicio_Relatorio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDataInicio_Relatorio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDataInicio_Relatorio.Name = "dtpDataInicio_Relatorio";
            this.dtpDataInicio_Relatorio.ShadowDecoration.Parent = this.dtpDataInicio_Relatorio;
            this.dtpDataInicio_Relatorio.Size = new System.Drawing.Size(229, 36);
            this.dtpDataInicio_Relatorio.TabIndex = 0;
            this.dtpDataInicio_Relatorio.Value = new System.DateTime(2022, 4, 11, 22, 17, 20, 615);
            // 
            // dtpDataFinal_Relatorio
            // 
            this.dtpDataFinal_Relatorio.CheckedState.Parent = this.dtpDataFinal_Relatorio;
            this.dtpDataFinal_Relatorio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpDataFinal_Relatorio.ForeColor = System.Drawing.Color.White;
            this.dtpDataFinal_Relatorio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDataFinal_Relatorio.HoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.dtpDataFinal_Relatorio.HoverState.ForeColor = System.Drawing.Color.White;
            this.dtpDataFinal_Relatorio.HoverState.Parent = this.dtpDataFinal_Relatorio;
            this.dtpDataFinal_Relatorio.Location = new System.Drawing.Point(91, 141);
            this.dtpDataFinal_Relatorio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDataFinal_Relatorio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDataFinal_Relatorio.Name = "dtpDataFinal_Relatorio";
            this.dtpDataFinal_Relatorio.ShadowDecoration.Parent = this.dtpDataFinal_Relatorio;
            this.dtpDataFinal_Relatorio.Size = new System.Drawing.Size(229, 36);
            this.dtpDataFinal_Relatorio.TabIndex = 1;
            this.dtpDataFinal_Relatorio.Value = new System.DateTime(2022, 4, 11, 22, 17, 20, 615);
            // 
            // GraficoEntrada
            // 
            this.GraficoEntrada.animationEnabled = false;
            this.GraficoEntrada.AxisLineColor = System.Drawing.Color.Silver;
            this.GraficoEntrada.AxisXFontColor = System.Drawing.Color.White;
            this.GraficoEntrada.AxisXGridColor = System.Drawing.Color.White;
            this.GraficoEntrada.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GraficoEntrada.AxisYFontColor = System.Drawing.Color.White;
            this.GraficoEntrada.AxisYGridColor = System.Drawing.Color.White;
            this.GraficoEntrada.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GraficoEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GraficoEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GraficoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraficoEntrada.ForeColor = System.Drawing.Color.Red;
            this.GraficoEntrada.Location = new System.Drawing.Point(377, 28);
            this.GraficoEntrada.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.GraficoEntrada.Name = "GraficoEntrada";
            this.GraficoEntrada.Size = new System.Drawing.Size(609, 265);
            this.GraficoEntrada.TabIndex = 151;
            this.GraficoEntrada.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme1;
            this.GraficoEntrada.Title = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 152;
            this.label1.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(645, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 153;
            this.label2.Text = "Codigo do Produto";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(553, 28);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(307, 25);
            this.gunaLabel2.TabIndex = 154;
            this.gunaLabel2.Text = "Top 5 Produtos Com Maior Entrada";
            // 
            // SuprimentoRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 542);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GraficoEntrada);
            this.Controls.Add(this.dtpDataFinal_Relatorio);
            this.Controls.Add(this.dtpDataInicio_Relatorio);
            this.Controls.Add(this.gdvRelatorioNFEntrada_Suprimento);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.btnPesquisa_CadastroCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuprimentoRelatorio";
            this.Text = "SuprimentoRelatorioGeral";
            this.Load += new System.EventHandler(this.SuprimentoRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvRelatorioNFEntrada_Suprimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaAdvenceButton btnPesquisa_CadastroCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView gdvRelatorioNFEntrada_Suprimento;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDataInicio_Relatorio;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDataFinal_Relatorio;
        private Bunifu.DataViz.WinForms.BunifuDataViz GraficoEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Razao_Social;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANT;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Lancamento;
    }
}