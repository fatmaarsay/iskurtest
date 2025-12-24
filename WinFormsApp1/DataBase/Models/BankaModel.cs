using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.DataBase.Models
{
    internal class BankaModel
    {
        int bnk_id;
        string bnk_iban,bnk_ad_soyad,bnk_tc,bnk_aciklama;
        float bnk_tutar;

        public int Bnk_id { get => bnk_id; set => bnk_id = value; }
        public string Bnk_iban { get => bnk_iban; set => bnk_iban = value; }
        public string Bnk_ad_soyad { get => bnk_ad_soyad; set => bnk_ad_soyad = value; }
        public string Bnk_tc { get => bnk_tc; set => bnk_tc = value; }
        public string Bnk_aciklama { get => bnk_aciklama; set => bnk_aciklama = value; }
        public float Bnk_tutar { get => bnk_tutar; set => bnk_tutar = value; }
    }
}
