
namespace TeknikServis.Formlar
{
    partial class FrmFaturaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaListesi));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSeri = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFaturaId = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LuePersonel = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.LueCari = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSaat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTarih = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSiraNo = new DevExpress.XtraEditors.TextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LuePersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LueCari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSiraNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(85, 101);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "SERİ:";
            // 
            // TxtSeri
            // 
            this.TxtSeri.Location = new System.Drawing.Point(118, 98);
            this.TxtSeri.Name = "TxtSeri";
            this.TxtSeri.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtSeri.Properties.MaskSettings.Set("mask", "A");
            this.TxtSeri.Size = new System.Drawing.Size(187, 20);
            this.TxtSeri.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(66, 127);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "SIRA NO:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(118, 293);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(187, 39);
            this.BtnKaydet.TabIndex = 8;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(118, 338);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(187, 39);
            this.BtnSil.TabIndex = 9;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(118, 383);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(187, 39);
            this.BtnGuncelle.TabIndex = 10;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
            this.BtnListele.Location = new System.Drawing.Point(118, 428);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(187, 39);
            this.BtnListele.TabIndex = 11;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(54, 75);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(58, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "FATURA ID:";
            // 
            // TxtFaturaId
            // 
            this.TxtFaturaId.EditValue = "";
            this.TxtFaturaId.Enabled = false;
            this.TxtFaturaId.Location = new System.Drawing.Point(118, 72);
            this.TxtFaturaId.Name = "TxtFaturaId";
            this.TxtFaturaId.Size = new System.Drawing.Size(187, 20);
            this.TxtFaturaId.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.LuePersonel);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.LueCari);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.TxtVergiDairesi);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.TxtSaat);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.TxtTarih);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtSiraNo);
            this.groupControl1.Controls.Add(this.TxtFaturaId);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.BtnListele);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TxtSeri);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1539, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(372, 841);
            this.groupControl1.TabIndex = 21;
            this.groupControl1.Text = "FATURA İŞLEMLERİ";
            // 
            // LuePersonel
            // 
            this.LuePersonel.Location = new System.Drawing.Point(118, 254);
            this.LuePersonel.Name = "LuePersonel";
            this.LuePersonel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuePersonel.Properties.DisplayMember = "AD";
            this.LuePersonel.Properties.ValueMember = "ID";
            this.LuePersonel.Size = new System.Drawing.Size(187, 20);
            this.LuePersonel.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(57, 257);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(55, 13);
            this.labelControl8.TabIndex = 32;
            this.labelControl8.Text = "PERSONEL:";
            // 
            // LueCari
            // 
            this.LueCari.Location = new System.Drawing.Point(118, 228);
            this.LueCari.Name = "LueCari";
            this.LueCari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LueCari.Properties.DisplayMember = "AD";
            this.LueCari.Properties.ValueMember = "ID";
            this.LueCari.Size = new System.Drawing.Size(187, 20);
            this.LueCari.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(83, 231);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(29, 13);
            this.labelControl6.TabIndex = 29;
            this.labelControl6.Text = "CARİ:";
            // 
            // TxtVergiDairesi
            // 
            this.TxtVergiDairesi.Location = new System.Drawing.Point(118, 202);
            this.TxtVergiDairesi.Name = "TxtVergiDairesi";
            this.TxtVergiDairesi.Size = new System.Drawing.Size(187, 20);
            this.TxtVergiDairesi.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(34, 205);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 13);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "VERGİ DAİRESİ:";
            // 
            // TxtSaat
            // 
            this.TxtSaat.Location = new System.Drawing.Point(118, 176);
            this.TxtSaat.Name = "TxtSaat";
            this.TxtSaat.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtSaat.Properties.MaskSettings.Set("mask", "90:00");
            this.TxtSaat.Size = new System.Drawing.Size(187, 20);
            this.TxtSaat.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(82, 179);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "SAAT:";
            // 
            // TxtTarih
            // 
            this.TxtTarih.Location = new System.Drawing.Point(118, 150);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtTarih.Properties.MaskSettings.Set("mask", "99/99/00");
            this.TxtTarih.Size = new System.Drawing.Size(187, 20);
            this.TxtTarih.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(77, 153);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "TARİH:";
            // 
            // TxtSiraNo
            // 
            this.TxtSiraNo.Location = new System.Drawing.Point(118, 124);
            this.TxtSiraNo.Name = "TxtSiraNo";
            this.TxtSiraNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtSiraNo.Properties.MaskSettings.Set("mask", "AAAAAA");
            this.TxtSiraNo.Size = new System.Drawing.Size(187, 20);
            this.TxtSiraNo.TabIndex = 2;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
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
            // FrmFaturaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1917, 841);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmFaturaListesi";
            this.Text = "Fatura Listesi";
            this.Load += new System.EventHandler(this.FrmFaturaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LuePersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LueCari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSiraNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtSeri;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TxtFaturaId;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit LuePersonel;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit LueCari;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtVergiDairesi;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtSaat;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtTarih;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtSiraNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
    }
}