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
    public partial class frmgrafikler : Form
    {
        public frmgrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RE91BPD\SQLEXPRESS;Initial Catalog=DBSECIM;Integrated Security=True");
        private void frmgrafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select ILCEAD from TBLILCE", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select SUM(APARTI),SUM(BPARTI),SUM(CAPARTI),SUM(DPARTI),SUM(EPARTI) FROM TBLILCE", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTİ", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTİ", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C PARTİ", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D PARTİ", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E PARTİ", dr2[4]);
            }
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * FROM TBLILCE where ILCEAD=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                progressBara.Value = int.Parse(dr[2].ToString());
                progressBarb.Value = int.Parse(dr[3].ToString());
                progressBarc.Value = int.Parse(dr[4].ToString());
                progressBard.Value = int.Parse(dr[5].ToString());
                progressBare.Value = int.Parse(dr[6].ToString());

                lbla.Text = dr[2].ToString();
                lblb.Text = dr[3].ToString();
                lblc.Text = dr[4].ToString();
                lbld.Text = dr[5].ToString();
                lble.Text = dr[6].ToString();
            }
            baglanti.Close();

        }
    }
}
