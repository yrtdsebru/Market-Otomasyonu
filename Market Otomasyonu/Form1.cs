﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market_Otomasyonu.Entity;

namespace Market_Otomasyonu
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) => new Context().Database.Create();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Uygulamamız yapım aşamasındadır.");

        }

        private void btnStokIslemleri_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Uygulamamız yapım aşamasındadır.");
        }
       
        private void button3_Click(object sender, EventArgs e)
        {  

        }

        private void btnSatisListesi_Click(object sender, EventArgs e)
        {

        }


        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulamamız yapım aşamasındadır.");
        }
    }
}
