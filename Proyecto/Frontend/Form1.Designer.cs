namespace Frontend
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tituloPnl = new System.Windows.Forms.Panel();
            this.restaurarIcon = new System.Windows.Forms.PictureBox();
            this.maximizarIcon = new System.Windows.Forms.PictureBox();
            this.minimizarIcon = new System.Windows.Forms.PictureBox();
            this.cerrarIcon = new System.Windows.Forms.PictureBox();
            this.menuIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contentPnl = new System.Windows.Forms.Panel();
            this.colapsarMenuIcon = new System.Windows.Forms.PictureBox();
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tituloPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurarIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colapsarMenuIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuVertical.Controls.Add(this.pictureBox1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(250, 650);
            this.menuVertical.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tituloPnl
            // 
            this.tituloPnl.BackColor = System.Drawing.Color.SlateBlue;
            this.tituloPnl.Controls.Add(this.colapsarMenuIcon);
            this.tituloPnl.Controls.Add(this.restaurarIcon);
            this.tituloPnl.Controls.Add(this.maximizarIcon);
            this.tituloPnl.Controls.Add(this.minimizarIcon);
            this.tituloPnl.Controls.Add(this.cerrarIcon);
            this.tituloPnl.Controls.Add(this.menuIcon);
            this.tituloPnl.Controls.Add(this.label1);
            this.tituloPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloPnl.Location = new System.Drawing.Point(250, 0);
            this.tituloPnl.Name = "tituloPnl";
            this.tituloPnl.Size = new System.Drawing.Size(1050, 70);
            this.tituloPnl.TabIndex = 1;
            this.tituloPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tituloPnl_MouseDown);
            // 
            // restaurarIcon
            // 
            this.restaurarIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurarIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restaurarIcon.Image = ((System.Drawing.Image)(resources.GetObject("restaurarIcon.Image")));
            this.restaurarIcon.Location = new System.Drawing.Point(992, 3);
            this.restaurarIcon.Name = "restaurarIcon";
            this.restaurarIcon.Size = new System.Drawing.Size(23, 17);
            this.restaurarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restaurarIcon.TabIndex = 5;
            this.restaurarIcon.TabStop = false;
            this.restaurarIcon.Visible = false;
            this.restaurarIcon.Click += new System.EventHandler(this.restaurarIcon_Click);
            // 
            // maximizarIcon
            // 
            this.maximizarIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizarIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizarIcon.Image = ((System.Drawing.Image)(resources.GetObject("maximizarIcon.Image")));
            this.maximizarIcon.Location = new System.Drawing.Point(992, 3);
            this.maximizarIcon.Name = "maximizarIcon";
            this.maximizarIcon.Size = new System.Drawing.Size(23, 17);
            this.maximizarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizarIcon.TabIndex = 4;
            this.maximizarIcon.TabStop = false;
            this.maximizarIcon.Click += new System.EventHandler(this.maximizarIcon_Click);
            // 
            // minimizarIcon
            // 
            this.minimizarIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizarIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizarIcon.Image = ((System.Drawing.Image)(resources.GetObject("minimizarIcon.Image")));
            this.minimizarIcon.Location = new System.Drawing.Point(963, 6);
            this.minimizarIcon.Name = "minimizarIcon";
            this.minimizarIcon.Size = new System.Drawing.Size(23, 17);
            this.minimizarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizarIcon.TabIndex = 3;
            this.minimizarIcon.TabStop = false;
            this.minimizarIcon.Click += new System.EventHandler(this.minimizarIcon_Click);
            // 
            // cerrarIcon
            // 
            this.cerrarIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarIcon.Image = ((System.Drawing.Image)(resources.GetObject("cerrarIcon.Image")));
            this.cerrarIcon.Location = new System.Drawing.Point(1021, 3);
            this.cerrarIcon.Name = "cerrarIcon";
            this.cerrarIcon.Size = new System.Drawing.Size(23, 17);
            this.cerrarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrarIcon.TabIndex = 2;
            this.cerrarIcon.TabStop = false;
            this.cerrarIcon.Click += new System.EventHandler(this.cerrarIcon_Click);
            // 
            // menuIcon
            // 
            this.menuIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuIcon.Image = ((System.Drawing.Image)(resources.GetObject("menuIcon.Image")));
            this.menuIcon.Location = new System.Drawing.Point(8, 12);
            this.menuIcon.Name = "menuIcon";
            this.menuIcon.Size = new System.Drawing.Size(42, 45);
            this.menuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuIcon.TabIndex = 1;
            this.menuIcon.TabStop = false;
            this.menuIcon.Visible = false;
            this.menuIcon.Click += new System.EventHandler(this.menuIcon_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(434, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESTAURANTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // contentPnl
            // 
            this.contentPnl.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.contentPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPnl.Location = new System.Drawing.Point(250, 70);
            this.contentPnl.Name = "contentPnl";
            this.contentPnl.Size = new System.Drawing.Size(1050, 580);
            this.contentPnl.TabIndex = 2;
            // 
            // colapsarMenuIcon
            // 
            this.colapsarMenuIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colapsarMenuIcon.Image = ((System.Drawing.Image)(resources.GetObject("colapsarMenuIcon.Image")));
            this.colapsarMenuIcon.Location = new System.Drawing.Point(6, 18);
            this.colapsarMenuIcon.Name = "colapsarMenuIcon";
            this.colapsarMenuIcon.Size = new System.Drawing.Size(44, 30);
            this.colapsarMenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colapsarMenuIcon.TabIndex = 0;
            this.colapsarMenuIcon.TabStop = false;
            this.colapsarMenuIcon.Click += new System.EventHandler(this.colapsarMenuIcon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.contentPnl);
            this.Controls.Add(this.tituloPnl);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tituloPnl.ResumeLayout(false);
            this.tituloPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurarIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colapsarMenuIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Panel tituloPnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contentPnl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox menuIcon;
        private System.Windows.Forms.PictureBox maximizarIcon;
        private System.Windows.Forms.PictureBox minimizarIcon;
        private System.Windows.Forms.PictureBox cerrarIcon;
        private System.Windows.Forms.PictureBox restaurarIcon;
        private System.Windows.Forms.PictureBox colapsarMenuIcon;
    }
}

