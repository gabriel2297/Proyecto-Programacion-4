namespace Frontend.Reportes
{
    partial class reporteFacturaciones
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnRegresarFacturas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(1, 67);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(798, 381);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnRegresarFacturas
            // 
            this.btnRegresarFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresarFacturas.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRegresarFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresarFacturas.FlatAppearance.BorderSize = 0;
            this.btnRegresarFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarFacturas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarFacturas.ForeColor = System.Drawing.Color.White;
            this.btnRegresarFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresarFacturas.Location = new System.Drawing.Point(11, 11);
            this.btnRegresarFacturas.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresarFacturas.Name = "btnRegresarFacturas";
            this.btnRegresarFacturas.Size = new System.Drawing.Size(170, 46);
            this.btnRegresarFacturas.TabIndex = 9;
            this.btnRegresarFacturas.Text = "Regresar";
            this.btnRegresarFacturas.UseVisualStyleBackColor = false;
            this.btnRegresarFacturas.Click += new System.EventHandler(this.btnRegresarFacturas_Click);
            // 
            // reporteFacturaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresarFacturas);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reporteFacturaciones";
            this.Text = "reporteFacturaciones";
            this.Load += new System.EventHandler(this.reporteFacturaciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnRegresarFacturas;
    }
}