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
    public partial class Forms : Form
    {
        public Forms()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (TelaInicial.Controls.Count > 0)
                TelaInicial.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            TelaInicial.Controls.Add(f);
            TelaInicial.Tag = f;
            f.Show();
        }

        //Tela de Home
        private void btnHome_Click(object sender, EventArgs e)
        {
            loadform(new TelaHome());
        }

        //Tela de Cadastros
        private void btnClientesEFornecedores_Click(object sender, EventArgs e)
        {
            loadform(new Cadastro_Clientes_e_Fornecedores());
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            loadform(new Vendas_Nota_Fiscal_Saida());
        }

        //Tela de Suprimentos

        private void btnTransferenciaDeEstoque_Click_1(object sender, EventArgs e)
        {
            loadform(new SuprimentosControleTransferencia());
        }

        private void btnTransferenciaEntreEtiqueta_Click(object sender, EventArgs e)
        {
            loadform(new Transferencia_Etiqueta());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            loadform(new SuprimentoControleBusca());
        }

        private void btnNotaDeEntrada_Click(object sender, EventArgs e)
        {
            loadform(new SuprimentoNotaDeEntrada());
        }

        private void btnSuprimentosRelatorio_Click(object sender, EventArgs e)
        {
            loadform(new SuprimentoRelatorio());
        }

        //Tela de Vendas
        private void btnNotaFiscalSaida_Click(object sender, EventArgs e)
        {
            loadform(new VendasNotaFiscalSaida());
        }

        private void btnVendasRelatorio_Click(object sender, EventArgs e)
        {
            loadform(new VendasRelatorio());
        }

        private void Forms_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}