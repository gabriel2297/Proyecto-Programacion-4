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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.facturasLbl = new System.Windows.Forms.Label();
            this.tablaFacturas = new System.Windows.Forms.DataGridView();
            this.iDFACTURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDORDENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALCANCELADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRECAJERODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablaFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // facturasLbl
            // 
            this.facturasLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.facturasLbl.AutoSize = true;
            this.facturasLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturasLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.facturasLbl.Location = new System.Drawing.Point(283, 29);
            this.facturasLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.facturasLbl.Name = "facturasLbl";
            this.facturasLbl.Size = new System.Drawing.Size(89, 22);
            this.facturasLbl.TabIndex = 3;
            this.facturasLbl.Text = "Facturas";
            this.facturasLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tablaFacturas
            // 
            this.tablaFacturas.AllowUserToAddRows = false;
            this.tablaFacturas.AllowUserToDeleteRows = false;
            this.tablaFacturas.AllowUserToOrderColumns = true;
            this.tablaFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaFacturas.AutoGenerateColumns = false;
            this.tablaFacturas.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.tablaFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaFacturas.ColumnHeadersHeight = 35;
            this.tablaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDFACTURADataGridViewTextBoxColumn,
            this.iDORDENDataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn,
            this.tOTALCANCELADODataGridViewTextBoxColumn,
            this.nOMBRECAJERODataGridViewTextBoxColumn});
            this.tablaFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaFacturas.DataSource = this.fACTURABindingSource;
            this.tablaFacturas.EnableHeadersVisualStyles = false;
            this.tablaFacturas.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.tablaFacturas.Location = new System.Drawing.Point(38, 69);
            this.tablaFacturas.Margin = new System.Windows.Forms.Padding(2);
            this.tablaFacturas.Name = "tablaFacturas";
            this.tablaFacturas.ReadOnly = true;
            this.tablaFacturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tablaFacturas.RowHeadersVisible = false;
            this.tablaFacturas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tablaFacturas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.tablaFacturas.RowTemplate.Height = 25;
            this.tablaFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaFacturas.Size = new System.Drawing.Size(567, 199);
            this.tablaFacturas.TabIndex = 4;
            // 
            // iDFACTURADataGridViewTextBoxColumn
            // 
            this.iDFACTURADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDFACTURADataGridViewTextBoxColumn.DataPropertyName = "ID_FACTURA";
            this.iDFACTURADataGridViewTextBoxColumn.HeaderText = "Número de factura";
            this.iDFACTURADataGridViewTextBoxColumn.Name = "iDFACTURADataGridViewTextBoxColumn";
            this.iDFACTURADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDORDENDataGridViewTextBoxColumn
            // 
            this.iDORDENDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDORDENDataGridViewTextBoxColumn.DataPropertyName = "ID_ORDEN";
            this.iDORDENDataGridViewTextBoxColumn.HeaderText = "Número de órden";
            this.iDORDENDataGridViewTextBoxColumn.Name = "iDORDENDataGridViewTextBoxColumn";
            this.iDORDENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            this.fECHADataGridViewTextBoxColumn.HeaderText = "Fecha de compra";
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            this.fECHADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOTALCANCELADODataGridViewTextBoxColumn
            // 
            this.tOTALCANCELADODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tOTALCANCELADODataGridViewTextBoxColumn.DataPropertyName = "TOTAL_CANCELADO";
            this.tOTALCANCELADODataGridViewTextBoxColumn.HeaderText = "Total cancelado";
            this.tOTALCANCELADODataGridViewTextBoxColumn.Name = "tOTALCANCELADODataGridViewTextBoxColumn";
            this.tOTALCANCELADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBRECAJERODataGridViewTextBoxColumn
            // 
            this.nOMBRECAJERODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMBRECAJERODataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_CAJERO";
            this.nOMBRECAJERODataGridViewTextBoxColumn.HeaderText = "Cajero";
            this.nOMBRECAJERODataGridViewTextBoxColumn.Name = "nOMBRECAJERODataGridViewTextBoxColumn";
            this.nOMBRECAJERODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fACTURABindingSource
            // 
            this.fACTURABindingSource.DataSource = typeof(Backend.Model.FACTURA);
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(643, 366);
            this.Controls.Add(this.tablaFacturas);
            this.Controls.Add(this.facturasLbl);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Facturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label facturasLbl;
        private System.Windows.Forms.DataGridView tablaFacturas;
        private System.Windows.Forms.BindingSource fACTURABindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFACTURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDORDENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALCANCELADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRECAJERODataGridViewTextBoxColumn;
    }
}