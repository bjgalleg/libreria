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
    public partial class ingresarusuario : Form
    {
        private string rucCliente;
        private string nombre;
        private string direccion;
        private string telefono;
        private static OdbcConnection conexionBaseDeDatos = new OdbcConnection();
        MySqlConnection conexionCont;
        MySqlCommand conexionCmdCont;
        private String connectionString = "Server = 127.0.0.1; Uid = root; Password =; Database = libreria; Port = 3306;";

        public ingresarusuario()
        {
            InitializeComponent();

            try
            {

                conexionCont = new MySqlConnection(connectionString);
                //conexion = new MySqlConnection("Server = localhost; Uid = root; Password = FIEC05553_l3m ; Database = sistemafacturacion; Port = 3306;"); conexionCmd = new MySqlCommand();
                conexionCmdCont = new MySqlCommand();

                conexionCont.Open();
                if (conexionCont.State == ConnectionState.Open && conexionCont.State.ToString() == "Open")
                {
                    this.estadoConexion.Text = "Conectado a la base de datos: " + conexionCont.State.ToString();
                }
                else { this.estadoConexion.Text = "No conectado a la base de datos"; }
            }
            catch (Exception ex)
            {
                this.estadoConexion.Text = "No Conectado a la base de datos";
            }
            finally
            {
                conexionCont.Close();
            }
        }

        private bool existeRUC(String rucC)
        {
            //label1.Text = conexion.State.ToString();
            try
            {
                conexionCont = new MySqlConnection(connectionString);
                //conexion = new MySqlConnection("Server = localhost; Uid = root; Password = FIEC05553_l3m ; Database = sistemafacturacion; Port = 3306;"); conexionCmd = new MySqlCommand();
                conexionCont.Open();

                conexionCmdCont.Connection = conexionCont;
                conexionCmdCont.CommandText = "verificarRUC";
                conexionCmdCont.CommandType = CommandType.StoredProcedure;
                //rucCliente a rucing
                conexionCmdCont.Parameters.AddWithValue("@rucing", rucC);
                conexionCmdCont.Parameters["@rucing"].Direction = ParameterDirection.Input;
                //existeruc 
                conexionCmdCont.Parameters.AddWithValue("@existeRUC", MySqlDbType.Int32);
                conexionCmdCont.Parameters["@existeRUC"].Direction = ParameterDirection.Output;

                conexionCmdCont.ExecuteNonQuery();


                if ((Int32)conexionCmdCont.Parameters["@existeRUC"].Value == 1)
                {
                    conexionCont.Close();

                    MessageBox.Show("El RUC ingresado ya existe en el sistema.", "RUC ya existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }

            }
            catch (Exception ex)
            {

                return false;
            }

            finally
            {
                conexionCont.Close();
            }
            return false;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtruc_TextChanged(object sender, EventArgs e)
        {
            rucCliente = this.txtruc.Text.ToString();
            if (Regex.IsMatch(rucCliente, "[^0-9]"))
            {
                this.rucFB.Text = "sólo se permiten números";
                this.rucFB.Visible = true;
            }
            else if (rucCliente.Length != 13 && rucCliente.Length != 0)
            {
                this.rucFB.Text = "el número de dígitos debe ser 13";
                this.rucFB.Visible = true;
            }

            else if (rucCliente.Length != 13 )
            {

                this.rucFB.Text = "RUC no válido\n";
                this.rucFB.Visible = true;
            }

            else
            {
                this.rucFB.Visible = false;
            }

            setEnabledRButton(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
           
            bool existeCliente = this.existeRUC(this.rucCliente);
            
            if (existeCliente)
            {
                this.nombreC.Text = "";
                this.txtruc.Text = "";
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
        private void setEnabledRButton(object sender, EventArgs e)
        {
            if (//!this.nombre.Text.Equals("") &&
               //!this.ruc.Text.Equals("") &&
               !this.rucFB.Visible &&
               !this.telefonoFB.Visible && !this.nombreFB.Visible)
            {
                this.register.Enabled = true;
                //this.errores.Visible = false;
            }
            else
            {
               // this.errores.Visible = true;
                this.register.Enabled = false;
            }
        }

        private void nombreC_TextChanged(object sender, EventArgs e)
        {
            nombre = this.nombreC.Text.ToString();

            if (!Regex.IsMatch(nombre, "^[a-zA-Z ]*$"))
            {
                this.nombreFB.Text = "Sólo se permiten letras";
                this.nombreFB.Visible = true;

            }

            else
            {
                this.nombreFB.Visible = false;

            }
            setEnabledRButton(sender, e);
        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {
            telefono = this.telefonoC.Text.ToString();
            if (Regex.IsMatch(rucCliente, "[^0-9]"))
            {
                this.telefonoFB.Text = "solo se permiten numeros";
                this.telefonoFB.Visible = true;
            }
            else if (this.telefonoC.Text.Length != 6)
            {
                this.telefonoFB.Text = "Debe ingresar 6 dígitos";
                this.telefonoFB.Visible = true;
            }
            else
            {
                this.telefonoFB.Visible = false;
            }

            setEnabledRButton(sender, e);
        }

        private void salir_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form inicio = new Inicio();
            inicio.Visible = true;
        }
        }
    }

