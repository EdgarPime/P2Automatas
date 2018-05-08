﻿using System;
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
            dataGridView1.Columns.Add("", "");
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
                AutoClosingMessageBox.Show("hola que hace", "Caption", 500);
                MessageBox.Show("Realizando la suma");
                

                while (j < Chars.Length)
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
                            else if (caracter == "+")
                            {
                                listBox1.Items.Add("Paso: " + pasos + " ---> Caracter: " + caracter + " ---> UC= " + Estado + " ---> transicion: (q2,1,R)");
                                Estado = "q2";
                                dataGridView1.Rows[0].Cells[j].Value = "1";
                                j++;
                                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[j];

                                MessageBox.Show("(q2,1,R)");

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

                            break; ;


                    }
                    pasos++;
                    label5.Text = pasos.ToString();
                }
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

        
    }
    public class AutoClosingMessageBox
    {
        System.Threading.Timer _timeoutTimer;
        string _caption;
        AutoClosingMessageBox()
        {
            _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                null, 500, System.Threading.Timeout.Infinite);
            using (_timeoutTimer) ;
        }
        public static void Show(string text, string caption, int timeout)
        {
            new AutoClosingMessageBox();
        }
        void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            _timeoutTimer.Dispose();
        }
        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
    }
}
