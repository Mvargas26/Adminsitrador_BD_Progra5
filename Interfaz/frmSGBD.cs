using Negocios;
using System;
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
        public frmSGBD()
        {
            InitializeComponent();
        }

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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.rtxtConsultas.Text = "";
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
                    this.dgvTerminal.DataSource = objSQLServer.QuerySQLServerNegocios(consultaDelUsuario);
                }

                if (negocios_Loguin.motorElegido == 2)
                {
                    Negocios_MySQL objNegocios = new Negocios_MySQL();
                    String consultaDelUsuario = this.rtxtConsultas.Text;

                    this.dgvTerminal.DataSource = objNegocios.QueryMySQLNegocios(consultaDelUsuario);
                }
                

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                //limpiamos el rtext antes de cargarlo
                limpiarRtext(rtxtSchemas);

                DataTable dtdatos = new DataTable();

                if (negocios_Loguin.motorElegido == 1)
                {
                    Negocios_SQL_Server objSqlServer = new Negocios_SQL_Server();

                    dtdatos = objSqlServer.QuerySQLServerNegocios("SELECT name, database_id, create_date  FROM sys.databases; ");

                    foreach (DataRow valor in dtdatos.Rows)
                    {
                        this.rtxtSchemas.AppendText(valor["name"].ToString() + "\n");
                    }
                }

                if (negocios_Loguin.motorElegido == 2)
                {
                    Negocios_MySQL objNegocios = new Negocios_MySQL();

                    dtdatos = objNegocios.QueryMySQLNegocios("SHOW DATABASES");

                    foreach (DataRow valor in dtdatos.Rows)
                    {
                        this.rtxtSchemas.AppendText(valor["DATABASE"].ToString() + "\n");
                    }
                }

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        public void exportarExcel(DataGridView dgvConDatos)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application objExcel = new Microsoft.Office.Interop.Excel.Application();
                objExcel.Application.Workbooks.Add(true);//le idicamos que vamos a crear un nuevo libro

                //creacion columnas
                int indiceColum = 0;

                foreach(DataGridViewColumn column in dgvConDatos.Columns)
                {
                    indiceColum++;
                    objExcel.Cells[1, indiceColum] = column.Name;
                }

                //filas
                int indiceFila = 0;
                foreach (DataGridViewRow fila in dgvConDatos.Rows)
                {
                    indiceFila++;
                    indiceColum = 0;// para que al llegar a la ultima columna, se devuelva a la primera pero ya en otra fila
                    foreach (DataGridViewColumn column in dgvConDatos.Columns)
                    {
                        indiceColum++;
                        objExcel.Cells[indiceFila + 1, indiceColum] = fila.Cells[column.Name].Value;
                    }
                }

                objExcel.Visible = true;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Fallo exportar a Excel");
            }
            //Creditos DE METODO BASE: JC SOURCE CODE, https://www.youtube.com/watch?v=V4Jcxb97EMU&list=PLYDUurx6L3YWheBbYG9-WZj11ARajua9F&index=3
        }//fin exportarExcel

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvTerminal.RowCount == 0)
            {
                MessageBox.Show("No hay datos para Exportar");
                return;
            }
            else
            {
                exportarExcel(dgvTerminal);
            }
           
        }

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

       private void limpiarRtext(RichTextBox rTextLimpiar)
        {
            rTextLimpiar.Text = "";
            rTextLimpiar.Clear();
            
        }//fin limpiar

       
    }// fin calss del frame
}
