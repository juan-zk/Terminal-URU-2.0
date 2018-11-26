namespace Administracion
{
    partial class ABMViajesNacionales
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDesahcer = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datePartida = new System.Windows.Forms.DateTimePicker();
            this.dateArribo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCompañia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbParadas = new System.Windows.Forms.ComboBox();
            this.cbTerminal = new System.Windows.Forms.ComboBox();
            this.txtAsientos = new System.Windows.Forms.TextBox();
            this.txtNumViaje = new System.Windows.Forms.TextBox();
            this.EPNNumViaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtHoraPartida = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHoraArribo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblError = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPNNumViaje)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEliminar,
            this.btnModificar,
            this.toolStripSeparator1,
            this.btnDesahcer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1121, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar.Image = global::Administracion.Properties.Resources.nuevo;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(23, 22);
            this.btnAgregar.Text = "Agregar";
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
            // btnDesahcer
            // 
            this.btnDesahcer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDesahcer.Image = global::Administracion.Properties.Resources.cancelar;
            this.btnDesahcer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDesahcer.Name = "btnDesahcer";
            this.btnDesahcer.Size = new System.Drawing.Size(23, 22);
            this.btnDesahcer.Text = "Desahcer";
            this.btnDesahcer.Click += new System.EventHandler(this.btnDesahcer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese Numero de Viaje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Compañia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Terminal de Arribo (Destino):";
            // 
            // datePartida
            // 
            this.datePartida.Location = new System.Drawing.Point(475, 76);
            this.datePartida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datePartida.Name = "datePartida";
            this.datePartida.Size = new System.Drawing.Size(265, 22);
            this.datePartida.TabIndex = 4;
            // 
            // dateArribo
            // 
            this.dateArribo.Location = new System.Drawing.Point(828, 76);
            this.dateArribo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateArribo.Name = "dateArribo";
            this.dateArribo.Size = new System.Drawing.Size(265, 22);
            this.dateArribo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Partida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(899, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de Arribo";
            // 
            // cbCompañia
            // 
            this.cbCompañia.FormattingEnabled = true;
            this.cbCompañia.Location = new System.Drawing.Point(233, 158);
            this.cbCompañia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCompañia.Name = "cbCompañia";
            this.cbCompañia.Size = new System.Drawing.Size(160, 24);
            this.cbCompañia.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Paradas Intermedias:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cantidad de Asientos:";
            // 
            // cbParadas
            // 
            this.cbParadas.FormattingEnabled = true;
            this.cbParadas.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbParadas.Location = new System.Drawing.Point(233, 191);
            this.cbParadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbParadas.Name = "cbParadas";
            this.cbParadas.Size = new System.Drawing.Size(160, 24);
            this.cbParadas.TabIndex = 11;
            // 
            // cbTerminal
            // 
            this.cbTerminal.FormattingEnabled = true;
            this.cbTerminal.Location = new System.Drawing.Point(233, 126);
            this.cbTerminal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTerminal.Name = "cbTerminal";
            this.cbTerminal.Size = new System.Drawing.Size(160, 24);
            this.cbTerminal.TabIndex = 12;
            // 
            // txtAsientos
            // 
            this.txtAsientos.Location = new System.Drawing.Point(233, 256);
            this.txtAsientos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAsientos.Name = "txtAsientos";
            this.txtAsientos.Size = new System.Drawing.Size(160, 22);
            this.txtAsientos.TabIndex = 13;
            // 
            // txtNumViaje
            // 
            this.txtNumViaje.Location = new System.Drawing.Point(233, 76);
            this.txtNumViaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumViaje.Name = "txtNumViaje";
            this.txtNumViaje.Size = new System.Drawing.Size(160, 22);
            this.txtNumViaje.TabIndex = 14;
            this.txtNumViaje.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumViajes_Validating);
            // 
            // EPNNumViaje
            // 
            this.EPNNumViaje.ContainerControl = this;
            // 
            // txtHoraPartida
            // 
            this.txtHoraPartida.Location = new System.Drawing.Point(475, 167);
            this.txtHoraPartida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoraPartida.Name = "txtHoraPartida";
            this.txtHoraPartida.Size = new System.Drawing.Size(265, 22);
            this.txtHoraPartida.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Hora de Partida";
            // 
            // txtHoraArribo
            // 
            this.txtHoraArribo.Location = new System.Drawing.Point(828, 167);
            this.txtHoraArribo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoraArribo.Name = "txtHoraArribo";
            this.txtHoraArribo.Size = new System.Drawing.Size(265, 22);
            this.txtHoraArribo.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(824, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Hora de Arribo";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1121, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblError
            // 
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            // 
            // ABMViajesNacionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 406);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHoraArribo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHoraPartida);
            this.Controls.Add(this.txtNumViaje);
            this.Controls.Add(this.txtAsientos);
            this.Controls.Add(this.cbTerminal);
            this.Controls.Add(this.cbParadas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCompañia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateArribo);
            this.Controls.Add(this.datePartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ABMViajesNacionales";
            this.Text = "ABMViajesNacionales";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPNNumViaje)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnDesahcer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datePartida;
        private System.Windows.Forms.DateTimePicker dateArribo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCompañia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbParadas;
        private System.Windows.Forms.ComboBox cbTerminal;
        private System.Windows.Forms.TextBox txtAsientos;
        private System.Windows.Forms.TextBox txtNumViaje;
        private System.Windows.Forms.ErrorProvider EPNNumViaje;
        private System.Windows.Forms.TextBox txtHoraPartida;
        private System.Windows.Forms.TextBox txtHoraArribo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblError;
    }
}