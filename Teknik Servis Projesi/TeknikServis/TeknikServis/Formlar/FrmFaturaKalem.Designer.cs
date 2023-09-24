
namespace TeknikServis.Formlar
{
    partial class FrmFaturaKalem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaKalem));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.LueUrun = new DevExpress.XtraEditors.LookUpEdit();
            this.TxtFaturaId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAdet = new DevExpress.XtraEditors.TextEdit();
            this.TxtDetayID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LueUrun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDetayID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1527, 841);
            this.gridControl1.TabIndex = 22;
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
            this.groupControl1.Controls.Add(this.LueUrun);
            this.groupControl1.Controls.Add(this.TxtFaturaId);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.TxtTutar);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.TxtFiyat);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtAdet);
            this.groupControl1.Controls.Add(this.TxtDetayID);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.BtnListele);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1539, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(372, 841);
            this.groupControl1.TabIndex = 23;
            this.groupControl1.Text = "FATURA KALEM İŞLEMLERİ";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(118, 408);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(187, 39);
            this.BtnTemizle.TabIndex = 29;
            this.BtnTemizle.Text = "TEMİZLE";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // LueUrun
            // 
            this.LueUrun.Location = new System.Drawing.Point(118, 98);
            this.LueUrun.Name = "LueUrun";
            this.LueUrun.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LueUrun.Properties.DisplayMember = "AD";
            this.LueUrun.Properties.NullText = "";
            this.LueUrun.Properties.ValueMember = "ID";
            this.LueUrun.Size = new System.Drawing.Size(187, 20);
            this.LueUrun.TabIndex = 1;
            // 
            // TxtFaturaId
            // 
            this.TxtFaturaId.Location = new System.Drawing.Point(118, 202);
            this.TxtFaturaId.Name = "TxtFaturaId";
            this.TxtFaturaId.Size = new System.Drawing.Size(187, 20);
            this.TxtFaturaId.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(54, 205);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 13);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "FATURA ID:";
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(118, 176);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(187, 20);
            this.TxtTutar.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(75, 179);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "TUTAR:";
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(118, 150);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(187, 20);
            this.TxtFiyat.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(79, 153);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "FİYAT:";
            // 
            // TxtAdet
            // 
            this.TxtAdet.Location = new System.Drawing.Point(118, 124);
            this.TxtAdet.Name = "TxtAdet";
            this.TxtAdet.Size = new System.Drawing.Size(187, 20);
            this.TxtAdet.TabIndex = 2;
            // 
            // TxtDetayID
            // 
            this.TxtDetayID.Enabled = false;
            this.TxtDetayID.Location = new System.Drawing.Point(118, 72);
            this.TxtDetayID.Name = "TxtDetayID";
            this.TxtDetayID.Size = new System.Drawing.Size(187, 20);
            this.TxtDetayID.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(62, 75);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "DETAY ID:";
            // 
            // BtnListele
            // 
            this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
            this.BtnListele.Location = new System.Drawing.Point(118, 363);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(187, 39);
            this.BtnListele.TabIndex = 11;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(118, 318);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(187, 39);
            this.BtnGuncelle.TabIndex = 10;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(118, 273);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(187, 39);
            this.BtnSil.TabIndex = 9;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(118, 228);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(187, 39);
            this.BtnKaydet.TabIndex = 8;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(82, 127);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "ADET:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(80, 101);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "ÜRÜN:";
            // 
            // FrmFaturaKalem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1917, 841);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmFaturaKalem";
            this.Text = "Fatura Kalem Girişi";
            this.Load += new System.EventHandler(this.FrmFaturaKalem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LueUrun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDetayID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtFaturaId;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtTutar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtAdet;
        private DevExpress.XtraEditors.TextEdit TxtDetayID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit LueUrun;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
    }
}