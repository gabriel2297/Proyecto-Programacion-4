namespace Frontend.FormsEditarEliminar
{
    partial class editarMesa
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
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.editarBtn = new System.Windows.Forms.Button();
            this.mesaLbl = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.comboCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.capacidadSpnr = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.capacidadSpnr)).BeginInit();
            this.SuspendLayout();
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
            this.cancelarBtn.Location = new System.Drawing.Point(266, 266);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(139, 44);
            this.cancelarBtn.TabIndex = 16;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // editarBtn
            // 
            this.editarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editarBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.editarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarBtn.FlatAppearance.BorderSize = 0;
            this.editarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarBtn.ForeColor = System.Drawing.Color.White;
            this.editarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editarBtn.Location = new System.Drawing.Point(412, 266);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(142, 44);
            this.editarBtn.TabIndex = 15;
            this.editarBtn.Text = "Editar";
            this.editarBtn.UseVisualStyleBackColor = false;
            this.editarBtn.Click += new System.EventHandler(this.editarBtn_Click);
            // 
            // mesaLbl
            // 
            this.mesaLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mesaLbl.AutoSize = true;
            this.mesaLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesaLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mesaLbl.Location = new System.Drawing.Point(206, 30);
            this.mesaLbl.Name = "mesaLbl";
            this.mesaLbl.Size = new System.Drawing.Size(152, 30);
            this.mesaLbl.TabIndex = 14;
            this.mesaLbl.Text = "Editar mesa";
            this.mesaLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorLbl
            // 
            this.errorLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(154, 207);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(241, 19);
            this.errorLbl.TabIndex = 21;
            this.errorLbl.Text = "Por favor ingrese un nombre";
            this.errorLbl.Visible = false;
            // 
            // comboCB
            // 
            this.comboCB.FormattingEnabled = true;
            this.comboCB.Location = new System.Drawing.Point(139, 167);
            this.comboCB.Name = "comboCB";
            this.comboCB.Size = new System.Drawing.Size(292, 24);
            this.comboCB.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Estado:";
            // 
            // nombreLbl
            // 
            this.nombreLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLbl.ForeColor = System.Drawing.Color.White;
            this.nombreLbl.Location = new System.Drawing.Point(135, 96);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(98, 20);
            this.nombreLbl.TabIndex = 18;
            this.nombreLbl.Text = "Capacidad:";
            // 
            // capacidadSpnr
            // 
            this.capacidadSpnr.Location = new System.Drawing.Point(139, 119);
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
            this.capacidadSpnr.TabIndex = 17;
            this.capacidadSpnr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // editarMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(566, 322);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.comboCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.capacidadSpnr);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.editarBtn);
            this.Controls.Add(this.mesaLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editarMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "editarMesa";
            this.Load += new System.EventHandler(this.editarMesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capacidadSpnr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Label mesaLbl;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.ComboBox comboCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.NumericUpDown capacidadSpnr;
    }
}