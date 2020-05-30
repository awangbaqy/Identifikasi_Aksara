using System.Drawing;
using System.Windows.Forms;

namespace Identifikasi_Aksara
{
    public partial class FormAksara : Form
    {
        public FormAksara(int i, Bitmap bit, string cc)
        {
            InitializeComponent();

            Text = "Aksara " + i;
            pbAksara.Image = bit;
            tbAksara.Text = cc;
        }
    }
}
