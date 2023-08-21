using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneSistemiProjesi
{
    public partial class FrmSekreterPaneli : Form
    {
        public FrmSekreterPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmSekreterPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Tbl_Sekreterler", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            bgl.baglanti().Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Sekreterler (SekreterAdSoyad,SekreterTC,SekreterSifre) values (@d1,@d2,@d3)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@d2", MskTC.Text);
            komut.Parameters.AddWithValue("@d3", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Sekreter Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAdSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            MskTC.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Sekreterler where SekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Sekreterler set SekreterAdSoyad=@d1,SekreterSifre=@d3 where SekreterTC=@d2", bgl.baglanti());

            komut.Parameters.AddWithValue("@d1", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@d2", MskTC.Text);
            komut.Parameters.AddWithValue("@d3", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Sekreter Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
