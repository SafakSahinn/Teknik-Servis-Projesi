
namespace TeknikServis.İletişim
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.RchMesaj = new System.Windows.Forms.RichTextBox();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.PictureCikis = new DevExpress.XtraEditors.PictureEdit();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtAliciMail = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtKonu = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCikis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAliciMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKonu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // RchMesaj
            // 
            this.RchMesaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.RchMesaj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RchMesaj.ForeColor = System.Drawing.Color.White;
            this.RchMesaj.Location = new System.Drawing.Point(84, 326);
            this.RchMesaj.Name = "RchMesaj";
            this.RchMesaj.Size = new System.Drawing.Size(553, 342);
            this.RchMesaj.TabIndex = 105;
            this.RchMesaj.Text = "İçerik";
            this.RchMesaj.Click += new System.EventHandler(this.RchMesaj_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(26, 297);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(50, 50);
            this.pictureEdit1.TabIndex = 106;
            // 
            // PictureCikis
            // 
            this.PictureCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureCikis.EditValue = ((object)(resources.GetObject("PictureCikis.EditValue")));
            this.PictureCikis.Location = new System.Drawing.Point(649, 0);
            this.PictureCikis.Name = "PictureCikis";
            this.PictureCikis.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PictureCikis.Properties.Appearance.Options.UseBackColor = true;
            this.PictureCikis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PictureCikis.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PictureCikis.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.PictureCikis.Size = new System.Drawing.Size(50, 50);
            this.PictureCikis.TabIndex = 104;
            this.PictureCikis.Click += new System.EventHandler(this.PictureCikis_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(83, 674);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(553, 3);
            this.panel7.TabIndex = 103;
            // 
            // BtnGonder
            // 
            this.BtnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGonder.ImageOptions.Image")));
            this.BtnGonder.Location = new System.Drawing.Point(277, 696);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(147, 44);
            this.BtnGonder.TabIndex = 100;
            this.BtnGonder.Text = "GÖNDER";
            this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 102;
            this.label1.Text = "Yeni Mail Oluştur";
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Location = new System.Drawing.Point(26, 32);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit6.Size = new System.Drawing.Size(100, 100);
            this.pictureEdit6.TabIndex = 101;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(82, 212);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 3);
            this.panel4.TabIndex = 110;
            // 
            // TxtAliciMail
            // 
            this.TxtAliciMail.EditValue = "Mail Adresi";
            this.TxtAliciMail.Location = new System.Drawing.Point(82, 181);
            this.TxtAliciMail.Name = "TxtAliciMail";
            this.TxtAliciMail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtAliciMail.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAliciMail.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtAliciMail.Properties.Appearance.Options.UseBackColor = true;
            this.TxtAliciMail.Properties.Appearance.Options.UseFont = true;
            this.TxtAliciMail.Properties.Appearance.Options.UseForeColor = true;
            this.TxtAliciMail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtAliciMail.Size = new System.Drawing.Size(200, 26);
            this.TxtAliciMail.TabIndex = 108;
            this.TxtAliciMail.Click += new System.EventHandler(this.TxtAliciMail_Click);
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(26, 165);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit4.Size = new System.Drawing.Size(50, 50);
            this.pictureEdit4.TabIndex = 109;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(84, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 3);
            this.panel1.TabIndex = 113;
            // 
            // TxtKonu
            // 
            this.TxtKonu.EditValue = "Konu";
            this.TxtKonu.Location = new System.Drawing.Point(84, 247);
            this.TxtKonu.Name = "TxtKonu";
            this.TxtKonu.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtKonu.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKonu.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtKonu.Properties.Appearance.Options.UseBackColor = true;
            this.TxtKonu.Properties.Appearance.Options.UseFont = true;
            this.TxtKonu.Properties.Appearance.Options.UseForeColor = true;
            this.TxtKonu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtKonu.Size = new System.Drawing.Size(200, 26);
            this.TxtKonu.TabIndex = 111;
            this.TxtKonu.Click += new System.EventHandler(this.TxtKonu_Click);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(28, 231);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit2.Size = new System.Drawing.Size(50, 50);
            this.pictureEdit2.TabIndex = 112;
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(700, 767);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtKonu);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.TxtAliciMail);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.RchMesaj);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.PictureCikis);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.BtnGonder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureEdit6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCikis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAliciMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKonu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox RchMesaj;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit PictureCikis;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.SimpleButton BtnGonder;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.TextEdit TxtAliciMail;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit TxtKonu;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
    }
}