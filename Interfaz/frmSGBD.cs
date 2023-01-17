using Negocios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class frmSGBD : Form
    {
        //Variables globales
        ArrayList listaChequeados = new ArrayList();
        public frmSGBD()
        {
            InitializeComponent();
        }//fn constructor

        private void frmSGBD_Load(object sender, EventArgs e)
        {
            try
            {
                if (negocios_Loguin.motorElegido == 0)
                {
                    MessageBox.Show("Por favor vaya a la pagina de Loguin Primero");
                    
                }
                
                DataTable dtdatos = new DataTable();

                if (negocios_Loguin.motorElegido == 1)
                {
                    Negocios_SQL_Server objSqlServer = new Negocios_SQL_Server();
                   
                    dtdatos = objSqlServer.QuerySQLServerNegocios("SELECT name, database_id, create_date  FROM sys.databases; ");

                    this.richTx_Servidor.AppendText("Server: " + negocios_Loguin.Servidor+"\n");
                    this.richTx_Servidor.AppendText("User: " + negocios_Loguin.usuario + "\n");

                    CheckedListBox ch_list = new CheckedListBox();
                    ch_list.Dock = DockStyle.Fill;

                    foreach (DataRow valor in dtdatos.Rows)
                    {
                        ch_list.Items.Add(valor["name"].ToString());
                    }
                    this.pan_esquemas.Controls.Add(ch_list);
                    ch_list.SelectedIndexChanged += new EventHandler(this.verifica_chked); //dispara cada q seleccionan uno
                }

                if (negocios_Loguin.motorElegido == 2)
                {
                    Negocios_MySQL objNegocios = new Negocios_MySQL();

                    dtdatos = objNegocios.QueryMySQLNegocios("SHOW DATABASES");

                    this.richTx_Servidor.AppendText("Server: " + negocios_Loguin.Servidor + "\n");
                    this.richTx_Servidor.AppendText("User: " + negocios_Loguin.usuario + "\n");

                    CheckedListBox ch_list = new CheckedListBox();
                    ch_list.Dock = DockStyle.Fill;
                    foreach (DataRow valor in dtdatos.Rows)
                    {
                        ch_list.Items.Add(valor["DATABASE"].ToString());
                    }
                    this.pan_esquemas.Controls.Add(ch_list);
                }
            }
            catch (Exception Error)
            {
               MessageBox.Show(Error.Message);
            }
        }//fn load

        #region Botones
        private void btnLimpiarResult_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTerminal.DataSource = null;
                dgvTerminal.Rows.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtdatos = new DataTable();

                if (negocios_Loguin.motorElegido == 1)
                {
                    Negocios_SQL_Server objSqlServer = new Negocios_SQL_Server();

                    dtdatos = objSqlServer.QuerySQLServerNegocios("SELECT name, database_id, create_date  FROM sys.databases; ");

                    this.richTx_Servidor.AppendText("Server: " + negocios_Loguin.Servidor + "\n");
                    this.richTx_Servidor.AppendText("User: " + negocios_Loguin.usuario + "\n");

                    CheckedListBox ch_list = new CheckedListBox();
                    ch_list.Dock = DockStyle.Fill;

                    foreach (DataRow valor in dtdatos.Rows)
                    {
                        ch_list.Items.Add(valor["name"].ToString());
                        //this.rtxtSchemas.AppendText(valor["name"].ToString()+"\n");
                    }
                    this.pan_esquemas.Controls.Add(ch_list);
                }

                if (negocios_Loguin.motorElegido == 2)
                {
                    Negocios_MySQL objNegocios = new Negocios_MySQL();

                    dtdatos = objNegocios.QueryMySQLNegocios("SHOW DATABASES");

                    this.richTx_Servidor.AppendText("Server: " + negocios_Loguin.Servidor + "\n");
                    this.richTx_Servidor.AppendText("User: " + negocios_Loguin.usuario + "\n");

                    CheckedListBox ch_list = new CheckedListBox();
                    ch_list.Dock = DockStyle.Fill;
                    foreach (DataRow valor in dtdatos.Rows)
                    {
                        ch_list.Items.Add(valor["DATABASE"].ToString());
                        //this.rtxtSchemas.AppendText(valor["DATABASE"].ToString()+"\n");
                    }
                    this.pan_esquemas.Controls.Add(ch_list);
                }


            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                resaltadoSintaxis(rtxtConsultas.Text.ToUpper(), rtxtConsultas);

                this.dgvTerminal.DataSource = null;
                this.dgvTerminal.Rows.Clear();
                this.dgvTerminal.Columns.Clear();

                if (negocios_Loguin.motorElegido == 1)
                {
                    Negocios_SQL_Server objSQLServer = new Negocios_SQL_Server();
                    String consultaDelUsuario = this.rtxtConsultas.Text;
                    DataSet ds = new DataSet();

                    if (listaChequeados.Count <= 2) //si en la lista hay chequeados
                    {
                       StringBuilder strB_cadena = new StringBuilder();

                        foreach (string dbConsultar in listaChequeados)//envia consulta x cada base
                        {
                            strB_cadena.Append("use "+dbConsultar+";");
                            strB_cadena.Append(consultaDelUsuario+"\n");
                        }

                        ds = objSQLServer.QuerySQLServerNegocios_DS(strB_cadena.ToString());
                        int posicion = 0;
                        for (int i = 0; i < ds.Tables.Count; i++)
                        {
                            DataGridView newDGV = new DataGridView();
                            newDGV.DataSource= ds.Tables[i];
                            newDGV.Location = new Point(0, posicion);
                            newDGV.Size = new Size(500, 100);
                            this.pan_Terminal.Controls.Add(newDGV);
                            posicion += 130;
                        }
                    }
                    else
                    {
                        DataGridView newDGV = new DataGridView();
                        newDGV.DataSource = objSQLServer.QuerySQLServerNegocios(consultaDelUsuario);
                        newDGV.Dock=  DockStyle.Fill;
                        newDGV.Location = new Point(0, 0);
                        this.pan_Terminal.Controls.Add(newDGV);
                    }
                   
                   // this.dgvTerminal.DataSource = objSQLServer.QuerySQLServerNegocios(consultaDelUsuario);
                }

                if (negocios_Loguin.motorElegido == 2)
                {
                    Negocios_MySQL objNegocios = new Negocios_MySQL();
                    String consultaDelUsuario = this.rtxtConsultas.Text;

                    //this.dgvTerminal.DataSource = objNegocios.QueryMySQLNegocios(consultaDelUsuario);
                }


            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.rtxtConsultas.Text = "";
        }
        #endregion

        #region Privados
        private void verifica_chked(object sender, EventArgs e)
        {
            CheckedListBox chk_list = (CheckedListBox)sender;
            int indice = chk_list.SelectedIndex;

            if (indice != -1)
            {
                listaChequeados.Add(chk_list.Items[indice].ToString());
            }
        }//fn verifica_chked
        private void resaltadoSintaxis(String strCadenaUsuario, RichTextBox rTextAmodificar)
        {
            //estas son las palabras que si encuentra va pintar azul
            string[] arryPalAbrasReservadas = { "SELECT", "GO", "DELETE", "UPDATE", "FROM" ,"USE","CREATE",
            "DROP", "DATABASE","IF"," EXISTS"};

            foreach (string valor in arryPalAbrasReservadas)
            {
                int indexIncio = 0;
                while (indexIncio < rTextAmodificar.TextLength)
                {
                    int indexInicioPalabra = rTextAmodificar.Find(valor, indexIncio, RichTextBoxFinds.None);
                    if (indexInicioPalabra != -1)
                    {
                        rTextAmodificar.SelectionStart = indexInicioPalabra;
                        rTextAmodificar.SelectionLength = valor.Length;
                        rTextAmodificar.SelectionColor = Color.Blue;
                    }
                    else
                        break;
                    indexIncio += indexInicioPalabra + valor.Length;
                }

            }

        }// fin resaltadoSintaxis
        #endregion

    }// fin calss del frame
}
