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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblError = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsAcciones.SuspendLayout();
            this.gbViajesInter.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.tsAcciones.Size = new System.Drawing.Size(972, 25);
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
            this.gbViajesInter.Location = new System.Drawing.Point(17, 47);
            this.gbViajesInter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbViajesInter.Name = "gbViajesInter";
            this.gbViajesInter.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbViajesInter.Size = new System.Drawing.Size(927, 363);
            this.gbViajesInter.TabIndex = 1;
            this.gbViajesInter.TabStop = false;
            this.gbViajesInter.Text = "Viajes Internacionales";
            // 
            // lblHoraArribo
            // 
            this.lblHoraArribo.AutoSize = true;
            this.lblHoraArribo.Location = new System.Drawing.Point(483, 207);
            this.lblHoraArribo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraArribo.Name = "lblHoraArribo";
            this.lblHoraArribo.Size = new System.Drawing.Size(101, 17);
            this.lblHoraArribo.TabIndex = 23;
            this.lblHoraArribo.Text = "Hora de Arribo";
            // 
            // dtFechaArribo
            // 
            this.dtFechaArribo.Location = new System.Drawing.Point(605, 153);
            this.dtFechaArribo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFechaArribo.Name = "dtFechaArribo";
            this.dtFechaArribo.Size = new System.Drawing.Size(265, 22);
            this.dtFechaArribo.TabIndex = 7;
            // 
            // lblHoraPartida
            // 
            this.lblHoraPartida.AutoSize = true;
            this.lblHoraPartida.Location = new System.Drawing.Point(483, 86);
            this.lblHoraPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraPartida.Name = "lblHoraPartida";
            this.lblHoraPartida.Size = new System.Drawing.Size(108, 17);
            this.lblHoraPartida.TabIndex = 21;
            this.lblHoraPartida.Text = "Hora de Partida";
            // 
            // dtFechaPartida
            // 
            this.dtFechaPartida.Location = new System.Drawing.Point(605, 28);
            this.dtFechaPartida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFechaPartida.Name = "dtFechaPartida";
            this.dtFechaPartida.Size = new System.Drawing.Size(265, 22);
            this.dtFechaPartida.TabIndex = 5;
            // 
            // cbTerminales
            // 
            this.cbTerminales.FormattingEnabled = true;
            this.cbTerminales.Location = new System.Drawing.Point(269, 151);
            this.cbTerminales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTerminales.Name = "cbTerminales";
            this.cbTerminales.Size = new System.Drawing.Size(160, 24);
            this.cbTerminales.TabIndex = 2;
            // 
            // cbCompanias
            // 
            this.cbCompanias.FormattingEnabled = true;
            this.cbCompanias.Location = new System.Drawing.Point(269, 86);
            this.cbCompanias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCompanias.Name = "cbCompanias";
            this.cbCompanias.Size = new System.Drawing.Size(160, 24);
            this.cbCompanias.TabIndex = 1;
            // 
            // txtDocumentacion
            // 
            this.txtDocumentacion.Location = new System.Drawing.Point(269, 313);
            this.txtDocumentacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocumentacion.Name = "txtDocumentacion";
            this.txtDocumentacion.Size = new System.Drawing.Size(325, 22);
            this.txtDocumentacion.TabIndex = 4;
            // 
            // lblDocumentacion
            // 
            this.lblDocumentacion.AutoSize = true;
            this.lblDocumentacion.Location = new System.Drawing.Point(9, 322);
            this.lblDocumentacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumentacion.Name = "lblDocumentacion";
            this.lblDocumentacion.Size = new System.Drawing.Size(106, 17);
            this.lblDocumentacion.TabIndex = 17;
            this.lblDocumentacion.Text = "Documentación";
            // 
            // chkServicioaBordo
            // 
            this.chkServicioaBordo.AutoSize = true;
            this.chkServicioaBordo.Location = new System.Drawing.Point(8, 260);
            this.chkServicioaBordo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkServicioaBordo.Name = "chkServicioaBordo";
            this.chkServicioaBordo.Size = new System.Drawing.Size(134, 21);
            this.chkServicioaBordo.TabIndex = 16;
            this.chkServicioaBordo.Text = "Servicio a Bordo";
            this.chkServicioaBordo.UseVisualStyleBackColor = true;
            // 
            // lblServicioaBordo
            // 
            this.lblServicioaBordo.AutoSize = true;
            this.lblServicioaBordo.Location = new System.Drawing.Point(9, 284);
            this.lblServicioaBordo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServicioaBordo.Name = "lblServicioaBordo";
            this.lblServicioaBordo.Size = new System.Drawing.Size(0, 17);
            this.lblServicioaBordo.TabIndex = 15;
            // 
            // txtAsientos
            // 
            this.txtAsientos.Location = new System.Drawing.Point(269, 198);
            this.txtAsientos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAsientos.Name = "txtAsientos";
            this.txtAsientos.Size = new System.Drawing.Size(160, 22);
            this.txtAsientos.TabIndex = 3;
            // 
            // lblAsientos
            // 
            this.lblAsientos.AutoSize = true;
            this.lblAsientos.Location = new System.Drawing.Point(9, 208);
            this.lblAsientos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsientos.Name = "lblAsientos";
            this.lblAsientos.Size = new System.Drawing.Size(142, 17);
            this.lblAsientos.TabIndex = 11;
            this.lblAsientos.Text = "Cantidad de Asientos";
            // 
            // txtHoraArribo
            // 
            this.txtHoraArribo.Location = new System.Drawing.Point(605, 199);
            this.txtHoraArribo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoraArribo.Name = "txtHoraArribo";
            this.txtHoraArribo.Size = new System.Drawing.Size(265, 22);
            this.txtHoraArribo.TabIndex = 8;
            this.txtHoraArribo.TextChanged += new System.EventHandler(this.txtFechaArribo_TextChanged);
            // 
            // lblFechaArribo
            // 
            this.lblFechaArribo.AutoSize = true;
            this.lblFechaArribo.Location = new System.Drawing.Point(483, 161);
            this.lblFechaArribo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaArribo.Name = "lblFechaArribo";
            this.lblFechaArribo.Size = new System.Drawing.Size(109, 17);
            this.lblFechaArribo.TabIndex = 9;
            this.lblFechaArribo.Text = "Fecha de Arribo";
            // 
            // txtHoraPartida
            // 
            this.txtHoraPartida.Location = new System.Drawing.Point(605, 78);
            this.txtHoraPartida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoraPartida.Name = "txtHoraPartida";
            this.txtHoraPartida.Size = new System.Drawing.Size(265, 22);
            this.txtHoraPartida.TabIndex = 6;
            this.txtHoraPartida.TextChanged += new System.EventHandler(this.txtHoraPartida_TextChanged);
            // 
            // lblFechaPartida
            // 
            this.lblFechaPartida.AutoSize = true;
            this.lblFechaPartida.Location = new System.Drawing.Point(479, 38);
            this.lblFechaPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaPartida.Name = "lblFechaPartida";
            this.lblFechaPartida.Size = new System.Drawing.Size(116, 17);
            this.lblFechaPartida.TabIndex = 7;
            this.lblFechaPartida.Text = "Fecha de Partida";
            // 
            // lblTerminal
            // 
            this.lblTerminal.AutoSize = true;
            this.lblTerminal.Location = new System.Drawing.Point(9, 161);
            this.lblTerminal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTerminal.Name = "lblTerminal";
            this.lblTerminal.Size = new System.Drawing.Size(111, 17);
            this.lblTerminal.TabIndex = 5;
            this.lblTerminal.Text = "Código Terminal";
            // 
            // lblCompania
            // 
            this.lblCompania.AutoSize = true;
            this.lblCompania.Location = new System.Drawing.Point(4, 96);
            this.lblCompania.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompania.Name = "lblCompania";
            this.lblCompania.Size = new System.Drawing.Size(125, 17);
            this.lblCompania.TabIndex = 3;
            this.lblCompania.Text = "Nombre Compañia";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(269, 30);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(160, 22);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumero_Validating);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(8, 38);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 17);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(972, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblError
            // 
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            // 
            // ABMViajesInternacionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 449);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbViajesInter);
            this.Controls.Add(this.tsAcciones);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ABMViajesInternacionales";
            this.Text = "Viajes Internacionales";
            this.tsAcciones.ResumeLayout(false);
            this.tsAcciones.PerformLayout();
            this.gbViajesInter.ResumeLayout(false);
            this.gbViajesInter.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblError;
    }
}