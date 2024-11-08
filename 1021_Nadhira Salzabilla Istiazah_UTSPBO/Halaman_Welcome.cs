using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _1021_Nadhira_Salzabilla_Istiazah_UTSPBO
{
    public partial class Halaman_Welcome : Form
    {
        List<Pengguna> ListPengguna = new List<Pengguna>();

        public Halaman_Welcome()
        {
            InitializeComponent();

            Pengguna pgn = new Pengguna
            {
                username = "1021",
                password = "Dhira",
            };

            //ListPenggunaa.Add(pgn);

            //// Binding ListMahasiswa ke DataGridView
            //dataGridView1.DataSource = ListPengguna;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Halaman_Login frmDataBaru = new Halaman_Login();
            //if (frmDataBaru.ShowDialog() == DialogResult.OK) ;
            //{
            //    Pengguna pgn = frmDataBaru.GetPengguna();
            //    ListPengguna.Add(pgn);
            //    dataGridView1.DataSource = null;
            //    dataGridView1.DataSource = ListPengguna;
            //}
        }

        private void button
    public class Pengguna
        {
            public int id { get; set; }
            public string username { get; set; }
            public string password { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
