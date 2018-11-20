namespace Frontend.FormsAgregar
{
    partial class agregarCategoria
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
            this.agregarBtn = new System.Windows.Forms.Button();
            this.categoriaLbl = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.descripcionTxt = new System.Windows.Forms.TextBox();
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
            this.cancelarBtn.Location = new System.Drawing.Point(263, 253);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(139, 44);
            this.cancelarBtn.TabIndex = 12;
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
            this.agregarBtn.TabIndex = 11;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = false;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // categoriaLbl
            // 
            this.categoriaLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoriaLbl.AutoSize = true;
            this.categoriaLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoriaLbl.Location = new System.Drawing.Point(170, 35);
            this.categoriaLbl.Name = "categoriaLbl";
            this.categoriaLbl.Size = new System.Drawing.Size(232, 30);
            this.categoriaLbl.TabIndex = 13;
            this.categoriaLbl.Text = "Agregar categoria";
            this.categoriaLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.errorLbl.TabIndex = 18;
            this.errorLbl.Text = "Por favor ingrese un nombre";
            this.errorLbl.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Descripcion:";
            // 
            // nombreLbl
            // 
            this.nombreLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLbl.ForeColor = System.Drawing.Color.White;
            this.nombreLbl.Location = new System.Drawing.Point(103, 96);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(190, 20);
            this.nombreLbl.TabIndex = 15;
            this.nombreLbl.Text = "Nombre de la categoria:";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreTxt.BackColor = System.Drawing.Color.White;
            this.nombreTxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTxt.Location = new System.Drawing.Point(107, 119);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(359, 26);
            this.nombreTxt.TabIndex = 19;
            // 
            // descripcionTxt
            // 
            this.descripcionTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionTxt.BackColor = System.Drawing.Color.White;
            this.descripcionTxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTxt.Location = new System.Drawing.Point(107, 171);
            this.descripcionTxt.Name = "descripcionTxt";
            this.descripcionTxt.Size = new System.Drawing.Size(359, 26);
            this.descripcionTxt.TabIndex = 20;
            // 
            // agregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(566, 322);
            this.Controls.Add(this.descripcionTxt);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.categoriaLbl);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.agregarBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agregarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "agregarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Label categoriaLbl;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox descripcionTxt;
    }
}