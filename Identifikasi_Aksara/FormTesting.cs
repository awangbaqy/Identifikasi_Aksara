using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Identifikasi_Aksara
{
    public partial class FormTesting : Form
    {
        private ButtonCode bc = new ButtonCode();

        public FormTesting()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, System.EventArgs e)
        {
            List<PictureBox> pbs = Controls.OfType<PictureBox>().ToList();
            List<TextBox> tbs = Controls.OfType<TextBox>().ToList();

            bc.Input(pbs, tbs, pbAksara);
        }

        private void btnPre_Click(object sender, System.EventArgs e)
        {
            List<PictureBox> pbs = Controls.OfType<PictureBox>().ToList();

            bc.Pre(pbs);
        }

        private void btnProcess_Click(object sender, System.EventArgs e)
        {
            bc.Process(pbThinning, tbChaincode);
        }

        private void btnClassification_Click(object sender, System.EventArgs e)
        {
            tbClassification.Text = bc.Classification(tbChaincode.Text, cbNilaiK.Text);
        }
    }
}
