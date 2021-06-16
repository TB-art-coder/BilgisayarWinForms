using BilgisayarWinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgisayarWinForms
{
    public partial class Form1 : Form
    {
        Bilgisayar bilgisayar; //global değişken
        string mesaj = "Test Mesaj";
        string[] klavyeler; // global değişken
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ddlTipi.SelectedIndex = 0;
            tbMarka.Text = "Asus";
            rbTurkceQ.Checked = true;
            //ddlKlavye.Items.Add("Türkçe Q Klavye");
            //ddlKlavye.Items.Add("Türkçe F Klavye");
            //ddlKlavye.Items.Add("İngilizce Klavye");
            klavyeler = new string[] { "Türkçe Q", "Türkçe F", "İngilizce" };
            ddlKlavye.Items.AddRange(klavyeler);
            ddlKlavye.SelectedIndex = 2;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("From clicked");
        }

        private void bObjeyiOlustur_Click(object sender, EventArgs e)
        {
            Bilgisayar bilgisayar = new Bilgisayar() // local değişken
            {
                Id = 1,
                Marka = tbMarka.Text,
                Model = tbModel.Text,
                Tipi = (BilgisayarTipi)ddlTipi.SelectedIndex,
                GHz = Convert.ToDouble(tbGHz.Text),
                //Hafıza = short.Parse(nudHafiza.Value.ToString()),
                Hafıza = Convert.ToInt16(nudHafiza.Value),
                EkranBoyutu = double.Parse(tbEkran.Text),
                SuSuğutmalıMı = cbSuSoğutma.Checked,
                UretimTarihi = dtpUretimTarihi.Value,
                Klavye = rbTurkceQ.Checked ? Klavye.TürkçeQ : (rbTurkceF.Checked ? Klavye.TürkçeF : Klavye.İngilizce)

                

            };

            //Klavye klavye = Klavye.İngilizce;
            //if (rbTurkceQ.Checked)
            //    klavye = Klavye.TürkçeQ;
            //else if (rbTurkceF.Checked)
            //    klavye = Klavye.TürkçeF;
            //bilgisayar.Klavye = klavye;
            MessageBox.Show("Bilgisayar Oluşturuldu");

        }

        private void rtbObje_TextChanged(object sender, EventArgs e)
        {

        }

        private void bObjeGoster_Click(object sender, EventArgs e)
        {
            string sonuc = "";
            string asusDisplay = "";
            asusDisplay += "ID: " + bilgisayar.Id + "\n";
            asusDisplay += "Marka: " + bilgisayar.Marka + "\n";
            asusDisplay += "Model: " + bilgisayar.Model + "\n";
            asusDisplay += "Tipi: " + bilgisayar.Tipi + "(" + (int)bilgisayar.Tipi + ")\n";
            asusDisplay += "Hızı" + bilgisayar.GHz.ToString(new CultureInfo("en")) + " GHz\n";
            asusDisplay += "Hafıza: " + bilgisayar.Hafıza + "GB\n";
            asusDisplay += "Ekran: " + bilgisayar.EkranBoyutu + "inç\n";
            //if (bilgisayar.SuSuğutmalıMı == true)
            // asusDisplay += "Su Soğutma: Var"  + "\n";
            //else
            //    asusDisplay += "Su Soğutma: Yok" + "\n";
            //asusDisplay += bilgisayar.SuSuğutmalıMı ? "Su Soğutma: Var" : "Su Suğutma: yok";
            asusDisplay += "Su Soğutma: " + bilgisayar.SuSogutma + "\n";
            asusDisplay += "Üretim Tarihi: " + bilgisayar.UretimTarihi.ToShortDateString()+ "\n";
            sonuc += "Klavye" + bilgisayar.Klavye;
            sonuc += "Klavye: " + bilgisayar.Klavye + "\n";
            sonuc += "Klavye: " + klavyeler[bilgisayar.KlavyelerIndex];
            rtbObje.Text = sonuc;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(ddlKlavye.SelectedIndex.ToString() + "- " + ddlKlavye.Items[ddlKlavye.SelectedIndex]);
        }
    }
}
