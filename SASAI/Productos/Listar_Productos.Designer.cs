namespace SASAI
{
    partial class Listar_Productos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.marca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pmen = new System.Windows.Forms.RadioButton();
            this.pigu = new System.Windows.Forms.RadioButton();
            this.pmay = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.smen = new System.Windows.Forms.RadioButton();
            this.sigu = new System.Windows.Forms.RadioButton();
            this.smay = new System.Windows.Forms.RadioButton();
            this.detalle = new System.Windows.Forms.ComboBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gv = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // marca
            // 
            this.marca.FormattingEnabled = true;
            this.marca.Location = new System.Drawing.Point(151, 16);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(327, 21);
            this.marca.TabIndex = 3;
            this.marca.SelectedIndexChanged += new System.EventHandler(this.marca_SelectedIndexChanged);
            this.marca.TextUpdate += new System.EventHandler(this.marca_TextUpdate);
            this.marca.SelectedValueChanged += new System.EventHandler(this.marca_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stock:";
            // 
            // NombreP
            // 
            this.NombreP.Location = new System.Drawing.Point(151, 70);
            this.NombreP.Name = "NombreP";
            this.NombreP.Size = new System.Drawing.Size(507, 20);
            this.NombreP.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Detalle Producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo:";
            // 
            // Tipo
            // 
            this.Tipo.FormattingEnabled = true;
            this.Tipo.Location = new System.Drawing.Point(63, 43);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(277, 21);
            this.Tipo.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(202, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.detalle);
            this.groupBox1.Controls.Add(this.precio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.stock);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.marca);
            this.groupBox1.Controls.Add(this.Tipo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NombreP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 161);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pmen);
            this.groupBox3.Controls.Add(this.pigu);
            this.groupBox3.Controls.Add(this.pmay);
            this.groupBox3.Location = new System.Drawing.Point(395, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(121, 31);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // pmen
            // 
            this.pmen.AutoSize = true;
            this.pmen.Location = new System.Drawing.Point(6, 10);
            this.pmen.Name = "pmen";
            this.pmen.Size = new System.Drawing.Size(37, 17);
            this.pmen.TabIndex = 20;
            this.pmen.TabStop = true;
            this.pmen.Text = "<=";
            this.pmen.UseVisualStyleBackColor = true;
            // 
            // pigu
            // 
            this.pigu.AutoSize = true;
            this.pigu.Location = new System.Drawing.Point(86, 10);
            this.pigu.Name = "pigu";
            this.pigu.Size = new System.Drawing.Size(31, 17);
            this.pigu.TabIndex = 22;
            this.pigu.TabStop = true;
            this.pigu.Text = "=";
            this.pigu.UseVisualStyleBackColor = true;
            // 
            // pmay
            // 
            this.pmay.AutoSize = true;
            this.pmay.Location = new System.Drawing.Point(43, 10);
            this.pmay.Name = "pmay";
            this.pmay.Size = new System.Drawing.Size(37, 17);
            this.pmay.TabIndex = 21;
            this.pmay.TabStop = true;
            this.pmay.Text = ">=";
            this.pmay.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.smen);
            this.groupBox2.Controls.Add(this.sigu);
            this.groupBox2.Controls.Add(this.smay);
            this.groupBox2.Location = new System.Drawing.Point(63, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 31);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // smen
            // 
            this.smen.AutoSize = true;
            this.smen.Location = new System.Drawing.Point(6, 10);
            this.smen.Name = "smen";
            this.smen.Size = new System.Drawing.Size(37, 17);
            this.smen.TabIndex = 20;
            this.smen.TabStop = true;
            this.smen.Text = "<=";
            this.smen.UseVisualStyleBackColor = true;
            // 
            // sigu
            // 
            this.sigu.AutoSize = true;
            this.sigu.Location = new System.Drawing.Point(86, 10);
            this.sigu.Name = "sigu";
            this.sigu.Size = new System.Drawing.Size(31, 17);
            this.sigu.TabIndex = 22;
            this.sigu.TabStop = true;
            this.sigu.Text = "=";
            this.sigu.UseVisualStyleBackColor = true;
            // 
            // smay
            // 
            this.smay.AutoSize = true;
            this.smay.Location = new System.Drawing.Point(43, 10);
            this.smay.Name = "smay";
            this.smay.Size = new System.Drawing.Size(37, 17);
            this.smay.TabIndex = 21;
            this.smay.TabStop = true;
            this.smay.Text = ">=";
            this.smay.UseVisualStyleBackColor = true;
            // 
            // detalle
            // 
            this.detalle.FormattingEnabled = true;
            this.detalle.Location = new System.Drawing.Point(151, 100);
            this.detalle.Name = "detalle";
            this.detalle.Size = new System.Drawing.Size(507, 21);
            this.detalle.TabIndex = 19;
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(522, 133);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(80, 20);
            this.precio.TabIndex = 18;
            this.precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(332, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Precio:";
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(190, 131);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(80, 20);
            this.stock.TabIndex = 16;
            this.stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precio_KeyPress);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(337, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 30);
            this.button2.TabIndex = 17;
            this.button2.Text = "Borrar Filtros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gv
            // 
            this.gv.AllowUserToAddRows = false;
            this.gv.AllowUserToDeleteRows = false;
            this.gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gv.CausesValidation = false;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gv.Location = new System.Drawing.Point(0, 215);
            this.gv.Name = "gv";
            this.gv.ShowCellErrors = false;
            this.gv.ShowEditingIcon = false;
            this.gv.ShowRowErrors = false;
            this.gv.Size = new System.Drawing.Size(693, 166);
            this.gv.TabIndex = 18;
            this.gv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellValueChanged);
            // 
            // Listar_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 381);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "Listar_Productos";
            this.Text = "Listar_Productos";
            this.Load += new System.EventHandler(this.Listar_Productos_Load);
            this.Resize += new System.EventHandler(this.Listar_Productos_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox marca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Tipo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.ComboBox detalle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton pmen;
        private System.Windows.Forms.RadioButton pigu;
        private System.Windows.Forms.RadioButton pmay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton smen;
        private System.Windows.Forms.RadioButton sigu;
        private System.Windows.Forms.RadioButton smay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView gv;
    }
}