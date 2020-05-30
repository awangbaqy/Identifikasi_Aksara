using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Identifikasi_Aksara
{
    public partial class FormTraining : Form
    {
        private ButtonCode bc = new ButtonCode();

        public FormTraining()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            List<PictureBox> pbs = Controls.OfType<PictureBox>().ToList();
            List<TextBox> tbs = Controls.OfType<TextBox>().ToList();

            bc.Input(pbs, tbs, pbAksara);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            List<PictureBox> pbs = Controls.OfType<PictureBox>().ToList();

            bc.Pre(pbs);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            bc.Process(pbThinning, tbChaincode);
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            bc.Training(tbIterasi.Text.Trim(), tbChaincode.Text.Trim());
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            bc.Simpan(pbThinning);
        }

        private void tbIterasi_Leave(object sender, EventArgs e)
        {
            string str = tbIterasi.Text.Trim();

            if (!Regex.IsMatch(str, @"^[A-Z]+$") || str == "")
            {
                tbIterasi.Text = "-";
            }
        }
    }
}
