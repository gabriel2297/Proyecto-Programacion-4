namespace Frontend
{
    partial class Facturas
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
            this.facturasLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDFACTURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDORDENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALCANCELADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRECAJERODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // facturasLbl
            // 
            this.facturasLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.facturasLbl.AutoSize = true;
            this.facturasLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturasLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.facturasLbl.Location = new System.Drawing.Point(350, 36);
            this.facturasLbl.Name = "facturasLbl";
            this.facturasLbl.Size = new System.Drawing.Size(113, 30);
            this.facturasLbl.TabIndex = 3;
            this.facturasLbl.Text = "Facturas";
            this.facturasLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDFACTURADataGridViewTextBoxColumn,
            this.iDORDENDataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn,
            this.tOTALCANCELADODataGridViewTextBoxColumn,
            this.nOMBRECAJERODataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.fACTURABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 224);
            this.dataGridView1.TabIndex = 4;
            // 
            // fACTURABindingSource
            // 
            this.fACTURABindingSource.DataSource = typeof(Backend.Model.FACTURA);
            // 
            // iDFACTURADataGridViewTextBoxColumn
            // 
            this.iDFACTURADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDFACTURADataGridViewTextBoxColumn.DataPropertyName = "ID_FACTURA";
            this.iDFACTURADataGridViewTextBoxColumn.HeaderText = "Número de factura";
            this.iDFACTURADataGridViewTextBoxColumn.Name = "iDFACTURADataGridViewTextBoxColumn";
            // 
            // iDORDENDataGridViewTextBoxColumn
            // 
            this.iDORDENDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDORDENDataGridViewTextBoxColumn.DataPropertyName = "ID_ORDEN";
            this.iDORDENDataGridViewTextBoxColumn.HeaderText = "Número de órden";
            this.iDORDENDataGridViewTextBoxColumn.Name = "iDORDENDataGridViewTextBoxColumn";
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            this.fECHADataGridViewTextBoxColumn.HeaderText = "Fecha de compra";
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            // 
            // tOTALCANCELADODataGridViewTextBoxColumn
            // 
            this.tOTALCANCELADODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tOTALCANCELADODataGridViewTextBoxColumn.DataPropertyName = "TOTAL_CANCELADO";
            this.tOTALCANCELADODataGridViewTextBoxColumn.HeaderText = "Total cancelado";
            this.tOTALCANCELADODataGridViewTextBoxColumn.Name = "tOTALCANCELADODataGridViewTextBoxColumn";
            // 
            // nOMBRECAJERODataGridViewTextBoxColumn
            // 
            this.nOMBRECAJERODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMBRECAJERODataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_CAJERO";
            this.nOMBRECAJERODataGridViewTextBoxColumn.HeaderText = "Cajero";
            this.nOMBRECAJERODataGridViewTextBoxColumn.Name = "nOMBRECAJERODataGridViewTextBoxColumn";
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.facturasLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label facturasLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fACTURABindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFACTURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDORDENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALCANCELADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRECAJERODataGridViewTextBoxColumn;
    }
}