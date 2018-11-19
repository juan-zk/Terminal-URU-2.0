namespace Administracion
{
    partial class Estadisticas
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
            this.gvViajes = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDeshacer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFechas = new System.Windows.Forms.Button();
            this.btnViajesAnuales = new System.Windows.Forms.Button();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvViajes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvViajes
            // 
            this.gvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvViajes.Location = new System.Drawing.Point(12, 161);
            this.gvViajes.Name = "gvViajes";
            this.gvViajes.Size = new System.Drawing.Size(743, 233);
            this.gvViajes.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeshacer,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(767, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeshacer.Image = global::Administracion.Properties.Resources.cancelar;
            this.btnDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(23, 22);
            this.btnDeshacer.Text = "Deshacer";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnFechas
            // 
            this.btnFechas.Location = new System.Drawing.Point(12, 48);
            this.btnFechas.Name = "btnFechas";
            this.btnFechas.Size = new System.Drawing.Size(124, 23);
            this.btnFechas.TabIndex = 2;
            this.btnFechas.Text = "Filtro por Fechas";
            this.btnFechas.UseVisualStyleBackColor = true;
            // 
            // btnViajesAnuales
            // 
            this.btnViajesAnuales.Location = new System.Drawing.Point(12, 78);
            this.btnViajesAnuales.Name = "btnViajesAnuales";
            this.btnViajesAnuales.Size = new System.Drawing.Size(124, 23);
            this.btnViajesAnuales.TabIndex = 3;
            this.btnViajesAnuales.Text = "Viajes por Año";
            this.btnViajesAnuales.UseVisualStyleBackColor = true;
            // 
            // cbPais
            // 
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(13, 108);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(121, 21);
            this.cbPais.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(396, 78);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 13);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "lblError";
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 406);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.btnViajesAnuales);
            this.Controls.Add(this.btnFechas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gvViajes);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.gvViajes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvViajes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDeshacer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnFechas;
        private System.Windows.Forms.Button btnViajesAnuales;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Label lblError;
    }
}