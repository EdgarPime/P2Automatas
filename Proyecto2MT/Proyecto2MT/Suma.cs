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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Estado = "q0";
            label7.Text = "";
            listBox1.Items.Clear();            
            label3.Text = "";
            String cadena = textBox1.Text;
            label7.Text = Estado;
            if (cadena=="")
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
                while(j<Chars.Length)
                {
                    if(incorrecto==true)
                    {
                        break;
                    }
                    caracter = dataGridView1.Rows[0].Cells[j].Value.ToString();
                    label7.Text = Estado;
                    switch (Estado)
                    {
                        case "q0":
                            if (caracter=="l")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q1,B,R)");
                                Estado = "q1";
                                dataGridView1.Rows[0].Cells[j].Value = "B";                                
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q1,B,R)");
                                
                                
                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }
                            
                            break;

                        case "q1":
                            if (caracter == "l")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q1,l,R)");
                                Estado = "q1";
                                dataGridView1.Rows[0].Cells[j].Value = "l";                               
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                                                
                                MessageBox.Show("(q1,l,R)");
                                
                            }
                            else if(caracter == "+")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,l,R)");
                                Estado = "q2";
                                dataGridView1.Rows[0].Cells[j].Value = "l";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                
                                MessageBox.Show("(q2,l,R)");
                                
                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }

                            break;

                        case "q2":
                            if (caracter == "l")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,l,R)");
                                Estado = "q3";
                                dataGridView1.Rows[0].Cells[j].Value = "l";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                
                                MessageBox.Show("(q3,l,R)");
                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }

                            break;

                        case "q3":
                            if (caracter == "l")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,l,R)");
                                Estado = "q3";
                                dataGridView1.Rows[0].Cells[j].Value = "l";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                
                                MessageBox.Show("(q3,l,R)");
                            }
                            else if (caracter == "=")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q4,B,R)");
                                Estado = "q4";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                
                                MessageBox.Show("(q4,B,R)");
                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }

                            break;

                        case "q4":
                            
                            break;

                           
                    }
                    pasos++;
                    label5.Text = pasos.ToString();
                }
                if (Estado=="q4")
                {
                    MessageBox.Show("La cadena es aceptada");
                    label7.Text = "q4";
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        label3.Text=label3.Text+dataGridView1.Rows[0].Cells[i].Value.ToString();
                    }
                   
                }
                else
                {
                    MessageBox.Show("La cadena no es aceptada");
                }

                

            }
            
        }

        private void Suma_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
