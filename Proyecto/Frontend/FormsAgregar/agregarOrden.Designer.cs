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
            this.agregarBtn = new System.Windows.Forms.Button();
            this.terminarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // ordenesLbl
            // 
            this.ordenesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ordenesLbl.AutoSize = true;
            this.ordenesLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenesLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ordenesLbl.Location = new System.Drawing.Point(312, 36);
            this.ordenesLbl.Name = "ordenesLbl";
            this.ordenesLbl.Size = new System.Drawing.Size(185, 30);
            this.ordenesLbl.TabIndex = 5;
            this.ordenesLbl.Text = "Agregar orden";
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
            this.agregarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarBtn.Location = new System.Drawing.Point(599, 381);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.agregarBtn.Size = new System.Drawing.Size(189, 57);
            this.agregarBtn.TabIndex = 6;
            this.agregarBtn.Text = "Agregar producto";
            this.agregarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarBtn.UseVisualStyleBackColor = false;
            // 
            // terminarBtn
            // 
            this.terminarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.terminarBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.terminarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.terminarBtn.FlatAppearance.BorderSize = 0;
            this.terminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.terminarBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminarBtn.ForeColor = System.Drawing.Color.White;
            this.terminarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.terminarBtn.Location = new System.Drawing.Point(438, 381);
            this.terminarBtn.Name = "terminarBtn";
            this.terminarBtn.Size = new System.Drawing.Size(155, 57);
            this.terminarBtn.TabIndex = 7;
            this.terminarBtn.Text = "Terminar orden";
            this.terminarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.terminarBtn.UseVisualStyleBackColor = false;
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
            this.cancelarBtn.Location = new System.Drawing.Point(327, 381);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(105, 57);
            this.cancelarBtn.TabIndex = 8;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // tablaDatos
            // 
            this.tablaDatos.AllowUserToAddRows = false;
            this.tablaDatos.AllowUserToDeleteRows = false;
            this.tablaDatos.AllowUserToOrderColumns = true;
            this.tablaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaDatos.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.tablaDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.tablaDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaDatos.Location = new System.Drawing.Point(51, 103);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.ReadOnly = true;
            this.tablaDatos.RowTemplate.Height = 24;
            this.tablaDatos.Size = new System.Drawing.Size(699, 245);
            this.tablaDatos.TabIndex = 9;
            // 
            // agregarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.terminarBtn);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.ordenesLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agregarOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "agregarOrden";
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ordenesLbl;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Button terminarBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.DataGridView tablaDatos;
    }
}