namespace Administracion
{
    partial class FrmInicio
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
            this.stpMenu = new System.Windows.Forms.MenuStrip();
            this.menuEstad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViaje = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViajeNac = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViajeInter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuComp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTerm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsr = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsrCerrarS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsrSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.stpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // stpMenu
            // 
            this.stpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEstad,
            this.menuViaje,
            this.menuComp,
            this.menuTerm,
            this.menuEmp,
            this.menuUsr});
            this.stpMenu.Location = new System.Drawing.Point(0, 0);
            this.stpMenu.Name = "stpMenu";
            this.stpMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.stpMenu.Size = new System.Drawing.Size(1020, 28);
            this.stpMenu.TabIndex = 0;
            this.stpMenu.Text = "menu";
            // 
            // menuEstad
            // 
            this.menuEstad.Name = "menuEstad";
            this.menuEstad.Size = new System.Drawing.Size(97, 24);
            this.menuEstad.Text = "Estadisticas";
            // 
            // menuViaje
            // 
            this.menuViaje.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViajeNac,
            this.menuViajeInter});
            this.menuViaje.Name = "menuViaje";
            this.menuViaje.Size = new System.Drawing.Size(60, 24);
            this.menuViaje.Text = "Viajes";
            // 
            // menuViajeNac
            // 
            this.menuViajeNac.Name = "menuViajeNac";
            this.menuViajeNac.Size = new System.Drawing.Size(178, 24);
            this.menuViajeNac.Text = "Nacionales";
            this.menuViajeNac.Click += new System.EventHandler(this.menuViajeNac_Click);
            // 
            // menuViajeInter
            // 
            this.menuViajeInter.Name = "menuViajeInter";
            this.menuViajeInter.Size = new System.Drawing.Size(178, 24);
            this.menuViajeInter.Text = "Internacionales";
            // 
            // menuComp
            // 
            this.menuComp.Name = "menuComp";
            this.menuComp.Size = new System.Drawing.Size(95, 24);
            this.menuComp.Text = "Compañias";
            // 
            // menuTerm
            // 
            this.menuTerm.Name = "menuTerm";
            this.menuTerm.Size = new System.Drawing.Size(92, 24);
            this.menuTerm.Text = "Terminales";
            this.menuTerm.Click += new System.EventHandler(this.menuTerm_Click);
            // 
            // menuEmp
            // 
            this.menuEmp.Name = "menuEmp";
            this.menuEmp.Size = new System.Drawing.Size(95, 24);
            this.menuEmp.Text = "Empleados";
            this.menuEmp.Click += new System.EventHandler(this.menuEmp_Click);
            // 
            // menuUsr
            // 
            this.menuUsr.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuUsr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsrCerrarS,
            this.menuUsrSalir});
            this.menuUsr.Name = "menuUsr";
            this.menuUsr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuUsr.Size = new System.Drawing.Size(71, 24);
            this.menuUsr.Text = "Usuario";
            // 
            // menuUsrCerrarS
            // 
            this.menuUsrCerrarS.Name = "menuUsrCerrarS";
            this.menuUsrCerrarS.Size = new System.Drawing.Size(163, 24);
            this.menuUsrCerrarS.Text = "Cerrar sesion";
            this.menuUsrCerrarS.Click += new System.EventHandler(this.menuUsrCerrarS_Click);
            // 
            // menuUsrSalir
            // 
            this.menuUsrSalir.Name = "menuUsrSalir";
            this.menuUsrSalir.Size = new System.Drawing.Size(163, 24);
            this.menuUsrSalir.Text = "Salir";
            this.menuUsrSalir.Click += new System.EventHandler(this.menuUsrSalir_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 466);
            this.Controls.Add(this.stpMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.stpMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion TerminalURU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.stpMenu.ResumeLayout(false);
            this.stpMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip stpMenu;
        private System.Windows.Forms.ToolStripMenuItem menuEstad;
        private System.Windows.Forms.ToolStripMenuItem menuViaje;
        private System.Windows.Forms.ToolStripMenuItem menuViajeNac;
        private System.Windows.Forms.ToolStripMenuItem menuViajeInter;
        private System.Windows.Forms.ToolStripMenuItem menuComp;
        private System.Windows.Forms.ToolStripMenuItem menuTerm;
        private System.Windows.Forms.ToolStripMenuItem menuEmp;
        private System.Windows.Forms.ToolStripMenuItem menuUsr;
        private System.Windows.Forms.ToolStripMenuItem menuUsrCerrarS;
        private System.Windows.Forms.ToolStripMenuItem menuUsrSalir;

    }
}