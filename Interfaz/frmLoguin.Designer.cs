
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
            this.chkVer = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmbBD = new System.Windows.Forms.ComboBox();
            this.lblBD = new System.Windows.Forms.Label();
            this.btnWinAuth = new System.Windows.Forms.Button();
            this.grpLoguin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLoguin
            // 
            this.grpLoguin.Controls.Add(this.btnWinAuth);
            this.grpLoguin.Controls.Add(this.chkVer);
            this.grpLoguin.Controls.Add(this.btnCancelar);
            this.grpLoguin.Controls.Add(this.btnIngresar);
            this.grpLoguin.Controls.Add(this.txtPassword);
            this.grpLoguin.Controls.Add(this.lblPassword);
            this.grpLoguin.Controls.Add(this.txtUsuario);
            this.grpLoguin.Controls.Add(this.lblUsuario);
            this.grpLoguin.Controls.Add(this.cmbBD);
            this.grpLoguin.Controls.Add(this.lblBD);
            this.grpLoguin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLoguin.Font = new System.Drawing.Font("Arial Black", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoguin.Location = new System.Drawing.Point(0, 0);
            this.grpLoguin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpLoguin.Name = "grpLoguin";
            this.grpLoguin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpLoguin.Size = new System.Drawing.Size(514, 358);
            this.grpLoguin.TabIndex = 0;
            this.grpLoguin.TabStop = false;
            // 
            // chkVer
            // 
            this.chkVer.AutoSize = true;
            this.chkVer.Location = new System.Drawing.Point(379, 223);
            this.chkVer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkVer.Name = "chkVer";
            this.chkVer.Size = new System.Drawing.Size(57, 26);
            this.chkVer.TabIndex = 8;
            this.chkVer.Text = "Ver";
            this.chkVer.UseVisualStyleBackColor = true;
            this.chkVer.CheckedChanged += new System.EventHandler(this.chkVer_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(314, 287);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 33);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(108, 287);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(92, 33);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(194, 221);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(168, 28);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 176);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(199, 22);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Ingrese su contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(194, 137);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(168, 28);
            this.txtUsuario.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(18, 97);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(262, 22);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Ingrese su nombre de Usuario:";
            // 
            // cmbBD
            // 
            this.cmbBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBD.FormattingEnabled = true;
            this.cmbBD.Items.AddRange(new object[] {
            "SQLServer",
            "MySQL"});
            this.cmbBD.Location = new System.Drawing.Point(194, 67);
            this.cmbBD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBD.Name = "cmbBD";
            this.cmbBD.Size = new System.Drawing.Size(168, 27);
            this.cmbBD.TabIndex = 1;
            this.cmbBD.SelectedIndexChanged += new System.EventHandler(this.cmbBD_SelectedIndexChanged);
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Location = new System.Drawing.Point(16, 33);
            this.lblBD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(461, 22);
            this.lblBD.TabIndex = 0;
            this.lblBD.Text = "Selecione el motor de Base de Datos para Conectarse:";
            // 
            // btnWinAuth
            // 
            this.btnWinAuth.Location = new System.Drawing.Point(217, 287);
            this.btnWinAuth.Name = "btnWinAuth";
            this.btnWinAuth.Size = new System.Drawing.Size(75, 59);
            this.btnWinAuth.TabIndex = 9;
            this.btnWinAuth.Text = "Win Auth";
            this.btnWinAuth.UseVisualStyleBackColor = true;
            this.btnWinAuth.Click += new System.EventHandler(this.btnWinAuth_Click);
            // 
            // frmLoguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 358);
            this.ControlBox = false;
            this.Controls.Add(this.grpLoguin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLoguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrese sus Credenciales";
            this.grpLoguin.ResumeLayout(false);
            this.grpLoguin.PerformLayout();
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
        private System.Windows.Forms.Button btnWinAuth;
    }
}