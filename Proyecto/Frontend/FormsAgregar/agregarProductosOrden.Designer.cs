namespace Frontend.FormsAgregar
{
    partial class agregarProductosOrden
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
            this.ordenesLbl = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOrdenes = new System.Windows.Forms.ComboBox();
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.pRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIOPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ordenesLbl
            // 
            this.ordenesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ordenesLbl.AutoSize = true;
            this.ordenesLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenesLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ordenesLbl.Location = new System.Drawing.Point(238, 26);
            this.ordenesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ordenesLbl.Name = "ordenesLbl";
            this.ordenesLbl.Size = new System.Drawing.Size(286, 22);
            this.ordenesLbl.TabIndex = 6;
            this.ordenesLbl.Text = "Agregar productos a la orden";
            this.ordenesLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cancelarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarBtn.FlatAppearance.BorderSize = 0;
            this.cancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.ForeColor = System.Drawing.Color.White;
            this.cancelarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarBtn.Location = new System.Drawing.Point(476, 394);
            this.cancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(103, 46);
            this.cancelarBtn.TabIndex = 12;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
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
            this.agregarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarBtn.Location = new System.Drawing.Point(592, 394);
            this.agregarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(112, 46);
            this.agregarBtn.TabIndex = 11;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = false;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // nombreLbl
            // 
            this.nombreLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLbl.ForeColor = System.Drawing.Color.White;
            this.nombreLbl.Location = new System.Drawing.Point(11, 120);
            this.nombreLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(110, 17);
            this.nombreLbl.TabIndex = 15;
            this.nombreLbl.Text = "Orden a agregar:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Producto a agregar:";
            // 
            // cmbOrdenes
            // 
            this.cmbOrdenes.FormattingEnabled = true;
            this.cmbOrdenes.Location = new System.Drawing.Point(168, 120);
            this.cmbOrdenes.Name = "cmbOrdenes";
            this.cmbOrdenes.Size = new System.Drawing.Size(121, 21);
            this.cmbOrdenes.TabIndex = 19;
            // 
            // tablaProductos
            // 
            this.tablaProductos.AllowUserToAddRows = false;
            this.tablaProductos.AllowUserToDeleteRows = false;
            this.tablaProductos.AllowUserToOrderColumns = true;
            this.tablaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaProductos.AutoGenerateColumns = false;
            this.tablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaProductos.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.tablaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaProductos.ColumnHeadersHeight = 18;
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPRODUCTODataGridViewTextBoxColumn,
            this.nOMBREPRODUCTODataGridViewTextBoxColumn,
            this.pRECIOPRODUCTODataGridViewTextBoxColumn});
            this.tablaProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaProductos.DataSource = this.pRODUCTOBindingSource;
            this.tablaProductos.EnableHeadersVisualStyles = false;
            this.tablaProductos.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.tablaProductos.Location = new System.Drawing.Point(152, 181);
            this.tablaProductos.Margin = new System.Windows.Forms.Padding(2);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.ReadOnly = true;
            this.tablaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tablaProductos.RowTemplate.Height = 24;
            this.tablaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaProductos.Size = new System.Drawing.Size(549, 169);
            this.tablaProductos.TabIndex = 6;
            this.tablaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPorductos_Click);
            // 
            // pRODUCTOBindingSource
            // 
            this.pRODUCTOBindingSource.DataSource = typeof(Backend.Model.PRODUCTO);
            // 
            // iDPRODUCTODataGridViewTextBoxColumn
            // 
            this.iDPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUCTO";
            this.iDPRODUCTODataGridViewTextBoxColumn.HeaderText = "ID_PRODUCTO";
            this.iDPRODUCTODataGridViewTextBoxColumn.Name = "iDPRODUCTODataGridViewTextBoxColumn";
            this.iDPRODUCTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREPRODUCTODataGridViewTextBoxColumn
            // 
            this.nOMBREPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_PRODUCTO";
            this.nOMBREPRODUCTODataGridViewTextBoxColumn.HeaderText = "NOMBRE_PRODUCTO";
            this.nOMBREPRODUCTODataGridViewTextBoxColumn.Name = "nOMBREPRODUCTODataGridViewTextBoxColumn";
            this.nOMBREPRODUCTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRECIOPRODUCTODataGridViewTextBoxColumn
            // 
            this.pRECIOPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "PRECIO_PRODUCTO";
            this.pRECIOPRODUCTODataGridViewTextBoxColumn.HeaderText = "PRECIO_PRODUCTO";
            this.pRECIOPRODUCTODataGridViewTextBoxColumn.Name = "pRECIOPRODUCTODataGridViewTextBoxColumn";
            this.pRECIOPRODUCTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agregarProductosOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.cmbOrdenes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tablaProductos);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.ordenesLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "agregarProductosOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "agregarProductosOrden";
            this.Load += new System.EventHandler(this.agregarProductosOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ordenesLbl;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Label nombreLbl;
        public System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOrdenes;
        private System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.BindingSource pRODUCTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIOPRODUCTODataGridViewTextBoxColumn;
    }
}