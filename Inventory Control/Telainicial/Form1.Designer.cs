namespace Inventory_Control
{
    partial class Forms
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnHome = new System.Windows.Forms.ToolStripMenuItem();
            this.tesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClientesEFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.esfasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asfafsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTransferenciaDeEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTransferenciaEntreEtiqueta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNotaDeEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuprimentosRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.fasdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNotaFiscalSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVendasRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TelaInicial = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(984, -1);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.SystemColors.Highlight;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.White;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(938, -1);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.SystemColors.Highlight;
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 1;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.menuStrip1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHome,
            this.tesToolStripMenuItem,
            this.esfasToolStripMenuItem,
            this.fasdfToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1025, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.ImageTransparentColor = System.Drawing.Color.LimeGreen;
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(57, 24);
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // tesToolStripMenuItem
            // 
            this.tesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientesEFornecedores,
            this.btnProdutos});
            this.tesToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tesToolStripMenuItem.Name = "tesToolStripMenuItem";
            this.tesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.tesToolStripMenuItem.Text = "Cadastros";
            // 
            // btnClientesEFornecedores
            // 
            this.btnClientesEFornecedores.Name = "btnClientesEFornecedores";
            this.btnClientesEFornecedores.Size = new System.Drawing.Size(227, 24);
            this.btnClientesEFornecedores.Text = "Clientes e Fornecedores";
            this.btnClientesEFornecedores.Click += new System.EventHandler(this.btnClientesEFornecedores_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(227, 24);
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // esfasToolStripMenuItem
            // 
            this.esfasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asfafsToolStripMenuItem,
            this.btnNotaDeEntrada,
            this.btnSuprimentosRelatorio});
            this.esfasToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esfasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.esfasToolStripMenuItem.Name = "esfasToolStripMenuItem";
            this.esfasToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.esfasToolStripMenuItem.Text = "Suprimentos";
            // 
            // asfafsToolStripMenuItem
            // 
            this.asfafsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimentaçãoToolStripMenuItem,
            this.btnBuscar});
            this.asfafsToolStripMenuItem.Name = "asfafsToolStripMenuItem";
            this.asfafsToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.asfafsToolStripMenuItem.Text = "Controle de Estoque";
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTransferenciaDeEstoque,
            this.btnTransferenciaEntreEtiqueta});
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // btnTransferenciaDeEstoque
            // 
            this.btnTransferenciaDeEstoque.Name = "btnTransferenciaDeEstoque";
            this.btnTransferenciaDeEstoque.Size = new System.Drawing.Size(251, 24);
            this.btnTransferenciaDeEstoque.Text = "Transferencia Local";
            this.btnTransferenciaDeEstoque.Click += new System.EventHandler(this.btnTransferenciaDeEstoque_Click_1);
            // 
            // btnTransferenciaEntreEtiqueta
            // 
            this.btnTransferenciaEntreEtiqueta.Name = "btnTransferenciaEntreEtiqueta";
            this.btnTransferenciaEntreEtiqueta.Size = new System.Drawing.Size(251, 24);
            this.btnTransferenciaEntreEtiqueta.Text = "Transferencia Entre Etiquetas";
            this.btnTransferenciaEntreEtiqueta.Click += new System.EventHandler(this.btnTransferenciaEntreEtiqueta_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(165, 24);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNotaDeEntrada
            // 
            this.btnNotaDeEntrada.Name = "btnNotaDeEntrada";
            this.btnNotaDeEntrada.Size = new System.Drawing.Size(202, 24);
            this.btnNotaDeEntrada.Text = "Nota de Entrada";
            this.btnNotaDeEntrada.Click += new System.EventHandler(this.btnNotaDeEntrada_Click);
            // 
            // btnSuprimentosRelatorio
            // 
            this.btnSuprimentosRelatorio.Name = "btnSuprimentosRelatorio";
            this.btnSuprimentosRelatorio.Size = new System.Drawing.Size(202, 24);
            this.btnSuprimentosRelatorio.Text = "Relatório Entrada";
            this.btnSuprimentosRelatorio.Click += new System.EventHandler(this.btnSuprimentosRelatorio_Click);
            // 
            // fasdfToolStripMenuItem
            // 
            this.fasdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNotaFiscalSaida,
            this.btnVendasRelatorio});
            this.fasdfToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fasdfToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fasdfToolStripMenuItem.Name = "fasdfToolStripMenuItem";
            this.fasdfToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.fasdfToolStripMenuItem.Text = "Vendas";
            // 
            // btnNotaFiscalSaida
            // 
            this.btnNotaFiscalSaida.Name = "btnNotaFiscalSaida";
            this.btnNotaFiscalSaida.Size = new System.Drawing.Size(169, 24);
            this.btnNotaFiscalSaida.Text = "Nota Fiscal ";
            this.btnNotaFiscalSaida.Click += new System.EventHandler(this.btnNotaFiscalSaida_Click);
            // 
            // btnVendasRelatorio
            // 
            this.btnVendasRelatorio.Name = "btnVendasRelatorio";
            this.btnVendasRelatorio.Size = new System.Drawing.Size(169, 24);
            this.btnVendasRelatorio.Text = "Relatório Saída";
            this.btnVendasRelatorio.Click += new System.EventHandler(this.btnVendasRelatorio_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 10);
            this.panel1.TabIndex = 0;
            // 
            // TelaInicial
            // 
            this.TelaInicial.BackColor = System.Drawing.Color.White;
            this.TelaInicial.BackgroundImage = global::Inventory_Control.Properties.Resources.Imagem_Inicial_V2_0_copiar;
            this.TelaInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TelaInicial.Location = new System.Drawing.Point(12, 34);
            this.TelaInicial.Name = "TelaInicial";
            this.TelaInicial.Size = new System.Drawing.Size(1000, 542);
            this.TelaInicial.TabIndex = 3;
            // 
            // Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1025, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.TelaInicial);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Forms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Forms_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel TelaInicial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnHome;
        private System.Windows.Forms.ToolStripMenuItem tesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnClientesEFornecedores;
        private System.Windows.Forms.ToolStripMenuItem btnProdutos;
        private System.Windows.Forms.ToolStripMenuItem esfasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asfafsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnTransferenciaDeEstoque;
        private System.Windows.Forms.ToolStripMenuItem btnTransferenciaEntreEtiqueta;
        private System.Windows.Forms.ToolStripMenuItem btnBuscar;
        private System.Windows.Forms.ToolStripMenuItem btnNotaDeEntrada;
        private System.Windows.Forms.ToolStripMenuItem btnSuprimentosRelatorio;
        private System.Windows.Forms.ToolStripMenuItem fasdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNotaFiscalSaida;
        private System.Windows.Forms.ToolStripMenuItem btnVendasRelatorio;
    }
}

