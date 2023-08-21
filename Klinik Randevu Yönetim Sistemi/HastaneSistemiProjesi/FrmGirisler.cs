using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneSistemiProjesi
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void BtnHastaGirisi_Click(object sender, EventArgs e)
        {
            FrmYoneticiGiris fr = new FrmYoneticiGiris();
            fr.Show();
            this.Hide();

        }

        private void BtnDoktorGirisi_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris fr= new FrmDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnnSekreterGirisi_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris fr=new FrmSekreterGiris();
            fr.Show();
            this.Hide();
        }

        private void FrmGirisler_Load(object sender, EventArgs e)
        {

        }
    }
}
