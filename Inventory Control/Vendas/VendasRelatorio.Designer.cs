namespace Inventory_Control
{
    partial class VendasRelatorio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendasRelatorio));
            this.gdvRelatorioNFSaida_Vendas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnPesquisa_CadastroCliente = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dtpDataInicio_Relatorio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpDataFinal_Relatorio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.GraficoSaida = new Bunifu.DataViz.WinForms.BunifuDataViz();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRelatorioNFSaida_Vendas)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvRelatorioNFSaida_Vendas
            // 
            this.gdvRelatorioNFSaida_Vendas.AllowUserToAddRows = false;
            this.gdvRelatorioNFSaida_Vendas.AllowUserToDeleteRows = false;
            this.gdvRelatorioNFSaida_Vendas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gdvRelatorioNFSaida_Vendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvRelatorioNFSaida_Vendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvRelatorioNFSaida_Vendas.BackgroundColor = System.Drawing.Color.White;
            this.gdvRelatorioNFSaida_Vendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvRelatorioNFSaida_Vendas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvRelatorioNFSaida_Vendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvRelatorioNFSaida_Vendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdvRelatorioNFSaida_Vendas.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvRelatorioNFSaida_Vendas.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdvRelatorioNFSaida_Vendas.EnableHeadersVisualStyles = false;
            this.gdvRelatorioNFSaida_Vendas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvRelatorioNFSaida_Vendas.Location = new System.Drawing.Point(13, 339);
            this.gdvRelatorioNFSaida_Vendas.MultiSelect = false;
            this.gdvRelatorioNFSaida_Vendas.Name = "gdvRelatorioNFSaida_Vendas";
            this.gdvRelatorioNFSaida_Vendas.ReadOnly = true;
            this.gdvRelatorioNFSaida_Vendas.RowHeadersVisible = false;
            this.gdvRelatorioNFSaida_Vendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvRelatorioNFSaida_Vendas.Size = new System.Drawing.Size(1019, 191);
            this.gdvRelatorioNFSaida_Vendas.TabIndex = 154;
            this.gdvRelatorioNFSaida_Vendas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.Highlight;
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.HeaderStyle.Height = 30;
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.ReadOnly = true;
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.RowsStyle.Height = 22;
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdvRelatorioNFSaida_Vendas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(10, 162);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(62, 15);
            this.gunaLabel1.TabIndex = 152;
            this.gunaLabel1.Tag = "103; 109";
            this.gunaLabel1.Text = "Data Final:";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(10, 117);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(66, 15);
            this.gunaLabel5.TabIndex = 150;
            this.gunaLabel5.Tag = "103; 109";
            this.gunaLabel5.Text = "Data Início:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(4, 53);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(57, 15);
            this.gunaLabel4.TabIndex = 149;
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
            this.btnPesquisa_CadastroCliente.TabIndex = 148;
            this.btnPesquisa_CadastroCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPesquisa_CadastroCliente.Click += new System.EventHandler(this.btnPesquisa_CadastroCliente_Click);
            // 
            // dtpDataInicio_Relatorio
            // 
            this.dtpDataInicio_Relatorio.BackColor = System.Drawing.SystemColors.Control;
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
            this.dtpDataInicio_Relatorio.TabIndex = 155;
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
            this.dtpDataFinal_Relatorio.TabIndex = 156;
            this.dtpDataFinal_Relatorio.Value = new System.DateTime(2022, 4, 11, 22, 17, 20, 615);
            // 
            // GraficoSaida
            // 
            this.GraficoSaida.animationEnabled = false;
            this.GraficoSaida.AxisLineColor = System.Drawing.Color.Silver;
            this.GraficoSaida.AxisXFontColor = System.Drawing.Color.White;
            this.GraficoSaida.AxisXGridColor = System.Drawing.Color.White;
            this.GraficoSaida.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GraficoSaida.AxisYFontColor = System.Drawing.Color.White;
            this.GraficoSaida.AxisYGridColor = System.Drawing.Color.White;
            this.GraficoSaida.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GraficoSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GraficoSaida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GraficoSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraficoSaida.ForeColor = System.Drawing.Color.Red;
            this.GraficoSaida.Location = new System.Drawing.Point(423, 28);
            this.GraficoSaida.Name = "GraficoSaida";
            this.GraficoSaida.Size = new System.Drawing.Size(609, 265);
            this.GraficoSaida.TabIndex = 157;
            this.GraficoSaida.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme1;
            this.GraficoSaida.Title = "";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(599, 28);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(288, 25);
            this.gunaLabel2.TabIndex = 158;
            this.gunaLabel2.Text = "Top 5 Produtos Com Maior Saida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 159;
            this.label1.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(691, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 160;
            this.label2.Text = "Codigo do Produto";
            // 
            // VendasRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.GraficoSaida);
            this.Controls.Add(this.dtpDataFinal_Relatorio);
            this.Controls.Add(this.dtpDataInicio_Relatorio);
            this.Controls.Add(this.gdvRelatorioNFSaida_Vendas);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.btnPesquisa_CadastroCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VendasRelatorio";
            this.Text = "VendasRelatorio";
            this.Load += new System.EventHandler(this.VendasRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvRelatorioNFSaida_Vendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gdvRelatorioNFSaida_Vendas;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaAdvenceButton btnPesquisa_CadastroCliente;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDataInicio_Relatorio;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDataFinal_Relatorio;
        private Bunifu.DataViz.WinForms.BunifuDataViz GraficoSaida;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}