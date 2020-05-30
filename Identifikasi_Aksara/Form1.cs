using System;
using System.Windows.Forms;

namespace Identifikasi_Aksara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            FormTraining ft = new FormTraining();
            Hide();
            ft.ShowDialog();
            Show();
        }

        private void btnTesting_Click(object sender, EventArgs e)
        {
            FormTesting ft = new FormTesting();
            Hide();
            ft.ShowDialog();
            Show();
        }
    }
}
