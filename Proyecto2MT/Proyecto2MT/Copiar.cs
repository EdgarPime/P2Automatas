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
    public partial class Copiar : Form
    {
        public Copiar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Estado = "qo";
            label7.Text = "";
            listBox1.Items.Clear();
            label3.Text = "";
            String cadena = textBox1.Text;
            label7.Text = Estado;
            if (cadena == "")
            {
                MessageBox.Show("La cadena esta vacia");
            }
            else
            {
                var Chars = cadena.ToCharArray();
                dataGridView1.ColumnCount = Chars.Length + 1;
                for (int i = 0; i < Chars.Length; i++)
                {
                    dataGridView1.Columns[i].Name = " ";
                    dataGridView1.Rows[0].Cells[i].Value = Chars[i].ToString();
                }
                dataGridView1.Rows[0].Cells[Chars.Length].Value = "B";

                int j = 0;
                string caracter;
                bool incorrecto = false;
                int pasos = 1;
            }
        }
    }
}
