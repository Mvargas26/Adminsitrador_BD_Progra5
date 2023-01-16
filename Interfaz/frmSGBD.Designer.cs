
namespace Interfaz
{
    partial class frmSGBD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
                        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.grpSchemas = new System.Windows.Forms.GroupBox();
            this.pan_esquemas = new System.Windows.Forms.Panel();
            this.grpSchemas2 = new System.Windows.Forms.GroupBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.rtxtSchemas = new System.Windows.Forms.RichTextBox();
            this.rtxtArbol = new System.Windows.Forms.RichTextBox();
            this.grpConsultas = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.rtxtConsultas = new System.Windows.Forms.RichTextBox();
            this.grpTerminal = new System.Windows.Forms.GroupBox();
            this.grpTerminal2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarResult = new System.Windows.Forms.Button();
            this.dgvTerminal = new System.Windows.Forms.DataGridView();
            this.richTx_Servidor = new System.Windows.Forms.RichTextBox();
            this.pan_Server = new System.Windows.Forms.Panel();
            this.grpSchemas.SuspendLayout();
            this.grpSchemas2.SuspendLayout();
            this.grpConsultas.SuspendLayout();
            this.grpTerminal.SuspendLayout();
            this.grpTerminal2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminal)).BeginInit();
            this.pan_Server.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(316, 313);
            this.btnEjecutar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(163, 53);
            this.btnEjecutar.TabIndex = 0;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // grpSchemas
            // 
            this.grpSchemas.Controls.Add(this.grpSchemas2);
            this.grpSchemas.Controls.Add(this.pan_esquemas);
            this.grpSchemas.Controls.Add(this.rtxtSchemas);
            this.grpSchemas.Controls.Add(this.rtxtArbol);
            this.grpSchemas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpSchemas.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSchemas.Location = new System.Drawing.Point(0, 100);
            this.grpSchemas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSchemas.Name = "grpSchemas";
            this.grpSchemas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSchemas.Size = new System.Drawing.Size(300, 334);
            this.grpSchemas.TabIndex = 1;
            this.grpSchemas.TabStop = false;
            this.grpSchemas.Text = "SCHEMAS";
            // 
            // pan_esquemas
            // 
            this.pan_esquemas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan_esquemas.Location = new System.Drawing.Point(6, 25);
            this.pan_esquemas.Name = "pan_esquemas";
            this.pan_esquemas.Size = new System.Drawing.Size(294, 341);
            this.pan_esquemas.TabIndex = 3;
            // 
            // grpSchemas2
            // 
            this.grpSchemas2.Controls.Add(this.btnRefrescar);
            this.grpSchemas2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpSchemas2.Location = new System.Drawing.Point(3, 256);
            this.grpSchemas2.Name = "grpSchemas2";
            this.grpSchemas2.Size = new System.Drawing.Size(294, 76);
            this.grpSchemas2.TabIndex = 2;
            this.grpSchemas2.TabStop = false;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Location = new System.Drawing.Point(65, 26);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(147, 33);
            this.btnRefrescar.TabIndex = 0;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // rtxtSchemas
            // 
            this.rtxtSchemas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtSchemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtSchemas.Location = new System.Drawing.Point(3, 22);
            this.rtxtSchemas.Name = "rtxtSchemas";
            this.rtxtSchemas.ReadOnly = true;
            this.rtxtSchemas.Size = new System.Drawing.Size(294, 310);
            this.rtxtSchemas.TabIndex = 1;
            this.rtxtSchemas.Text = "";
            // 
            // rtxtArbol
            // 
            this.rtxtArbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtArbol.Location = new System.Drawing.Point(3, 22);
            this.rtxtArbol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtArbol.Name = "rtxtArbol";
            this.rtxtArbol.ReadOnly = true;
            this.rtxtArbol.Size = new System.Drawing.Size(294, 310);
            this.rtxtArbol.TabIndex = 0;
            this.rtxtArbol.Text = "";
            // 
            // grpConsultas
            // 
            this.grpConsultas.Controls.Add(this.btnBorrar);
            this.grpConsultas.Controls.Add(this.rtxtConsultas);
            this.grpConsultas.Controls.Add(this.btnEjecutar);
            this.grpConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpConsultas.Location = new System.Drawing.Point(306, 0);
            this.grpConsultas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConsultas.Name = "grpConsultas";
            this.grpConsultas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConsultas.Size = new System.Drawing.Size(918, 434);
            this.grpConsultas.TabIndex = 2;
            this.grpConsultas.TabStop = false;
            this.grpConsultas.Text = "CONSULTAS";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(521, 313);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(163, 53);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar Consola";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // rtxtConsultas
            // 
            this.rtxtConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtxtConsultas.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtConsultas.Location = new System.Drawing.Point(3, 17);
            this.rtxtConsultas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtConsultas.Name = "rtxtConsultas";
            this.rtxtConsultas.Size = new System.Drawing.Size(912, 281);
            this.rtxtConsultas.TabIndex = 1;
            this.rtxtConsultas.Text = "";
            // 
            // grpTerminal
            // 
            this.grpTerminal.Controls.Add(this.grpTerminal2);
            this.grpTerminal.Controls.Add(this.dgvTerminal);
            this.grpTerminal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpTerminal.Location = new System.Drawing.Point(0, 456);
            this.grpTerminal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTerminal.Name = "grpTerminal";
            this.grpTerminal.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTerminal.Size = new System.Drawing.Size(1224, 320);
            this.grpTerminal.TabIndex = 3;
            this.grpTerminal.TabStop = false;
            this.grpTerminal.Text = "TERMINAL";
            // 
            // grpTerminal2
            // 
            this.grpTerminal2.Controls.Add(this.btnLimpiarResult);
            this.grpTerminal2.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpTerminal2.Location = new System.Drawing.Point(1083, 17);
            this.grpTerminal2.Name = "grpTerminal2";
            this.grpTerminal2.Size = new System.Drawing.Size(138, 301);
            this.grpTerminal2.TabIndex = 2;
            this.grpTerminal2.TabStop = false;
            this.grpTerminal2.Text = "Exportar";
            // 
            // btnLimpiarResult
            // 
            this.btnLimpiarResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarResult.Location = new System.Drawing.Point(21, 66);
            this.btnLimpiarResult.Name = "btnLimpiarResult";
            this.btnLimpiarResult.Size = new System.Drawing.Size(103, 127);
            this.btnLimpiarResult.TabIndex = 0;
            this.btnLimpiarResult.Text = "Limpiar Resultado";
            this.btnLimpiarResult.UseVisualStyleBackColor = true;
            this.btnLimpiarResult.Click += new System.EventHandler(this.btnLimpiarResult_Click);
            // 
            // dgvTerminal
            // 
            this.dgvTerminal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTerminal.Location = new System.Drawing.Point(3, 17);
            this.dgvTerminal.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTerminal.Name = "dgvTerminal";
            this.dgvTerminal.ReadOnly = true;
            this.dgvTerminal.RowHeadersWidth = 51;
            this.dgvTerminal.Size = new System.Drawing.Size(1218, 301);
            this.dgvTerminal.TabIndex = 1;
            // 
            // richTx_Servidor
            // 
            this.richTx_Servidor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.richTx_Servidor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTx_Servidor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.richTx_Servidor.Location = new System.Drawing.Point(0, 0);
            this.richTx_Servidor.Name = "richTx_Servidor";
            this.richTx_Servidor.ReadOnly = true;
            this.richTx_Servidor.Size = new System.Drawing.Size(287, 59);
            this.richTx_Servidor.TabIndex = 4;
            this.richTx_Servidor.Text = "";
            // 
            // pan_Server
            // 
            this.pan_Server.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan_Server.Controls.Add(this.richTx_Servidor);
            this.pan_Server.Location = new System.Drawing.Point(6, 17);
            this.pan_Server.Name = "pan_Server";
            this.pan_Server.Size = new System.Drawing.Size(291, 63);
            this.pan_Server.TabIndex = 4;
            // 
            // frmSGBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 776);
            this.Controls.Add(this.pan_Server);
            this.Controls.Add(this.grpTerminal);
            this.Controls.Add(this.grpConsultas);
            this.Controls.Add(this.grpSchemas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSGBD";
            this.Text = "SISTEMA GESTOR BASE DE DATOS";
            this.Load += new System.EventHandler(this.frmSGBD_Load);
            this.grpSchemas.ResumeLayout(false);
            this.grpSchemas2.ResumeLayout(false);
            this.grpConsultas.ResumeLayout(false);
            this.grpTerminal.ResumeLayout(false);
            this.grpTerminal2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminal)).EndInit();
            this.pan_Server.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.GroupBox grpSchemas;
        private System.Windows.Forms.RichTextBox rtxtArbol;
        private System.Windows.Forms.GroupBox grpConsultas;
        private System.Windows.Forms.RichTextBox rtxtConsultas;
        private System.Windows.Forms.GroupBox grpTerminal;
        private System.Windows.Forms.DataGridView dgvTerminal;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.RichTextBox rtxtSchemas;
        private System.Windows.Forms.GroupBox grpSchemas2;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.GroupBox grpTerminal2;
        private System.Windows.Forms.Button btnLimpiarResult;
        private System.Windows.Forms.Panel pan_esquemas;
        private System.Windows.Forms.RichTextBox richTx_Servidor;
        private System.Windows.Forms.Panel pan_Server;
    }
}

