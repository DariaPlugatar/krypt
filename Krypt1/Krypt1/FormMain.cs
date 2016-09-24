using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krypt1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            cbChange.Hide();
        }

        public char[] al()
        {
            char ch;
            int n = 0;
            char[] mass = new char[33];
            for (int i = 1072; i <= 1103; i++)
            {
                ch = System.Convert.ToChar(i);
                mass[n] = ch;
                n++;
            }
            mass[33] = Convert.ToChar(" ");
            return mass;
        }

        public string CesarShifr(string a, int key)
        {
            char[] alf = al();
            char[] outer = new char[a.Length];
            char[] inner = a.ToCharArray();
            for (int i = 0; i < inner.Length; i++)
            {
                for (int j = 0; j < alf.Length; j++)
                {
                    if (alf[j] == inner[i])
                    {
                        outer[i] = alf[(j + key) % 32];
                        break;
                    }
                }
            }
            string z = new string(outer);
            return z;
        }

        public string CesarDeshifr(string a, int key)
        {
            char[] alf = al();
            char[] outer = new char[a.Length];
            char[] inner = a.ToCharArray();
            for (int i = 0; i < inner.Length; i++)
            {
                for (int j = 0; j < alf.Length; j++)
                {
                    if (alf[j] == inner[i])
                    {
                        if(j > key)
                            outer[i] = alf[(j - key) % 32];
                        else
                            outer[i] = alf[(32 + j - key) % 32];
                        break;
                    }
                }
            }
            string z = new string(outer);
            return z;
        }


        public string TrythemiusShifr(string a, int b, int c)
        {
            char[] alf = al();
            char[] outer = new char[a.Length];
            char[] inner = a.ToCharArray();
            int k;
            for (int i = 0; i < inner.Length; i++)
            {
                k=(i+1)*b + c;
                for (int j = 0; j < alf.Length; j++)
                {
                    if (alf[j] == inner[i])
                    {
                        outer[i] = alf[k % 32];
                        break;
                    }
                }
            }
            string z = new string(outer);
            return z;
         }


        public string TrythemiusDeshifr(string a, int b, int c)
        {
            char[] alf = al();
            char[] outer = new char[a.Length];
            char[] inner = a.ToCharArray();
            int k;
            for (int i = 0; i < inner.Length; i++)
            {
                k = (i + 1) * b + c;
                for (int j = 0; j < alf.Length; j++)
                {
                    if (alf[j] == inner[i])
                    {
                        if (j > k)
                            outer[i] = alf[(j - k) % 32];
                        else if (j == k) outer[i] = alf[0];
                        else
                            outer[i]=alf[(32 + j - k)%32];
                        break;
                    }
                }
            }
            string z = new string(outer);
            return z;
        }
        




        public string GammShifr(string a, string gam)
        {
            char[] alf = al();
            char[] outer = new char[a.Length];
            int x = 0;
            int y = 0;
            for (int j = 0; j < gam.ToCharArray().Length; j++)
            {
                for (int i = 0; i < alf.Length; i++)
                {
                    if (gam[j] ==alf[i])
                    {
                        x = i;
                    }
                    if (alf[i] == a[j])
                    {
                        y = i;
                    }
                }
                outer[j] = alf[(x + y) % 32];
            }
            string z = new string(outer);
            return z;
        }

        public string GammDeshifr(string a, string gam)
        {
            char[] alf = al();
            char[] outer = new char[a.Length];
            int x = 0;
            int y = 0;
            for (int j = 0; j < gam.ToCharArray().Length; j++)
            {
                for (int i = 0; i < alf.Length; i++)
                {
                    if (gam[j] == alf[i])
                    {
                        x = i;
                    }
                    if (alf[i] == a[j])
                    {
                        y = i;
                    }
                }
                outer[j] = alf[(y - x + 32) % 32];
            }
            string z = new string(outer);
            return z;
        }



      

        public void textcontrol(string a)
        {
            if (a.Length > 0)
            {
                if (tb_in1.Text.Length > 1)
                {
                    char[] tbText = tb_in1.Text.ToCharArray();
                    string simbol = tbText[tbText.Length - 1].ToString();
                    if (Regex.IsMatch(simbol, @"[^а-я]+"))
                    {
                        tb_in1.Text = tb_in1.Text.Substring(0, tb_in1.Text.Length - 1);
                        tb_in1.SelectionStart = tb_in1.Text.Length;
                    }
                }
                else
                {
                    if (Regex.IsMatch(tb_in1.Text, @"[^А-Яа-я]+"))
                    {
                        tb_in1.Text = String.Empty;
                        tb_in1.SelectionStart = 0;
                    }
                }
            }
        }
        private void btnShifr_Click(object sender, EventArgs e)
        {
            if (rbCesar.Checked)
            {
                tb_out1.Text = CesarShifr(tb_in1.Text, Convert.ToInt16(nudCesarKey1.Value));
            }
            if (rbTrit.Checked)
            {
                tb_out1.Text = TrythemiusShifr(tb_in1.Text, Convert.ToInt16(nudK1.Value), Convert.ToInt16(nudB1.Value));
            }
            if (rbGamm.Checked)
            {
                if (tbgamm1.Text.Length != tb_in1.Text.Length )
                    MessageBox.Show("Довжина гамми не дорівнює довжині тексту для шифрування!");
                else
                    tb_out1.Text = GammShifr(tb_in1.Text, tbgamm1.Text);
            }
        }

        private void rbCesar_CheckedChanged(object sender, EventArgs e)
        {
            nudCesarKey1.Show();
            nudB1.Hide();
            nudK1.Hide();
            label4.Hide();
            label5.Hide();
            tbgamm1.Hide();
            label3.Text = "Ключ";

            nudCesarKey2.Show();
            nudB2.Hide();
            nudK2.Hide();
            label8.Hide();
            label10.Hide();
            tbgamm2.Hide();
            label9.Text = "Ключ";
        }

        private void rbTrit_CheckedChanged(object sender, EventArgs e)
        {
            nudCesarKey1.Hide();
            nudB1.Show();
            nudK1.Show();
            label4.Show();
            label5.Hide();
            tbgamm1.Hide();
            label3.Text = "Ключ";

            nudCesarKey2.Hide();
            nudB2.Show();
            nudK2.Show();
            label10.Show();
            label8.Hide();
            tbgamm2.Hide();
            label9.Text = "Ключ";
        }

        private void rbGamm_CheckedChanged(object sender, EventArgs e)
        {
            nudCesarKey1.Hide();
            nudB1.Hide();
            nudK1.Hide();
            label4.Hide();
            label5.Show();
            tbgamm1.Show();
            label3.Text = "Гамма";

            nudCesarKey2.Hide();
            nudB2.Hide();
            nudK2.Hide();
            label10.Hide();
            label8.Show();
            tbgamm2.Show();
            label9.Text = "Гамма";
        }

        private void btnDeshifr_Click(object sender, EventArgs e)
        {
            if (rbCesar.Checked)
            {
                tb_out2.Text = CesarDeshifr(tb_in2.Text, Convert.ToInt16(nudCesarKey2.Value));
            }
            if (rbTrit.Checked)
            {
                tb_out2.Text = TrythemiusDeshifr(tb_in2.Text, Convert.ToInt16(nudK2.Value), Convert.ToInt16(nudB2.Value));
            }
            if (rbGamm.Checked)
            {
                if (tbgamm2.Text.Length != tb_in2.Text.Length)
                    MessageBox.Show("Довжина гамми не дорівнює довжині тексту для шифрування!");
                else
                    tb_out2.Text = GammDeshifr(tb_in2.Text, tbgamm2.Text);
            }
        }

        private void tb_in1_TextChanged(object sender, EventArgs e)
        {

            textcontrol(tb_in1.Text);
        }

        private void tb_in2_TextChanged(object sender, EventArgs e)
        {
            textcontrol(tb_in2.Text);
        }







    }
}
