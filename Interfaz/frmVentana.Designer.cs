
namespace Interfaz
{
    partial class frmVentana
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
            this.mnMenu = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMenu
            // 
            this.mnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.mnPrincipal,
            this.salirToolStripMenuItem});
            this.mnMenu.Location = new System.Drawing.Point(0, 0);
            this.mnMenu.Name = "mnMenu";
            this.mnMenu.Size = new System.Drawing.Size(1361, 37);
            this.mnMenu.TabIndex = 1;
            this.mnMenu.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(87, 33);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Size = new System.Drawing.Size(121, 33);
            this.mnPrincipal.Text = "Principal";
            this.mnPrincipal.Click += new System.EventHandler(this.principalToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(76, 33);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 783);
            this.Controls.Add(this.mnMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnMenu;
            this.Name = "frmVentana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmVentana_Load);
            this.mnMenu.ResumeLayout(false);
            this.mnMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnMenu;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}