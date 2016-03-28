namespace WindowsFormsApplication1
{
    partial class eliminarusuario
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
            this.eliminar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminarUs = new System.Windows.Forms.TextBox();
            this.limpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(111, 172);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 0;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(111, 211);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 1;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresar RUC";
            // 
            // eliminarUs
            // 
            this.eliminarUs.Location = new System.Drawing.Point(111, 59);
            this.eliminarUs.Name = "eliminarUs";
            this.eliminarUs.Size = new System.Drawing.Size(100, 20);
            this.eliminarUs.TabIndex = 3;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(111, 141);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 4;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre cliente";
            // 
            // nombreCliente
            // 
            this.nombreCliente.Location = new System.Drawing.Point(111, 96);
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Size = new System.Drawing.Size(100, 20);
            this.nombreCliente.TabIndex = 6;
            // 
            // eliminarusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.nombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.eliminarUs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.eliminar);
            this.Name = "eliminarusuario";
            this.Text = "Eliminar usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eliminarUs;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreCliente;
    }
}