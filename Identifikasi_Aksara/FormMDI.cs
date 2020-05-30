using System;
using System.Windows.Forms;

namespace Identifikasi_Aksara
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void trainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTraining ft = new FormTraining();
            ft.Show();
            ft.MdiParent = this;
        }

        private void testingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTesting ft = new FormTesting();
            ft.Show();
            ft.MdiParent = this;
        }

        private void aksaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompact f2 = new FormCompact();
            f2.Show();
            f2.MdiParent = this;
        }

        private void tembungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTembung ft = new FormTembung();
            ft.Show();
            ft.MdiParent = this;
        }
    }
}
