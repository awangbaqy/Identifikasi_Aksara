using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Identifikasi_Aksara
{
    internal class ButtonCode
    {
        private ImageProcessing ip = new ImageProcessing();
        private readonly string koneksi = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = A:\\My Documents\\Coding\\C#\\Identifikasi_Aksara\\Identifikasi_Aksara\\dbAksara.accdb";
        private string sql = "";

        internal void Input(List<PictureBox> pbs, List<TextBox> tbs, PictureBox pb)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "Image File (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png"
            };

            if (DialogResult.OK == openFile.ShowDialog())
            {
                pbs.ForEach(p => p.Image = null);
                tbs.ForEach(t => t.Text = "-");

                pb.Image = new Bitmap(openFile.FileName);
            }
        }

        internal void Pre(List<PictureBox> pbs)
        {
            PictureBox pb0 = pbs.Find(x => x.Name == "pbAksara");
            PictureBox pb1 = pbs.Find(x => x.Name == "pbGrayscale");
            PictureBox pb2 = pbs.Find(x => x.Name == "pbBiner");
            PictureBox pb3 = pbs.Find(x => x.Name == "pbCrop");
            PictureBox pb4 = pbs.Find(x => x.Name == "pbThinning");

            pb1.Image = ip.PreProcessing((Bitmap)pb0.Image, 0);
            pb2.Image = ip.PreProcessing((Bitmap)pb1.Image, 1);
            pb3.Image = ip.PreProcessing_Cropping((Bitmap)pb2.Image);
            pb4.Image = ip.PreProcessing_Thinning((Bitmap)pb3.Image);
        }

        internal void Process(PictureBox pb, TextBox tb)
        {
            if (pb == null)
            { MessageBox.Show("Tidak ada gambar!"); }
            else
            { tb.Text = ip.ChainCode((Bitmap)pb.Image); }
        }

        internal void Training(string iterasi, string cc)
        {
            if (iterasi == "-" || cc == "-")
            { MessageBox.Show("Harap isi Teksboks denga BENAR!"); }
            else
            {
                sql = string.Format("select * from chain_aksara where chaincode = '" + cc + "' and aksara = '" + iterasi + "' ");
                OleDbConnection conn = new OleDbConnection(koneksi);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                OleDbDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Data Training TELAH Tersimpan!");

                    conn.Close();
                }
                else
                {
                    conn.Close();

                    try
                    {
                        sql = string.Format("insert into chain_aksara (aksara, chaincode) VALUES('{0}', '{1}')", iterasi, cc);
                        conn = new OleDbConnection(koneksi);
                        conn.Open();
                        cmd = new OleDbCommand(sql, conn);

                        if (cmd.ExecuteNonQuery() == 1)
                        { MessageBox.Show("Data Training BERHASIL Disimpan!"); }
                        else
                        { MessageBox.Show("Data Training GAGAL Disimpan!"); }

                        conn.Close();
                    }
                    catch (OleDbException ole)
                    {
                        MessageBox.Show("Error: " + ole.ToString());
                        throw;
                    }
                }
            }
        }

        internal void Simpan(PictureBox pb)
        {
            if (pb.Image == null)
            {
                MessageBox.Show("Tidak Ada citra yang akan disimpan!");
            }
            else
            {
                SaveFileDialog simpanFile = new SaveFileDialog
                {
                    Title = "Simpan File Citra",
                    Filter = "Image File (*.bmp, *.jpg, *.jpeg)| *.bmp; *.jpg; *.jpeg"
                };

                if (DialogResult.OK == simpanFile.ShowDialog())
                {
                    pb.Image.Save(simpanFile.FileName);
                }
            }
        }

        internal string Classification(string cc, string k)
        {
            OleDbConnection conn = new OleDbConnection(koneksi);
            conn.Open();

            double ED;
            List<string> cls = new List<string>();
            List<double> sort = new List<double>();

            string sql = "SELECT * FROM chain_aksara ORDER BY ID";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader row = cmd.ExecuteReader();

            while (row.Read())
            {
                ED = 0;
                int A, B;

                for (int ln = 0; ln < row[2].ToString().Length; ln++)
                {
                    A = int.Parse(row[2].ToString().Substring(ln, 1));
                    if (ln < cc.Length)
                    { B = int.Parse(cc.Substring(ln, 1)); }
                    else
                    { B = 0; }

                    //ED = ED + Math.Sqrt(Math.Pow(A - B, 2));
                    ED = ED + Math.Pow(A - B, 2);
                }
                ED = Math.Sqrt(ED);
                //Console.WriteLine(ED);
                cls.Add(row[1].ToString());
                sort.Add(ED);
            }

            conn.Close();

            List<string> hasil = new List<string>();

            List<double> res = sort.OrderBy(o => o).Take(Convert.ToInt16(k)).ToList();

            foreach (double val in res)
            {
                hasil.Add(cls.ElementAt(sort.IndexOf(val)));
            }

            var result = hasil.GroupBy(g => g).Select(s => new { v = s.Key, n = s.Count() }).OrderByDescending(o => o.n).First();
            return result.v;
        }
    }
}
