namespace SASAI
{
    partial class Ventas_salida
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
            this.marcat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.detallet = new System.Windows.Forms.TextBox();
            this.cantidadt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // marcat
            // 
            this.marcat.Location = new System.Drawing.Point(86, 23);
            this.marcat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.marcat.Name = "marcat";
            this.marcat.ReadOnly = true;
            this.marcat.Size = new System.Drawing.Size(265, 29);
            this.marcat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Producto:";
            // 
            // nombret
            // 
            this.nombret.Location = new System.Drawing.Point(184, 64);
            this.nombret.Margin = new System.Windows.Forms.Padding(6);
            this.nombret.Name = "nombret";
            this.nombret.ReadOnly = true;
            this.nombret.Size = new System.Drawing.Size(490, 29);
            this.nombret.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Detalle:";
            // 
            // detallet
            // 
            this.detallet.Location = new System.Drawing.Point(86, 105);
            this.detallet.Margin = new System.Windows.Forms.Padding(6);
            this.detallet.Name = "detallet";
            this.detallet.ReadOnly = true;
            this.detallet.Size = new System.Drawing.Size(588, 29);
            this.detallet.TabIndex = 4;
            // 
            // cantidadt
            // 
            this.cantidadt.Location = new System.Drawing.Point(325, 156);
            this.cantidadt.Name = "cantidadt";
            this.cantidadt.Size = new System.Drawing.Size(153, 29);
            this.cantidadt.TabIndex = 6;
            this.cantidadt.Text = "1";
            this.cantidadt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad de venta:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(147, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(434, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ventas_salida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 283);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cantidadt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.detallet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombret);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marcat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Ventas_salida";
            this.Text = "Ventas_salida";
            this.Load += new System.EventHandler(this.Ventas_salida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox marcat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox detallet;
        private System.Windows.Forms.TextBox cantidadt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}