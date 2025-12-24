using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace WinFormsApp1.DataBase.Repos
{
    internal class KatilimciRepo
    {
        private readonly DbRepository _db = new DbRepository();

        public DataTable Listele()
        {
            return _db.GetByQuery(
                @"SELECT * FROM program_katilimcilari ");
        }
        public void Ekle(double tc_no, String ad_soyad, String iban_no, String gorev_yeri, DateTime ise_giris_tarihi, DateTime isten_cikis_tarihi)
        {
            _db.Execute(
               @"INSERT INTO program_katilimcilari " +
                "(pk_tc, pk_ad_soyad, pk_iban,pk_gorev_yeri, pk_ise_baslama_tarihi,pk_isten_ayrilma_tarihi)" +
                "VALUES @tc, @adsoyad, @iban,@gorevyeri, @isebaslama,@istenayrilma");
            new MySqlParameter("@tc",tc_no);
            new MySqlParameter("@adsoyad", ad_soyad);
            new MySqlParameter("@iban", iban_no);
            new MySqlParameter("@gorevyeri", gorev_yeri);
            new MySqlParameter("@isebaslama", ise_giris_tarihi);
            new MySqlParameter("@istenayrilma", isten_cikis_tarihi);

        }
        public void Sil()
        {

        }
    }
}
