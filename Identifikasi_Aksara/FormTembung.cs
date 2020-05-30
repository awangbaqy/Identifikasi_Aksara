using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Identifikasi_Aksara
{
    public partial class FormTembung : Form
    {
        private ButtonCode bc = new ButtonCode();
        private Dictionary<Bitmap, string> list_aksara = new Dictionary<Bitmap, string>();
        private Bitmap bitmap, copy;
        private Color c;
        private Graphics g;
        private ImageProcessing ip = new ImageProcessing();
        private Rectangle cropRectangle;

        private bool white;
        private int kiri, kanan, hitung, taling, tarung;
        private string cc, tembung, aksara, harakat;

        public FormTembung()
        {
            InitializeComponent();

            cbNilaiK.SelectedIndex = 0;
            tbClassification.Text = "-";
            toolStripProgressBar1.Visible = false;
        }

        private void pbAksara_Click(object sender, EventArgs e)
        {
            List<PictureBox> pbs = Controls.OfType<PictureBox>().ToList();
            List<TextBox> tbs = Controls.OfType<TextBox>().ToList();

            bc.Input(pbs, tbs, pbAksara);

            cariAksara();
        }

        private void cbNilaiK_SelectedIndexChanged(object sender, EventArgs e)
        {
            cariAksara();
        }

        private void cariAksara()
        {
            if (pbAksara.Image != null)
            {
                list_aksara.Clear();
                copy = new Bitmap((Bitmap)pbAksara.Image);
                copy = ip.PreProcessing(copy, 0);
                pbGrayscale.Image = copy;
                copy = ip.PreProcessing(copy, 1);
                pbBiner.Image = copy;
                kiri = kanan = copy.Width;
                cc = "";
                tembung = "";
                aksara = "";

                toolStripProgressBar1.Visible = true;

                for (int i = 0; i < copy.Width; i++)
                {
                    white = false;

                    for (int j = 0; j < copy.Height; j++)
                    {
                        c = copy.GetPixel(i, j);

                        if (!(c.R == 255 && c.G == 255 && c.B == 255))
                        {
                            white = true;

                            if (i < kiri)
                            {
                                kiri = i;
                            }
                            else if (i > kiri)
                            {
                                kanan = i;
                            }
                        }
                    }

                    if (!white && (kiri != copy.Width || kanan != copy.Width))
                    {
                        cropRectangle = new Rectangle(kiri, 0, kanan - kiri, copy.Height);
                        bitmap = new Bitmap(cropRectangle.Width, cropRectangle.Height);
                        g = Graphics.FromImage(bitmap);
                        g.DrawImage(copy, 0, 0, cropRectangle, GraphicsUnit.Pixel);

                        bitmap = ip.PreProcessing_Cropping(bitmap);
                        bitmap = ip.PreProcessing_Thinning(bitmap);

                        cc = ip.ChainCode(bitmap);
                        aksara = bc.Classification(cc, cbNilaiK.Text);
                        tembung += aksara;

                        list_aksara.Add(bitmap, aksara);

                        kiri = kanan = copy.Width;
                    }

                    toolStripProgressBar1.Value = 100 * (i + 1) / copy.Width;
                }

                if (tembung.Contains("TALING"))
                {
                    taling = tembung.IndexOf("TALING");

                    if (tembung.Contains("TARUNG"))
                    {
                        tarung = tembung.IndexOf("TARUNG");

                        harakat = tembung.Substring(taling + 6, tarung - (taling + 6));

                        harakat = Regex.Replace(harakat, @"[AIUE]", "O");

                        tembung = tembung.Remove(taling, (tarung - taling) + 6);

                        tembung = tembung.Insert(taling, harakat);
                    }
                    else
                    {
                        harakat = tembung.Substring(taling + 6);

                        harakat = Regex.Replace(harakat, @"[AIUO].+", "E");

                        tembung = tembung.Remove(taling, 6 + harakat.Length);

                        tembung = tembung.Insert(taling, harakat);
                    }
                }

                tbClassification.Text = tembung;

                toolStripProgressBar1.Visible = false;
            }
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            if (list_aksara.Count == 0)
            {
                MessageBox.Show("Belum ada aksara yang tersimpan!");
            }
            else
            {
                hitung = 1;
                foreach (KeyValuePair<Bitmap, string> aksara in list_aksara)
                {
                    FormAksara fa = new FormAksara(hitung++, aksara.Key, aksara.Value);
                    fa.Show(); fa.MdiParent = MdiParent;
                }
            };
        }
    }
}
