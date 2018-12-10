namespace Frontend
{
    partial class Ordenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordenes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ordenesLbl = new System.Windows.Forms.Label();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.pROIVDataSet = new Frontend.PROIVDataSet();
            this.oRDENESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDENESTableAdapter = new Frontend.PROIVDataSetTableAdapters.ORDENESTableAdapter();
            this.oRDENESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TablaOrdenes = new System.Windows.Forms.DataGridView();
            this.iDORDENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREORDENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMESERODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pROIVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDENESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDENESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // ordenesLbl
            // 
            this.ordenesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ordenesLbl.AutoSize = true;
            this.ordenesLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenesLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ordenesLbl.Location = new System.Drawing.Point(262, 29);
            this.ordenesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ordenesLbl.Name = "ordenesLbl";
            this.ordenesLbl.Size = new System.Drawing.Size(89, 22);
            this.ordenesLbl.TabIndex = 4;
            this.ordenesLbl.Text = "Ordenes";
            this.ordenesLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // agregarBtn
            // 
            this.agregarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.agregarBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.agregarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarBtn.FlatAppearance.BorderSize = 0;
            this.agregarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarBtn.ForeColor = System.Drawing.Color.White;
            this.agregarBtn.Image = ((System.Drawing.Image)(resources.GetObject("agregarBtn.Image")));
            this.agregarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarBtn.Location = new System.Drawing.Point(416, 310);
            this.agregarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(175, 46);
            this.agregarBtn.TabIndex = 5;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = false;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // pROIVDataSet
            // 
            this.pROIVDataSet.DataSetName = "PROIVDataSet";
            this.pROIVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oRDENESBindingSource
            // 
            this.oRDENESBindingSource.DataMember = "ORDENES";
            this.oRDENESBindingSource.DataSource = this.pROIVDataSet;
            // 
            // oRDENESTableAdapter
            // 
            this.oRDENESTableAdapter.ClearBeforeFill = true;
            // 
            // oRDENESBindingSource1
            // 
            this.oRDENESBindingSource1.DataMember = "ORDENES";
            this.oRDENESBindingSource1.DataSource = this.pROIVDataSet;
            // 
            // fACTURABindingSource
            // 
            this.fACTURABindingSource.DataSource = typeof(Backend.Model.FACTURA);
            // 
            // TablaOrdenes
            // 
            this.TablaOrdenes.AllowUserToAddRows = false;
            this.TablaOrdenes.AllowUserToDeleteRows = false;
            this.TablaOrdenes.AllowUserToOrderColumns = true;
            this.TablaOrdenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaOrdenes.AutoGenerateColumns = false;
            this.TablaOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaOrdenes.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.TablaOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaOrdenes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaOrdenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaOrdenes.ColumnHeadersHeight = 35;
            this.TablaOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TablaOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDORDENDataGridViewTextBoxColumn,
            this.nOMBREORDENDataGridViewTextBoxColumn,
            this.iDMESERODataGridViewTextBoxColumn,
            this.iDMESADataGridViewTextBoxColumn});
            this.TablaOrdenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TablaOrdenes.DataSource = this.oRDENESBindingSource;
            this.TablaOrdenes.EnableHeadersVisualStyles = false;
            this.TablaOrdenes.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.TablaOrdenes.Location = new System.Drawing.Point(38, 69);
            this.TablaOrdenes.Margin = new System.Windows.Forms.Padding(2);
            this.TablaOrdenes.Name = "TablaOrdenes";
            this.TablaOrdenes.ReadOnly = true;
            this.TablaOrdenes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.TablaOrdenes.RowHeadersVisible = false;
            this.TablaOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaOrdenes.Size = new System.Drawing.Size(524, 199);
            this.TablaOrdenes.TabIndex = 6;
            this.TablaOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaOrdenes_CellContentClick);
            // 
            // iDORDENDataGridViewTextBoxColumn
            // 
            this.iDORDENDataGridViewTextBoxColumn.DataPropertyName = "ID_ORDEN";
            this.iDORDENDataGridViewTextBoxColumn.HeaderText = "ID_ORDEN";
            this.iDORDENDataGridViewTextBoxColumn.Name = "iDORDENDataGridViewTextBoxColumn";
            this.iDORDENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREORDENDataGridViewTextBoxColumn
            // 
            this.nOMBREORDENDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_ORDEN";
            this.nOMBREORDENDataGridViewTextBoxColumn.HeaderText = "NOMBRE_ORDEN";
            this.nOMBREORDENDataGridViewTextBoxColumn.Name = "nOMBREORDENDataGridViewTextBoxColumn";
            this.nOMBREORDENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDMESERODataGridViewTextBoxColumn
            // 
            this.iDMESERODataGridViewTextBoxColumn.DataPropertyName = "ID_MESERO";
            this.iDMESERODataGridViewTextBoxColumn.HeaderText = "ID_MESERO";
            this.iDMESERODataGridViewTextBoxColumn.Name = "iDMESERODataGridViewTextBoxColumn";
            this.iDMESERODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDMESADataGridViewTextBoxColumn
            // 
            this.iDMESADataGridViewTextBoxColumn.DataPropertyName = "ID_MESA";
            this.iDMESADataGridViewTextBoxColumn.HeaderText = "ID_MESA";
            this.iDMESADataGridViewTextBoxColumn.Name = "iDMESADataGridViewTextBoxColumn";
            this.iDMESADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.TablaOrdenes);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.ordenesLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ordenes";
            this.Text = "Ordenes";
            this.Load += new System.EventHandler(this.Ordenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pROIVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDENESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDENESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaOrdenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ordenesLbl;
        private System.Windows.Forms.Button agregarBtn;
        private PROIVDataSet pROIVDataSet;
        private System.Windows.Forms.BindingSource oRDENESBindingSource;
        private PROIVDataSetTableAdapters.ORDENESTableAdapter oRDENESTableAdapter;
        private System.Windows.Forms.BindingSource fACTURABindingSource;
        private System.Windows.Forms.BindingSource oRDENESBindingSource1;
        private System.Windows.Forms.DataGridView TablaOrdenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDORDENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREORDENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMESERODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMESADataGridViewTextBoxColumn;
    }
}