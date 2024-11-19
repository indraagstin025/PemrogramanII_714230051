using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714230051
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Size = new Size (463, 272);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrWhiteSpace(textBoxNama.Text)) 
            {
                errorMessage.AppendLine("Nama Harus Diisi");
            }

            if (comboBoxAngkatan.SelectedIndex == -1) 
            {
                errorMessage.AppendLine("Angkatan Harus Diisi");
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorMessage.AppendLine("Kelas Harus Di Isi");
            }

            String errorMsg = errorMessage.ToString();

            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show(
               "Lengkap!!",
               "Informasi Submit Data",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Size = new Size(463, 603);
            } else
            {
                MessageBox.Show(
               errorMsg.Trim(),
               "Informasi Submit Data",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           

                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonWeekday.Checked)
            {
                checkBoxKuliah.Enabled = true; checkBoxKuliah.Checked = false;
                checkBoxTidur.Enabled = true; checkBoxTidur.Checked = false;
                checkBoxLiburan.Enabled = false; checkBoxLiburan.Checked = false;
            }
        }

        private void radioButtonWeekday_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekend.Checked)
            {
                checkBoxKuliah.Enabled = false; checkBoxKuliah.Checked = false;
                checkBoxTidur.Enabled = true; checkBoxTidur.Checked = false;
                checkBoxLiburan.Enabled = true; checkBoxLiburan.Checked = false;
            }
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            //string hari = null;
            //string kegiatan = null;

            //foreach (Control control in Controls)
            //{
            //    if (control is RadioButton radioButton && radioButton.Checked)
            //    {
            //        hari = radioButton.Text;
            //        break;
            //    }

            //}

            //foreach (Control control in Controls)
            //{
            //    if (control is CheckBox checkBox && checkBox.Checked)
            //    {
            //        if (!string.IsNullOrEmpty(kegiatan))
            //        {
            //            kegiatan += ", ";
            //        }
            //        kegiatan += checkBox.Text;

            //    }

            //}

            string hari = Controls.OfType<RadioButton>()
                .FirstOrDefault(rb => rb.Checked)?.Text;

            string kegiatan = string.Join(",",
                Controls.OfType<CheckBox>()
                .Where(rb => rb.Checked)
                .Select(rb => rb.Text));

            MessageBox.Show(
                "Nama : " + textBoxNama.Text + "\n" +
                "Angkatan : " + comboBoxAngkatan.Text + "\n" +
                "Kelas : " + textBox2.Text + "\n" +
                "============================================" +"\n"+
                "Hari : " + hari + "\n" +
                "Kegiatan : " + kegiatan + "\n",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //textBoxNama.Text = "";
            //comboBoxAngkatan.SelectedIndex = -1;
            //textBox2.Text = "";

            //radioButtonWeekday.Checked = false;
            //radioButtonWeekday.Checked = false;
            //checkBoxKuliah.Checked = false;
            //checkBoxTidur.Checked = false;
            //checkBoxLiburan.Checked = false;

            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                    textBox.Text = "";
                else if (control is ComboBox comboBox)
                    comboBox.SelectedIndex = -1;
                else if (control is RadioButton radioButton)
                    radioButton.Checked = false;
                else if (control is CheckBox checkBox) 
                {
                    checkBox.Checked = false;
                    checkBox.Enabled = true;
                }
                   
            }

            MessageBox.Show("Anda Telah Mereset Data Anda",
                "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Size = new Size(463, 272);

        }
    }
}
