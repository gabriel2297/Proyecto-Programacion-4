namespace Frontend
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.productosLbl = new System.Windows.Forms.Label();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.pRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productosLbl
            // 
            this.productosLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.productosLbl.AutoSize = true;
            this.productosLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productosLbl.Location = new System.Drawing.Point(350, 36);
            this.productosLbl.Name = "productosLbl";
            this.productosLbl.Size = new System.Drawing.Size(131, 30);
            this.productosLbl.TabIndex = 3;
            this.productosLbl.Text = "Productos";
            this.productosLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.agregarBtn.TabIndex = 4;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = false;
            // 
            // pRODUCTOBindingSource
            // 
            this.pRODUCTOBindingSource.DataSource = typeof(Backend.Model.PRODUCTO);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.productosLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productosLbl;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.BindingSource pRODUCTOBindingSource;
    }
}