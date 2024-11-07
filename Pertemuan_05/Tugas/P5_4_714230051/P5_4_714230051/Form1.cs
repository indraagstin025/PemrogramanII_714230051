using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714230051
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Menambahkan item ke ComboBox
            comboBox1.Items.Add("Laki - Laki");
            comboBox1.Items.Add("Perempuan");

            // Mengatur properti DateTimePicker
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd MMMM yyyy";
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            StringBuilder info = new StringBuilder();

            // Validasi untuk memastikan salah satu RadioButton (kelas) dipilih
            if (!Senin_Rabu.Checked && !Selasa_Kamis.Checked && !Minggu.Checked)
            {
                MessageBox.Show("Silakan pilih kelas terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi untuk memastikan setidaknya satu CheckBox (jadwal) dipilih
            if (!Basket.Checked && !Sepak_Bola.Checked && !Renang.Checked && !Tenis.Checked &&
                !Yoga.Checked && !Bulu_Tangkis.Checked && !Voli.Checked && !Panahan.Checked)
            {
                MessageBox.Show("Silakan pilih jadwal terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mengambil informasi ComboBox (jenis kelamin)
            string gender = comboBox1.SelectedItem?.ToString() ?? "Belum dipilih";

            // Mengambil informasi kelas (RadioButton)
            string kelas = "";
            if (Senin_Rabu.Checked) kelas = "Senin & Rabu";
            if (Selasa_Kamis.Checked) kelas = "Selasa & Kamis";
            if (Minggu.Checked) kelas = "Minggu";

            // Mengambil informasi jadwal (CheckBox)
            List<string> jadwal = new List<string>();
            if (Basket.Checked) jadwal.Add("Basket");
            if (Sepak_Bola.Checked) jadwal.Add("Sepak Bola");
            if (Renang.Checked) jadwal.Add("Renang");
            if (Tenis.Checked) jadwal.Add("Tenis");
            if (Yoga.Checked) jadwal.Add("Yoga");
            if (Bulu_Tangkis.Checked) jadwal.Add("Bulu Tangkis");
            if (Voli.Checked) jadwal.Add("Voli");
            if (Panahan.Checked) jadwal.Add("Panahan");

            // Mengambil informasi tanggal (DateTimePicker)
            string tanggal = dateTimePicker1.Value.ToString("dd MMMM yyyy");

            // Menyusun semua informasi dalam pesan
            info.AppendLine("Informasi Pendaftaran:");
            info.AppendLine($"Jenis Kelamin: {gender}");
            info.AppendLine($"Kelas: {kelas}");
            info.AppendLine($"Jadwal: {string.Join(", ", jadwal)}");
            info.AppendLine($"Tanggal: {tanggal}");

            // Menampilkan informasi dalam MessageBox
            MessageBox.Show(info.ToString(), "Informasi Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            // Event untuk keluar dari aplikasi
            Application.Exit();
        }

        // Event kosong yang disediakan untuk menangani perubahan kontrol, jika diperlukan
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

        private void Basket_CheckedChanged(object sender, EventArgs e) { }
        private void Sepak_Bola_CheckedChanged(object sender, EventArgs e) { }
        private void Renang_CheckedChanged(object sender, EventArgs e) { }
        private void Tenis_CheckedChanged(object sender, EventArgs e) { }
        private void Yoga_CheckedChanged(object sender, EventArgs e) { }
        private void Bulu_Tangkis_CheckedChanged(object sender, EventArgs e) { }
        private void Voli_CheckedChanged(object sender, EventArgs e) { }
        private void Panahan_CheckedChanged(object sender, EventArgs e) { }
        private void Senin_Rabu_CheckedChanged(object sender, EventArgs e) { }
        private void Selasa_Kamis_CheckedChanged(object sender, EventArgs e) { }
        private void Minggu_CheckedChanged(object sender, EventArgs e) { }
    }
}
