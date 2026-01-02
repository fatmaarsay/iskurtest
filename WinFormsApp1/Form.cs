using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IskurTakipSistemi.DataBase;
using IskurTakipSistemi.DataBase.Repos;

namespace IskurTakipSistemi
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var repo = new PuantajRepo();
            dataGridView.DataSource = repo.Listele();
        }
    }
}
