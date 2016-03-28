using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public partial class añadirlibro : Form
    {
        MySqlConnection conexion;
        MySqlCommand conexionCmdFACT;

        String nombrelibro = "";
        int cantidad = 0;
        float precio = 0;
        String autor = "";
        String editorial = "";
        String genero = "";
        String descripcion = "";

        public añadirlibro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool existelibro = this.existeLib(this.nombrelibro);

            if (existeLib)
            {
                this.name.Text = "";
                this.existencias.Text = "";
                this.txtdireccion.Text = "";
                this.telefonoC.Text = "";
                //this.codProvincia.Text = "";
                //this.errores.Visible = false;
                //MessageBox.Show("El RUC ingresado esta registrado ya en el sistema.", "Contribuyente existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conexionCont = new MySqlConnection(connectionString);
                //conexion = new MySqlConnection("Server = localhost; Uid = root; Password = FIEC05553_l3m ; Database = sistemafacturacion; Port = 3306;"); conexionCmd = new MySqlCommand();
                conexionCont.Open();
                conexionCmdCont.Connection = conexionCont;
                conexionCmdCont.CommandText = "añadirNuevoCliente";
                conexionCmdCont.CommandType = CommandType.StoredProcedure;

                conexionCmdCont.Parameters.AddWithValue("@ruc", this.txtruc.Text);
                conexionCmdCont.Parameters["@ruc"].Direction = ParameterDirection.Input;
                conexionCmdCont.Parameters.AddWithValue("@nombre", this.nombreC.Text);
                conexionCmdCont.Parameters["@nombre"].Direction = ParameterDirection.Input;
                conexionCmdCont.Parameters.AddWithValue("@direccion", this.txtdireccion.Text);
                conexionCmdCont.Parameters["@direccion"].Direction = ParameterDirection.Input;
                if (this.telefonoC.Text != "")
                {
                    conexionCmdCont.Parameters.AddWithValue("@telefono", this.telefonoC.Text);
                    conexionCmdCont.Parameters["@telefono"].Direction = ParameterDirection.Input;
                }
                else
                {
                    conexionCmdCont.Parameters.AddWithValue("@telefono", "");
                    conexionCmdCont.Parameters["@telefono"].Direction = ParameterDirection.Input;
                }
                conexionCmdCont.ExecuteNonQuery();
                conexionCont.Close();

                //this.Hide();

            }
        }

        private void añadirlibro_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
