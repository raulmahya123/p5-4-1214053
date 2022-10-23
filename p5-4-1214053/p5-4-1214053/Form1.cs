using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p5_4_1214053
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FormPendaftaran_Click(object sender, EventArgs e)
        {

        }

        private void rbJadwal1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kelas_Enter(object sender, EventArgs e)
        {

        }

        private void jadwal_Enter(object sender, EventArgs e)
        {

        }

        private void cbBiola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbGitar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbSaxophone_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbKonduktor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPiano_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbDrum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbVokal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbKomposer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbJadwal2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbJadwal3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbJadwal4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PilihJKK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tampilkan_Click(object sender, EventArgs e)
        
            {

                string kelas = "";
                string jadwal = "";

                if (cbBiola.Checked)
                {
                    kelas = kelas + "Biola, ";
                }
                if (cbGitar.Checked)
                {
                    kelas = kelas + "Gitar, ";
                }
                if (cbSaxophone.Checked)
                {
                    kelas = kelas + "Saxophone, ";
                }
                if (cbKonduktor.Checked)
                {
                    kelas = kelas + "Konduktor, ";
                }
                if (cbPiano.Checked)
                {
                    kelas = kelas + "Piano, ";
                }
                if (cbDrum.Checked)
                {
                    kelas = kelas + "Drum, ";
                }
                if (cbVokal.Checked)
                {
                    kelas = kelas + "Vokal, ";
                }
                if (cbKomposer.Checked)
                {
                    kelas = kelas + "Komposer, ";
                }
         

                var again = true;

                if (rbJadwal1.Checked)
                {
                    jadwal = "Senin & Rabu, 14.00 - 16.00";
                }
                else if (rbJadwal2.Checked)
                {
                    jadwal = "Senin & Kamis, 14.00 - 16.00";
                }
                else if (rbJadwal3.Checked)
                {
                    jadwal = "Sabtu & Minggu, 09.00 - 11.00";
                }
                else if (rbJadwal4.Checked)
                {
                    jadwal = "Minggu, 13.00 - 17.00";
                }
                else
                {
                    again = false;
                    MessageBox.Show("Harus memilih salah satu dari pilihan jadwal", "Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                while (again)
                {
                    if (cbBiola.Checked)
                    {
                        MessageBox.Show
                        ("Nama : " + txtNama.Text +
                        "\nJenis Kelamin : " + PilihJKK.Text +
                        "\nTanggal Lahir : " + TglLahirr.Text +
                        "\nPilihan Kelas : " + kelas +
                        "\nPilihan Jadwal : " + jadwal,
                        "Informasi Pendaftaran",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        again = false;
                    }
                    else if (cbGitar.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + txtNama.Text +
                    "\nJenis Kelamin : " + PilihJKK.Text +
                    "\nTanggal Lahir : " + TglLahirr.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cbSaxophone.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + txtNama.Text +
                    "\nJenis Kelamin : " + PilihJKK.Text +
                    "\nTanggal Lahir : " + TglLahirr.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cbKonduktor.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + txtNama.Text +
                    "\nJenis Kelamin : " + PilihJKK.Text +
                    "\nTanggal Lahir : " + TglLahirr.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cbPiano.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + txtNama.Text +
                    "\nJenis Kelamin : " + PilihJKK.Text +
                    "\nTanggal Lahir : " + TglLahirr.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cbDrum.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + txtNama.Text +
                    "\nJenis Kelamin : " + PilihJKK.Text +
                    "\nTanggal Lahir : " + TglLahirr.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cbVokal.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + txtNama.Text +
                    "\nJenis Kelamin : " + PilihJKK.Text +
                    "\nTanggal Lahir : " + TglLahirr.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else if (cbKomposer.Checked)
                {
                    MessageBox.Show
                    ("Nama : " + txtNama.Text +
                    "\nJenis Kelamin : " + PilihJKK.Text +
                    "\nTanggal Lahir : " + TglLahirr.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    again = false;
                }
                else
                    {
                        MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        again = false;
                    }
                }

            }
        

        private void Selesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
