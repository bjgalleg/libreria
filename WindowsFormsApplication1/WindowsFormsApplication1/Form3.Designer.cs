namespace WindowsFormsApplication1
{
    partial class Inventario
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
            this.salir = new System.Windows.Forms.Button();
            this.añadir = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(100, 205);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 0;
            this.salir.Text = "salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // añadir
            // 
            this.añadir.Location = new System.Drawing.Point(100, 32);
            this.añadir.Name = "añadir";
            this.añadir.Size = new System.Drawing.Size(75, 23);
            this.añadir.TabIndex = 1;
            this.añadir.Text = "Añadir libro";
            this.añadir.UseVisualStyleBackColor = true;
            this.añadir.Click += new System.EventHandler(this.añadir_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(100, 75);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 2;
            this.eliminar.Text = "Eliminar libro";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(82, 117);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(112, 23);
            this.consultar.TabIndex = 3;
            this.consultar.Text = "Consultar libro";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(91, 157);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(94, 23);
            this.modificar.TabIndex = 4;
            this.modificar.Text = "Modificar libro";
            this.modificar.UseVisualStyleBackColor = true;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.añadir);
            this.Controls.Add(this.salir);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button añadir;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button modificar;
    }
}