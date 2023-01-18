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
                if (this.cmbBD.Text == "" && (!cmbBD.SelectedItem.Equals("SQLServer(Windos Autentification)")))
                {
                    MessageBox.Show("Debe selecionar un motor de base de datos");
                    return;
                }

                if (this.txtUsuario.Text == "" && (!cmbBD.SelectedItem.Equals("SQLServer(Windos Autentification)")))
                {
                    MessageBox.Show("Usuario Requerido");
                    return;
                }

                if (this.txtPassword.Text == "" && (!cmbBD.SelectedItem.Equals("SQLServer(Windos Autentification)")))
                {
                    MessageBox.Show("Contraseña Requerida");
                    return;
                }//fin validaciones

                negociosProcesos objNegocios =new  negociosProcesos();

                //si es igual a uno llamamos el metodo de SQLServer
                if (cmbBD.SelectedItem.Equals("SQLServer"))
                {
                    //asignamos al appseting las credenciales enviadas
                    ConfigurationManager.AppSettings["DataSource_SqlSer"] = txtServidor.Text;
                    ConfigurationManager.AppSettings["User_SqlSer"] = txtUsuario.Text;
                    ConfigurationManager.AppSettings["Password_SqlSer"]= txtPassword.Text;
                    

                    if (objNegocios.usuarioExiste(1, txtServidor.Text, txtUsuario.Text, txtPassword.Text))
                    {
                        // si es true, se conecto bien a SQLServer
                        //pasamos los datos a la clase estatica para almacenarlos
                        negocios_Loguin.motorElegido = 1;
                        negocios_Loguin.usuario = this.txtUsuario.Text;
                        negocios_Loguin.password = this.txtPassword.Text;
                        negocios_Loguin.EstaActiva = true;
                        negocios_Loguin.Servidor = this.txtServidor.Text;


                        MessageBox.Show("conexión Exitosa");
                        this.Close();
                     }
                }//fin en caso que selecione 1

                //si es igual a 2 llamamos el metodo de mySQL
                if (cmbBD.SelectedItem.Equals("MySQL"))
                {
                    ConfigurationManager.AppSettings["ServerName_MySQL"] = "127.0.0.1";
                    ConfigurationManager.AppSettings["User_MySQL"] = txtUsuario.Text;
                    ConfigurationManager.AppSettings["Password_MySQL"] = txtPassword.Text;

                    if (objNegocios.usuarioExiste(2, txtServidor.Text, txtUsuario.Text, txtPassword.Text))
                    {
                        // si es true, se conecto bien a SQLServer
                        //pasamos los datos a la clase estatica para almacenarlos
                        negocios_Loguin.motorElegido = 2;
                        negocios_Loguin.usuario = this.txtUsuario.Text;
                        negocios_Loguin.password = this.txtPassword.Text;
                        negocios_Loguin.Servidor = "127.0.0.1";

                        MessageBox.Show("conexión Exitosa");
                        this.Close();
                     }
                }//fin en caso que selecione 2

                //si es igual a 3
                if (cmbBD.SelectedItem.Equals("SQLServer(Windos Autentification)"))
                {
                    //asignamos al appseting las credenciales enviadas
                    //ConfigurationManager.AppSettings["DataSource"] = txtServidor.Text;
                    ConfigurationManager.AppSettings["User_SqlSer"] = Environment.UserName;
                    //ConfigurationManager.AppSettings["Password_SqlSer"] = txtPassword.Text;


                    if (objNegocios.usuarioExiste_WA(3, txtServidor.Text))
                    {
                        // si es true, se conecto bien a SQLServer
                        //pasamos los datos a la clase estatica para almacenarlos
                        negocios_Loguin.motorElegido = 3;
                        negocios_Loguin.usuario = Environment.UserName; 
                        //negocios_Loguin.password = "";
                        negocios_Loguin.EstaActiva = true;
                        negocios_Loguin.Servidor = ConfigurationManager.AppSettings["DataSource"];

                        MessageBox.Show("conexión Exitosa");
                        this.Close();
                    }
                }//fin en caso que selecione 1

            }
            catch (Exception ex)
            {
                MessageBox.Show("No ha  sido posible lograr la conexión con los datos  indicados, por favor intente de nuevo.", ex.Message);
            }
        }//fn btn ingresar

        private void cmbBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBD.SelectedItem.Equals("SQLServer(Windos Autentification)"))
            {
                this.grp_Credenciales.Visible = false;
                txtServidor.Text = ConfigurationManager.AppSettings["DataSource"];
            }
            if (!cmbBD.SelectedItem.Equals("SQLServer(Windos Autentification)"))
            {
                this.grp_Credenciales.Visible = true;
            }
            if (cmbBD.SelectedItem.Equals("SQLServer"))
            {
                txtServidor.Text = ConfigurationManager.AppSettings["DataSource_SqlSer"];
            }
            if (cmbBD.SelectedItem.Equals("MySQL"))
            {
                txtServidor.Text = ConfigurationManager.AppSettings["ServerName_MySQL"];
            }
        }//fn cmbBD_SelectedIndexChanged

    }//fin class

}//fin space
