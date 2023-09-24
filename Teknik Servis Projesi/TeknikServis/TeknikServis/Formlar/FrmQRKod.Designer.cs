
namespace TeknikServis.Formlar
{
    partial class FrmQRKod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQRKod));
            this.PictureCikis = new DevExpress.XtraEditors.PictureEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.BtnQROlustur = new DevExpress.XtraEditors.SimpleButton();
            this.PictureQR = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCikis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureQR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureCikis
            // 
            this.PictureCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureCikis.EditValue = ((object)(resources.GetObject("PictureCikis.EditValue")));
            this.PictureCikis.Location = new System.Drawing.Point(300, 0);
            this.PictureCikis.Name = "PictureCikis";
            this.PictureCikis.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PictureCikis.Properties.Appearance.Options.UseBackColor = true;
            this.PictureCikis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PictureCikis.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PictureCikis.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.PictureCikis.Size = new System.Drawing.Size(50, 50);
            this.PictureCikis.TabIndex = 96;
            this.PictureCikis.Click += new System.EventHandler(this.PictureCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 84;
            this.label1.Text = "QR Kod Oluştur";
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Location = new System.Drawing.Point(26, 33);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit6.Size = new System.Drawing.Size(100, 100);
            this.pictureEdit6.TabIndex = 82;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(82, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 3);
            this.panel1.TabIndex = 73;
            // 
            // TxtSeriNo
            // 
            this.TxtSeriNo.EditValue = "Seri No";
            this.TxtSeriNo.Location = new System.Drawing.Point(82, 182);
            this.TxtSeriNo.Name = "TxtSeriNo";
            this.TxtSeriNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtSeriNo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSeriNo.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtSeriNo.Properties.Appearance.Options.UseBackColor = true;
            this.TxtSeriNo.Properties.Appearance.Options.UseFont = true;
            this.TxtSeriNo.Properties.Appearance.Options.UseForeColor = true;
            this.TxtSeriNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtSeriNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtSeriNo.Properties.MaskSettings.Set("mask", "AAAAA");
            this.TxtSeriNo.Size = new System.Drawing.Size(200, 26);
            this.TxtSeriNo.TabIndex = 2;
            this.TxtSeriNo.Click += new System.EventHandler(this.TxtSeriNo_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(26, 166);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(50, 50);
            this.pictureEdit1.TabIndex = 72;
            // 
            // BtnQROlustur
            // 
            this.BtnQROlustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnQROlustur.ImageOptions.Image")));
            this.BtnQROlustur.Location = new System.Drawing.Point(105, 461);
            this.BtnQROlustur.Name = "BtnQROlustur";
            this.BtnQROlustur.Size = new System.Drawing.Size(147, 44);
            this.BtnQROlustur.TabIndex = 3;
            this.BtnQROlustur.Text = "QR OLUŞTUR";
            this.BtnQROlustur.Click += new System.EventHandler(this.BtnQROlustur_Click);
            // 
            // PictureQR
            // 
            this.PictureQR.Location = new System.Drawing.Point(82, 237);
            this.PictureQR.Name = "PictureQR";
            this.PictureQR.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PictureQR.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.PictureQR.Size = new System.Drawing.Size(200, 200);
            this.PictureQR.TabIndex = 1;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(26, 232);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit3.Size = new System.Drawing.Size(50, 50);
            this.pictureEdit3.TabIndex = 98;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(82, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 3);
            this.panel2.TabIndex = 74;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(288, 397);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(40, 40);
            this.BtnKaydet.TabIndex = 99;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // FrmQRKod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(350, 529);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.PictureQR);
            this.Controls.Add(this.PictureCikis);
            this.Controls.Add(this.BtnQROlustur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureEdit6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtSeriNo);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQRKod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQRKod";
            ((System.ComponentModel.ISupportInitialize)(this.PictureCikis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureQR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit PictureCikis;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit TxtSeriNo;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton BtnQROlustur;
        private DevExpress.XtraEditors.PictureEdit PictureQR;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
    }
}