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
            string Estado = "q0";
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
                for (int i = 1; i < Chars.Length + 1; i++)
                {
                    dataGridView1.Columns[i - 1].Name = " ";
                    dataGridView1.Rows[0].Cells[i].Value = Chars[i - 1].ToString();
                }

                dataGridView1.Rows[0].Cells[Chars.Length + 1].Value = "B";

                int j = 1;
                string caracter;
                bool incorrecto = false;
                int pasos = 1;

                while (j < dataGridView1.ColumnCount+1)
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
                            if (caracter == "a")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q1,X,R)");
                                Estado = "q1";
                                dataGridView1.Rows[0].Cells[j].Value = "X";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q1,X,R)");


                            }
                            else if (caracter == "b")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,Y,R)");
                                Estado = "q3";
                                dataGridView1.Rows[0].Cells[j].Value = "Y";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q3,Y,R)");


                            }
                            else if (caracter == "c")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q5,Z,R)");
                                Estado = "q5";
                                dataGridView1.Rows[0].Cells[j].Value = "Z";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q5,Z,R)");


                            }
                            else if (caracter == "X")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q0,X,R)");
                                Estado = "q0";
                                dataGridView1.Rows[0].Cells[j].Value = "X";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q0,X,R)");


                            }
                            else if (caracter == "Y")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q0,Y,R)");
                                Estado = "q0";
                                dataGridView1.Rows[0].Cells[j].Value = "Y";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q0,Y,R)");


                            }
                            else if (caracter == "Z")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q0,Z,R)");
                                Estado = "q0";
                                dataGridView1.Rows[0].Cells[j].Value = "Z";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q0,Z,R)");


                            }
                            else if (caracter == "B")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q7,B,L)");
                                Estado = "q7";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q7,B,L)");


                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }

                            break;

                        case "q1":
                            if (caracter == "a")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q1,a,R)");
                                Estado = "q1";
                                dataGridView1.Rows[0].Cells[j].Value = "a";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q1,a,R)");

                            }
                            else if (caracter == "b")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q1,b,R)");
                                Estado = "q1";
                                dataGridView1.Rows[0].Cells[j].Value = "b";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q1,b,R)");

                            }
                            else if (caracter == "c")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q1,c,R)");
                                Estado = "q1";
                                dataGridView1.Rows[0].Cells[j].Value = "c";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q1,c,R)");

                            }
                            else if (caracter == "X")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q1,X,R)");
                                Estado = "q1";
                                dataGridView1.Rows[0].Cells[j].Value = "X";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q1,X,R)");

                            }
                            else if (caracter == "Y")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q1,Y,R)");
                                Estado = "q1";
                                dataGridView1.Rows[0].Cells[j].Value = "Y";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q1,Y,R)");

                            }
                            else if (caracter == "Z")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q1,Z,R)");
                                Estado = "q1";
                                dataGridView1.Rows[0].Cells[j].Value = "Z";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q1,Z,R)");

                            }
                            else if (caracter == "B")
                            {
                               
                                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                                columna.HeaderText = " ";
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,X,L)");
                                Estado = "q2";
                                dataGridView1.Rows[0].Cells[j].Value = "X";
                                dataGridView1.Columns.Add(columna);
                                dataGridView1.Rows[0].Cells[j + 1].Value = "B";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q2,X,L)");

                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }

                            break;

                        case "q2":
                            if (caracter == "a")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,a,L)");
                                Estado = "q2";
                                dataGridView1.Rows[0].Cells[j].Value = "a";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q2,a,L)");

                            }
                            else if (caracter == "b")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,b,L)");
                                Estado = "q2";
                                dataGridView1.Rows[0].Cells[j].Value = "b";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q2,b,L)");
                            }
                            else if (caracter == "c")
                            {

                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,c,L)");
                                Estado = "q2";
                                dataGridView1.Rows[0].Cells[j].Value = "c";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q2,c,L)");
                            }
                            else if (caracter == "X")
                            {

                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,X,L)");
                                Estado = "q2";
                                dataGridView1.Rows[0].Cells[j].Value = "X";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q2,X,L)");
                            }
                            else if (caracter == "Y")
                            {

                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,Y,L)");
                                Estado = "q2";
                                dataGridView1.Rows[0].Cells[j].Value = "Y";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q2,Y,L)");
                            }
                            else if (caracter == "Z")
                            {

                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,Z,L)");
                                Estado = "q2";
                                dataGridView1.Rows[0].Cells[j].Value = "Z";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q2,Z,L)");
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

                        case "q3":
                            if (caracter == "a")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,a,R)");
                                Estado = "q3";
                                dataGridView1.Rows[0].Cells[j].Value = "a";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q3,a,R)");
                            }
                            else if (caracter == "b")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,b,R)");
                                Estado = "q3";
                                dataGridView1.Rows[0].Cells[j].Value = "b";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q3,b,R)");
                            }
                            else if (caracter == "c")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,c,R)");
                                Estado = "q3";
                                dataGridView1.Rows[0].Cells[j].Value = "c";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q3,c,R)");
                            }
                            else if (caracter == "X")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,X,R)");
                                Estado = "q3";
                                dataGridView1.Rows[0].Cells[j].Value = "X";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q3,X,R)");
                            }
                            else if (caracter == "Y")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,Y,R)");
                                Estado = "q3";
                                dataGridView1.Rows[0].Cells[j].Value = "Y";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q3,Y,R)");
                            }
                            else if (caracter == "Z")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,Z,R)");
                                Estado = "q3";
                                dataGridView1.Rows[0].Cells[j].Value = "Z";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q3,Z,R)");
                            }
                            else if (caracter == "B")
                            {
                                
                                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                                columna.HeaderText = " ";
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q4,Y,L)");
                                Estado = "q4";
                                dataGridView1.Rows[0].Cells[j].Value = "Y";
                                dataGridView1.Columns.Add(columna);
                                dataGridView1.Rows[0].Cells[j + 1].Value = "B";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q4,Y,L)");
                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }

                            break;

                        case "q4":
                            if (caracter == "a")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q4,a,L)");
                                Estado = "q4";
                                dataGridView1.Rows[0].Cells[j].Value = "a";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q4,a,L)");


                            }
                            else if (caracter == "b")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q4,b,L)");
                                Estado = "q4";
                                dataGridView1.Rows[0].Cells[j].Value = "b";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q4,b,L)");


                            }
                            else if (caracter == "c")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q4,c,L)");
                                Estado = "q4";
                                dataGridView1.Rows[0].Cells[j].Value = "c";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q4,c,L)");


                            }
                            else if (caracter == "X")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q4,X,L)");
                                Estado = "q4";
                                dataGridView1.Rows[0].Cells[j].Value = "X";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q4,X,L)");


                            }
                            else if (caracter == "Y")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q4,Y,L)");
                                Estado = "q4";
                                dataGridView1.Rows[0].Cells[j].Value = "Y";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q4,Y,L)");


                            }
                            else if (caracter == "Z")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q4,Z,L)");
                                Estado = "q4";
                                dataGridView1.Rows[0].Cells[j].Value = "Z";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q4,Z,L)");


                            }
                            else if (caracter == "B")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q0,B,R)");
                                Estado = "q0";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q0,B,R)");


                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }

                            break;

                        case "q5":
                            if (caracter == "a")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q5,a,R)");
                                Estado = "q5";
                                dataGridView1.Rows[0].Cells[j].Value = "a";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q5,a,R)");


                            }
                            else if (caracter == "b")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q5,b,R)");
                                Estado = "q5";
                                dataGridView1.Rows[0].Cells[j].Value = "b";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q5,b,R)");


                            }
                            else if (caracter == "c")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q5,c,R)");
                                Estado = "q5";
                                dataGridView1.Rows[0].Cells[j].Value = "c";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q5,c,R)");


                            }
                            else if (caracter == "X")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q5,X,R)");
                                Estado = "q5";
                                dataGridView1.Rows[0].Cells[j].Value = "X";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q5,X,R)");


                            }
                            else if (caracter == "Y")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q5,Y,R)");
                                Estado = "q5";
                                dataGridView1.Rows[0].Cells[j].Value = "Y";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q5,Y,R)");


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
                            else if (caracter == "B")
                            {
                                

                                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                                columna.HeaderText = " ";
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q6,Z,L)");
                                Estado = "q6";
                                dataGridView1.Rows[0].Cells[j].Value = "Z";
                                dataGridView1.Columns.Add(columna);
                                dataGridView1.Rows[0].Cells[j + 1].Value = "B";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q6,Z,L)");


                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }

                            break;

                        case "q6":
                            if (caracter == "a")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q6,a,L)");
                                Estado = "q6";
                                dataGridView1.Rows[0].Cells[j].Value = "a";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q6,a,L)");


                            }
                            else if (caracter == "b")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q6,b,L)");
                                Estado = "q6";
                                dataGridView1.Rows[0].Cells[j].Value = "b";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q6,b,L)");


                            }
                            else if (caracter == "c")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q6,c,L)");
                                Estado = "q6";
                                dataGridView1.Rows[0].Cells[j].Value = "c";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q6,c,L)");


                            }
                            else if (caracter == "X")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q6,X,L)");
                                Estado = "q6";
                                dataGridView1.Rows[0].Cells[j].Value = "X";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q6,X,L)");


                            }
                            else if (caracter == "Y")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q6,Y,L)");
                                Estado = "q6";
                                dataGridView1.Rows[0].Cells[j].Value = "Y";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q6,Y,L)");


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
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q0,B,R)");
                                Estado = "q0";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q0,B,R)");


                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }

                            break;

                        case "q7":
                            if (caracter == "X")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q7,a,L)");
                                Estado = "q7";
                                dataGridView1.Rows[0].Cells[j].Value = "a";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q7,a,L)");

                            }
                            else if (caracter == "Y")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q7,b,L)");
                                Estado = "q7";
                                dataGridView1.Rows[0].Cells[j].Value = "b";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q7,b,L)");

                            }
                            else if (caracter == "Z")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q7,c,L)");
                                Estado = "q7";
                                dataGridView1.Rows[0].Cells[j].Value = "c";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q7,c,L)");

                            }
                            else if (caracter == "B")
                            {
                                
                                j= dataGridView1.ColumnCount + 2;
                               

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
                if (Estado == "q7")
                {
                    MessageBox.Show("La cadena es aceptada");
                    label7.Text = "q7";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
