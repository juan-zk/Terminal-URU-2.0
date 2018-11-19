namespace Administracion
{
    partial class ABMTerminal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMTerminal));
            this.tsBotones = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtFacilidad = new System.Windows.Forms.TextBox();
            this.lstFacilidad = new System.Windows.Forms.ListBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.grp = new System.Windows.Forms.GroupBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnFacilidadAgregar = new System.Windows.Forms.Button();
            this.btnFacilidadBorrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tsBotones.SuspendLayout();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsBotones
            // 
            this.tsBotones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEliminar,
            this.btnModificar,
            this.toolStripSeparator1,
            this.btnLimpiar});
            this.tsBotones.Location = new System.Drawing.Point(0, 0);
            this.tsBotones.Name = "tsBotones";
            this.tsBotones.Size = new System.Drawing.Size(525, 25);
            this.tsBotones.TabIndex = 0;
            this.tsBotones.Text = "tsBotones";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(23, 22);
            this.btnAgregar.Text = "Nuevo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.Text = "Eliminar";
            // 
            // btnModificar
            // 
            this.btnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(23, 22);
            this.btnModificar.Text = "Modificar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(23, 22);
            this.btnLimpiar.Text = "Limpiar";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(136, 51);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(250, 22);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigo_Validating);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(136, 133);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(250, 22);
            this.txtCiudad.TabIndex = 2;
            // 
            // txtFacilidad
            // 
            this.txtFacilidad.Location = new System.Drawing.Point(136, 269);
            this.txtFacilidad.Name = "txtFacilidad";
            this.txtFacilidad.Size = new System.Drawing.Size(250, 22);
            this.txtFacilidad.TabIndex = 3;
            // 
            // lstFacilidad
            // 
            this.lstFacilidad.FormattingEnabled = true;
            this.lstFacilidad.ItemHeight = 16;
            this.lstFacilidad.Location = new System.Drawing.Point(136, 179);
            this.lstFacilidad.Name = "lstFacilidad";
            this.lstFacilidad.Size = new System.Drawing.Size(250, 84);
            this.lstFacilidad.TabIndex = 4;
            // 
            // cmbPais
            // 
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(136, 91);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(250, 24);
            this.cmbPais.TabIndex = 5;
            // 
            // grp
            // 
            this.grp.Controls.Add(this.lblMensaje);
            this.grp.Controls.Add(this.btnFacilidadAgregar);
            this.grp.Controls.Add(this.btnFacilidadBorrar);
            this.grp.Controls.Add(this.label4);
            this.grp.Controls.Add(this.label3);
            this.grp.Controls.Add(this.label2);
            this.grp.Controls.Add(this.label1);
            this.grp.Controls.Add(this.lstFacilidad);
            this.grp.Controls.Add(this.cmbPais);
            this.grp.Controls.Add(this.txtCodigo);
            this.grp.Controls.Add(this.txtCiudad);
            this.grp.Controls.Add(this.txtFacilidad);
            this.grp.Location = new System.Drawing.Point(12, 28);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(501, 431);
            this.grp.TabIndex = 6;
            this.grp.TabStop = false;
            this.grp.Text = "Terminales";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(133, 344);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 17);
            this.lblMensaje.TabIndex = 12;
            // 
            // btnFacilidadAgregar
            // 
            this.btnFacilidadAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnFacilidadAgregar.Image")));
            this.btnFacilidadAgregar.Location = new System.Drawing.Point(392, 269);
            this.btnFacilidadAgregar.Name = "btnFacilidadAgregar";
            this.btnFacilidadAgregar.Size = new System.Drawing.Size(25, 22);
            this.btnFacilidadAgregar.TabIndex = 11;
            this.btnFacilidadAgregar.UseVisualStyleBackColor = true;
            this.btnFacilidadAgregar.Click += new System.EventHandler(this.btnFacilidadAgregar_Click);
            // 
            // btnFacilidadBorrar
            // 
            this.btnFacilidadBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFacilidadBorrar.Image")));
            this.btnFacilidadBorrar.Location = new System.Drawing.Point(392, 241);
            this.btnFacilidadBorrar.Name = "btnFacilidadBorrar";
            this.btnFacilidadBorrar.Size = new System.Drawing.Size(25, 22);
            this.btnFacilidadBorrar.TabIndex = 10;
            this.btnFacilidadBorrar.UseVisualStyleBackColor = true;
            this.btnFacilidadBorrar.Click += new System.EventHandler(this.btnFacilidadBorrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Facilidades";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo";
            // 
            // ABMTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 471);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.tsBotones);
            this.Name = "ABMTerminal";
            this.Text = "Terminales";
            this.tsBotones.ResumeLayout(false);
            this.tsBotones.PerformLayout();
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBotones;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtFacilidad;
        private System.Windows.Forms.ListBox lstFacilidad;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnFacilidadAgregar;
        private System.Windows.Forms.Button btnFacilidadBorrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}