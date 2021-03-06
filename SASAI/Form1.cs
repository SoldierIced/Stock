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
                Marca m = new Marca();
                Alta_Materia a = new Alta_Materia(es.codigo_MARCA);
                m.codigoM = es.codigo_MARCA;
                if (m.registro_Existente() == true)
                {
                    MessageBox.Show("Codigo de Marca ya creado.");



                }
                else {
                    Formularios.AbrirFormularioHijos(new Alta_Materia(es.codigo_MARCA));
                }

            }


        }

        private void listarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Escanear es = new Escanear();

            Formularios.AbrirFormularioHijos(es);
            if (es.DialogResult == DialogResult.OK) {
                Marca m = new Marca();
                Alta_Materia a = new Alta_Materia(es.codigo_MARCA);
                m.codigoM = es.codigo_MARCA;
                if (m.registro_Existente() != true)
                {
                    MessageBox.Show("Codigo de Marca inexistente.");

                }
                else { Formularios.AbrirFormularioHijos(new Editar_Marca(es.codigo_MARCA)); }

              
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

                Marca m = new Marca();
                Alta_Materia a = new Alta_Materia(es.codigo_MARCA);
                m.codigoM = es.codigo_MARCA;
                if (m.registro_Existente() != true)
                {
                    MessageBox.Show("Codigo de Marca inexistente. Carguela Primero.");

                    Formularios.AbrirFormularioHijos(a);
                    if (a.DialogResult == DialogResult.OK)
                    {
                        Formularios.AbrirFormularioHijos(new Alta_producto(es.codigo, es.codigo_MARCA));
                    }
                }
                else {
                    Formularios.AbrirFormularioHijos(new Alta_producto(es.codigo, es.codigo_MARCA));
                }

               



              
             }
        }

        private void editarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Escanear es = new Escanear();

            Formularios.AbrirFormularioHijos(es);
            if (es.DialogResult == DialogResult.OK)
            {
                Producto p = new Producto(es.codigo_MARCA, es.codigo);
                if (p.get_codigoM() != string.Empty)
                    Formularios.AbrirFormularioHijos(new Modificar_Producto(es.codigo, es.codigo_MARCA));
                else { MessageBox.Show("Producto inexistente."); }
            }
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void venderProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Escanear es = new Escanear();

            Formularios.AbrirFormularioHijos(es);
            if (es.DialogResult == DialogResult.OK)
            {
                Producto p = new Producto(es.codigo_MARCA, es.codigo);
                if (p.get_codigoM() != string.Empty) {

                    Ventas_salida ve = new Ventas_salida(es.codigo_MARCA, es.codigo);
                    Formularios.AbrirFormularioHijos(ve);
                    if (ve.DialogResult == DialogResult.OK) { 
                Formularios.AbrirFormularioPadre(new Ventas_Listar());
                        }
                }
                else { MessageBox.Show("Producto inexistente."); }

            }
        }

        private void listarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.AbrirFormularioPadre(new Ventas_Listar());
        }

        private void nuevoProductoMasivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool seguir = true;
            while (seguir == true)
            {
               Escanear es = new Escanear();
                Formularios.AbrirFormularioHijos(es);
                if (es.DialogResult == DialogResult.OK)
                {

                    Marca m = new Marca();
                    Alta_Materia a = new Alta_Materia(es.codigo_MARCA);
                    m.codigoM = es.codigo_MARCA;
                    if (m.registro_Existente() != true)
                    {
                        MessageBox.Show("Codigo de Marca inexistente. Carguela Primero.");

                        Formularios.AbrirFormularioHijos(a);
                        if (a.DialogResult == DialogResult.OK)
                        {
                            Formularios.AbrirFormularioHijos(new Alta_producto(es.codigo, es.codigo_MARCA));
                        }
                    }
                    else
                    {
                        Formularios.AbrirFormularioHijos(new Alta_producto(es.codigo, es.codigo_MARCA));
                    }

                }
                else { seguir = false; }
            }
        }
    }
}
