using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Zadanie.NET_13._04._2023
{
    public partial class Gracz : Form
    {
        public Gracz()
        {
            InitializeComponent();
        }

        private void Gracz_Load(object sender, EventArgs e)
        {
            this.graczTableAdapter.Fill(this.pilkaNoznaDataSet.gracz);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.graczTableAdapter.Update(this.pilkaNoznaDataSet.gracz);

        }
        public static byte[] ImageToByte(string filePath)
        {
            var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var reader = new BinaryReader(stream);
            var photo = reader.ReadBytes((int)stream.Length);
            reader.Close();
            stream.Close();
            return photo;
        }
        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog { Filter = "Image Files(*.bmp;*.jpg;*.gif)|*.bmp;*.jpg;*.gif" };
            var sciezkaObrazka = "";
            if (ofd.ShowDialog() == DialogResult.OK) sciezkaObrazka = ofd.FileName;
            var id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DataRow dr = pilkaNoznaDataSet.gracz.Select("id=" + id).FirstOrDefault();
            if (sciezkaObrazka != null)
            {
                dr["zdjecie"] = ImageToByte(sciezkaObrazka);
            }
        }



        private void btnZapisz_Click_1(object sender, EventArgs e)
        {

            graczTableAdapter.Update(pilkaNoznaDataSet.gracz);

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null ?dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value : null;


            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 &&value.ToString().Length>1)
                {
                    pictureBox1.Image = byteArrayToImage((byte[])value);
                }
                else
                {
                    pictureBox1.Image = null;
                }

                //pictureBox1.Image = null;
                string teamID = row.Cells[1].Value.ToString();
                string position = row.Cells[2].Value.ToString();
                string name = row.Cells[3].Value.ToString();
                string surname = row.Cells[4].Value.ToString();
                string data = row.Cells[5].Value.ToString();


                int intValue = int.Parse(teamID);
                switch (intValue)
                {
                    case 1:
                        label1.Text = "Lechia Gdańsk";
                        break;
                    case 2:
                        label1.Text = "Legia Warszawa";
                        break;
                    case 3:
                        label1.Text = "Lech Poznań";
                        break;
                    case 4:
                        label1.Text = "Raków Częstochowa";
                        break;
                    case 5:
                        label1.Text = "Górnik Zabrze";
                        break;
                    case 6:
                        label1.Text = "Jagielonia Białystok";
                        break;
                    default:
                        label1.Text = "";
                        break;
                }
                label2.Text = position;
                label3.Text = name;
                label4.Text = surname;
                label6.Text = data;
                //if (e.RowIndex >= 0 && e.ColumnIndex == 6)
                //{


                //    using (var ms = new MemoryStream(value))
                //    {
                //        var image = Image.FromStream(ms);
                //        if (image != null)
                //        {
                //            pictureBox1.Image = image;

                //        }
                //        string teamID = row.Cells[1].Value.ToString();
                //        string position = row.Cells[2].Value.ToString();
                //        string name = row.Cells[3].Value.ToString();
                //        string surname = row.Cells[4].Value.ToString();
                //        string data = row.Cells[5].Value.ToString();


                //        int intValue = int.Parse(teamID);
                //        switch (intValue)
                //        {
                //            case 1:
                //                label1.Text = "Lechia Gdańsk";
                //                break;
                //            case 2:
                //                label1.Text = "Legia Warszawa";
                //                break;
                //            case 3:
                //                label1.Text = "Lech Poznań";
                //                break;
                //            case 4:
                //                label1.Text = "Raków Częstochowa";
                //                break;
                //            case 5:
                //                label1.Text = "Górnik Zabrze";
                //                break;
                //            case 6:
                //                label1.Text = "Jagielonia Białystok";
                //                break;
                //            default:
                //                label1.Text = "";
                //                break;
                //        }
                //        label2.Text = position;
                //        label3.Text = name;
                //        label4.Text = surname;
                //        label6.Text = data;
                //    }
                //}
                //else
                //{
                //    pictureBox1.Image = null;
                //    string teamID = row.Cells[1].Value.ToString();
                //    string position = row.Cells[2].Value.ToString();
                //    string name = row.Cells[3].Value.ToString();
                //    string surname = row.Cells[4].Value.ToString();
                //    string data = row.Cells[5].Value.ToString();


                //    int intValue = int.Parse(teamID);
                //    switch (intValue)
                //    {
                //        case 1:
                //            label1.Text = "Lechia Gdańsk";
                //            break;
                //        case 2:
                //            label1.Text = "Legia Warszawa";
                //            break;
                //        case 3:
                //            label1.Text = "Lech Poznań";
                //            break;
                //        case 4:
                //            label1.Text = "Raków Częstochowa";
                //            break;
                //        case 5:
                //            label1.Text = "Górnik Zabrze";
                //            break;
                //        case 6:
                //            label1.Text = "Jagielonia Białystok";
                //            break;
                //        default:
                //            label1.Text = "";
                //            break;
                //    }
                //    label2.Text = position;
                //    label3.Text = name;
                //    label4.Text = surname;
                //    label6.Text = data;
                //}

                //}
                //else
                //{
                //    pictureBox1.Image = null;
                //}

            }
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        //Byte array to photo
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string surname = row.Cells[4].Value.ToString();
                string data = row.Cells[5].Value.ToString();

                DataTable table = (DataTable)dataGridView1.DataSource;
                table.Rows[e.RowIndex]["Surname"] = surname;
                table.Rows[e.RowIndex]["DateOfBirth"] = data;

                label4.Text = surname;
                label6.Text = data;
            }
        }
    }
}

