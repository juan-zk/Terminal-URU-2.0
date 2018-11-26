namespace Administracion
{
    partial class ABMViajesInternacionales
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
            this.tsAcciones = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.gbViajesInter = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblHoraArribo = new System.Windows.Forms.Label();
            this.dtFechaArribo = new System.Windows.Forms.DateTimePicker();
            this.lblHoraPartida = new System.Windows.Forms.Label();
            this.dtFechaPartida = new System.Windows.Forms.DateTimePicker();
            this.cbTerminales = new System.Windows.Forms.ComboBox();
            this.cbCompanias = new System.Windows.Forms.ComboBox();
            this.txtDocumentacion = new System.Windows.Forms.TextBox();
            this.lblDocumentacion = new System.Windows.Forms.Label();
            this.chkServicioaBordo = new System.Windows.Forms.CheckBox();
            this.lblServicioaBordo = new System.Windows.Forms.Label();
            this.txtAsientos = new System.Windows.Forms.TextBox();
            this.lblAsientos = new System.Windows.Forms.Label();
            this.txtHoraArribo = new System.Windows.Forms.TextBox();
            this.lblFechaArribo = new System.Windows.Forms.Label();
            this.txtHoraPartida = new System.Windows.Forms.TextBox();
            this.lblFechaPartida = new System.Windows.Forms.Label();
            this.lblTerminal = new System.Windows.Forms.Label();
            this.lblCompania = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tsAcciones.SuspendLayout();
            this.gbViajesInter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsAcciones
            // 
            this.tsAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEliminar,
            this.btnModificar,
            this.toolStripSeparator1,
            this.btnLimpiar});
            this.tsAcciones.Location = new System.Drawing.Point(0, 0);
            this.tsAcciones.Name = "tsAcciones";
            this.tsAcciones.Size = new System.Drawing.Size(729, 25);
            this.tsAcciones.TabIndex = 0;
            this.tsAcciones.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar.Image = global::Administracion.Properties.Resources.nuevo;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(23, 22);
            this.btnAgregar.Text = "Nuevo";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = global::Administracion.Properties.Resources.eliminar;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificar.Image = global::Administracion.Properties.Resources.modificar;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(23, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLimpiar.Image = global::Administracion.Properties.Resources.cancelar;
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(23, 22);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gbViajesInter
            // 
            this.gbViajesInter.Controls.Add(this.lblError);
            this.gbViajesInter.Controls.Add(this.lblHoraArribo);
            this.gbViajesInter.Controls.Add(this.dtFechaArribo);
            this.gbViajesInter.Controls.Add(this.lblHoraPartida);
            this.gbViajesInter.Controls.Add(this.dtFechaPartida);
            this.gbViajesInter.Controls.Add(this.cbTerminales);
            this.gbViajesInter.Controls.Add(this.cbCompanias);
            this.gbViajesInter.Controls.Add(this.txtDocumentacion);
            this.gbViajesInter.Controls.Add(this.lblDocumentacion);
            this.gbViajesInter.Controls.Add(this.chkServicioaBordo);
            this.gbViajesInter.Controls.Add(this.lblServicioaBordo);
            this.gbViajesInter.Controls.Add(this.txtAsientos);
            this.gbViajesInter.Controls.Add(this.lblAsientos);
            this.gbViajesInter.Controls.Add(this.txtHoraArribo);
            this.gbViajesInter.Controls.Add(this.lblFechaArribo);
            this.gbViajesInter.Controls.Add(this.txtHoraPartida);
            this.gbViajesInter.Controls.Add(this.lblFechaPartida);
            this.gbViajesInter.Controls.Add(this.lblTerminal);
            this.gbViajesInter.Controls.Add(this.lblCompania);
            this.gbViajesInter.Controls.Add(this.txtNumero);
            this.gbViajesInter.Controls.Add(this.lblNumero);
            this.gbViajesInter.Controls.Add(this.label1);
            this.gbViajesInter.Location = new System.Drawing.Point(13, 38);
            this.gbViajesInter.Name = "gbViajesInter";
            this.gbViajesInter.Size = new System.Drawing.Size(695, 295);
            this.gbViajesInter.TabIndex = 1;
            this.gbViajesInter.TabStop = false;
            this.gbViajesInter.Text = "Viajes Internacionales";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(222, 215);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 24;
            // 
            // lblHoraArribo
            // 
            this.lblHoraArribo.AutoSize = true;
            this.lblHoraArribo.Location = new System.Drawing.Point(362, 168);
            this.lblHoraArribo.Name = "lblHoraArribo";
            this.lblHoraArribo.Size = new System.Drawing.Size(75, 13);
            this.lblHoraArribo.TabIndex = 23;
            this.lblHoraArribo.Text = "Hora de Arribo";
            // 
            // dtFechaArribo
            // 
            this.dtFechaArribo.Location = new System.Drawing.Point(454, 124);
            this.dtFechaArribo.Name = "dtFechaArribo";
            this.dtFechaArribo.Size = new System.Drawing.Size(200, 20);
            this.dtFechaArribo.TabIndex = 7;
            // 
            // lblHoraPartida
            // 
            this.lblHoraPartida.AutoSize = true;
            this.lblHoraPartida.Location = new System.Drawing.Point(362, 70);
            this.lblHoraPartida.Name = "lblHoraPartida";
            this.lblHoraPartida.Size = new System.Drawing.Size(81, 13);
            this.lblHoraPartida.TabIndex = 21;
            this.lblHoraPartida.Text = "Hora de Partida";
            // 
            // dtFechaPartida
            // 
            this.dtFechaPartida.Location = new System.Drawing.Point(454, 23);
            this.dtFechaPartida.Name = "dtFechaPartida";
            this.dtFechaPartida.Size = new System.Drawing.Size(200, 20);
            this.dtFechaPartida.TabIndex = 5;
            // 
            // cbTerminales
            // 
            this.cbTerminales.FormattingEnabled = true;
            this.cbTerminales.Location = new System.Drawing.Point(202, 123);
            this.cbTerminales.Name = "cbTerminales";
            this.cbTerminales.Size = new System.Drawing.Size(121, 21);
            this.cbTerminales.TabIndex = 2;
            // 
            // cbCompanias
            // 
            this.cbCompanias.FormattingEnabled = true;
            this.cbCompanias.Location = new System.Drawing.Point(202, 70);
            this.cbCompanias.Name = "cbCompanias";
            this.cbCompanias.Size = new System.Drawing.Size(121, 21);
            this.cbCompanias.TabIndex = 1;
            // 
            // txtDocumentacion
            // 
            this.txtDocumentacion.Location = new System.Drawing.Point(202, 254);
            this.txtDocumentacion.Name = "txtDocumentacion";
            this.txtDocumentacion.Size = new System.Drawing.Size(245, 20);
            this.txtDocumentacion.TabIndex = 4;
            // 
            // lblDocumentacion
            // 
            this.lblDocumentacion.AutoSize = true;
            this.lblDocumentacion.Location = new System.Drawing.Point(7, 262);
            this.lblDocumentacion.Name = "lblDocumentacion";
            this.lblDocumentacion.Size = new System.Drawing.Size(82, 13);
            this.lblDocumentacion.TabIndex = 17;
            this.lblDocumentacion.Text = "Documentación";
            // 
            // chkServicioaBordo
            // 
            this.chkServicioaBordo.AutoSize = true;
            this.chkServicioaBordo.Location = new System.Drawing.Point(6, 211);
            this.chkServicioaBordo.Name = "chkServicioaBordo";
            this.chkServicioaBordo.Size = new System.Drawing.Size(104, 17);
            this.chkServicioaBordo.TabIndex = 16;
            this.chkServicioaBordo.Text = "Servicio a Bordo";
            this.chkServicioaBordo.UseVisualStyleBackColor = true;
            // 
            // lblServicioaBordo
            // 
            this.lblServicioaBordo.AutoSize = true;
            this.lblServicioaBordo.Location = new System.Drawing.Point(7, 231);
            this.lblServicioaBordo.Name = "lblServicioaBordo";
            this.lblServicioaBordo.Size = new System.Drawing.Size(0, 13);
            this.lblServicioaBordo.TabIndex = 15;
            // 
            // txtAsientos
            // 
            this.txtAsientos.Location = new System.Drawing.Point(202, 161);
            this.txtAsientos.Name = "txtAsientos";
            this.txtAsientos.Size = new System.Drawing.Size(121, 20);
            this.txtAsientos.TabIndex = 3;
            // 
            // lblAsientos
            // 
            this.lblAsientos.AutoSize = true;
            this.lblAsientos.Location = new System.Drawing.Point(7, 169);
            this.lblAsientos.Name = "lblAsientos";
            this.lblAsientos.Size = new System.Drawing.Size(107, 13);
            this.lblAsientos.TabIndex = 11;
            this.lblAsientos.Text = "Cantidad de Asientos";
            // 
            // txtHoraArribo
            // 
            this.txtHoraArribo.Location = new System.Drawing.Point(454, 162);
            this.txtHoraArribo.Name = "txtHoraArribo";
            this.txtHoraArribo.Size = new System.Drawing.Size(200, 20);
            this.txtHoraArribo.TabIndex = 8;
            this.txtHoraArribo.TextChanged += new System.EventHandler(this.txtFechaArribo_TextChanged);
            // 
            // lblFechaArribo
            // 
            this.lblFechaArribo.AutoSize = true;
            this.lblFechaArribo.Location = new System.Drawing.Point(362, 131);
            this.lblFechaArribo.Name = "lblFechaArribo";
            this.lblFechaArribo.Size = new System.Drawing.Size(82, 13);
            this.lblFechaArribo.TabIndex = 9;
            this.lblFechaArribo.Text = "Fecha de Arribo";
            // 
            // txtHoraPartida
            // 
            this.txtHoraPartida.Location = new System.Drawing.Point(454, 63);
            this.txtHoraPartida.Name = "txtHoraPartida";
            this.txtHoraPartida.Size = new System.Drawing.Size(200, 20);
            this.txtHoraPartida.TabIndex = 6;
            this.txtHoraPartida.TextChanged += new System.EventHandler(this.txtHoraPartida_TextChanged);
            // 
            // lblFechaPartida
            // 
            this.lblFechaPartida.AutoSize = true;
            this.lblFechaPartida.Location = new System.Drawing.Point(359, 31);
            this.lblFechaPartida.Name = "lblFechaPartida";
            this.lblFechaPartida.Size = new System.Drawing.Size(88, 13);
            this.lblFechaPartida.TabIndex = 7;
            this.lblFechaPartida.Text = "Fecha de Partida";
            // 
            // lblTerminal
            // 
            this.lblTerminal.AutoSize = true;
            this.lblTerminal.Location = new System.Drawing.Point(7, 131);
            this.lblTerminal.Name = "lblTerminal";
            this.lblTerminal.Size = new System.Drawing.Size(83, 13);
            this.lblTerminal.TabIndex = 5;
            this.lblTerminal.Text = "Código Terminal";
            // 
            // lblCompania
            // 
            this.lblCompania.AutoSize = true;
            this.lblCompania.Location = new System.Drawing.Point(3, 78);
            this.lblCompania.Name = "lblCompania";
            this.lblCompania.Size = new System.Drawing.Size(94, 13);
            this.lblCompania.TabIndex = 3;
            this.lblCompania.Text = "Nombre Compañia";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(202, 24);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(121, 20);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumero_Validating);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(6, 31);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // ABMViajesInternacionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 345);
            this.Controls.Add(this.gbViajesInter);
            this.Controls.Add(this.tsAcciones);
            this.Name = "ABMViajesInternacionales";
            this.Text = "Viajes Internacionales";
            this.tsAcciones.ResumeLayout(false);
            this.tsAcciones.PerformLayout();
            this.gbViajesInter.ResumeLayout(false);
            this.gbViajesInter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsAcciones;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.GroupBox gbViajesInter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCompania;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblTerminal;
        private System.Windows.Forms.TextBox txtHoraPartida;
        private System.Windows.Forms.Label lblFechaPartida;
        private System.Windows.Forms.CheckBox chkServicioaBordo;
        private System.Windows.Forms.Label lblServicioaBordo;
        private System.Windows.Forms.TextBox txtAsientos;
        private System.Windows.Forms.Label lblAsientos;
        private System.Windows.Forms.TextBox txtHoraArribo;
        private System.Windows.Forms.Label lblFechaArribo;
        private System.Windows.Forms.TextBox txtDocumentacion;
        private System.Windows.Forms.Label lblDocumentacion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox cbTerminales;
        private System.Windows.Forms.ComboBox cbCompanias;
        private System.Windows.Forms.Label lblHoraPartida;
        private System.Windows.Forms.DateTimePicker dtFechaPartida;
        private System.Windows.Forms.Label lblHoraArribo;
        private System.Windows.Forms.DateTimePicker dtFechaArribo;
        private System.Windows.Forms.Label lblError;
    }
}