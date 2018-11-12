namespace Administracion
{
    partial class ABMEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.EPNCedula = new System.Windows.Forms.ErrorProvider(this.components);
            this.BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnDeshacer = new System.Windows.Forms.ToolStripButton();
            this.btnModificar1 = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar1 = new System.Windows.Forms.ToolStripButton();
            this.btnAgregar1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.EPNCedula)).BeginInit();
            this.BarraHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese Nombre Completo:";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(194, 170);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(209, 20);
            this.txtNombreCompleto.TabIndex = 3;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(194, 100);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(209, 20);
            this.txtContraseña.TabIndex = 4;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(194, 50);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(209, 20);
            this.txtCedula.TabIndex = 5;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(191, 219);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 13);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "lblError";
            // 
            // EPNCedula
            // 
            this.EPNCedula.ContainerControl = this;
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeshacer,
            this.btnModificar1,
            this.btnEliminar1,
            this.btnAgregar1});
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(482, 25);
            this.BarraHerramientas.TabIndex = 10;
            this.BarraHerramientas.Text = "toolStrip1";
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeshacer.Image = global::Administracion.Properties.Resources.cancelar;
            this.btnDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(23, 22);
            this.btnDeshacer.Text = "Deshacer";
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // btnModificar1
            // 
            this.btnModificar1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificar1.Image = global::Administracion.Properties.Resources.modificar;
            this.btnModificar1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar1.Name = "btnModificar1";
            this.btnModificar1.Size = new System.Drawing.Size(23, 22);
            this.btnModificar1.Text = "Modificar";
            this.btnModificar1.Click += new System.EventHandler(this.btnModificar1_Click);
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar1.Image = global::Administracion.Properties.Resources.eliminar;
            this.btnEliminar1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar1.Text = "Eliminar";
            this.btnEliminar1.Click += new System.EventHandler(this.btnEliminar1_Click);
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar1.Image = global::Administracion.Properties.Resources.nuevo;
            this.btnAgregar1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.Size = new System.Drawing.Size(23, 22);
            this.btnAgregar1.Text = "Nuevo";
            this.btnAgregar1.Click += new System.EventHandler(this.btnAgregar1_Click);
            // 
            // ABMEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 440);
            this.Controls.Add(this.BarraHerramientas);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ABMEmpleado";
            this.Text = "ABMEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.EPNCedula)).EndInit();
            this.BarraHerramientas.ResumeLayout(false);
            this.BarraHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ErrorProvider EPNCedula;
        private System.Windows.Forms.ToolStrip BarraHerramientas;
        private System.Windows.Forms.ToolStripButton btnDeshacer;
        private System.Windows.Forms.ToolStripButton btnModificar1;
        private System.Windows.Forms.ToolStripButton btnEliminar1;
        private System.Windows.Forms.ToolStripButton btnAgregar1;
    }
}