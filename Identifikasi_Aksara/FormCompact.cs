using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Identifikasi_Aksara
{
    public partial class FormCompact : Form
    {
        private ButtonCode bc = new ButtonCode();

        public FormCompact()
        {
            InitializeComponent();

            tbChaincode.Text = "-";
            tbIterasi.Text = "-";
            cbNilaiK.SelectedIndex = 0;
            tbClassification.Text = "-";
        }

        private void pbAksara_Click(object sender, EventArgs e)
        {
            List<PictureBox> pbs = Controls.OfType<PictureBox>().ToList();
            List<TextBox> tbs = Controls.OfType<TextBox>().ToList();

            bc.Input(pbs, tbs, pbAksara);

            if (pbAksara.Image != null)
            {
                bc.Pre(pbs);
                bc.Process(pbThinning, tbChaincode);
            }
        }

        private void tbIterasi_Enter(object sender, EventArgs e)
        {
            if (tbIterasi.Text == "-")
            {
                tbIterasi.Text = "";
            }
        }

        private void tbIterasi_Leave(object sender, EventArgs e)
        {
            string str = tbIterasi.Text.Trim();

            if (!Regex.IsMatch(str, @"^[A-Z]+$") || str == "")
            {
                tbIterasi.Text = "-";
            }
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            tbClassification.Text = "-";
            bc.Training(tbIterasi.Text.Trim(), tbChaincode.Text.Trim());
        }

        private void btnClassification_Click(object sender, EventArgs e)
        {
            tbClassification.Text = bc.Classification(tbChaincode.Text, cbNilaiK.Text);
        }
    }
}
