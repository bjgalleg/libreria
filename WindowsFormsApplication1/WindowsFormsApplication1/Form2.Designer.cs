namespace WindowsFormsApplication1
{
    partial class Inicio
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
            this.usuario = new System.Windows.Forms.Button();
            this.compra = new System.Windows.Forms.Button();
            this.inventario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(58, 122);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(75, 72);
            this.usuario.TabIndex = 0;
            this.usuario.Text = "Usuarios";
            this.usuario.UseVisualStyleBackColor = true;
            this.usuario.Click += new System.EventHandler(this.usuario_Click);
            // 
            // compra
            // 
            this.compra.Location = new System.Drawing.Point(172, 121);
            this.compra.Name = "compra";
            this.compra.Size = new System.Drawing.Size(75, 72);
            this.compra.TabIndex = 1;
            this.compra.Text = "Compras";
            this.compra.UseVisualStyleBackColor = true;
            this.compra.Click += new System.EventHandler(this.button2_Click);
            // 
            // inventario
            // 
            this.inventario.Location = new System.Drawing.Point(287, 121);
            this.inventario.Name = "inventario";
            this.inventario.Size = new System.Drawing.Size(75, 72);
            this.inventario.TabIndex = 3;
            this.inventario.Text = "Inventario";
            this.inventario.UseVisualStyleBackColor = true;
            this.inventario.Click += new System.EventHandler(this.inventario_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 322);
            this.Controls.Add(this.inventario);
            this.Controls.Add(this.compra);
            this.Controls.Add(this.usuario);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button usuario;
        private System.Windows.Forms.Button compra;
        private System.Windows.Forms.Button inventario;
    }
}