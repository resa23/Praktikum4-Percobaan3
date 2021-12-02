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

namespace P4_3_1204053
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Texbox Huruf tidak boleh kosong !");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul !");
                }
                else
                {
                    epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");
                }
            }
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                epWarning.SetError(txtAngka, "Texbox Angka tidak boleh kosong !");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");
            }
            else
            {
                if ((txtAngka.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "Betul !");

                }
                else
                {
                    epWrong.SetError(txtAngka, "Inputan hanya boleh angka!");
                    epWarning.SetError(txtAngka, "");
                    epCorrect.SetError(txtAngka, "");
                }
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "Texbox Email tidak boleh kosong !");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "Betul !");
                }
                else
                {
                    epWrong.SetError(txtEmail, "Format email salah! \nContoh: a@b.c");
                    epWarning.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");

                }
            }
        }

        private void txtAngka1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAngka2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (txtAngka1.Text != "")
            {
                if (int.Parse(txtAngka1.Text) > int.Parse(txtAngka2.Text))
                {
                    epCorrect.SetError(txtAngka1, "Betul !");
                    epWarning.SetError(txtAngka1, " Angka 1 tidak boleh lebih dari angka 2 ! ");
                    epWrong.SetError(txtAngka1, "");

                }
                else
                {
                    epCorrect.SetError(txtAngka1, "betul");
                    epWarning.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka1, "");
                }

            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if (txtAngka2.Text != "")
            {
                if (int.Parse(txtAngka1.Text) > int.Parse(txtAngka2.Text))
             
                {
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka2, " Angka1 lebih besar dari Angka 2");
                    epWrong.SetError(txtAngka2, "");

                }
                else
                {
                    epCorrect.SetError(txtAngka2, "Betul");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka2, "");
                }

            }
        }
    }
}
