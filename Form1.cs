using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntLancar_Click(object sender, EventArgs e)
        {
            List<string> lPrecos = new List<string>();
            lPrecos.Add(textPreco.Text);

            List<string> lProdutos = new List<string>();
            lProdutos.Add(textProduto.Text);

            foreach (object item in lProdutos)
            {
                listProduto.Items.Add(item.ToString());
            }

            foreach (object item in lPrecos)
            {
                listPreco.Items.Add(item.ToString());
            }

            decimal preco = decimal.Parse(textPreco.Text);

            decimal total = decimal.Parse(lblTotalVendas.Text) + preco;
            lblTotalVendas.Text = total.ToString();

            textPreco.Clear();
            textProduto.Clear();

        }
        private void listProduto_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void bntRemover_Click(object sender, EventArgs e)
        {
            decimal preco = decimal.Parse(listPreco.SelectedItem.ToString());
            decimal total = decimal.Parse(lblTotalVendas.Text) - preco;

            lblTotalVendas.Text = total.ToString();
            listProduto.Items.Remove(listProduto.SelectedItem);
            listPreco.Items.Remove(listPreco.SelectedItem);
        }

        private void lblTotalVendas_Click(object sender, EventArgs e)
        {

        }
    }
}
