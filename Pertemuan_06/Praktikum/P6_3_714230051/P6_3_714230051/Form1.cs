using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714230051
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetErrorMessage(TextBox textBox, string warningMessage, string wrongMessage, string correctMesssage)
        {
            errorWarning.SetError(textBox, warningMessage);
            errorWrong.SetError(textBox, wrongMessage);
            errorCorrect.SetError(textBox, correctMesssage);
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                SetErrorMessage(txtHuruf, "TextBox Huruf tidak boleh kosong!", "", "");
            }
            else if (txtHuruf.Text.All(Char.IsLetter))
            {
                SetErrorMessage(txtHuruf, "", "", "Betul!");
            }
            else
            {
                SetErrorMessage(txtHuruf, "", "Inputan Hanya Boleh Huruf!", "");
            }
        }

        private void txtAngka_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                SetErrorMessage(txtAngka, "TextBox Angka tidak boleh kosong!", "", "");
            }
            else if (txtAngka.Text.All(Char.IsNumber))
            {
                SetErrorMessage(txtAngka, "", "", "Betul!");
            }
            else
            {
                SetErrorMessage(txtAngka, "", "Inputan Hanya Boleh Angka!", "");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

            if (txtEmail.Text == "")
            {
                SetErrorMessage(txtEmail, "TextBox Email tidak boleh kosong!", "", "");
            }
            else if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                SetErrorMessage(txtEmail, "", "", "Betul!");
            }
            else
            {
                SetErrorMessage(txtEmail, "", "Inputan Hanya Boleh Email!", "");
            }
        }

        private void txtAngka1_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka1.Text == "")
            {
                SetErrorMessage(txtAngka1, "TextBox Angka tidak boleh kosong!", "", "");
            }
            else if (txtAngka1.Text.All(Char.IsNumber))
            {
                SetErrorMessage(txtAngka1, "", "", "Betul!");
            }
            else
            {
                SetErrorMessage(txtAngka1, "", "Inputan Hanya Boleh Angka!", "");
            }
        }

        private void txtAngka2_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka2.Text == "")
            {
                SetErrorMessage(txtAngka2, "TextBox Angka tidak boleh kosong!", "", "");
            }
            else if (txtAngka2.Text.All(Char.IsNumber))
            {
                SetErrorMessage(txtAngka2, "", "", "Betul!");
            }
            else
            {
                SetErrorMessage(txtAngka2, "", "Inputan Hanya Boleh Angka!", "");
            }
        }

        public void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAngka1.Text))
            {
                SetErrorMessage(txtAngka1, "Angka 1 tidak boleh kosong!", "", "");
            }
            else if (txtAngka1.Text.All(Char.IsNumber))
            {
                SetErrorMessage(txtAngka1, "", "", "Betul!");
            }

            // Cek apakah Angka2 sudah terisi, jika iya, lakukan perbandingan
            if (!string.IsNullOrEmpty(txtAngka2.Text) && txtAngka2.Text.All(Char.IsDigit))
            {
                int angka1 = int.Parse(txtAngka1.Text);
                int angka2 = int.Parse(txtAngka2.Text);

                if (angka1 > angka2)
                {
                    SetErrorMessage(txtAngka2, "", "", "Correct!");
                }
                else
                {
                    SetErrorMessage(txtAngka2, "", "Angka 1 harus lebih besar dari angka 2", "");
                    SetErrorMessage(txtAngka1, "", "Angka 1 harus lebih besar dari angka 2", "");
                }
            }
        }

        public void txtAngka2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAngka2.Text))
            {
                SetErrorMessage(txtAngka2, "Angka 2 tidak boleh kosong!", "", "");
            }
            else if (txtAngka2.Text.All(Char.IsNumber))
            {
                SetErrorMessage(txtAngka2, "", "", "Betul!");
            }

            if (!string.IsNullOrEmpty(txtAngka1.Text) && txtAngka1.Text.All(Char.IsDigit))
            {
                int angka1 = int.Parse(txtAngka1.Text);
                int angka2 = int.Parse(txtAngka2.Text);

                if (angka1 > angka2)
                {
                    SetErrorMessage(txtAngka2, "", "", "Betul");
                }
                else
                {

                    SetErrorMessage(txtAngka2, "", "Angka 1 harus lebih besar dari angka 2", "");
                    SetErrorMessage(txtAngka1, "", "Angka 1 harus lebih besar dari angka 2", "");
                }
            }


        }
    }
}
