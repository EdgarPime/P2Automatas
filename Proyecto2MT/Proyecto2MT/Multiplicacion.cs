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
    public partial class Multiplicacion : Form
    {
        public Multiplicacion()
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
                dataGridView1.ColumnCount = Chars.Length + 2;

                dataGridView1.Columns[0].Name = " ";
                dataGridView1.Rows[0].Cells[0].Value = "B";
                for (int i = 1; i < Chars.Length+1; i++)
                {
                    dataGridView1.Columns[i-1].Name = " ";
                    dataGridView1.Rows[0].Cells[i].Value = Chars[i-1].ToString();
                }

                dataGridView1.Rows[0].Cells[Chars.Length+1].Value = "B";

                int j = 0;
                string caracter;
                bool incorrecto = false;
                int pasos = 1;

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
                        case "qo":
                            if (caracter == "B")
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
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,Y,R)");
                                Estado = "q2";
                                dataGridView1.Rows[0].Cells[j].Value = "Y";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q2,Y,R)");

                            }
                            else if (caracter == "x")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q4,X,R)");
                                Estado = "q4";
                                dataGridView1.Rows[0].Cells[j].Value = "x";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q4,X,R)");

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
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,l,R)");
                                Estado = "q2";
                                dataGridView1.Rows[0].Cells[j].Value = "l";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q2,l,R)");
                                
                            }
                            else if (caracter == "x")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,X,R)");
                                Estado = "q2";
                                dataGridView1.Rows[0].Cells[j].Value = "x";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q2,X,R)");
                            }
                            else if (caracter == "=")
                            {
                                
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,=,R)");
                                Estado = "q2";
                                dataGridView1.Rows[0].Cells[j].Value = "=";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q2,=,R)");
                            }
                            else if (caracter == "Z")
                            {

                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,Z,R)");
                                Estado = "q2";
                                dataGridView1.Rows[0].Cells[j].Value = "Z";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q2,Z,R)");
                            }
                            else if (caracter == "B")
                            {
                                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                                columna.HeaderText = " ";
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,l,L)");
                                Estado = "q3";
                                dataGridView1.Rows[0].Cells[j].Value = "l";
                                dataGridView1.Columns.Add(columna);
                                dataGridView1.Rows[0].Cells[j+1].Value = "B";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q3,l,L)");

                                
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
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,l,L)");
                                Estado = "q3";
                                dataGridView1.Rows[0].Cells[j].Value = "l";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q3,l,L)");
                            }
                            else if (caracter == "=")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,=,L)");
                                Estado = "q3";
                                dataGridView1.Rows[0].Cells[j].Value = "=";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q3,=,L)");
                            }
                            else if (caracter == "x")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,X,L)");
                                Estado = "q3";
                                dataGridView1.Rows[0].Cells[j].Value = "x";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q3,X,L)");
                            }
                            else if (caracter == "Z")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,Z,L)");
                                Estado = "q3";
                                dataGridView1.Rows[0].Cells[j].Value = "Z";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q3,Z,L)");
                            }
                            else if (caracter == "Y")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q1,l,R)");
                                Estado = "q1";
                                dataGridView1.Rows[0].Cells[j].Value = "l";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q1,l,R)");
                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }

                            break;

                        case "q4":
                            if (caracter == "l")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q5,Z,R)");
                                Estado = "q5";
                                dataGridView1.Rows[0].Cells[j].Value = "Z";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q5,Z,R)");


                            }
                            else if (caracter == "Z")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q5,Z,R)");
                                Estado = "q5";
                                dataGridView1.Rows[0].Cells[j].Value = "Z";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q5,Z,R)");


                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }

                            break;

                        case "q5":
                            if (caracter == "l")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q6,Z,L)");
                                Estado = "q6";
                                dataGridView1.Rows[0].Cells[j].Value = "Z";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q6,Z,L)");


                            }
                            else if (caracter == "=")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q7,=,L)");
                                Estado = "q7";
                                dataGridView1.Rows[0].Cells[j].Value = "=";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q7,=,L)");


                            }
                            else if (caracter == "Z")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q5,Z,R)");
                                Estado = "q5";
                                dataGridView1.Rows[0].Cells[j].Value = "Z";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q5,Z,R)");


                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }

                            break;

                        case "q6":
                            if (caracter == "l")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q6,l,L)");
                                Estado = "q6";
                                dataGridView1.Rows[0].Cells[j].Value = "l";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q6,l,L)");


                            }
                            else if (caracter == "x")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q6,X,L)");
                                Estado = "q6";
                                dataGridView1.Rows[0].Cells[j].Value = "x";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q6,X,L)");


                            }
                            else if (caracter == "Z")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q6,Z,L)");
                                Estado = "q6";
                                dataGridView1.Rows[0].Cells[j].Value = "Z";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q6,Z,L)");


                            }
                            else if (caracter == "B")
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

                        case "q7":
                            if (caracter == "Z")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q7,l,L)");
                                Estado = "q7";
                                dataGridView1.Rows[0].Cells[j].Value = "l";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q7,l,L)");

                            }
                            else if (caracter == "x")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q8,x,R)");
                                Estado = "q8";
                                dataGridView1.Rows[0].Cells[j].Value = "x";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q8,x,R)");

                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }

                            break;

                        case "q8":
                            if (caracter == "l")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q8,l,R)");
                                Estado = "q8";
                                dataGridView1.Rows[0].Cells[j].Value = "l";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q8,l,R)");


                            }
                            else if (caracter == "=")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q8,=,R)");
                                Estado = "q8";
                                dataGridView1.Rows[0].Cells[j].Value = "=";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q8,=,R)");


                            }
                            
                            else if (caracter == "B")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q8,B,R)");
                                Estado = "q8";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                j++;
                                //dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q8,B,R)");


                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }

                            break;


                    }
                    pasos++;
                    label5.Text = pasos.ToString();
                }
                if (Estado == "q8")
                {
                    MessageBox.Show("La cadena es aceptada");
                    label7.Text = "q8";
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        label3.Text = label3.Text + dataGridView1.Rows[0].Cells[i].Value.ToString();
                    }

                }
                else
                {
                    MessageBox.Show("La cadena no es aceptada");
                }




            }
        }
    }
}
