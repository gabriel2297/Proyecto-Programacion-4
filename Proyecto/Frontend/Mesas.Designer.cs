namespace Frontend
{
    partial class Mesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mesas));
            this.mesasLbl = new System.Windows.Forms.Label();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.tablaMesas = new System.Windows.Forms.DataGridView();
            this.mESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mESABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablaMesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESABindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mesasLbl
            // 
            this.mesasLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mesasLbl.AutoSize = true;
            this.mesasLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesasLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mesasLbl.Location = new System.Drawing.Point(350, 36);
            this.mesasLbl.Name = "mesasLbl";
            this.mesasLbl.Size = new System.Drawing.Size(88, 30);
            this.mesasLbl.TabIndex = 4;
            this.mesasLbl.Text = "Mesas";
            this.mesasLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.agregarBtn.TabIndex = 5;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = false;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // tablaMesas
            // 
            this.tablaMesas.AllowUserToAddRows = false;
            this.tablaMesas.AllowUserToDeleteRows = false;
            this.tablaMesas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaMesas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaMesas.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.tablaMesas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaMesas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.tablaMesas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tablaMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMesas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaMesas.Location = new System.Drawing.Point(50, 85);
            this.tablaMesas.Name = "tablaMesas";
            this.tablaMesas.ReadOnly = true;
            this.tablaMesas.RowTemplate.Height = 24;
            this.tablaMesas.Size = new System.Drawing.Size(699, 245);
            this.tablaMesas.TabIndex = 6;
            this.tablaMesas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaMesas_CellDoubleClick);
            // 
            // mESABindingSource
            // 
            this.mESABindingSource.DataSource = typeof(Backend.Model.MESA);
            // 
            // mESABindingSource1
            // 
            this.mESABindingSource1.DataSource = typeof(Backend.Model.MESA);
            // 
            // Mesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablaMesas);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.mesasLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mesas";
            this.Text = "Mesas";
            this.Load += new System.EventHandler(this.Mesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaMesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESABindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mesasLbl;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.BindingSource mESABindingSource;
        private System.Windows.Forms.DataGridView tablaMesas;
        private System.Windows.Forms.BindingSource mESABindingSource1;
    }
}