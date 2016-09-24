using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krypt1
{
    public partial class Gamm : FormMain
    {
        public Gamm()
        {
            InitializeComponent();
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
                    if (gam[j] == alf[i])
                    {
                        x = i;
                    }
                    if (alf[i] == a[j])
                    {
                        y = i;
                    }
                }
                outer[j] = alf[(x + y) % 33];
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
                outer[j] = alf[(y - x + 33) % 33];
            }
            string z = new string(outer);
            return z;
        }

        private void btnShifr_Click(object sender, EventArgs e)
        {
            if (tbGam1.Text.Length != lbShifr_in.Text.Length)
                MessageBox.Show("Довжина гамми не дорівнює довжині тексту для шифрування!");
            else
                lbShifr_out.Text = GammShifr(lbShifr_in.Text, tbGam1.Text);
        }

        private void btnDeshifr_Click(object sender, EventArgs e)
        {
            if (tbGam2.Text.Length != lbDeshifr_in.Text.Length)
                MessageBox.Show("Довжина гамми не дорівнює довжині тексту для шифрування!");
            else
                lbDeshifr_out.Text = GammDeshifr(lbDeshifr_in.Text, tbGam2.Text);
        }

        private void tb_in1_TextChanged(object sender, EventArgs e)
        {

            textcontrol(lbShifr_in.Text);
        }

        private void tb_in2_TextChanged(object sender, EventArgs e)
        {
            textcontrol(lbDeshifr_in.Text);
        }

    }
}
