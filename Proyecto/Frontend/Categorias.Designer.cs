namespace Frontend
{
    partial class Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorias));
            this.categoriasLbl = new System.Windows.Forms.Label();
            this.tablaCategorias = new System.Windows.Forms.DataGridView();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.iDCATEGORIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRECATEGORIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriasLbl
            // 
            this.categoriasLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoriasLbl.AutoSize = true;
            this.categoriasLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriasLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoriasLbl.Location = new System.Drawing.Point(350, 36);
            this.categoriasLbl.Name = "categoriasLbl";
            this.categoriasLbl.Size = new System.Drawing.Size(144, 30);
            this.categoriasLbl.TabIndex = 4;
            this.categoriasLbl.Text = "Categorias";
            this.categoriasLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tablaCategorias
            // 
            this.tablaCategorias.AllowUserToAddRows = false;
            this.tablaCategorias.AllowUserToDeleteRows = false;
            this.tablaCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaCategorias.AutoGenerateColumns = false;
            this.tablaCategorias.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.tablaCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tablaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCATEGORIADataGridViewTextBoxColumn,
            this.nOMBRECATEGORIADataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn});
            this.tablaCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaCategorias.DataSource = this.cATEGORIABindingSource;
            this.tablaCategorias.Location = new System.Drawing.Point(51, 103);
            this.tablaCategorias.Name = "tablaCategorias";
            this.tablaCategorias.ReadOnly = true;
            this.tablaCategorias.RowTemplate.Height = 24;
            this.tablaCategorias.Size = new System.Drawing.Size(699, 245);
            this.tablaCategorias.TabIndex = 5;
            this.tablaCategorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCategorias_CellDoubleClick);
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
            this.agregarBtn.Location = new System.Drawing.Point(555, 381);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(233, 57);
            this.agregarBtn.TabIndex = 6;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = false;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // iDCATEGORIADataGridViewTextBoxColumn
            // 
            this.iDCATEGORIADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDCATEGORIADataGridViewTextBoxColumn.DataPropertyName = "ID_CATEGORIA";
            this.iDCATEGORIADataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDCATEGORIADataGridViewTextBoxColumn.Name = "iDCATEGORIADataGridViewTextBoxColumn";
            this.iDCATEGORIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBRECATEGORIADataGridViewTextBoxColumn
            // 
            this.nOMBRECATEGORIADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMBRECATEGORIADataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_CATEGORIA";
            this.nOMBRECATEGORIADataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.nOMBRECATEGORIADataGridViewTextBoxColumn.Name = "nOMBRECATEGORIADataGridViewTextBoxColumn";
            this.nOMBRECATEGORIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            this.dESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cATEGORIABindingSource
            // 
            this.cATEGORIABindingSource.DataSource = typeof(Backend.Model.CATEGORIA);
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.tablaCategorias);
            this.Controls.Add(this.categoriasLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoriasLbl;
        private System.Windows.Forms.DataGridView tablaCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCATEGORIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRECATEGORIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cATEGORIABindingSource;
        private System.Windows.Forms.Button agregarBtn;
    }
}