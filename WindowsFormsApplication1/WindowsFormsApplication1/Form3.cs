﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Data.ProviderBase;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace WindowsFormsApplication1
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form inicio = new Inicio();
            inicio.Visible = true;
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form consulta = new consulta();
            consulta.Visible = true;
        }

        private void añadir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form añadirlibro = new añadirlibro();
            añadirlibro.Visible = true;
        }
    }
}
