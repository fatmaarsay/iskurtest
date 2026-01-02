using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.DataBase;
using WinFormsApp1.DataBase.Repos;

namespace WinFormsApp1
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
