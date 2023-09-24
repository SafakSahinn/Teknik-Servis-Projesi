
namespace TeknikServis.Formlar
{
    partial class FrmYeniKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniKategori));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtKategoriAd = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.PictureCikis = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKategoriAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCikis.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Yeni Kategori Ekle";
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Location = new System.Drawing.Point(28, 33);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit6.Size = new System.Drawing.Size(100, 100);
            this.pictureEdit6.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(84, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 3);
            this.panel1.TabIndex = 19;
            // 
            // TxtKategoriAd
            // 
            this.TxtKategoriAd.EditValue = "Kategori Adı";
            this.TxtKategoriAd.Location = new System.Drawing.Point(84, 182);
            this.TxtKategoriAd.Name = "TxtKategoriAd";
            this.TxtKategoriAd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtKategoriAd.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKategoriAd.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtKategoriAd.Properties.Appearance.Options.UseBackColor = true;
            this.TxtKategoriAd.Properties.Appearance.Options.UseFont = true;
            this.TxtKategoriAd.Properties.Appearance.Options.UseForeColor = true;
            this.TxtKategoriAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtKategoriAd.Size = new System.Drawing.Size(155, 26);
            this.TxtKategoriAd.TabIndex = 18;
            this.TxtKategoriAd.Click += new System.EventHandler(this.TxtKategoriAd_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(28, 166);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(50, 50);
            this.pictureEdit1.TabIndex = 17;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(92, 262);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(147, 44);
            this.BtnKaydet.TabIndex = 22;
            this.BtnKaydet.Text = "KATEGORİ EKLE";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // PictureCikis
            // 
            this.PictureCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureCikis.EditValue = ((object)(resources.GetObject("PictureCikis.EditValue")));
            this.PictureCikis.Location = new System.Drawing.Point(297, 3);
            this.PictureCikis.Name = "PictureCikis";
            this.PictureCikis.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PictureCikis.Properties.Appearance.Options.UseBackColor = true;
            this.PictureCikis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PictureCikis.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PictureCikis.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.PictureCikis.Size = new System.Drawing.Size(50, 50);
            this.PictureCikis.TabIndex = 62;
            this.PictureCikis.Click += new System.EventHandler(this.PictureCikis_Click);
            // 
            // FrmYeniKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(350, 347);
            this.Controls.Add(this.PictureCikis);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureEdit6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtKategoriAd);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYeniKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYeniKategori";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKategoriAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCikis.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit TxtKategoriAd;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.PictureEdit PictureCikis;
    }
}