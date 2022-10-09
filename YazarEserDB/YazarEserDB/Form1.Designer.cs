
namespace YazarEserDB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabYazarEserler = new System.Windows.Forms.TabControl();
            this.tabAnasayfa = new System.Windows.Forms.TabPage();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstEserler = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.cbxYazarlar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabYazarlar = new System.Windows.Forms.TabPage();
            this.lstYazarlar = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxYazarEkle = new System.Windows.Forms.GroupBox();
            this.btnEkleYazarlar = new System.Windows.Forms.Button();
            this.btnIptalYazarlar = new System.Windows.Forms.Button();
            this.txtTamAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEserler = new System.Windows.Forms.TabPage();
            this.lsvEserler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbEser = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.cbxYazarr = new System.Windows.Forms.ComboBox();
            this.cbxTur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEkleEserler = new System.Windows.Forms.Button();
            this.btnIptalEserler = new System.Windows.Forms.Button();
            this.txtEserBaslik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yazarlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabYazarEserler.SuspendLayout();
            this.tabAnasayfa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabYazarlar.SuspendLayout();
            this.gbxYazarEkle.SuspendLayout();
            this.tabEserler.SuspendLayout();
            this.grbEser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabYazarEserler
            // 
            this.tabYazarEserler.Controls.Add(this.tabAnasayfa);
            this.tabYazarEserler.Controls.Add(this.tabYazarlar);
            this.tabYazarEserler.Controls.Add(this.tabEserler);
            this.tabYazarEserler.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabYazarEserler.Location = new System.Drawing.Point(13, 1);
            this.tabYazarEserler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabYazarEserler.Name = "tabYazarEserler";
            this.tabYazarEserler.SelectedIndex = 0;
            this.tabYazarEserler.Size = new System.Drawing.Size(869, 551);
            this.tabYazarEserler.TabIndex = 0;
            // 
            // tabAnasayfa
            // 
            this.tabAnasayfa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabAnasayfa.Controls.Add(this.btnTemizle);
            this.tabAnasayfa.Controls.Add(this.pictureBox1);
            this.tabAnasayfa.Controls.Add(this.lstEserler);
            this.tabAnasayfa.Controls.Add(this.label9);
            this.tabAnasayfa.Controls.Add(this.label8);
            this.tabAnasayfa.Controls.Add(this.txtAciklama);
            this.tabAnasayfa.Controls.Add(this.cbxYazarlar);
            this.tabAnasayfa.Controls.Add(this.label7);
            this.tabAnasayfa.Location = new System.Drawing.Point(4, 26);
            this.tabAnasayfa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAnasayfa.Name = "tabAnasayfa";
            this.tabAnasayfa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAnasayfa.Size = new System.Drawing.Size(861, 521);
            this.tabAnasayfa.TabIndex = 0;
            this.tabAnasayfa.Text = "Anasayfa";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(689, 446);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(116, 46);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "SIL";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lstEserler
            // 
            this.lstEserler.BackColor = System.Drawing.Color.PeachPuff;
            this.lstEserler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstEserler.FormattingEnabled = true;
            this.lstEserler.ItemHeight = 18;
            this.lstEserler.Location = new System.Drawing.Point(375, 122);
            this.lstEserler.Margin = new System.Windows.Forms.Padding(4);
            this.lstEserler.Name = "lstEserler";
            this.lstEserler.Size = new System.Drawing.Size(431, 94);
            this.lstEserler.TabIndex = 7;
            this.lstEserler.SelectedIndexChanged += new System.EventHandler(this.lstEserler_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(374, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Eser Açıklama:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(372, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Eserler:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.Color.LightGray;
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(374, 255);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAciklama.Size = new System.Drawing.Size(431, 163);
            this.txtAciklama.TabIndex = 3;
            // 
            // cbxYazarlar
            // 
            this.cbxYazarlar.BackColor = System.Drawing.Color.MistyRose;
            this.cbxYazarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxYazarlar.FormattingEnabled = true;
            this.cbxYazarlar.Location = new System.Drawing.Point(456, 42);
            this.cbxYazarlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxYazarlar.Name = "cbxYazarlar";
            this.cbxYazarlar.Size = new System.Drawing.Size(276, 26);
            this.cbxYazarlar.TabIndex = 1;
            this.cbxYazarlar.SelectedIndexChanged += new System.EventHandler(this.cbxYazarlar_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(371, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yazarlar:";
            // 
            // tabYazarlar
            // 
            this.tabYazarlar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabYazarlar.Controls.Add(this.lstYazarlar);
            this.tabYazarlar.Controls.Add(this.label2);
            this.tabYazarlar.Controls.Add(this.gbxYazarEkle);
            this.tabYazarlar.Location = new System.Drawing.Point(4, 26);
            this.tabYazarlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabYazarlar.Name = "tabYazarlar";
            this.tabYazarlar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabYazarlar.Size = new System.Drawing.Size(861, 521);
            this.tabYazarlar.TabIndex = 1;
            this.tabYazarlar.Text = "Yazarlar";
            // 
            // lstYazarlar
            // 
            this.lstYazarlar.BackColor = System.Drawing.Color.MistyRose;
            this.lstYazarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstYazarlar.FormattingEnabled = true;
            this.lstYazarlar.ItemHeight = 18;
            this.lstYazarlar.Location = new System.Drawing.Point(13, 240);
            this.lstYazarlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstYazarlar.Name = "lstYazarlar";
            this.lstYazarlar.Size = new System.Drawing.Size(836, 256);
            this.lstYazarlar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yazarlar:";
            // 
            // gbxYazarEkle
            // 
            this.gbxYazarEkle.Controls.Add(this.btnEkleYazarlar);
            this.gbxYazarEkle.Controls.Add(this.btnIptalYazarlar);
            this.gbxYazarEkle.Controls.Add(this.txtTamAd);
            this.gbxYazarEkle.Controls.Add(this.label1);
            this.gbxYazarEkle.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxYazarEkle.Location = new System.Drawing.Point(175, 20);
            this.gbxYazarEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxYazarEkle.Name = "gbxYazarEkle";
            this.gbxYazarEkle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxYazarEkle.Size = new System.Drawing.Size(445, 167);
            this.gbxYazarEkle.TabIndex = 1;
            this.gbxYazarEkle.TabStop = false;
            this.gbxYazarEkle.Text = "Yazar Ekle";
            // 
            // btnEkleYazarlar
            // 
            this.btnEkleYazarlar.Location = new System.Drawing.Point(253, 87);
            this.btnEkleYazarlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkleYazarlar.Name = "btnEkleYazarlar";
            this.btnEkleYazarlar.Size = new System.Drawing.Size(97, 49);
            this.btnEkleYazarlar.TabIndex = 3;
            this.btnEkleYazarlar.Text = "EKLE";
            this.btnEkleYazarlar.UseVisualStyleBackColor = true;
            this.btnEkleYazarlar.Click += new System.EventHandler(this.btnEkleYazarlar_Click);
            // 
            // btnIptalYazarlar
            // 
            this.btnIptalYazarlar.Location = new System.Drawing.Point(141, 87);
            this.btnIptalYazarlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIptalYazarlar.Name = "btnIptalYazarlar";
            this.btnIptalYazarlar.Size = new System.Drawing.Size(97, 49);
            this.btnIptalYazarlar.TabIndex = 2;
            this.btnIptalYazarlar.Text = "IPTAL";
            this.btnIptalYazarlar.UseVisualStyleBackColor = true;
            this.btnIptalYazarlar.Click += new System.EventHandler(this.btnIptalYazarlar_Click);
            // 
            // txtTamAd
            // 
            this.txtTamAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTamAd.Location = new System.Drawing.Point(123, 36);
            this.txtTamAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTamAd.Name = "txtTamAd";
            this.txtTamAd.Size = new System.Drawing.Size(252, 24);
            this.txtTamAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tam Ad:";
            // 
            // tabEserler
            // 
            this.tabEserler.Controls.Add(this.lsvEserler);
            this.tabEserler.Controls.Add(this.grbEser);
            this.tabEserler.Location = new System.Drawing.Point(4, 26);
            this.tabEserler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEserler.Name = "tabEserler";
            this.tabEserler.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEserler.Size = new System.Drawing.Size(861, 521);
            this.tabEserler.TabIndex = 2;
            this.tabEserler.Text = "Eserler";
            this.tabEserler.UseVisualStyleBackColor = true;
            // 
            // lsvEserler
            // 
            this.lsvEserler.BackColor = System.Drawing.Color.PeachPuff;
            this.lsvEserler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvEserler.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvEserler.FullRowSelect = true;
            this.lsvEserler.GridLines = true;
            this.lsvEserler.HideSelection = false;
            this.lsvEserler.Location = new System.Drawing.Point(425, 17);
            this.lsvEserler.Margin = new System.Windows.Forms.Padding(4);
            this.lsvEserler.Name = "lsvEserler";
            this.lsvEserler.Size = new System.Drawing.Size(432, 474);
            this.lsvEserler.TabIndex = 10;
            this.lsvEserler.UseCompatibleStateImageBehavior = false;
            this.lsvEserler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Eser Adı";
            this.columnHeader1.Width = 162;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Eser Türü";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yazar Adı";
            this.columnHeader3.Width = 181;
            // 
            // grbEser
            // 
            this.grbEser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grbEser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbEser.Controls.Add(this.btnSil);
            this.grbEser.Controls.Add(this.cbxYazarr);
            this.grbEser.Controls.Add(this.cbxTur);
            this.grbEser.Controls.Add(this.label5);
            this.grbEser.Controls.Add(this.btnEkleEserler);
            this.grbEser.Controls.Add(this.btnIptalEserler);
            this.grbEser.Controls.Add(this.txtEserBaslik);
            this.grbEser.Controls.Add(this.label4);
            this.grbEser.Controls.Add(this.label3);
            this.grbEser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbEser.Location = new System.Drawing.Point(6, 17);
            this.grbEser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbEser.Name = "grbEser";
            this.grbEser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbEser.Size = new System.Drawing.Size(412, 479);
            this.grbEser.TabIndex = 0;
            this.grbEser.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(271, 256);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(93, 49);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "SIL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cbxYazarr
            // 
            this.cbxYazarr.FormattingEnabled = true;
            this.cbxYazarr.Location = new System.Drawing.Point(123, 82);
            this.cbxYazarr.Name = "cbxYazarr";
            this.cbxYazarr.Size = new System.Drawing.Size(241, 24);
            this.cbxYazarr.TabIndex = 9;
            // 
            // cbxTur
            // 
            this.cbxTur.FormattingEnabled = true;
            this.cbxTur.Location = new System.Drawing.Point(28, 197);
            this.cbxTur.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTur.Name = "cbxTur";
            this.cbxTur.Size = new System.Drawing.Size(336, 24);
            this.cbxTur.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Eser Türü:";
            // 
            // btnEkleEserler
            // 
            this.btnEkleEserler.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkleEserler.Location = new System.Drawing.Point(28, 256);
            this.btnEkleEserler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkleEserler.Name = "btnEkleEserler";
            this.btnEkleEserler.Size = new System.Drawing.Size(88, 49);
            this.btnEkleEserler.TabIndex = 6;
            this.btnEkleEserler.Text = "EKLE";
            this.btnEkleEserler.UseVisualStyleBackColor = true;
            this.btnEkleEserler.Click += new System.EventHandler(this.btnEkleEserler_Click);
            // 
            // btnIptalEserler
            // 
            this.btnIptalEserler.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIptalEserler.Location = new System.Drawing.Point(151, 256);
            this.btnIptalEserler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIptalEserler.Name = "btnIptalEserler";
            this.btnIptalEserler.Size = new System.Drawing.Size(93, 49);
            this.btnIptalEserler.TabIndex = 5;
            this.btnIptalEserler.Text = "IPTAL";
            this.btnIptalEserler.UseVisualStyleBackColor = true;
            this.btnIptalEserler.Click += new System.EventHandler(this.btnIptalEserler_Click);
            // 
            // txtEserBaslik
            // 
            this.txtEserBaslik.Location = new System.Drawing.Point(123, 36);
            this.txtEserBaslik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEserBaslik.Name = "txtEserBaslik";
            this.txtEserBaslik.Size = new System.Drawing.Size(241, 22);
            this.txtEserBaslik.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yazar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eser Başlık:";
            // 
            // yazarlarBindingSource
            // 
            this.yazarlarBindingSource.DataSource = typeof(YazarEserDB.Yazarlar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(943, 583);
            this.Controls.Add(this.tabYazarEserler);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Kitap Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabYazarEserler.ResumeLayout(false);
            this.tabAnasayfa.ResumeLayout(false);
            this.tabAnasayfa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabYazarlar.ResumeLayout(false);
            this.tabYazarlar.PerformLayout();
            this.gbxYazarEkle.ResumeLayout(false);
            this.gbxYazarEkle.PerformLayout();
            this.tabEserler.ResumeLayout(false);
            this.grbEser.ResumeLayout(false);
            this.grbEser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabYazarEserler;
        private System.Windows.Forms.TabPage tabAnasayfa;
        private System.Windows.Forms.TabPage tabYazarlar;
        private System.Windows.Forms.GroupBox gbxYazarEkle;
        private System.Windows.Forms.Button btnEkleYazarlar;
        private System.Windows.Forms.Button btnIptalYazarlar;
        private System.Windows.Forms.TextBox txtTamAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstYazarlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox cbxYazarlar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource yazarlarBindingSource;
        private System.Windows.Forms.ListBox lstEserler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TabPage tabEserler;
        private System.Windows.Forms.ListView lsvEserler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox grbEser;
        private System.Windows.Forms.ComboBox cbxTur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEkleEserler;
        private System.Windows.Forms.Button btnIptalEserler;
        private System.Windows.Forms.TextBox txtEserBaslik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxYazarr;
        private System.Windows.Forms.Button btnSil;
    }
}

