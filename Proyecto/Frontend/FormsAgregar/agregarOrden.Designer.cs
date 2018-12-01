namespace Frontend.FormsAgregar
{
    partial class agregarOrden
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
            this.ordenesLbl = new System.Windows.Forms.Label();
            this.terminarBtn = new System.Windows.Forms.Button();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.table_buscar_producto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_buscar_producto)).BeginInit();
            this.SuspendLayout();
            // 
            // ordenesLbl
            // 
            this.ordenesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ordenesLbl.AutoSize = true;
            this.ordenesLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenesLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ordenesLbl.Location = new System.Drawing.Point(605, 34);
            this.ordenesLbl.Name = "ordenesLbl";
            this.ordenesLbl.Size = new System.Drawing.Size(185, 30);
            this.ordenesLbl.TabIndex = 5;
            this.ordenesLbl.Text = "Agregar orden";
            this.ordenesLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // terminarBtn
            // 
            this.terminarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.terminarBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.terminarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.terminarBtn.FlatAppearance.BorderSize = 0;
            this.terminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.terminarBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminarBtn.ForeColor = System.Drawing.Color.White;
            this.terminarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.terminarBtn.Location = new System.Drawing.Point(1115, 530);
            this.terminarBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.terminarBtn.Name = "terminarBtn";
            this.terminarBtn.Size = new System.Drawing.Size(227, 57);
            this.terminarBtn.TabIndex = 6;
            this.terminarBtn.Text = "Terminar orden";
            this.terminarBtn.UseVisualStyleBackColor = false;
            // 
            // agregarBtn
            // 
            this.agregarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.agregarBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.agregarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarBtn.FlatAppearance.BorderSize = 0;
            this.agregarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarBtn.ForeColor = System.Drawing.Color.White;
            this.agregarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarBtn.Location = new System.Drawing.Point(57, 367);
            this.agregarBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(233, 57);
            this.agregarBtn.TabIndex = 7;
            this.agregarBtn.Text = "Agregar productos";
            this.agregarBtn.UseVisualStyleBackColor = false;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.cancelarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarBtn.FlatAppearance.BorderSize = 0;
            this.cancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.ForeColor = System.Drawing.Color.White;
            this.cancelarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarBtn.Location = new System.Drawing.Point(15, 530);
            this.cancelarBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(227, 57);
            this.cancelarBtn.TabIndex = 8;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // tablaProductos
            // 
            this.tablaProductos.AllowUserToAddRows = false;
            this.tablaProductos.AllowUserToDeleteRows = false;
            this.tablaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaProductos.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.tablaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nombre,
            this.Precio,
            this.Descripcion});
            this.tablaProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaProductos.Location = new System.Drawing.Point(752, 123);
            this.tablaProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.ReadOnly = true;
            this.tablaProductos.RowTemplate.Height = 24;
            this.tablaProductos.Size = new System.Drawing.Size(589, 331);
            this.tablaProductos.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar Productos:";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(57, 123);
            this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(589, 22);
            this.txtBuscarProducto.TabIndex = 11;
            this.txtBuscarProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProducto_KeyUp);
            // 
            // table_buscar_producto
            // 
            this.table_buscar_producto.AllowUserToAddRows = false;
            this.table_buscar_producto.AllowUserToDeleteRows = false;
            this.table_buscar_producto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_buscar_producto.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.table_buscar_producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_buscar_producto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.table_buscar_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_buscar_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.table_buscar_producto.Location = new System.Drawing.Point(57, 165);
            this.table_buscar_producto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table_buscar_producto.Name = "table_buscar_producto";
            this.table_buscar_producto.ReadOnly = true;
            this.table_buscar_producto.RowTemplate.Height = 24;
            this.table_buscar_producto.Size = new System.Drawing.Size(591, 186);
            this.table_buscar_producto.TabIndex = 12;
            this.table_buscar_producto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_buscar_producto_Click);
            // 
            // agregarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1376, 601);
            this.Controls.Add(this.table_buscar_producto);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaProductos);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.terminarBtn);
            this.Controls.Add(this.ordenesLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "agregarOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_buscar_producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ordenesLbl;
        private System.Windows.Forms.Button terminarBtn;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        public System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        public System.Windows.Forms.DataGridView table_buscar_producto;
    }
}