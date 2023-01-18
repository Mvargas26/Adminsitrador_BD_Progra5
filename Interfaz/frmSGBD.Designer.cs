
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
            this.grpSchemas2 = new System.Windows.Forms.GroupBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.pan_esquemas = new System.Windows.Forms.Panel();
            this.btn_Ninguna = new System.Windows.Forms.Button();
            this.btn_Todas = new System.Windows.Forms.Button();
            this.rtxtSchemas = new System.Windows.Forms.RichTextBox();
            this.rtxtArbol = new System.Windows.Forms.RichTextBox();
            this.grpConsultas = new System.Windows.Forms.GroupBox();
            this.btnLimpiarSelec = new System.Windows.Forms.Button();
            this.lblBasesSelec = new System.Windows.Forms.Label();
            this.rhc_BasesSelect = new System.Windows.Forms.RichTextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.rtxtConsultas = new System.Windows.Forms.RichTextBox();
            this.grpTerminal = new System.Windows.Forms.GroupBox();
            this.pan_Terminal = new System.Windows.Forms.Panel();
            this.grpTerminal2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarResult = new System.Windows.Forms.Button();
            this.richTx_Servidor = new System.Windows.Forms.RichTextBox();
            this.pan_Server = new System.Windows.Forms.Panel();
            this.grpSchemas.SuspendLayout();
            this.grpSchemas2.SuspendLayout();
            this.pan_esquemas.SuspendLayout();
            this.grpConsultas.SuspendLayout();
            this.grpTerminal.SuspendLayout();
            this.grpTerminal2.SuspendLayout();
            this.pan_Server.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(345, 309);
            this.btnEjecutar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(181, 53);
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
            // pan_esquemas
            // 
            this.pan_esquemas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan_esquemas.Controls.Add(this.btn_Ninguna);
            this.pan_esquemas.Controls.Add(this.btn_Todas);
            this.pan_esquemas.Location = new System.Drawing.Point(6, 25);
            this.pan_esquemas.Name = "pan_esquemas";
            this.pan_esquemas.Size = new System.Drawing.Size(294, 341);
            this.pan_esquemas.TabIndex = 3;
            // 
            // btn_Ninguna
            // 
            this.btn_Ninguna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Ninguna.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Ninguna.Font = new System.Drawing.Font("Arial Black", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ninguna.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Ninguna.Location = new System.Drawing.Point(140, 196);
            this.btn_Ninguna.Name = "btn_Ninguna";
            this.btn_Ninguna.Size = new System.Drawing.Size(98, 31);
            this.btn_Ninguna.TabIndex = 1;
            this.btn_Ninguna.Text = "Ninguna";
            this.btn_Ninguna.UseVisualStyleBackColor = false;
            this.btn_Ninguna.Click += new System.EventHandler(this.btn_Ninguna_Click);
            // 
            // btn_Todas
            // 
            this.btn_Todas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Todas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Todas.Font = new System.Drawing.Font("Arial Black", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Todas.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Todas.Location = new System.Drawing.Point(14, 196);
            this.btn_Todas.Name = "btn_Todas";
            this.btn_Todas.Size = new System.Drawing.Size(98, 31);
            this.btn_Todas.TabIndex = 0;
            this.btn_Todas.Text = "Todas";
            this.btn_Todas.UseVisualStyleBackColor = false;
            this.btn_Todas.Click += new System.EventHandler(this.btn_Todas_Click);
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
            this.grpConsultas.Controls.Add(this.btnLimpiarSelec);
            this.grpConsultas.Controls.Add(this.lblBasesSelec);
            this.grpConsultas.Controls.Add(this.rhc_BasesSelect);
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
            // btnLimpiarSelec
            // 
            this.btnLimpiarSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarSelec.Location = new System.Drawing.Point(9, 394);
            this.btnLimpiarSelec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarSelec.Name = "btnLimpiarSelec";
            this.btnLimpiarSelec.Size = new System.Drawing.Size(127, 36);
            this.btnLimpiarSelec.TabIndex = 5;
            this.btnLimpiarSelec.Text = "Limpiar";
            this.btnLimpiarSelec.UseVisualStyleBackColor = true;
            this.btnLimpiarSelec.Click += new System.EventHandler(this.btnLimpiarSelec_Click);
            // 
            // lblBasesSelec
            // 
            this.lblBasesSelec.AutoSize = true;
            this.lblBasesSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasesSelec.Location = new System.Drawing.Point(6, 309);
            this.lblBasesSelec.Name = "lblBasesSelec";
            this.lblBasesSelec.Size = new System.Drawing.Size(163, 16);
            this.lblBasesSelec.TabIndex = 4;
            this.lblBasesSelec.Text = "Bases Seleccionadas:";
            // 
            // rhc_BasesSelect
            // 
            this.rhc_BasesSelect.Location = new System.Drawing.Point(6, 331);
            this.rhc_BasesSelect.Name = "rhc_BasesSelect";
            this.rhc_BasesSelect.Size = new System.Drawing.Size(168, 58);
            this.rhc_BasesSelect.TabIndex = 3;
            this.rhc_BasesSelect.Text = "";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(550, 309);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(192, 53);
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
            this.grpTerminal.Controls.Add(this.pan_Terminal);
            this.grpTerminal.Controls.Add(this.grpTerminal2);
            this.grpTerminal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpTerminal.Location = new System.Drawing.Point(0, 438);
            this.grpTerminal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTerminal.Name = "grpTerminal";
            this.grpTerminal.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTerminal.Size = new System.Drawing.Size(1224, 338);
            this.grpTerminal.TabIndex = 3;
            this.grpTerminal.TabStop = false;
            this.grpTerminal.Text = "TERMINAL";
            // 
            // pan_Terminal
            // 
            this.pan_Terminal.AutoScroll = true;
            this.pan_Terminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Terminal.Location = new System.Drawing.Point(3, 17);
            this.pan_Terminal.Name = "pan_Terminal";
            this.pan_Terminal.Size = new System.Drawing.Size(1080, 319);
            this.pan_Terminal.TabIndex = 3;
            // 
            // grpTerminal2
            // 
            this.grpTerminal2.Controls.Add(this.btnLimpiarResult);
            this.grpTerminal2.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpTerminal2.Location = new System.Drawing.Point(1083, 17);
            this.grpTerminal2.Name = "grpTerminal2";
            this.grpTerminal2.Size = new System.Drawing.Size(138, 319);
            this.grpTerminal2.TabIndex = 2;
            this.grpTerminal2.TabStop = false;
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
            this.AutoScroll = true;
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
            this.pan_esquemas.ResumeLayout(false);
            this.grpConsultas.ResumeLayout(false);
            this.grpConsultas.PerformLayout();
            this.grpTerminal.ResumeLayout(false);
            this.grpTerminal2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.RichTextBox rtxtSchemas;
        private System.Windows.Forms.GroupBox grpSchemas2;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.GroupBox grpTerminal2;
        private System.Windows.Forms.Button btnLimpiarResult;
        private System.Windows.Forms.Panel pan_esquemas;
        private System.Windows.Forms.RichTextBox richTx_Servidor;
        private System.Windows.Forms.Panel pan_Server;
        private System.Windows.Forms.Panel pan_Terminal;
        private System.Windows.Forms.Button btnLimpiarSelec;
        private System.Windows.Forms.Label lblBasesSelec;
        private System.Windows.Forms.RichTextBox rhc_BasesSelect;
        private System.Windows.Forms.Button btn_Ninguna;
        private System.Windows.Forms.Button btn_Todas;
    }
}

