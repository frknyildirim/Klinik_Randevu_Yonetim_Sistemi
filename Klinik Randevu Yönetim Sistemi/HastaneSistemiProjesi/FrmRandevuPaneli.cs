using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneSistemiProjesi
{
    public partial class FrmRandevuPaneli : Form
    {
        public FrmRandevuPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //branşları comboboxa çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();

        }

        private void BtnRandevuOlustur_Click_1(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,HastaTC,HastaAdiSoyadi,HastaNumara,HastaSikayet) values (@r1,@r2,@r3,@r4,@r5,@r6,@r7,@r8)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", MskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", CmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", CmbDoktor.Text);
            komutkaydet.Parameters.AddWithValue("@r5", MskTC.Text);
            komutkaydet.Parameters.AddWithValue("@r6", TxtAdSoyad.Text);
            komutkaydet.Parameters.AddWithValue("@r7", TxtNumara.Text);
            komutkaydet.Parameters.AddWithValue("@r8", RchSikayet.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu oluşturuldu");
        }

        private void CmbBrans_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            MskTarih.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            MskSaat.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            CmbDoktor.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            ChkDurum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            MskTC.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtAdSoyad.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            TxtNumara.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            RchSikayet.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString(); 
        }

        private void BtnRandevuGuncelle_Click_1(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update Tbl_Randevular set RandevuTarih=@p2,RandevuSaat=@p3,RandevuBrans=@p4,RandevuDoktor=@p5,RandevuDurum=@p6,HastaTC=@p7,HastaAdiSoyadi=@p8,HastaNumara=@p9,HastaSikayet=@p10 where Randevuid=@p1",bgl.baglanti());

            

            guncelle.Parameters.AddWithValue("@p1", Txtid.Text);
            guncelle.Parameters.AddWithValue("@p2", MskTarih.Text);
            guncelle.Parameters.AddWithValue("@p3", MskSaat.Text);
            guncelle.Parameters.AddWithValue("@p4", CmbBrans.Text);
            guncelle.Parameters.AddWithValue("@p5", CmbDoktor.Text);
            guncelle.Parameters.AddWithValue("@p6", ChkDurum.Checked);
            guncelle.Parameters.AddWithValue("@p7", MskTC.Text);
            guncelle.Parameters.AddWithValue("@p8", TxtAdSoyad.Text);
            guncelle.Parameters.AddWithValue("@p9", TxtNumara.Text);
            guncelle.Parameters.AddWithValue("@p10", RchSikayet.Text);

            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
