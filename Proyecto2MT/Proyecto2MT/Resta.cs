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
    public partial class Resta : Form
    {
        public Resta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Estado = "q0";
            label7.Text = "";
            listBox1.Items.Clear();
            textBox2.Text = "";
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

                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];                                              
                MessageBox.Show("Realizando la resta");

                while (j < dataGridView1.ColumnCount)
                {
                    if (incorrecto == true)
                    {
                        break;
                    }
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
                                MessageBox.Show("(q1,B,R)");


                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
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

                                MessageBox.Show("(q1,1,R)");

                            }
                            else if (caracter == "-")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,-,R)");
                                Estado = "q2";
                                dataGridView1.Rows[0].Cells[j].Value = "-";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q2,-,R)");

                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
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

                                MessageBox.Show("(q3,1,R)");
                            }
                            else if (caracter == "B")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q6,B,L)");
                                Estado = "q6";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q6,B,L)");
                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
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

                                MessageBox.Show("(q3,1,R)");
                            }
                            else if (caracter == "B")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q4,B,L)");
                                Estado = "q4";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q4,B,L)");
                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }

                            break;

                        case "q4":
                            if (caracter == "1")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q5,B,L)");
                                Estado = "q5";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q5,B,L)");
                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }
                            break;

                        case "q5":
                            if (caracter == "1")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q5,1,L)");
                                Estado = "q5";
                                dataGridView1.Rows[0].Cells[j].Value = "1";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q5,1,L)");
                            }
                            else if (caracter == "-")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q5,-,L)");
                                Estado = "q5";
                                dataGridView1.Rows[0].Cells[j].Value = "-";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q5,-,L)");
                            }
                            else if (caracter == "B")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q0,B,R)");
                                Estado = "q0";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q0,B,R)");
                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }
                            break;

                        case "q6":
                            if (caracter == "-")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q7,1,R)");
                                Estado = "q7";
                                dataGridView1.Rows[0].Cells[j].Value = "1";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q7,1,R)");


                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }

                            break;

                        case "q7":
                            j=j+ dataGridView1.ColumnCount;
                            break;

                    }
                    pasos++;
                    label5.Text = pasos.ToString();
                }
                if (Estado == "q7")
                {
                    MessageBox.Show("La cadena es aceptada");
                    label7.Text = "q7";
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
        }

        private void Resta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
