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
            this.lblError = new System.Windows.Forms.Label();
            this.EPNNumViaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtHoraPartida = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHoraArribo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPNNumViaje)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(841, 25);
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
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese Numero de Viaje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Compañia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Terminal de Arribo (Destino):";
            // 
            // datePartida
            // 
            this.datePartida.Location = new System.Drawing.Point(356, 62);
            this.datePartida.Name = "datePartida";
            this.datePartida.Size = new System.Drawing.Size(200, 20);
            this.datePartida.TabIndex = 4;
            // 
            // dateArribo
            // 
            this.dateArribo.Location = new System.Drawing.Point(621, 62);
            this.dateArribo.Name = "dateArribo";
            this.dateArribo.Size = new System.Drawing.Size(200, 20);
            this.dateArribo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Partida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(674, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de Arribo";
            // 
            // cbCompañia
            // 
            this.cbCompañia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompañia.FormattingEnabled = true;
            this.cbCompañia.Location = new System.Drawing.Point(175, 128);
            this.cbCompañia.Name = "cbCompañia";
            this.cbCompañia.Size = new System.Drawing.Size(121, 21);
            this.cbCompañia.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Paradas Intermedias:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cantidad de Asientos:";
            // 
            // cbParadas
            // 
            this.cbParadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbParadas.Location = new System.Drawing.Point(175, 155);
            this.cbParadas.Name = "cbParadas";
            this.cbParadas.Size = new System.Drawing.Size(121, 21);
            this.cbParadas.TabIndex = 11;
            // 
            // cbTerminal
            // 
            this.cbTerminal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTerminal.FormattingEnabled = true;
            this.cbTerminal.Location = new System.Drawing.Point(175, 97);
            this.cbTerminal.Name = "cbTerminal";
            this.cbTerminal.Size = new System.Drawing.Size(121, 21);
            this.cbTerminal.TabIndex = 12;
            // 
            // txtAsientos
            // 
            this.txtAsientos.Location = new System.Drawing.Point(175, 208);
            this.txtAsientos.Name = "txtAsientos";
            this.txtAsientos.Size = new System.Drawing.Size(121, 20);
            this.txtAsientos.TabIndex = 13;
            // 
            // txtNumViaje
            // 
            this.txtNumViaje.Location = new System.Drawing.Point(175, 62);
            this.txtNumViaje.Name = "txtNumViaje";
            this.txtNumViaje.Size = new System.Drawing.Size(121, 20);
            this.txtNumViaje.TabIndex = 14;
            this.txtNumViaje.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumViajes_Validating);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(391, 264);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 13);
            this.lblError.TabIndex = 15;
            this.lblError.Text = "lblError";
            // 
            // EPNNumViaje
            // 
            this.EPNNumViaje.ContainerControl = this;
            // 
            // txtHoraPartida
            // 
            this.txtHoraPartida.Location = new System.Drawing.Point(356, 136);
            this.txtHoraPartida.Name = "txtHoraPartida";
            this.txtHoraPartida.Size = new System.Drawing.Size(200, 20);
            this.txtHoraPartida.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Hora de Partida";
            // 
            // txtHoraArribo
            // 
            this.txtHoraArribo.Location = new System.Drawing.Point(621, 136);
            this.txtHoraArribo.Name = "txtHoraArribo";
            this.txtHoraArribo.Size = new System.Drawing.Size(200, 20);
            this.txtHoraArribo.TabIndex = 18;
            
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(618, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Hora de Arribo";
            // 
            // ABMViajesNacionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 330);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHoraArribo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHoraPartida);
            this.Controls.Add(this.lblError);
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
            this.Name = "ABMViajesNacionales";
            this.Text = "ABMViajesNacionales";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPNNumViaje)).EndInit();
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
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ErrorProvider EPNNumViaje;
        private System.Windows.Forms.TextBox txtHoraPartida;
        private System.Windows.Forms.TextBox txtHoraArribo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}