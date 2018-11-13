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
            this.gbViajesInter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblCompania = new System.Windows.Forms.Label();
            this.txtCompania = new System.Windows.Forms.TextBox();
            this.lblTerminal = new System.Windows.Forms.Label();
            this.txtTerminal = new System.Windows.Forms.TextBox();
            this.lblFechaPartida = new System.Windows.Forms.Label();
            this.txtFechaPartida = new System.Windows.Forms.TextBox();
            this.lblFechaArribo = new System.Windows.Forms.Label();
            this.txtFechaArribo = new System.Windows.Forms.TextBox();
            this.lblAsientos = new System.Windows.Forms.Label();
            this.txtAsientos = new System.Windows.Forms.TextBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.lblServicioaBordo = new System.Windows.Forms.Label();
            this.chkServicioaBordo = new System.Windows.Forms.CheckBox();
            this.lblDocumentacion = new System.Windows.Forms.Label();
            this.txtDocumentacion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.tsAcciones.Size = new System.Drawing.Size(390, 25);
            this.tsAcciones.TabIndex = 0;
            this.tsAcciones.Text = "toolStrip1";
            // 
            // gbViajesInter
            // 
            this.gbViajesInter.Controls.Add(this.txtDocumentacion);
            this.gbViajesInter.Controls.Add(this.lblDocumentacion);
            this.gbViajesInter.Controls.Add(this.chkServicioaBordo);
            this.gbViajesInter.Controls.Add(this.lblServicioaBordo);
            this.gbViajesInter.Controls.Add(this.txtEmpleado);
            this.gbViajesInter.Controls.Add(this.lblEmpleado);
            this.gbViajesInter.Controls.Add(this.txtAsientos);
            this.gbViajesInter.Controls.Add(this.lblAsientos);
            this.gbViajesInter.Controls.Add(this.txtFechaArribo);
            this.gbViajesInter.Controls.Add(this.lblFechaArribo);
            this.gbViajesInter.Controls.Add(this.txtFechaPartida);
            this.gbViajesInter.Controls.Add(this.lblFechaPartida);
            this.gbViajesInter.Controls.Add(this.txtTerminal);
            this.gbViajesInter.Controls.Add(this.lblTerminal);
            this.gbViajesInter.Controls.Add(this.txtCompania);
            this.gbViajesInter.Controls.Add(this.lblCompania);
            this.gbViajesInter.Controls.Add(this.txtNumero);
            this.gbViajesInter.Controls.Add(this.lblNumero);
            this.gbViajesInter.Controls.Add(this.label1);
            this.gbViajesInter.Location = new System.Drawing.Point(13, 38);
            this.gbViajesInter.Name = "gbViajesInter";
            this.gbViajesInter.Size = new System.Drawing.Size(351, 295);
            this.gbViajesInter.TabIndex = 1;
            this.gbViajesInter.TabStop = false;
            this.gbViajesInter.Text = "Viajes Internacionales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
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
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(202, 24);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 0;
            // 
            // lblCompania
            // 
            this.lblCompania.AutoSize = true;
            this.lblCompania.Location = new System.Drawing.Point(7, 63);
            this.lblCompania.Name = "lblCompania";
            this.lblCompania.Size = new System.Drawing.Size(94, 13);
            this.lblCompania.TabIndex = 3;
            this.lblCompania.Text = "Nombre Compañia";
            // 
            // txtCompania
            // 
            this.txtCompania.Location = new System.Drawing.Point(202, 56);
            this.txtCompania.Name = "txtCompania";
            this.txtCompania.Size = new System.Drawing.Size(100, 20);
            this.txtCompania.TabIndex = 1;
            // 
            // lblTerminal
            // 
            this.lblTerminal.AutoSize = true;
            this.lblTerminal.Location = new System.Drawing.Point(6, 89);
            this.lblTerminal.Name = "lblTerminal";
            this.lblTerminal.Size = new System.Drawing.Size(83, 13);
            this.lblTerminal.TabIndex = 5;
            this.lblTerminal.Text = "Código Terminal";
            // 
            // txtTerminal
            // 
            this.txtTerminal.Location = new System.Drawing.Point(202, 82);
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.Size = new System.Drawing.Size(100, 20);
            this.txtTerminal.TabIndex = 2;
            // 
            // lblFechaPartida
            // 
            this.lblFechaPartida.AutoSize = true;
            this.lblFechaPartida.Location = new System.Drawing.Point(7, 116);
            this.lblFechaPartida.Name = "lblFechaPartida";
            this.lblFechaPartida.Size = new System.Drawing.Size(119, 13);
            this.lblFechaPartida.TabIndex = 7;
            this.lblFechaPartida.Text = "Fecha y hora de partida";
            // 
            // txtFechaPartida
            // 
            this.txtFechaPartida.Location = new System.Drawing.Point(202, 109);
            this.txtFechaPartida.Name = "txtFechaPartida";
            this.txtFechaPartida.Size = new System.Drawing.Size(100, 20);
            this.txtFechaPartida.TabIndex = 3;
            // 
            // lblFechaArribo
            // 
            this.lblFechaArribo.AutoSize = true;
            this.lblFechaArribo.Location = new System.Drawing.Point(6, 139);
            this.lblFechaArribo.Name = "lblFechaArribo";
            this.lblFechaArribo.Size = new System.Drawing.Size(113, 13);
            this.lblFechaArribo.TabIndex = 9;
            this.lblFechaArribo.Text = "Fecha y hora de arribo";
            // 
            // txtFechaArribo
            // 
            this.txtFechaArribo.Location = new System.Drawing.Point(202, 132);
            this.txtFechaArribo.Name = "txtFechaArribo";
            this.txtFechaArribo.Size = new System.Drawing.Size(100, 20);
            this.txtFechaArribo.TabIndex = 4;
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
            // txtAsientos
            // 
            this.txtAsientos.Location = new System.Drawing.Point(202, 161);
            this.txtAsientos.Name = "txtAsientos";
            this.txtAsientos.Size = new System.Drawing.Size(100, 20);
            this.txtAsientos.TabIndex = 5;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(7, 199);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(105, 13);
            this.lblEmpleado.TabIndex = 13;
            this.lblEmpleado.Text = "Cédula de Empleado";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(202, 191);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtEmpleado.TabIndex = 6;
            // 
            // lblServicioaBordo
            // 
            this.lblServicioaBordo.AutoSize = true;
            this.lblServicioaBordo.Location = new System.Drawing.Point(7, 231);
            this.lblServicioaBordo.Name = "lblServicioaBordo";
            this.lblServicioaBordo.Size = new System.Drawing.Size(0, 13);
            this.lblServicioaBordo.TabIndex = 15;
            // 
            // chkServicioaBordo
            // 
            this.chkServicioaBordo.AutoSize = true;
            this.chkServicioaBordo.Location = new System.Drawing.Point(6, 227);
            this.chkServicioaBordo.Name = "chkServicioaBordo";
            this.chkServicioaBordo.Size = new System.Drawing.Size(104, 17);
            this.chkServicioaBordo.TabIndex = 16;
            this.chkServicioaBordo.Text = "Servicio a Bordo";
            this.chkServicioaBordo.UseVisualStyleBackColor = true;
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
            // txtDocumentacion
            // 
            this.txtDocumentacion.Location = new System.Drawing.Point(202, 254);
            this.txtDocumentacion.Name = "txtDocumentacion";
            this.txtDocumentacion.Size = new System.Drawing.Size(100, 20);
            this.txtDocumentacion.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar.Image = global::Administracion.Properties.Resources.nuevo;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(23, 22);
            this.btnAgregar.Text = "Nuevo";
            // 
            // btnModificar
            // 
            this.btnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificar.Image = global::Administracion.Properties.Resources.modificar;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(23, 22);
            this.btnModificar.Text = "Modificar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = global::Administracion.Properties.Resources.eliminar;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.Text = "Eliminar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLimpiar.Image = global::Administracion.Properties.Resources.cancelar;
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(23, 22);
            this.btnLimpiar.Text = "Limpiar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ABMViajesInternacionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 345);
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
        private System.Windows.Forms.TextBox txtCompania;
        private System.Windows.Forms.Label lblCompania;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtTerminal;
        private System.Windows.Forms.Label lblTerminal;
        private System.Windows.Forms.TextBox txtFechaPartida;
        private System.Windows.Forms.Label lblFechaPartida;
        private System.Windows.Forms.CheckBox chkServicioaBordo;
        private System.Windows.Forms.Label lblServicioaBordo;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TextBox txtAsientos;
        private System.Windows.Forms.Label lblAsientos;
        private System.Windows.Forms.TextBox txtFechaArribo;
        private System.Windows.Forms.Label lblFechaArribo;
        private System.Windows.Forms.TextBox txtDocumentacion;
        private System.Windows.Forms.Label lblDocumentacion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}