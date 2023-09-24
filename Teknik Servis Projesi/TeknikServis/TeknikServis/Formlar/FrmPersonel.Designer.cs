
namespace TeknikServis.Formlar
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TxtPersonelId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtPersonelAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.LueDepartman = new DevExpress.XtraEditors.LookUpEdit();
            this.TxtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.TxtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.TxtPersonelSoyad = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LueDepartman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelSoyad.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(43, 75);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(69, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "PERSONEL ID:";
            // 
            // BtnListele
            // 
            this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
            this.BtnListele.Location = new System.Drawing.Point(118, 363);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(187, 39);
            this.BtnListele.TabIndex = 10;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(118, 318);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(187, 39);
            this.BtnGuncelle.TabIndex = 9;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(118, 273);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(187, 39);
            this.BtnSil.TabIndex = 8;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(118, 228);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(187, 39);
            this.BtnKaydet.TabIndex = 7;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtPersonelId
            // 
            this.TxtPersonelId.Enabled = false;
            this.TxtPersonelId.Location = new System.Drawing.Point(118, 72);
            this.TxtPersonelId.Name = "TxtPersonelId";
            this.TxtPersonelId.Size = new System.Drawing.Size(187, 20);
            this.TxtPersonelId.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(74, 127);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "SOYAD:";
            // 
            // TxtPersonelAd
            // 
            this.TxtPersonelAd.Location = new System.Drawing.Point(118, 98);
            this.TxtPersonelAd.Name = "TxtPersonelAd";
            this.TxtPersonelAd.Size = new System.Drawing.Size(187, 20);
            this.TxtPersonelAd.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(94, 101);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "AD:";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1527, 841);
            this.gridControl1.TabIndex = 20;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.LueDepartman);
            this.groupControl1.Controls.Add(this.TxtTelefon);
            this.groupControl1.Controls.Add(this.labelControl31);
            this.groupControl1.Controls.Add(this.TxtMail);
            this.groupControl1.Controls.Add(this.labelControl30);
            this.groupControl1.Controls.Add(this.labelControl28);
            this.groupControl1.Controls.Add(this.TxtPersonelSoyad);
            this.groupControl1.Controls.Add(this.TxtPersonelId);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.BtnListele);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TxtPersonelAd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1539, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(372, 841);
            this.groupControl1.TabIndex = 21;
            this.groupControl1.Text = "PERSONEL İŞLEMLERİ";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(118, 408);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(187, 39);
            this.BtnTemizle.TabIndex = 11;
            this.BtnTemizle.Text = "TEMİZLE";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // LueDepartman
            // 
            this.LueDepartman.Location = new System.Drawing.Point(118, 150);
            this.LueDepartman.Name = "LueDepartman";
            this.LueDepartman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LueDepartman.Properties.DisplayMember = "AD";
            this.LueDepartman.Properties.NullText = "";
            this.LueDepartman.Properties.ValueMember = "ID";
            this.LueDepartman.Size = new System.Drawing.Size(187, 20);
            this.LueDepartman.TabIndex = 4;
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(118, 202);
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(187, 20);
            this.TxtTelefon.TabIndex = 6;
            // 
            // labelControl31
            // 
            this.labelControl31.Location = new System.Drawing.Point(64, 205);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(48, 13);
            this.labelControl31.TabIndex = 28;
            this.labelControl31.Text = "TELEFON:";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(118, 176);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(187, 20);
            this.TxtMail.TabIndex = 5;
            // 
            // labelControl30
            // 
            this.labelControl30.Location = new System.Drawing.Point(84, 179);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(28, 13);
            this.labelControl30.TabIndex = 26;
            this.labelControl30.Text = "MAIL:";
            // 
            // labelControl28
            // 
            this.labelControl28.Location = new System.Drawing.Point(47, 153);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(65, 13);
            this.labelControl28.TabIndex = 22;
            this.labelControl28.Text = "DEPARTMAN:";
            // 
            // TxtPersonelSoyad
            // 
            this.TxtPersonelSoyad.Location = new System.Drawing.Point(118, 124);
            this.TxtPersonelSoyad.Name = "TxtPersonelSoyad";
            this.TxtPersonelSoyad.Size = new System.Drawing.Size(187, 20);
            this.TxtPersonelSoyad.TabIndex = 3;
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1917, 841);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmPersonel";
            this.Text = "Personel Listesi";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LueDepartman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelSoyad.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.TextEdit TxtPersonelId;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtPersonelAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit LueDepartman;
        private DevExpress.XtraEditors.TextEdit TxtTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraEditors.TextEdit TxtMail;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.TextEdit TxtPersonelSoyad;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
    }
}