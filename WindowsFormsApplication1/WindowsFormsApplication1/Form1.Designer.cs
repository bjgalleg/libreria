namespace WindowsFormsApplication1
{
    partial class ingresarusuario
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.nombreC = new System.Windows.Forms.TextBox();
            this.telefonoC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.estadoConexion = new System.Windows.Forms.Label();
            this.rucFB = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.nombreFB = new System.Windows.Forms.Label();
            this.telefonoFB = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RUC";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(95, 35);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(100, 20);
            this.txtruc.TabIndex = 4;
            this.txtruc.TextChanged += new System.EventHandler(this.txtruc_TextChanged);
            // 
            // nombreC
            // 
            this.nombreC.Location = new System.Drawing.Point(95, 62);
            this.nombreC.Name = "nombreC";
            this.nombreC.Size = new System.Drawing.Size(100, 20);
            this.nombreC.TabIndex = 5;
            this.nombreC.TextChanged += new System.EventHandler(this.nombreC_TextChanged);
            // 
            // telefonoC
            // 
            this.telefonoC.Location = new System.Drawing.Point(95, 88);
            this.telefonoC.Name = "telefonoC";
            this.telefonoC.Size = new System.Drawing.Size(100, 20);
            this.telefonoC.TabIndex = 6;
            this.telefonoC.TextChanged += new System.EventHandler(this.txttelefono_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dirección";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(95, 115);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(100, 20);
            this.txtdireccion.TabIndex = 8;
            // 
            // estadoConexion
            // 
            this.estadoConexion.AutoSize = true;
            this.estadoConexion.Location = new System.Drawing.Point(12, 9);
            this.estadoConexion.Name = "estadoConexion";
            this.estadoConexion.Size = new System.Drawing.Size(0, 13);
            this.estadoConexion.TabIndex = 9;
            // 
            // rucFB
            // 
            this.rucFB.AutoSize = true;
            this.rucFB.Location = new System.Drawing.Point(213, 44);
            this.rucFB.Name = "rucFB";
            this.rucFB.Size = new System.Drawing.Size(0, 13);
            this.rucFB.TabIndex = 10;
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(198, 195);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 11;
            this.register.Text = "Guardar";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreFB
            // 
            this.nombreFB.AutoSize = true;
            this.nombreFB.Location = new System.Drawing.Point(202, 68);
            this.nombreFB.Name = "nombreFB";
            this.nombreFB.Size = new System.Drawing.Size(0, 13);
            this.nombreFB.TabIndex = 12;
            // 
            // telefonoFB
            // 
            this.telefonoFB.AutoSize = true;
            this.telefonoFB.Location = new System.Drawing.Point(202, 95);
            this.telefonoFB.Name = "telefonoFB";
            this.telefonoFB.Size = new System.Drawing.Size(0, 13);
            this.telefonoFB.TabIndex = 13;
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(318, 194);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 14;
            this.salir.Text = "salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // ingresarusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 261);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.telefonoFB);
            this.Controls.Add(this.nombreFB);
            this.Controls.Add(this.register);
            this.Controls.Add(this.rucFB);
            this.Controls.Add(this.estadoConexion);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telefonoC);
            this.Controls.Add(this.nombreC);
            this.Controls.Add(this.txtruc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ingresarusuario";
            this.Text = "Ingresar usuario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.TextBox nombreC;
        private System.Windows.Forms.TextBox telefonoC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label estadoConexion;
        private System.Windows.Forms.Label rucFB;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label nombreFB;
        private System.Windows.Forms.Label telefonoFB;
        private System.Windows.Forms.Button salir;
    }
}

