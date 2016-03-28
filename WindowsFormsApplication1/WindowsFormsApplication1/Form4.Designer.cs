namespace WindowsFormsApplication1
{
    partial class compra
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codcliente = new System.Windows.Forms.TextBox();
            this.codart = new System.Windows.Forms.TextBox();
            this.cantart = new System.Windows.Forms.TextBox();
            this.añadirart = new System.Windows.Forms.Button();
            this.eliminarart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(521, 87);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 0;
            this.salir.Text = "salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresar codigo articulo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingresar cantidad";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(154, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(354, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // codcliente
            // 
            this.codcliente.Location = new System.Drawing.Point(139, 29);
            this.codcliente.Name = "codcliente";
            this.codcliente.Size = new System.Drawing.Size(100, 20);
            this.codcliente.TabIndex = 6;
            // 
            // codart
            // 
            this.codart.Location = new System.Drawing.Point(139, 54);
            this.codart.Name = "codart";
            this.codart.Size = new System.Drawing.Size(100, 20);
            this.codart.TabIndex = 7;
            // 
            // cantart
            // 
            this.cantart.Location = new System.Drawing.Point(139, 81);
            this.cantart.Name = "cantart";
            this.cantart.Size = new System.Drawing.Size(100, 20);
            this.cantart.TabIndex = 8;
            this.cantart.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // añadirart
            // 
            this.añadirart.Location = new System.Drawing.Point(503, 29);
            this.añadirart.Name = "añadirart";
            this.añadirart.Size = new System.Drawing.Size(112, 23);
            this.añadirart.TabIndex = 9;
            this.añadirart.Text = "Añadir articulo";
            this.añadirart.UseVisualStyleBackColor = true;
            // 
            // eliminarart
            // 
            this.eliminarart.Location = new System.Drawing.Point(503, 58);
            this.eliminarart.Name = "eliminarart";
            this.eliminarart.Size = new System.Drawing.Size(112, 23);
            this.eliminarart.TabIndex = 10;
            this.eliminarart.Text = "Eliminar articulo";
            this.eliminarart.UseVisualStyleBackColor = true;
            // 
            // compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 336);
            this.Controls.Add(this.eliminarart);
            this.Controls.Add(this.añadirart);
            this.Controls.Add(this.cantart);
            this.Controls.Add(this.codart);
            this.Controls.Add(this.codcliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salir);
            this.Name = "compra";
            this.Text = "Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox codcliente;
        private System.Windows.Forms.TextBox codart;
        private System.Windows.Forms.TextBox cantart;
        private System.Windows.Forms.Button añadirart;
        private System.Windows.Forms.Button eliminarart;
    }
}