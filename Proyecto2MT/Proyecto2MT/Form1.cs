using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2MT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Suma form = new Suma();
            form.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Multiplicacion form = new Multiplicacion();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resta form = new Resta();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Copiar form = new Copiar();
            form.Show();
        }
    }
}
