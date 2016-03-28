namespace WindowsFormsApplication1
{
    partial class usuarios
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
            this.agregarUsuario = new System.Windows.Forms.Button();
            this.modificarUsuario = new System.Windows.Forms.Button();
            this.eliminarUsuario = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agregarUsuario
            // 
            this.agregarUsuario.Location = new System.Drawing.Point(99, 49);
            this.agregarUsuario.Name = "agregarUsuario";
            this.agregarUsuario.Size = new System.Drawing.Size(123, 23);
            this.agregarUsuario.TabIndex = 0;
            this.agregarUsuario.Text = "Agregar usuario";
            this.agregarUsuario.UseVisualStyleBackColor = true;
            this.agregarUsuario.Click += new System.EventHandler(this.agregarUsuario_Click);
            // 
            // modificarUsuario
            // 
            this.modificarUsuario.Location = new System.Drawing.Point(99, 91);
            this.modificarUsuario.Name = "modificarUsuario";
            this.modificarUsuario.Size = new System.Drawing.Size(123, 23);
            this.modificarUsuario.TabIndex = 1;
            this.modificarUsuario.Text = "Modificar usuario";
            this.modificarUsuario.UseVisualStyleBackColor = true;
            // 
            // eliminarUsuario
            // 
            this.eliminarUsuario.Location = new System.Drawing.Point(99, 139);
            this.eliminarUsuario.Name = "eliminarUsuario";
            this.eliminarUsuario.Size = new System.Drawing.Size(123, 23);
            this.eliminarUsuario.TabIndex = 2;
            this.eliminarUsuario.Text = "Eliminar usuario";
            this.eliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(99, 190);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(123, 23);
            this.salir.TabIndex = 3;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 261);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.eliminarUsuario);
            this.Controls.Add(this.modificarUsuario);
            this.Controls.Add(this.agregarUsuario);
            this.Name = "usuarios";
            this.Text = "Usuarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button agregarUsuario;
        private System.Windows.Forms.Button modificarUsuario;
        private System.Windows.Forms.Button eliminarUsuario;
        private System.Windows.Forms.Button salir;
    }
}