
namespace Interfaz
{
    partial class frmLoguin
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
            this.grpLoguin = new System.Windows.Forms.GroupBox();
            this.grp_Credenciales = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.chkVer = new System.Windows.Forms.CheckBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.cmbBD = new System.Windows.Forms.ComboBox();
            this.lblBD = new System.Windows.Forms.Label();
            this.grpLoguin.SuspendLayout();
            this.grp_Credenciales.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLoguin
            // 
            this.grpLoguin.Controls.Add(this.label1);
            this.grpLoguin.Controls.Add(this.txtServidor);
            this.grpLoguin.Controls.Add(this.grp_Credenciales);
            this.grpLoguin.Controls.Add(this.btnCancelar);
            this.grpLoguin.Controls.Add(this.btnIngresar);
            this.grpLoguin.Controls.Add(this.cmbBD);
            this.grpLoguin.Controls.Add(this.lblBD);
            this.grpLoguin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLoguin.Font = new System.Drawing.Font("Arial Black", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoguin.Location = new System.Drawing.Point(0, 0);
            this.grpLoguin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpLoguin.Name = "grpLoguin";
            this.grpLoguin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpLoguin.Size = new System.Drawing.Size(676, 729);
            this.grpLoguin.TabIndex = 0;
            this.grpLoguin.TabStop = false;
            // 
            // grp_Credenciales
            // 
            this.grp_Credenciales.Controls.Add(this.lblUsuario);
            this.grp_Credenciales.Controls.Add(this.txtUsuario);
            this.grp_Credenciales.Controls.Add(this.chkVer);
            this.grp_Credenciales.Controls.Add(this.lblPassword);
            this.grp_Credenciales.Controls.Add(this.txtPassword);
            this.grp_Credenciales.Location = new System.Drawing.Point(26, 249);
            this.grp_Credenciales.Name = "grp_Credenciales";
            this.grp_Credenciales.Size = new System.Drawing.Size(567, 303);
            this.grp_Credenciales.TabIndex = 12;
            this.grp_Credenciales.TabStop = false;
            this.grp_Credenciales.Text = "Credenciales User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingrese el nombre de la instancia:";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(256, 189);
            this.txtServidor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(223, 33);
            this.txtServidor.TabIndex = 11;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(6, 66);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(313, 26);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Ingrese su nombre de Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(241, 116);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(223, 33);
            this.txtUsuario.TabIndex = 3;
            // 
            // chkVer
            // 
            this.chkVer.AutoSize = true;
            this.chkVer.Location = new System.Drawing.Point(487, 221);
            this.chkVer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkVer.Name = "chkVer";
            this.chkVer.Size = new System.Drawing.Size(67, 30);
            this.chkVer.TabIndex = 8;
            this.chkVer.Text = "Ver";
            this.chkVer.UseVisualStyleBackColor = true;
            this.chkVer.CheckedChanged += new System.EventHandler(this.chkVer_CheckedChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 164);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(238, 26);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Ingrese su contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(241, 219);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(223, 33);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(389, 627);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 41);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(114, 627);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(123, 41);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // cmbBD
            // 
            this.cmbBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBD.FormattingEnabled = true;
            this.cmbBD.Items.AddRange(new object[] {
            "SQLServer",
            "MySQL",
            "SQLServer(Windos Autentification)"});
            this.cmbBD.Location = new System.Drawing.Point(259, 82);
            this.cmbBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBD.Name = "cmbBD";
            this.cmbBD.Size = new System.Drawing.Size(223, 34);
            this.cmbBD.TabIndex = 1;
            this.cmbBD.SelectedIndexChanged += new System.EventHandler(this.cmbBD_SelectedIndexChanged);
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Location = new System.Drawing.Point(21, 41);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(550, 26);
            this.lblBD.TabIndex = 0;
            this.lblBD.Text = "Selecione el motor de Base de Datos para Conectarse:";
            // 
            // frmLoguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 729);
            this.ControlBox = false;
            this.Controls.Add(this.grpLoguin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLoguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrese sus Credenciales";
            this.grpLoguin.ResumeLayout(false);
            this.grpLoguin.PerformLayout();
            this.grp_Credenciales.ResumeLayout(false);
            this.grp_Credenciales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLoguin;
        private System.Windows.Forms.CheckBox chkVer;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbBD;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_Credenciales;
    }
}