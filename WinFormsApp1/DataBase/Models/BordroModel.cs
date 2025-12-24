using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.DataBase.Models
{
    internal class BordroModel
    {
        int bdr_id,bdr_aylik_calisilan_gun;
        String bdr_tc, bdr_ad_soyad, bdr_gorev_yeri;
        float bdr_cep_harcligi, bdr_sosyal_guvenlik_primi, bdr_tahakkuk_toplami, 
            bdr_gelir_vergisi_matrahi, bdr_hesaplanan_gelir_vergisi, bdr_gv_istisna_tutari,
            bdr_hesaplanan_damga_vergisi, bdr_dv_istisna_tutari, bdr_damga_vergisi_kesintisi, 
            bdr_gssp_kvsk, bdr_icra_kesintisi, bdr_toplam_kesinti, bdr_net_odenek;

        public float Bdr_cep_harcligi { get => bdr_cep_harcligi; set => bdr_cep_harcligi = value; }
        public float Bdr_sosyal_guvenlik_primi { get => bdr_sosyal_guvenlik_primi; set => bdr_sosyal_guvenlik_primi = value; }
        public float Bdr_tahakkuk_toplami { get => bdr_tahakkuk_toplami; set => bdr_tahakkuk_toplami = value; }
        public float Bdr_gelir_vergisi_matrahi { get => bdr_gelir_vergisi_matrahi; set => bdr_gelir_vergisi_matrahi = value; }
        public float Bdr_hesaplanan_gelir_vergisi { get => bdr_hesaplanan_gelir_vergisi; set => bdr_hesaplanan_gelir_vergisi = value; }
        public float Bdr_gv_istisna_tutari { get => bdr_gv_istisna_tutari; set => bdr_gv_istisna_tutari = value; }
        public float Bdr_hesaplanan_damga_vergisi { get => bdr_hesaplanan_damga_vergisi; set => bdr_hesaplanan_damga_vergisi = value; }
        public float Bdr_dv_istisna_tutari { get => bdr_dv_istisna_tutari; set => bdr_dv_istisna_tutari = value; }
        public float Bdr_damga_vergisi_kesintisi { get => bdr_damga_vergisi_kesintisi; set => bdr_damga_vergisi_kesintisi = value; }
        public float Bdr_gssp_kvsk { get => bdr_gssp_kvsk; set => bdr_gssp_kvsk = value; }
        public float Bdr_icra_kesintisi { get => bdr_icra_kesintisi; set => bdr_icra_kesintisi = value; }
        public float Bdr_toplam_kesinti { get => bdr_toplam_kesinti; set => bdr_toplam_kesinti = value; }
        public float Bdr_net_odenek { get => bdr_net_odenek; set => bdr_net_odenek = value; }
        public int Bdr_id { get => bdr_id; set => bdr_id = value; }
        public int Bdr_aylik_calisilan_gun { get => bdr_aylik_calisilan_gun; set => bdr_aylik_calisilan_gun = value; }
        public string Bdr_tc { get => bdr_tc; set => bdr_tc = value; }
        public string Bdr_ad_soyad { get => bdr_ad_soyad; set => bdr_ad_soyad = value; }
        public string Bdr_gorev_yeri { get => bdr_gorev_yeri; set => bdr_gorev_yeri = value; }
    }
}
