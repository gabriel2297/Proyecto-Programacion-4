namespace Frontend.FormsEditarEliminar
{
    partial class editarMesero
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
            this.meserosLbl = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.editarBtn = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // meserosLbl
            // 
            this.meserosLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.meserosLbl.AutoSize = true;
            this.meserosLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meserosLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.meserosLbl.Location = new System.Drawing.Point(206, 30);
            this.meserosLbl.Name = "meserosLbl";
            this.meserosLbl.Size = new System.Drawing.Size(175, 30);
            this.meserosLbl.TabIndex = 4;
            this.meserosLbl.Text = "Editar mesero";
            this.meserosLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.cancelarBtn.TabIndex = 9;
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
            this.editarBtn.TabIndex = 8;
            this.editarBtn.Text = "Editar";
            this.editarBtn.UseVisualStyleBackColor = false;
            this.editarBtn.Click += new System.EventHandler(this.editarBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(164, 151);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(241, 19);
            this.errorLbl.TabIndex = 13;
            this.errorLbl.Text = "Por favor ingrese un nombre";
            this.errorLbl.Visible = false;
            // 
            // nombreLbl
            // 
            this.nombreLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLbl.ForeColor = System.Drawing.Color.White;
            this.nombreLbl.Location = new System.Drawing.Point(97, 84);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(147, 20);
            this.nombreLbl.TabIndex = 12;
            this.nombreLbl.Text = "Nombre completo:";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreTxt.BackColor = System.Drawing.Color.White;
            this.nombreTxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTxt.Location = new System.Drawing.Point(101, 107);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(359, 26);
            this.nombreTxt.TabIndex = 11;
            // 
            // editarMesero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(566, 322);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.editarBtn);
            this.Controls.Add(this.meserosLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editarMesero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "editarMesero";
            this.Load += new System.EventHandler(this.editarMesero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label meserosLbl;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Label nombreLbl;
        public System.Windows.Forms.TextBox nombreTxt;
    }
}