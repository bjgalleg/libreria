namespace WindowsFormsApplication1
{
    partial class consulta
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.autor = new System.Windows.Forms.ComboBox();
            this.editorial = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.genero = new System.Windows.Forms.ComboBox();
            this.descripcion = new System.Windows.Forms.Label();
            this.mostrar = new System.Windows.Forms.Button();
            this.mostrarfiltro = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.TextBox();
            this.max = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.descipcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(565, 22);
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
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Editorial";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre del libro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Género";
            // 
            // autor
            // 
            this.autor.FormattingEnabled = true;
            this.autor.Location = new System.Drawing.Point(91, 27);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(171, 21);
            this.autor.TabIndex = 6;
            // 
            // editorial
            // 
            this.editorial.FormattingEnabled = true;
            this.editorial.Location = new System.Drawing.Point(413, 59);
            this.editorial.Name = "editorial";
            this.editorial.Size = new System.Drawing.Size(121, 21);
            this.editorial.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 168);
            this.dataGridView1.TabIndex = 10;
            // 
            // genero
            // 
            this.genero.FormattingEnabled = true;
            this.genero.Items.AddRange(new object[] {
            "sci fi",
            "drama",
            "comedia"});
            this.genero.Location = new System.Drawing.Point(91, 102);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(121, 21);
            this.genero.TabIndex = 11;
            this.genero.SelectedIndexChanged += new System.EventHandler(this.genero_SelectedIndexChanged);
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Location = new System.Drawing.Point(324, 102);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(63, 13);
            this.descripcion.TabIndex = 13;
            this.descripcion.Text = "Descripción";
            // 
            // mostrar
            // 
            this.mostrar.Location = new System.Drawing.Point(565, 62);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(75, 23);
            this.mostrar.TabIndex = 14;
            this.mostrar.Text = "Mostrar todo";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // mostrarfiltro
            // 
            this.mostrarfiltro.Location = new System.Drawing.Point(565, 105);
            this.mostrarfiltro.Name = "mostrarfiltro";
            this.mostrarfiltro.Size = new System.Drawing.Size(75, 23);
            this.mostrarfiltro.TabIndex = 15;
            this.mostrarfiltro.Text = "Mostrar filtro";
            this.mostrarfiltro.UseVisualStyleBackColor = true;
            this.mostrarfiltro.Click += new System.EventHandler(this.mostrarfiltro_Click);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(91, 60);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(38, 20);
            this.min.TabIndex = 16;
            this.min.TextChanged += new System.EventHandler(this.min_TextChanged);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(224, 59);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(38, 20);
            this.max.TabIndex = 17;
            this.max.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Precio max";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(413, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 19;
            // 
            // descipcion
            // 
            this.descipcion.Location = new System.Drawing.Point(413, 99);
            this.descipcion.Name = "descipcion";
            this.descipcion.Size = new System.Drawing.Size(100, 20);
            this.descipcion.TabIndex = 20;
            // 
            // consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 331);
            this.Controls.Add(this.descipcion);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.mostrarfiltro);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.editorial);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salir);
            this.Name = "consulta";
            this.Text = "Consultar libro";
            this.Load += new System.EventHandler(this.consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox autor;
        private System.Windows.Forms.ComboBox editorial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox genero;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Button mostrar;
        private System.Windows.Forms.Button mostrarfiltro;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.TextBox max;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox descipcion;
    }
}