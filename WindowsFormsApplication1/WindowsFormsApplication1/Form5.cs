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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class consulta : Form
    {
        private static OdbcConnection conexionBaseDeDatos = new OdbcConnection();
       
        private String connectionString = "Server = 127.0.0.1; Uid = root; Password =; Database = libreria; Port = 3306;";
               private String rucCont;
               MySqlConnection conexion;
               MySqlCommand conexionCmdFACT;
               String gen = "";
               float mini = 0;
               float maxi = 1000; 
        public consulta()
        {
            InitializeComponent();
        }

        private void consulta_Load(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form inventario = new Inventario();
            inventario.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion = new MySqlConnection(connectionString);
                conexionCmdFACT = new MySqlCommand("mostrar", conexion);
                conexionCmdFACT.CommandType = CommandType.StoredProcedure;
                try
                {
                    conexion.Open();
                   
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = conexionCmdFACT;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    dataGridView1.DataSource = bsource;
                    sda.Update(dbdataset);
                    conexionCmdFACT.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    conexion.Close();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexion.Close();
                }

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void mostrarfiltro_Click(object sender, System.EventArgs e)
        {
            conexion = new MySqlConnection(connectionString);
            conexionCmdFACT = new MySqlCommand("mostrarfiltrogen", conexion);
            conexionCmdFACT.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Open();
                conexionCmdFACT.Parameters.AddWithValue("@gene", gen);
                conexionCmdFACT.Parameters["@gene"].Direction = ParameterDirection.Input;
                conexionCmdFACT.Parameters.AddWithValue("@minim", mini);
                conexionCmdFACT.Parameters["@minim"].Direction = ParameterDirection.Input;
                conexionCmdFACT.Parameters.AddWithValue("@maxim", maxi);
                conexionCmdFACT.Parameters["@maxim"].Direction = ParameterDirection.Input;
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = conexionCmdFACT;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
                conexionCmdFACT.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conexion.Close();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void genero_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (genero.Text == "sci fi")
                gen = "sci fi";
            if (genero.Text == "drama")
                gen = "drama";
            if (genero.Text == "comedia")
                gen = "comedia";
        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {
            maxi = float.Parse(this.max.Text.ToString());
        }

        private void min_TextChanged(object sender, System.EventArgs e)
        {
            mini = float.Parse(this.min.Text.ToString());
        }
    }
}
