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
    public partial class Palin : Form
    {
        public Palin()
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

                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
                MessageBox.Show("Verificar si es palindromo");

                while (j < dataGridView1.ColumnCount + 1)
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
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q1,B,R)");
                                Estado = "q1";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q1,B,R)");


                            }
                            else if (caracter == "b")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q4,B,R)");
                                Estado = "q4";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q4,B,R)");


                            }
                            else if (caracter == "c")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q7,B,R)");
                                Estado = "q7";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q7,B,R)");


                            }
                           
                            else if (caracter == "B")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q10,B,R)");
                                Estado = "q10";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q10,B,R)");


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
                            
                            else if (caracter == "B")
                            {

                                
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,B,L)");
                                Estado = "q2";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q2,B,L)");

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
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,B,L)");
                                Estado = "q3";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q3,B,L)");

                            }
                           
                            else if (caracter == "B")
                            {

                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q10,B,R)");
                                Estado = "q10";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q10,B,R)");
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
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,a,L)");
                                Estado = "q3";
                                dataGridView1.Rows[0].Cells[j].Value = "a";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q3,a,L)");
                            }
                            else if (caracter == "b")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,b,L)");
                                Estado = "q3";
                                dataGridView1.Rows[0].Cells[j].Value = "b";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q3,b,L)");
                            }
                            else if (caracter == "c")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,c,L)");
                                Estado = "q3";
                                dataGridView1.Rows[0].Cells[j].Value = "c";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q3,c,L)");
                            }
                           
                            else if (caracter == "B")
                            {

                               
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: q0,B,R)");
                                Estado = "q0";
                                dataGridView1.Rows[0].Cells[j].Value = "B";                                
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("q0,B,R)");
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
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q4,a,R)");
                                Estado = "q4";
                                dataGridView1.Rows[0].Cells[j].Value = "a";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q4,a,R)");


                            }
                            else if (caracter == "b")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q4,b,R)");
                                Estado = "q4";
                                dataGridView1.Rows[0].Cells[j].Value = "b";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q4,b,R)");


                            }
                            else if (caracter == "c")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q4,c,R)");
                                Estado = "q4";
                                dataGridView1.Rows[0].Cells[j].Value = "c";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q4,c,R)");


                            }
                           
                            else if (caracter == "B")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q5,B,L)");
                                Estado = "q5";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q5,B,L)");


                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }

                            break;

                        case "q5":
                            if (caracter == "b")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q6,B,L)");
                                Estado = "q6";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q6,B,L)");


                            }
                            else if (caracter == "B")
                            {


                                
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q10,B,R)");
                                Estado = "q10";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q10,B,R)");


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
                            if (caracter == "a")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q7,a,R)");
                                Estado = "q7";
                                dataGridView1.Rows[0].Cells[j].Value = "a";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q7,a,R)");

                            }
                            else if (caracter == "b")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q7,b,R)");
                                Estado = "q7";
                                dataGridView1.Rows[0].Cells[j].Value = "b";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q7,b,R)");

                            }
                            else if (caracter == "c")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q7,c,L)");
                                Estado = "q7";
                                dataGridView1.Rows[0].Cells[j].Value = "c";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q7,c,L)");

                            }
                            else if (caracter == "B")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q8,B,L)");
                                Estado = "q8";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q8,B,L)");

                               
                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }

                            break;

                        case "q8":
                            if (caracter == "c")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q9,B,L)");
                                Estado = "q9";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q9,B,L)");


                            }
                            else if (caracter == "B")
                            {

                                
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q10,B,R)");
                                Estado = "q10";
                                dataGridView1.Rows[0].Cells[j].Value = "B";
                                
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q10,B,R)");


                            }
                            else
                            {
                                MessageBox.Show("No existe la transicion");
                                incorrecto = true;
                            }

                            break;

                        case "q9":
                            if (caracter == "a")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q9,a,L)");
                                Estado = "q9";
                                dataGridView1.Rows[0].Cells[j].Value = "a";
                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                                //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                                MessageBox.Show("(q9,a,L)");


                            }
                            else if (caracter == "b")
                            { 
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q9,b,L)");
                                Estado = "q9";
                                dataGridView1.Rows[0].Cells[j].Value = "b";

                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q9,b,L)");


                            }
                            else if (caracter == "c")
                            {

                                
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q9,c,L)");
                                Estado = "q9";
                                dataGridView1.Rows[0].Cells[j].Value = "c";

                                j--;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q9,c,L)");


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

                        case "q10":
                            j = dataGridView1.ColumnCount + 2;
                            break;


                    }
                    pasos++;
                    label5.Text = pasos.ToString();
                }
                if (Estado == "q10")
                {
                    MessageBox.Show("La cadena es palindromo");
                    label7.Text = "q10";
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        textBox2.Text = textBox2.Text + dataGridView1.Rows[0].Cells[i].Value.ToString();
                    }

                }
                else
                {
                    MessageBox.Show("La cadena no es palindromo");
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
