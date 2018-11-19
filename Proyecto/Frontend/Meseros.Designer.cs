namespace Frontend
{
    partial class Meseros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meseros));
            this.agregarBtn = new System.Windows.Forms.Button();
            this.meserosLbl = new System.Windows.Forms.Label();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.iDMESERODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREMESERODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mESEROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESEROBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.agregarBtn.TabIndex = 1;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = false;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // meserosLbl
            // 
            this.meserosLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.meserosLbl.AutoSize = true;
            this.meserosLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meserosLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.meserosLbl.Location = new System.Drawing.Point(350, 36);
            this.meserosLbl.Name = "meserosLbl";
            this.meserosLbl.Size = new System.Drawing.Size(111, 30);
            this.meserosLbl.TabIndex = 2;
            this.meserosLbl.Text = "Meseros";
            this.meserosLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tablaDatos
            // 
            this.tablaDatos.AllowUserToAddRows = false;
            this.tablaDatos.AllowUserToDeleteRows = false;
            this.tablaDatos.AllowUserToOrderColumns = true;
            this.tablaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaDatos.AutoGenerateColumns = false;
            this.tablaDatos.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.tablaDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.tablaDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMESERODataGridViewTextBoxColumn,
            this.nOMBREMESERODataGridViewTextBoxColumn});
            this.tablaDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaDatos.DataSource = this.mESEROBindingSource;
            this.tablaDatos.Location = new System.Drawing.Point(50, 85);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.ReadOnly = true;
            this.tablaDatos.RowTemplate.Height = 24;
            this.tablaDatos.Size = new System.Drawing.Size(699, 245);
            this.tablaDatos.TabIndex = 4;
            this.tablaDatos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDatos_Click);
            // 
            // iDMESERODataGridViewTextBoxColumn
            // 
            this.iDMESERODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDMESERODataGridViewTextBoxColumn.DataPropertyName = "ID_MESERO";
            this.iDMESERODataGridViewTextBoxColumn.HeaderText = "Identificación del mesero";
            this.iDMESERODataGridViewTextBoxColumn.Name = "iDMESERODataGridViewTextBoxColumn";
            this.iDMESERODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREMESERODataGridViewTextBoxColumn
            // 
            this.nOMBREMESERODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMBREMESERODataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_MESERO";
            this.nOMBREMESERODataGridViewTextBoxColumn.HeaderText = "Nombre completo";
            this.nOMBREMESERODataGridViewTextBoxColumn.Name = "nOMBREMESERODataGridViewTextBoxColumn";
            this.nOMBREMESERODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mESEROBindingSource
            // 
            this.mESEROBindingSource.DataSource = typeof(Backend.Model.MESERO);
            // 
            // Meseros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.meserosLbl);
            this.Controls.Add(this.agregarBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Meseros";
            this.Load += new System.EventHandler(this.Meseros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESEROBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Label meserosLbl;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.BindingSource mESEROBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMESERODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREMESERODataGridViewTextBoxColumn;
    }
}