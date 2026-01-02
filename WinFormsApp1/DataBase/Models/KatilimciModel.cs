using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.DataBase.Models
{
    internal class KatilimciModel
    {
        int ktc_id;
        string ktc_tc, ktc_ad_soyad, ktc_gorev_yeri, ktc_iban;
        DateTime ktc_ise_baslama_tarihi, ktc_isten_cikma_tarihi;

        public int Ktc_id { get => ktc_id; set => ktc_id = value; }
        public string Ktc_tc { get => ktc_tc; set => ktc_tc = value; }
        public string Ktc_ad_soyad { get => ktc_ad_soyad; set => ktc_ad_soyad = value; }
        public string Ktc_gorev_yeri { get => ktc_gorev_yeri; set => ktc_gorev_yeri = value; }
        public DateTime Ktc_ise_baslama_tarihi { get => ktc_ise_baslama_tarihi; set => ktc_ise_baslama_tarihi = value; }
        public DateTime Ktc_isten_cikma_tarihi { get => ktc_isten_cikma_tarihi; set => ktc_isten_cikma_tarihi = value; }
        public string Ktc_iban { get => ktc_iban; set => ktc_iban = value; }
    }
}
