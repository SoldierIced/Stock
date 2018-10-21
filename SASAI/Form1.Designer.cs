namespace SASAI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.materisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeAltaUnaMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProductoMasivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materisaToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.ventaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // materisaToolStripMenuItem
            // 
            this.materisaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darDeAltaUnaMarcaToolStripMenuItem,
            this.listarMarcasToolStripMenuItem});
            this.materisaToolStripMenuItem.Name = "materisaToolStripMenuItem";
            this.materisaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.materisaToolStripMenuItem.Text = "Marcas";
            // 
            // darDeAltaUnaMarcaToolStripMenuItem
            // 
            this.darDeAltaUnaMarcaToolStripMenuItem.Name = "darDeAltaUnaMarcaToolStripMenuItem";
            this.darDeAltaUnaMarcaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.darDeAltaUnaMarcaToolStripMenuItem.Text = "Dar de alta una Marca";
            this.darDeAltaUnaMarcaToolStripMenuItem.Click += new System.EventHandler(this.darDeAltaUnaMarcaToolStripMenuItem_Click);
            // 
            // listarMarcasToolStripMenuItem
            // 
            this.listarMarcasToolStripMenuItem.Name = "listarMarcasToolStripMenuItem";
            this.listarMarcasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.listarMarcasToolStripMenuItem.Text = "Modificar Marca";
            this.listarMarcasToolStripMenuItem.Click += new System.EventHandler(this.listarMarcasToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarProductosToolStripMenuItem,
            this.editarProductoToolStripMenuItem,
            this.nuevoProductoToolStripMenuItem,
            this.nuevoProductoMasivoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // listarProductosToolStripMenuItem
            // 
            this.listarProductosToolStripMenuItem.Name = "listarProductosToolStripMenuItem";
            this.listarProductosToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.listarProductosToolStripMenuItem.Text = "Listar productos";
            this.listarProductosToolStripMenuItem.Click += new System.EventHandler(this.listarProductosToolStripMenuItem_Click);
            // 
            // editarProductoToolStripMenuItem
            // 
            this.editarProductoToolStripMenuItem.Name = "editarProductoToolStripMenuItem";
            this.editarProductoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.editarProductoToolStripMenuItem.Text = "Editar producto";
            this.editarProductoToolStripMenuItem.Click += new System.EventHandler(this.editarProductoToolStripMenuItem_Click);
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            this.nuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.nuevoProductoToolStripMenuItem.Text = "Nuevo Producto";
            this.nuevoProductoToolStripMenuItem.Click += new System.EventHandler(this.nuevoProductoToolStripMenuItem_Click);
            // 
            // nuevoProductoMasivoToolStripMenuItem
            // 
            this.nuevoProductoMasivoToolStripMenuItem.Name = "nuevoProductoMasivoToolStripMenuItem";
            this.nuevoProductoMasivoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.nuevoProductoMasivoToolStripMenuItem.Text = "Nuevo Producto (Masivo)";
            this.nuevoProductoMasivoToolStripMenuItem.Click += new System.EventHandler(this.nuevoProductoMasivoToolStripMenuItem_Click);
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarVentasToolStripMenuItem,
            this.venderProductoToolStripMenuItem});
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ventaToolStripMenuItem.Text = "Venta";
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // listarVentasToolStripMenuItem
            // 
            this.listarVentasToolStripMenuItem.Name = "listarVentasToolStripMenuItem";
            this.listarVentasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarVentasToolStripMenuItem.Text = "Listar Ventas";
            this.listarVentasToolStripMenuItem.Click += new System.EventHandler(this.listarVentasToolStripMenuItem_Click);
            // 
            // venderProductoToolStripMenuItem
            // 
            this.venderProductoToolStripMenuItem.Name = "venderProductoToolStripMenuItem";
            this.venderProductoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.venderProductoToolStripMenuItem.Text = "Vender producto";
            this.venderProductoToolStripMenuItem.Click += new System.EventHandler(this.venderProductoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "-. Control de Stock .-";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem materisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeAltaUnaMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venderProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProductoMasivoToolStripMenuItem;
    }
}