using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgisayarWinForms.Models
{
    public class Bilgisayar
    {
        public int Id { get; set; }
        public  string Marka { get; set; }
        public string Model { get; set; }
        //public int Tipi { get; set; } //1: masaüstü, 2:dizüstü, 3:sunucu
        public BilgisayarTipi Tipi { get; set; }
        public double GHz { get; set; }
        public short Hafıza { get; set; }
        public double EkranBoyutu { get; set; }
        public bool SuSuğutmalıMı { get; set; }
        public string SuSogutma
        { 
            get
            {
                return SuSuğutmalıMı ? "Var" : "Yok";
            }
             
        }
        public DateTime UretimTarihi { get; set; }

        public Klavye Klavye { get; set; }
        public string[] Klavyeler { get; set; } = new string[3] { "Türkçe Q Klavye", "Türkçe F Klavye", "İngilizce Klavye" };
        public int KlavyelerIndex { get; set; }
    }
}
