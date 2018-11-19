namespace Frontend.FormsAgregar
{
    partial class agregarMesa
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
            this.mesaLbl = new System.Windows.Forms.Label();
            this.capacidadSpnr = new System.Windows.Forms.NumericUpDown();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboCB = new System.Windows.Forms.ComboBox();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.capacidadSpnr)).BeginInit();
            this.SuspendLayout();
            // 
            // mesaLbl
            // 
            this.mesaLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mesaLbl.AutoSize = true;
            this.mesaLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesaLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mesaLbl.Location = new System.Drawing.Point(195, 34);
            this.mesaLbl.Name = "mesaLbl";
            this.mesaLbl.Size = new System.Drawing.Size(181, 30);
            this.mesaLbl.TabIndex = 4;
            this.mesaLbl.Text = "Agregar mesa";
            this.mesaLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // capacidadSpnr
            // 
            this.capacidadSpnr.Location = new System.Drawing.Point(146, 119);
            this.capacidadSpnr.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.capacidadSpnr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.capacidadSpnr.Name = "capacidadSpnr";
            this.capacidadSpnr.Size = new System.Drawing.Size(292, 22);
            this.capacidadSpnr.TabIndex = 5;
            this.capacidadSpnr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nombreLbl
            // 
            this.nombreLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLbl.ForeColor = System.Drawing.Color.White;
            this.nombreLbl.Location = new System.Drawing.Point(142, 96);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(98, 20);
            this.nombreLbl.TabIndex = 6;
            this.nombreLbl.Text = "Capacidad:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Estado inicial:";
            // 
            // comboCB
            // 
            this.comboCB.FormattingEnabled = true;
            this.comboCB.Location = new System.Drawing.Point(146, 167);
            this.comboCB.Name = "comboCB";
            this.comboCB.Size = new System.Drawing.Size(292, 24);
            this.comboCB.TabIndex = 8;
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
            this.cancelarBtn.Location = new System.Drawing.Point(263, 253);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(139, 44);
            this.cancelarBtn.TabIndex = 10;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
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
            this.agregarBtn.Location = new System.Drawing.Point(412, 253);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(142, 44);
            this.agregarBtn.TabIndex = 9;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = false;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(161, 207);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(241, 19);
            this.errorLbl.TabIndex = 11;
            this.errorLbl.Text = "Por favor ingrese un nombre";
            this.errorLbl.Visible = false;
            // 
            // agregarMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(566, 322);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.comboCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.capacidadSpnr);
            this.Controls.Add(this.mesaLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agregarMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "agregarMesa";
            ((System.ComponentModel.ISupportInitialize)(this.capacidadSpnr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mesaLbl;
        private System.Windows.Forms.NumericUpDown capacidadSpnr;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboCB;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Label errorLbl;
    }
}