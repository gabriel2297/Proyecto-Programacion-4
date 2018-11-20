namespace Frontend.FormsEditarEliminar
{
    partial class editarCategoria
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
            this.categoriasLbl = new System.Windows.Forms.Label();
            this.descripcionTxt = new System.Windows.Forms.TextBox();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.errorLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.editarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categoriasLbl
            // 
            this.categoriasLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoriasLbl.AutoSize = true;
            this.categoriasLbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriasLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoriasLbl.Location = new System.Drawing.Point(170, 35);
            this.categoriasLbl.Name = "categoriasLbl";
            this.categoriasLbl.Size = new System.Drawing.Size(203, 30);
            this.categoriasLbl.TabIndex = 14;
            this.categoriasLbl.Text = "Editar categoria";
            this.categoriasLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.descripcionTxt.TabIndex = 27;
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
            this.nombreTxt.TabIndex = 26;
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
            this.errorLbl.TabIndex = 25;
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
            this.label1.TabIndex = 24;
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
            this.nombreLbl.TabIndex = 23;
            this.nombreLbl.Text = "Nombre de la categoria:";
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
            this.cancelarBtn.TabIndex = 22;
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
            this.editarBtn.Location = new System.Drawing.Point(412, 253);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(142, 44);
            this.editarBtn.TabIndex = 21;
            this.editarBtn.Text = "Editar";
            this.editarBtn.UseVisualStyleBackColor = false;
            this.editarBtn.Click += new System.EventHandler(this.editarBtn_Click);
            // 
            // editarCategoria
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
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.editarBtn);
            this.Controls.Add(this.categoriasLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "editarCategoria";
            this.Load += new System.EventHandler(this.editarCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label categoriasLbl;
        private System.Windows.Forms.TextBox descripcionTxt;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button editarBtn;
    }
}