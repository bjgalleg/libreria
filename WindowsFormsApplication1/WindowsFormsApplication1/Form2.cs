using System;
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form compra = new compra();
            compra.Visible = true;
        }

        private void inventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form inventario = new Inventario();
            inventario.Visible = true;
        }

        private void usuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form usuarios = new usuarios();
            usuarios.Visible = true;
        }

        private void consulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form consulta = new consulta();
            consulta.Visible = true;
        }
    }
}
