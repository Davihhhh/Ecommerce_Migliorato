using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }
        Prodotto prova1 = new Elettronico("nome", "modello", "descrzione", "produttore", 20.0);
        private void Main_Load(object sender, EventArgs e)
        {

            //textBox.Text = DateTime.Now.ToString();
            //textBox.Text = prova1.getPrezzoScontato().ToString();
        }

    }
}
