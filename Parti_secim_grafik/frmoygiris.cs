﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Parti_secim_grafik
{
    public partial class frmoygiris : Form
    {
        public frmoygiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RE91BPD\SQLEXPRESS;Initial Catalog=DBSECIM;Integrated Security=True");
        private void btnoy_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CAPARTI,DPARTI,EPARTI) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txta.Text);
            komut.Parameters.AddWithValue("@p3", txtb.Text);
            komut.Parameters.AddWithValue("@p4", txtc.Text);
            komut.Parameters.AddWithValue("@p5", txtd.Text);
            komut.Parameters.AddWithValue("@p6", txte.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti");
        }

        private void btnist_Click(object sender, EventArgs e)
        {
            frmgrafikler fr = new frmgrafikler();
            fr.Show();

        }
    }
}
