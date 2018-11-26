
﻿namespace Administracion
 {
     partial class ABMCompanias
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
             this.gbCompanias = new System.Windows.Forms.GroupBox();
             this.txtTelefono = new System.Windows.Forms.TextBox();
             this.lblTelefono = new System.Windows.Forms.Label();
             this.txtDireccion = new System.Windows.Forms.TextBox();
             this.lblDireccion = new System.Windows.Forms.Label();
             this.txtNombre = new System.Windows.Forms.TextBox();
             this.lblNombre = new System.Windows.Forms.Label();
             this.statusStrip1 = new System.Windows.Forms.StatusStrip();
             this.lblError = new System.Windows.Forms.ToolStripStatusLabel();
             this.tsAcciones.SuspendLayout();
             this.gbCompanias.SuspendLayout();
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
             this.tsAcciones.Size = new System.Drawing.Size(471, 25);
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
             // gbCompanias
             // 
             this.gbCompanias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                         | System.Windows.Forms.AnchorStyles.Left)
                         | System.Windows.Forms.AnchorStyles.Right)));
             this.gbCompanias.Controls.Add(this.txtTelefono);
             this.gbCompanias.Controls.Add(this.lblTelefono);
             this.gbCompanias.Controls.Add(this.txtDireccion);
             this.gbCompanias.Controls.Add(this.lblDireccion);
             this.gbCompanias.Controls.Add(this.txtNombre);
             this.gbCompanias.Controls.Add(this.lblNombre);
             this.gbCompanias.Location = new System.Drawing.Point(13, 29);
             this.gbCompanias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
             this.gbCompanias.Name = "gbCompanias";
             this.gbCompanias.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
             this.gbCompanias.Size = new System.Drawing.Size(445, 238);
             this.gbCompanias.TabIndex = 1;
             this.gbCompanias.TabStop = false;
             this.gbCompanias.Text = "Compañias";
             // 
             // txtTelefono
             // 
             this.txtTelefono.Location = new System.Drawing.Point(188, 103);
             this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
             this.txtTelefono.Name = "txtTelefono";
             this.txtTelefono.Size = new System.Drawing.Size(132, 22);
             this.txtTelefono.TabIndex = 2;
             // 
             // lblTelefono
             // 
             this.lblTelefono.AutoSize = true;
             this.lblTelefono.Location = new System.Drawing.Point(9, 113);
             this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
             this.lblTelefono.Name = "lblTelefono";
             this.lblTelefono.Size = new System.Drawing.Size(64, 17);
             this.lblTelefono.TabIndex = 4;
             this.lblTelefono.Text = "Teléfono";
             // 
             // txtDireccion
             // 
             this.txtDireccion.Location = new System.Drawing.Point(188, 66);
             this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
             this.txtDireccion.Name = "txtDireccion";
             this.txtDireccion.Size = new System.Drawing.Size(132, 22);
             this.txtDireccion.TabIndex = 1;
             // 
             // lblDireccion
             // 
             this.lblDireccion.AutoSize = true;
             this.lblDireccion.Location = new System.Drawing.Point(9, 76);
             this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
             this.lblDireccion.Name = "lblDireccion";
             this.lblDireccion.Size = new System.Drawing.Size(67, 17);
             this.lblDireccion.TabIndex = 2;
             this.lblDireccion.Text = "Dirección";
             // 
             // txtNombre
             // 
             this.txtNombre.Location = new System.Drawing.Point(188, 26);
             this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
             this.txtNombre.Name = "txtNombre";
             this.txtNombre.Size = new System.Drawing.Size(132, 22);
             this.txtNombre.TabIndex = 0;
             this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
             this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
             // 
             // lblNombre
             // 
             this.lblNombre.AutoSize = true;
             this.lblNombre.Location = new System.Drawing.Point(9, 36);
             this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
             this.lblNombre.Name = "lblNombre";
             this.lblNombre.Size = new System.Drawing.Size(58, 17);
             this.lblNombre.TabIndex = 0;
             this.lblNombre.Text = "Nombre";
             // 
             // statusStrip1
             // 
             this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblError});
             this.statusStrip1.Location = new System.Drawing.Point(0, 281);
             this.statusStrip1.Name = "statusStrip1";
             this.statusStrip1.Size = new System.Drawing.Size(471, 22);
             this.statusStrip1.TabIndex = 2;
             this.statusStrip1.Text = "statusStrip1";
             // 
             // lblError
             // 
             this.lblError.Name = "lblError";
             this.lblError.Size = new System.Drawing.Size(0, 17);
             // 
             // ABMCompanias
             // 
             this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
             this.ClientSize = new System.Drawing.Size(471, 303);
             this.Controls.Add(this.statusStrip1);
             this.Controls.Add(this.gbCompanias);
             this.Controls.Add(this.tsAcciones);
             this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
             this.Name = "ABMCompanias";
             this.Text = "Compañias";
             this.tsAcciones.ResumeLayout(false);
             this.tsAcciones.PerformLayout();
             this.gbCompanias.ResumeLayout(false);
             this.gbCompanias.PerformLayout();
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
         private System.Windows.Forms.GroupBox gbCompanias;
         private System.Windows.Forms.TextBox txtTelefono;
         private System.Windows.Forms.Label lblTelefono;
         private System.Windows.Forms.TextBox txtDireccion;
         private System.Windows.Forms.Label lblDireccion;
         private System.Windows.Forms.TextBox txtNombre;
         private System.Windows.Forms.Label lblNombre;
         private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
         private System.Windows.Forms.StatusStrip statusStrip1;
         private System.Windows.Forms.ToolStripStatusLabel lblError;
     }
 }