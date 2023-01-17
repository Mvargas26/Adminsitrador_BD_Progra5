using Microsoft.Office.Interop.Excel;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ubiety.Dns.Core.Records.General;

namespace Interfaz
{
    public partial class frmLoguin : Form
    {
        public frmLoguin()
        {
            InitializeComponent();
            btnWinAuth.Visible= false;
        }

        private void chkVer_CheckedChanged(object sender, EventArgs e)
        {//si el check esta marcado, la propiedad password del txt se desactiva
            if (chkVer.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }//fin accion chkVer

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //VALIDACIONES
                if (this.cmbBD.Text == "")
                {
                    MessageBox.Show("Debe selecionar un motor de base de datos");
                    return;
                }

                if (this.txtUsuario.Text == "")
                {
                    MessageBox.Show("Usuario Requerido");
                    return;
                }

                if (this.txtPassword.Text == "")
                {
                    MessageBox.Show("Contraseña Requerida");
                    return;
                }

                negociosProcesos objNegocios =new  negociosProcesos();

                //si es igual a uno llamamos el metodo de SQLServer
                if (cmbBD.SelectedItem.Equals("SQLServer"))
                {
                    //asignamos al appseting las credenciales enviadas
                    ConfigurationManager.AppSettings["User_SqlSer"] = txtUsuario.Text;
                    ConfigurationManager.AppSettings["Password_SqlSer"]= txtPassword.Text;

                   if (objNegocios.usuarioExiste(1, txtUsuario.Text, txtPassword.Text))
                    {
                        // si es true, se conecto bien a SQLServer
                        //pasamos los datos a la clase estatica para almacenarlos
                        negocios_Loguin.motorElegido = 1;
                        negocios_Loguin.usuario = this.txtUsuario.Text;
                        negocios_Loguin.password = this.txtPassword.Text;
                        negocios_Loguin.EstaActiva = true;
                        negocios_Loguin.Servidor = "VARGASPC\\INSTA1";


                        MessageBox.Show("conexión Exitosa");
                        this.Close();
                     }
                }//fin en caso que selecione 1

                //si es igual a 2 llamamos el metodo de mySQL
                if (cmbBD.SelectedItem.Equals("MySQL"))
                {
                    
                    ConfigurationManager.AppSettings["User_MySQL"] = txtUsuario.Text;
                    ConfigurationManager.AppSettings["Password_MySQL"] = txtPassword.Text;

                    if (objNegocios.usuarioExiste(2, txtUsuario.Text, txtPassword.Text))
                    {
                        // si es true, se conecto bien a SQLServer
                        //pasamos los datos a la clase estatica para almacenarlos
                        negocios_Loguin.motorElegido = 2;
                        negocios_Loguin.usuario = this.txtUsuario.Text;
                        negocios_Loguin.password = this.txtPassword.Text;
                        negocios_Loguin.Servidor = "172.0.0.1";

                        MessageBox.Show("conexión Exitosa");
                        this.Close();
                     }
                }//fin en caso que selecione 2
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fallo la conexion");
            }
        }

        private void btnWinAuth_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexión establecida");
                    this.Close(); 
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
                }
            }
        }

        private void cmbBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBD.SelectedItem.Equals("SQLServer"))
            {
                btnWinAuth.Visible = true;
            }
        }
    }

}
