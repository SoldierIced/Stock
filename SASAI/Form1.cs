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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void darDeAltaUnaMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Escanear es = new Escanear();

            Formularios.AbrirFormularioHijos(es);
            if (es.DialogResult == DialogResult.OK)
            {
                Formularios.AbrirFormularioHijos(new Alta_Materia(es.codigo));

            }


        }

        private void listarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Escanear es = new Escanear();

            Formularios.AbrirFormularioHijos(es);
            if (es.DialogResult == DialogResult.OK) {
                
                
                Formularios.AbrirFormularioHijos(new Editar_Marca(es.codigo_MARCA));
            }
           
        }

        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.AbrirFormularioPadre(new Listar_Productos());
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Escanear es = new Escanear();

            Formularios.AbrirFormularioHijos(es);
            if (es.DialogResult == DialogResult.OK)
            {
                Formularios.AbrirFormularioHijos(new Alta_producto(es.codigo,es.codigo_MARCA));
             }
        }
    }
}
