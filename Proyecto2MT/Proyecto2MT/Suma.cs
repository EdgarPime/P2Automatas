using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2MT
{
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
            
        }
        string Estado="q0";
        String cadena;
        int j=0;
        string caracter;
        bool incorrecto = false;
        int pasos = 1;
        bool verificar = false;
        bool aceptado = false;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void AgregarValores()
        {
            var Chars = cadena.ToCharArray();
            //dataGridView1.ColumnCount = Chars.Length + 1;
            for (int i = 0; i < Chars.Length; i++)
            {
                dataGridView1.Columns.Add("", "");
                //dataGridView1.Columns[i].Name = " ";
                dataGridView1.Rows[0].Cells[i].Value = Chars[i].ToString();
            }
            dataGridView1.Columns.Add("", "");
            dataGridView1.Rows[0].Cells[Chars.Length].Value = "B";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            Estado = "q0";
            
            j = 0;
            
            incorrecto = false;
            pasos = 1;
            verificar = false;
            aceptado = false;
            
            label7.Text = "";
            listBox1.Items.Clear();
            textBox2.Text = "";
            cadena = textBox1.Text;
            label7.Text = Estado;
            if (cadena == "")
            {
                MessageBox.Show("La cadena esta vacia");
            }
            else
            {
                if (!verificar)
                {
                    AgregarValores();

                    dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];                    
                    //MessageBox.Show("Realizando la suma");
                }
                
                timer1.Start();


            }


        }

        private void Suma_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //if (incorrecto == true)
            //{
            //    break;
            //}
            caracter = dataGridView1.Rows[0].Cells[j].Value.ToString();
            label7.Text = Estado;
            switch (Estado)
            {
                case "q0":
                    if (caracter == "1")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q1,B,R)");
                        Estado = "q1";
                        dataGridView1.Rows[0].Cells[j].Value = "B";
                        j++;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                        //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                        //MessageBox.Show("(q1,B,R)");



                    }
                    else
                    {
                        
                        timer1.Stop();
                    }

                    break;

                case "q1":
                    if (caracter == "1")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q1,1,R)");
                        Estado = "q1";
                        dataGridView1.Rows[0].Cells[j].Value = "1";
                        j++;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                       // MessageBox.Show("(q1,1,R)");

                    }
                    else if (caracter == "+")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,1,R)");
                        Estado = "q2";
                        dataGridView1.Rows[0].Cells[j].Value = "1";
                        j++;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                        //MessageBox.Show("(q2,1,R)");

                    }
                    else
                    {
                        incorrecto = true;
                        timer1.Stop();
                    }

                    break;

                case "q2":
                    if (caracter == "1")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,1,R)");
                        Estado = "q3";
                        dataGridView1.Rows[0].Cells[j].Value = "1";
                        j++;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                       // MessageBox.Show("(q3,1,R)");
                    }
                    else
                    {
                        incorrecto = true;
                        timer1.Stop();
                        
                    }

                    break;

                case "q3":
                    if (caracter == "1")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,1,R)");
                        Estado = "q3";
                        dataGridView1.Rows[0].Cells[j].Value = "1";
                        j++;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                        //MessageBox.Show("(q3,1,R)");
                    }
                    else if (caracter == "=")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q4,B,R)");
                        Estado = "q4";
                        dataGridView1.Rows[0].Cells[j].Value = "B";
                        j++;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                        //MessageBox.Show("(q4,B,R)");
                    }
                    else
                    {
                        incorrecto = true;
                        timer1.Stop();
                    }

                    break;

                case "q4":
                    aceptado = true;
                    timer1.Stop();
                    break; ;


            }
            pasos++;
            label5.Text = pasos.ToString();

            if (aceptado)
            {
                if (Estado == "q4")
                {
                    MessageBox.Show("La cadena es aceptada");
                    label7.Text = "q4";
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        textBox2.Text = textBox2.Text + dataGridView1.Rows[0].Cells[i].Value.ToString();
                    }

                }
                else
                {
                    MessageBox.Show("La cadena no es aceptada");

                }
            }
            if (incorrecto)
            {
                MessageBox.Show("No existe la transicion con "+ "'"+caracter+"'");
            }
        }
    }
   
}
