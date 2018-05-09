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
        string Estado = "q1";
        String cadena;
        int j = 1;
        string caracter;
        bool incorrecto = false;
        int pasos = 1;
        bool verificar = false;
        bool aceptado = false;

        public void AgregarValores()
        {
           

            var Chars = cadena.ToCharArray();
            //dataGridView1.ColumnCount = Chars.Length + 2;

            dataGridView1.Columns.Add("", "");
            dataGridView1.Rows[0].Cells[0].Value = "B";
            for (int i = 1; i < Chars.Length + 1; i++)
            {
                dataGridView1.Columns.Add("", "");
                dataGridView1.Rows[0].Cells[i].Value = Chars[i - 1].ToString();
            }
            dataGridView1.Columns.Add("", "");
            dataGridView1.Rows[0].Cells[Chars.Length + 1].Value = "B";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            Estado = "q1";

            j = 1;

            incorrecto = false;
            pasos = 1;
            verificar = false;
            aceptado = false;

            label7.Text = "";
            listBox1.Items.Clear();
            label3.Text = "";
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
                    MessageBox.Show("Realizando la multiplicacion");
                    dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];
                    
                }

                timer1.Start();

           
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            caracter = dataGridView1.Rows[0].Cells[j].Value.ToString();
            label7.Text = Estado;
            switch (Estado)
            {

                case "q1":
                    if (caracter == "1")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,Y,R)");
                        Estado = "q2";
                        dataGridView1.Rows[0].Cells[j].Value = "Y";
                        j++;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                        

                    }
                    else if (caracter == "x")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q4,X,R)");
                        Estado = "q4";
                        dataGridView1.Rows[0].Cells[j].Value = "x";
                        j++;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                       

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
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,1,R)");
                        Estado = "q2";
                        dataGridView1.Rows[0].Cells[j].Value = "1";
                        j++;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                        

                    }
                    else if (caracter == "x")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,X,R)");
                        Estado = "q2";
                        dataGridView1.Rows[0].Cells[j].Value = "x";
                        j++;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                        
                    }
                    else if (caracter == "=")
                    {

                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,=,R)");
                        Estado = "q2";
                        dataGridView1.Rows[0].Cells[j].Value = "=";
                        j++;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                        
                    }
                    else if (caracter == "Z")
                    {

                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,Z,R)");
                        Estado = "q2";
                        dataGridView1.Rows[0].Cells[j].Value = "Z";
                        j++;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                        
                    }
                    else if (caracter == "B")
                    {
                        DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                        columna.HeaderText = " ";
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,1,L)");
                        Estado = "q3";
                        dataGridView1.Rows[0].Cells[j].Value = "1";
                        dataGridView1.Columns.Add(columna);
                        dataGridView1.Rows[0].Cells[j + 1].Value = "B";
                        j--;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];


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
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,1,L)");
                        Estado = "q3";
                        dataGridView1.Rows[0].Cells[j].Value = "1";
                        j--;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                        
                    }
                    else if (caracter == "=")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,=,L)");
                        Estado = "q3";
                        dataGridView1.Rows[0].Cells[j].Value = "=";
                        j--;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                        
                    }
                    else if (caracter == "x")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,X,L)");
                        Estado = "q3";
                        dataGridView1.Rows[0].Cells[j].Value = "x";
                        j--;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                        
                    }
                    else if (caracter == "Z")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q3,Z,L)");
                        Estado = "q3";
                        dataGridView1.Rows[0].Cells[j].Value = "Z";
                        j--;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                        
                    }
                    else if (caracter == "Y")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q1,1,R)");
                        Estado = "q1";
                        dataGridView1.Rows[0].Cells[j].Value = "1";
                        j++;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                        
                    }
                    else
                    {
                        incorrecto = true;
                        timer1.Stop();
                    }

                    break;

                case "q4":
                    if (caracter == "1")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q5,Z,R)");
                        Estado = "q5";
                        dataGridView1.Rows[0].Cells[j].Value = "Z";
                        j++;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                        //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                        


                    }
                    else if (caracter == "Z")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q5,Z,R)");
                        Estado = "q5";
                        dataGridView1.Rows[0].Cells[j].Value = "Z";
                        j++;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                        //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                       


                    }
                    else
                    {
                        incorrecto = true;
                        timer1.Stop();
                    }

                    break;

                case "q5":
                    if (caracter == "1")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q6,Z,L)");
                        Estado = "q6";
                        dataGridView1.Rows[0].Cells[j].Value = "Z";
                        j--;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                        //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                        


                    }
                    else if (caracter == "=")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q7,=,L)");
                        Estado = "q7";
                        dataGridView1.Rows[0].Cells[j].Value = "=";
                        j--;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                        //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                       


                    }
                    else if (caracter == "Z")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q5,Z,R)");
                        Estado = "q5";
                        dataGridView1.Rows[0].Cells[j].Value = "Z";
                        j++;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                        //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                        


                    }
                    else
                    {
                        incorrecto = true;
                        timer1.Stop();
                    }

                    break;

                case "q6":
                    if (caracter == "1")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q6,1,L)");
                        Estado = "q6";
                        dataGridView1.Rows[0].Cells[j].Value = "1";
                        j--;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                        //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                        


                    }
                    else if (caracter == "x")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q6,X,L)");
                        Estado = "q6";
                        dataGridView1.Rows[0].Cells[j].Value = "x";
                        j--;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                        //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                        


                    }
                    else if (caracter == "Z")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q6,Z,L)");
                        Estado = "q6";
                        dataGridView1.Rows[0].Cells[j].Value = "Z";
                        j--;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                        //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                        


                    }
                    else if (caracter == "B")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q1,B,R)");
                        Estado = "q1";
                        dataGridView1.Rows[0].Cells[j].Value = "B";
                        j++;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                        //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                       


                    }
                    else
                    {
                        incorrecto = true;
                        timer1.Stop();
                    }

                    break;

                case "q7":
                    if (caracter == "Z")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q7,1,L)");
                        Estado = "q7";
                        dataGridView1.Rows[0].Cells[j].Value = "1";
                        j--;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                        //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                        

                    }
                    else if (caracter == "x")
                    {
                        listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q8,x,R)");
                        Estado = "q8";
                        dataGridView1.Rows[0].Cells[j].Value = "x";
                        j++;
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];
                        //dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Aqua;                                
                        

                    }
                    else
                    {
                        incorrecto = true;
                        timer1.Stop();
                    }

                    break;

                case "q8":
                    aceptado = true;
                    timer1.Stop();
                    break;


            }
            pasos++;
            label5.Text = pasos.ToString();


            if(aceptado)
            {
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

            if (incorrecto)
            {
                MessageBox.Show("No existe la transicion con " + "'" + caracter + "'");
            }


        }
    }
}
