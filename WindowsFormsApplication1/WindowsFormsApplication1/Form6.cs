﻿using System;
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
        private static OdbcConnection conexionBaseDeDatos = new OdbcConnection();
        MySqlConnection conexionCont;
        MySqlCommand conexionCmdCont;
        private String connectionString = "Server = 127.0.0.1; Uid = root; Password =; Database = libreria; Port = 3306;";

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


        private bool existeLib(String nombrelib)
        {
            //label1.Text = conexion.State.ToString();
            try
            {
                conexionCont = new MySqlConnection(connectionString);
                //conexion = new MySqlConnection("Server = localhost; Uid = root; Password = FIEC05553_l3m ; Database = sistemafacturacion; Port = 3306;"); conexionCmd = new MySqlCommand();
                conexionCont.Open();
                conexionCmdCont = new MySqlCommand();
                conexionCmdCont.Connection = conexionCont;
                conexionCmdCont.CommandText = "verificarLib";
                conexionCmdCont.CommandType = CommandType.StoredProcedure;
                //rucCliente a rucing
                conexionCmdCont.Parameters.AddWithValue("@lib", nombrelib);
                conexionCmdCont.Parameters["@lib"].Direction = ParameterDirection.Input;
                //existeruc 
                conexionCmdCont.Parameters.AddWithValue("@existeLib", MySqlDbType.Int32);
                conexionCmdCont.Parameters["@existeLib"].Direction = ParameterDirection.Output;

                conexionCmdCont.ExecuteNonQuery();


                if ((Int32)conexionCmdCont.Parameters["@existeLib"].Value == 1)
                {
                    conexionCont.Close();

                    MessageBox.Show("El libro ingresado ya existe en el sistema.", "Libro ya existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        private void button1_Click(object sender, EventArgs e)
        {

            bool existelibro = this.existeLib(this.nombrelibro);

            if (existelibro)
            {
                this.nomlib.Text = "";
                this.existencias.Text = "";
                this.autlib.Text = "";
                this.edit.Text = "";
                this.libprec.Text = "";
                this.libdes.Text = "";
                this.libgen.Text = "";
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
                conexionCmdCont.CommandText = "añadirNuevoLibro";
                conexionCmdCont.CommandType = CommandType.StoredProcedure;

                conexionCmdCont.Parameters.AddWithValue("@libro", this.nomlib.Text);
                conexionCmdCont.Parameters["@libro"].Direction = ParameterDirection.Input;
                conexionCmdCont.Parameters.AddWithValue("@aut", this.autlib.Text);
                conexionCmdCont.Parameters["@aut"].Direction = ParameterDirection.Input;
                conexionCmdCont.Parameters.AddWithValue("@edito", this.edit.Text);
                conexionCmdCont.Parameters["@edito"].Direction = ParameterDirection.Input;
                conexionCmdCont.Parameters.AddWithValue("@prec", this.libprec.Text);
                conexionCmdCont.Parameters["@prec"].Direction = ParameterDirection.Input;
                conexionCmdCont.Parameters.AddWithValue("@gene", this.libgen.Text);
                conexionCmdCont.Parameters["@gene"].Direction = ParameterDirection.Input;
                conexionCmdCont.Parameters.AddWithValue("@libdescr", this.libdes.Text);
                conexionCmdCont.Parameters["@libdescr"].Direction = ParameterDirection.Input;
                conexionCmdCont.Parameters.AddWithValue("@exist", this.existencias.Text);
                conexionCmdCont.Parameters["@exist"].Direction = ParameterDirection.Input;

                conexionCmdCont.ExecuteNonQuery();
                conexionCont.Close();
                this.nomlib.Text = "";
                this.autlib.Text = "";
                this.existencias.Text = "";
                this.edit.Text = "";
                this.libprec.Text = "";
                this.libdes.Text = "";
                this.libgen.Text = "";

              
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
            nombrelibro = this.nomlib.Text.ToString();
        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {

        }
    }
}
