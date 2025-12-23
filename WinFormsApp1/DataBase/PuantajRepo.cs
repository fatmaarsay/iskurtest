using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp1.DataBase
{
    internal class PuantajRepo
    {
        private readonly DbRepository _db = new DbRepository();
        public DataTable Listele()
        {
            return _db.GetByQuery(
                @"SELECT * FROM puantaj ");
        }
    }
}
