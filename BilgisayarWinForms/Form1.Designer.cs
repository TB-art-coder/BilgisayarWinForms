
namespace BilgisayarWinForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlTipi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGHz = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudHafiza = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEkran = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSuSoğutma = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpUretimTarihi = new System.Windows.Forms.DateTimePicker();
            this.mcUretimTarihi = new System.Windows.Forms.MonthCalendar();
            this.bObjeyiOlustur = new System.Windows.Forms.Button();
            this.lbObje = new System.Windows.Forms.ListBox();
            this.rbTurkceQ = new System.Windows.Forms.RadioButton();
            this.rbTurkceF = new System.Windows.Forms.RadioButton();
            this.rbIngilizce = new System.Windows.Forms.RadioButton();
            this.rtbObje = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bObjeGoster = new System.Windows.Forms.Button();
            this.ddlKlavye = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudHafiza)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(124, 19);
            this.tbMarka.MaxLength = 100;
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(232, 20);
            this.tbMarka.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(124, 61);
            this.tbModel.MaxLength = 125;
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(232, 20);
            this.tbModel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipi";
            // 
            // ddlTipi
            // 
            this.ddlTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipi.FormattingEnabled = true;
            this.ddlTipi.Items.AddRange(new object[] {
            "Masaüstü",
            "Dİzüstü",
            "Sunucu"});
            this.ddlTipi.Location = new System.Drawing.Point(124, 106);
            this.ddlTipi.Name = "ddlTipi";
            this.ddlTipi.Size = new System.Drawing.Size(232, 21);
            this.ddlTipi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "GHz";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbGHz
            // 
            this.tbGHz.Location = new System.Drawing.Point(124, 149);
            this.tbGHz.Name = "tbGHz";
            this.tbGHz.Size = new System.Drawing.Size(232, 20);
            this.tbGHz.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hafıza";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // nudHafiza
            // 
            this.nudHafiza.Location = new System.Drawing.Point(124, 192);
            this.nudHafiza.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudHafiza.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHafiza.Name = "nudHafiza";
            this.nudHafiza.Size = new System.Drawing.Size(232, 20);
            this.nudHafiza.TabIndex = 6;
            this.nudHafiza.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ekran";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbEkran
            // 
            this.tbEkran.Location = new System.Drawing.Point(124, 229);
            this.tbEkran.Name = "tbEkran";
            this.tbEkran.Size = new System.Drawing.Size(232, 20);
            this.tbEkran.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "SuSoğutma";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbSuSoğutma
            // 
            this.cbSuSoğutma.AutoSize = true;
            this.cbSuSoğutma.Location = new System.Drawing.Point(124, 264);
            this.cbSuSoğutma.Name = "cbSuSoğutma";
            this.cbSuSoğutma.Size = new System.Drawing.Size(88, 17);
            this.cbSuSoğutma.TabIndex = 8;
            this.cbSuSoğutma.Text = "Su Soğutmalı";
            this.cbSuSoğutma.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Klavye";
            this.label8.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtpUretimTarihi
            // 
            this.dtpUretimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUretimTarihi.Location = new System.Drawing.Point(124, 304);
            this.dtpUretimTarihi.Name = "dtpUretimTarihi";
            this.dtpUretimTarihi.Size = new System.Drawing.Size(242, 20);
            this.dtpUretimTarihi.TabIndex = 9;
            // 
            // mcUretimTarihi
            // 
            this.mcUretimTarihi.Location = new System.Drawing.Point(652, 22);
            this.mcUretimTarihi.Name = "mcUretimTarihi";
            this.mcUretimTarihi.TabIndex = 10;
            // 
            // bObjeyiOlustur
            // 
            this.bObjeyiOlustur.Location = new System.Drawing.Point(124, 457);
            this.bObjeyiOlustur.Name = "bObjeyiOlustur";
            this.bObjeyiOlustur.Size = new System.Drawing.Size(110, 27);
            this.bObjeyiOlustur.TabIndex = 11;
            this.bObjeyiOlustur.Text = "Objeyi Oluştur";
            this.bObjeyiOlustur.UseVisualStyleBackColor = true;
            this.bObjeyiOlustur.Click += new System.EventHandler(this.bObjeyiOlustur_Click);
            // 
            // lbObje
            // 
            this.lbObje.FormattingEnabled = true;
            this.lbObje.Location = new System.Drawing.Point(703, 446);
            this.lbObje.Name = "lbObje";
            this.lbObje.Size = new System.Drawing.Size(165, 147);
            this.lbObje.TabIndex = 12;
            // 
            // rbTurkceQ
            // 
            this.rbTurkceQ.AutoSize = true;
            this.rbTurkceQ.Location = new System.Drawing.Point(124, 360);
            this.rbTurkceQ.Name = "rbTurkceQ";
            this.rbTurkceQ.Size = new System.Drawing.Size(105, 17);
            this.rbTurkceQ.TabIndex = 13;
            this.rbTurkceQ.TabStop = true;
            this.rbTurkceQ.Text = "Türkçe Q Klavye";
            this.rbTurkceQ.UseVisualStyleBackColor = true;
            // 
            // rbTurkceF
            // 
            this.rbTurkceF.AutoSize = true;
            this.rbTurkceF.Location = new System.Drawing.Point(261, 360);
            this.rbTurkceF.Name = "rbTurkceF";
            this.rbTurkceF.Size = new System.Drawing.Size(103, 17);
            this.rbTurkceF.TabIndex = 14;
            this.rbTurkceF.TabStop = true;
            this.rbTurkceF.Text = "Türkçe F Klavye";
            this.rbTurkceF.UseVisualStyleBackColor = true;
            // 
            // rbIngilizce
            // 
            this.rbIngilizce.AutoSize = true;
            this.rbIngilizce.Location = new System.Drawing.Point(401, 358);
            this.rbIngilizce.Name = "rbIngilizce";
            this.rbIngilizce.Size = new System.Drawing.Size(98, 17);
            this.rbIngilizce.TabIndex = 15;
            this.rbIngilizce.TabStop = true;
            this.rbIngilizce.Text = "İngilizce Klavye";
            this.rbIngilizce.UseVisualStyleBackColor = true;
            // 
            // rtbObje
            // 
            this.rtbObje.Location = new System.Drawing.Point(124, 501);
            this.rtbObje.Name = "rtbObje";
            this.rtbObje.Size = new System.Drawing.Size(242, 173);
            this.rtbObje.TabIndex = 16;
            this.rtbObje.Text = "";
            this.rtbObje.TextChanged += new System.EventHandler(this.rtbObje_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(768, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // bObjeGoster
            // 
            this.bObjeGoster.Location = new System.Drawing.Point(254, 457);
            this.bObjeGoster.Name = "bObjeGoster";
            this.bObjeGoster.Size = new System.Drawing.Size(110, 27);
            this.bObjeGoster.TabIndex = 11;
            this.bObjeGoster.Text = "Objeyi Göster";
            this.bObjeGoster.UseVisualStyleBackColor = true;
            this.bObjeGoster.Click += new System.EventHandler(this.bObjeGoster_Click);
            // 
            // ddlKlavye
            // 
            this.ddlKlavye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlKlavye.FormattingEnabled = true;
            this.ddlKlavye.Location = new System.Drawing.Point(124, 395);
            this.ddlKlavye.Name = "ddlKlavye";
            this.ddlKlavye.Size = new System.Drawing.Size(232, 21);
            this.ddlKlavye.TabIndex = 18;
            this.ddlKlavye.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(880, 649);
            this.Controls.Add(this.ddlKlavye);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rtbObje);
            this.Controls.Add(this.rbIngilizce);
            this.Controls.Add(this.rbTurkceF);
            this.Controls.Add(this.rbTurkceQ);
            this.Controls.Add(this.lbObje);
            this.Controls.Add(this.bObjeGoster);
            this.Controls.Add(this.bObjeyiOlustur);
            this.Controls.Add(this.mcUretimTarihi);
            this.Controls.Add(this.dtpUretimTarihi);
            this.Controls.Add(this.cbSuSoğutma);
            this.Controls.Add(this.tbEkran);
            this.Controls.Add(this.nudHafiza);
            this.Controls.Add(this.tbGHz);
            this.Controls.Add(this.ddlTipi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BilgisayarApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.nudHafiza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlTipi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGHz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudHafiza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEkran;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbSuSoğutma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpUretimTarihi;
        private System.Windows.Forms.MonthCalendar mcUretimTarihi;
        private System.Windows.Forms.Button bObjeyiOlustur;
        private System.Windows.Forms.ListBox lbObje;
        private System.Windows.Forms.RadioButton rbTurkceQ;
        private System.Windows.Forms.RadioButton rbTurkceF;
        private System.Windows.Forms.RadioButton rbIngilizce;
        private System.Windows.Forms.RichTextBox rtbObje;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bObjeGoster;
        private System.Windows.Forms.ComboBox ddlKlavye;
    }
}

