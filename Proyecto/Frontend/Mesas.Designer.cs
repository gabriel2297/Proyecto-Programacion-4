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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mesasLbl = new System.Windows.Forms.Label();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.tablaMesas = new System.Windows.Forms.DataGridView();
            this.mESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mESABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
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
            this.mesasLbl.Location = new System.Drawing.Point(262, 29);
            this.mesasLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mesasLbl.Name = "mesasLbl";
            this.mesasLbl.Size = new System.Drawing.Size(66, 22);
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
            this.agregarBtn.Location = new System.Drawing.Point(416, 310);
            this.agregarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(175, 46);
            this.agregarBtn.TabIndex = 5;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = false;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // tablaMesas
            // 
            this.tablaMesas.AllowUserToAddRows = false;
            this.tablaMesas.AllowUserToDeleteRows = false;
            this.tablaMesas.AllowUserToOrderColumns = true;
            this.tablaMesas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaMesas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaMesas.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.tablaMesas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaMesas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaMesas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaMesas.ColumnHeadersHeight = 35;
            this.tablaMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaMesas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaMesas.EnableHeadersVisualStyles = false;
            this.tablaMesas.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.tablaMesas.Location = new System.Drawing.Point(38, 69);
            this.tablaMesas.Margin = new System.Windows.Forms.Padding(2);
            this.tablaMesas.Name = "tablaMesas";
            this.tablaMesas.ReadOnly = true;
            this.tablaMesas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tablaMesas.RowHeadersVisible = false;
            this.tablaMesas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tablaMesas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.tablaMesas.RowTemplate.Height = 25;
            this.tablaMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaMesas.Size = new System.Drawing.Size(524, 199);
            this.tablaMesas.TabIndex = 6;
            this.tablaMesas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaMesas_CellClick);
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
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(227, 310);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(175, 46);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Mesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.tablaMesas);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.mesasLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnEliminar;
    }
}