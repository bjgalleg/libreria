namespace WindowsFormsApplication1
{
    partial class añadirlibro
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nomlib = new System.Windows.Forms.TextBox();
            this.autlib = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.existencias = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.libgen = new System.Windows.Forms.TextBox();
            this.libdes = new System.Windows.Forms.TextBox();
            this.registrar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Editorial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Existencias";
            // 
            // nomlib
            // 
            this.nomlib.Location = new System.Drawing.Point(157, 23);
            this.nomlib.Name = "nomlib";
            this.nomlib.Size = new System.Drawing.Size(100, 20);
            this.nomlib.TabIndex = 5;
            this.nomlib.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // autlib
            // 
            this.autlib.Location = new System.Drawing.Point(157, 53);
            this.autlib.Name = "autlib";
            this.autlib.Size = new System.Drawing.Size(100, 20);
            this.autlib.TabIndex = 6;
            this.autlib.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(157, 88);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(100, 20);
            this.edit.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(157, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // existencias
            // 
            this.existencias.Location = new System.Drawing.Point(361, 125);
            this.existencias.Name = "existencias";
            this.existencias.Size = new System.Drawing.Size(100, 20);
            this.existencias.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Género";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descripción";
            // 
            // libgen
            // 
            this.libgen.Location = new System.Drawing.Point(157, 166);
            this.libgen.Name = "libgen";
            this.libgen.Size = new System.Drawing.Size(100, 20);
            this.libgen.TabIndex = 12;
            this.libgen.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // libdes
            // 
            this.libdes.Location = new System.Drawing.Point(157, 197);
            this.libdes.Name = "libdes";
            this.libdes.Size = new System.Drawing.Size(100, 20);
            this.libdes.TabIndex = 13;
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(157, 261);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(75, 23);
            this.registrar.TabIndex = 14;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(311, 260);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 15;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            // 
            // añadirlibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 342);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.libdes);
            this.Controls.Add(this.libgen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.existencias);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.autlib);
            this.Controls.Add(this.nomlib);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "añadirlibro";
            this.Text = "Añadir libro";
            this.Load += new System.EventHandler(this.añadirlibro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nomlib;
        private System.Windows.Forms.TextBox autlib;
        private System.Windows.Forms.TextBox edit;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox existencias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox libgen;
        private System.Windows.Forms.TextBox libdes;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Button salir;
    }
}