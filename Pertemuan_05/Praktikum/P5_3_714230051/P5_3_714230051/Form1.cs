using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_714230051
{
    public partial class ServiceHP : Form
    {
        public ServiceHP()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string os = "";
            string status = "";

            if (rb_Android.Checked == true)
            {
                os = "Android";
            }
            else if (rb_iOS.Checked == true)
            {
                os = "iOS";
            }
            if (cb_Ya.Checked == true)
            {
                status = "Ya , Sudah Diperbaiki";
            }
            MessageBox.Show(
                "Merk HP : " + txtMerekHP.Text +
                "\n Sistem Operasi : " + os +
                "\n Status Perbaikan : " + status ,
                "Informasi Service HP : ",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtMerekHP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
