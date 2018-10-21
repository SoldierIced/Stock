﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SASAI
{
    public partial class Escanear : Form
    {
        public string codigo="";
        public string codigo_MARCA="";
        public Escanear()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != "") {
                int aux = 0;
                foreach (char a in textBox2.Text) {
                    if (aux != 0) {
                        if (aux < 7)
                        {
                            codigo_MARCA += a.ToString();
                        }
                        else { codigo += a.ToString(); }

                    }
                    
                    aux++;
                }
                this.DialogResult=DialogResult.OK;
            this.Close();
            }
            else { MessageBox.Show("Ingrese algun valor en los campos."); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            codigo = "";
            codigo_MARCA = "";
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Escanear_Load(object sender, EventArgs e)
        {

        }

        private void Escanear_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
