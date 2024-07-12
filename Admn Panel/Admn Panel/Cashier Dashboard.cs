using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admn_Panel
{
    public partial class Cashier_Dashboard : Form
    {
        double chinesefood01 = 600;
        double chinesefood02 = 300;
        double chinesefood03 = 1300;
        double chinesefood04 = 1200;
        double chinesefood05 = 600;

        double korianfood01 = 600;
        double korianfood02 = 300;
        double korianfood03 = 1300;
        double korianfood04 = 1200;
        double korianfood05 = 600;

        double thaifood01 = 600;
        double thaifood02 = 300;
        double thaifood03 = 1300;
        double thaifood04 = 1200;
        double thaifood05 = 600;

        double indianfood01 = 600;
        double indianfood02 = 300;
        double indianfood03 = 1300;
        double indianfood04 = 1200;
        double indianfood05 = 600;

        double servicecharge = 60;
        double change, stot, tot, icharge;

        double[] itemcost = new double[20];

        public Cashier_Dashboard()
        {
            InitializeComponent();
        }

       

        private void BraisedPorkBelly_CheckedChanged(object sender, EventArgs e)
        {
            if (BraisedPorkBelly.Checked)
            {
                textBox1.Enabled = true;
                textBox1.Focus();
                textBox1.Text = "";
            }
            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }
        }

        private void Hamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (Hamburger.Checked)
            {
                textBox2.Enabled = true;
                textBox2.Focus();
                textBox2.Text = "";
            }
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void HoneyOrangeFirecracker_CheckedChanged(object sender, EventArgs e)
        {
            if (HoneyOrangeFirecracker.Checked)
            {
                textBox3.Enabled = true;
                textBox3.Focus();
                textBox3.Text = "";
            }
            else
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }

        private void LoMeinNoodles_CheckedChanged(object sender, EventArgs e)
        {
            if (LoMeinNoodles.Checked)
            {
                textBox4.Enabled = true;
                textBox4.Focus();
                textBox4.Text = "";
            }
            else
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }

        private void VegetableLoMeinTofu_CheckedChanged(object sender, EventArgs e)
        {
            if (VegetableLoMeinTofu.Checked)
            {
                textBox5.Enabled = true;
                textBox5.Focus();
                textBox5.Text = "";
            }
            else
            {
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }
        }

        private void CheesyShrimpRoseTteokbokki_CheckedChanged(object sender, EventArgs e)
        {
            if (CheesyShrimpRoseTteokbokki.Checked)
            {
                textBox6.Enabled = true;
                textBox6.Focus();
                textBox6.Text = "";
            }
            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }

        private void ChungChunKoreanRiceDog_CheckedChanged(object sender, EventArgs e)
        {
            if (ChungChunKoreanRiceDog.Checked)
            {
                textBox7.Enabled = true;
                textBox7.Focus();
                textBox7.Text = "";
            }
            else
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }

        private void KorianArmyStew_CheckedChanged(object sender, EventArgs e)
        {
            if (KorianArmyStew.Checked)
            {
                textBox8.Enabled = true;
                textBox8.Focus();
                textBox8.Text = "";
            }
            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
        }

        private void Rabokki_CheckedChanged(object sender, EventArgs e)
        {
            if (Rabokki.Checked)
            {
                textBox9.Enabled = true;
                textBox9.Focus();
                textBox9.Text = "";
            }
            else
            {
                textBox9.Enabled = false;
                textBox9.Text = "0";
            }
        }

        private void SpicyKoreanRice_CheckedChanged(object sender, EventArgs e)
        {
            if (SpicyKoreanRice.Checked)
            {
                textBox10.Enabled = true;
                textBox10.Focus();
                textBox10.Text = "";
            }
            else
            {
                textBox10.Enabled = false;
                textBox10.Text = "0";
            }
        }

        private void SichuanChiliPrawns_CheckedChanged(object sender, EventArgs e)
        {
            if (SichuanChiliPrawns.Checked)
            {
                textBox11.Enabled = true;
                textBox11.Focus();
                textBox11.Text = "";
            }
            else
            {
                textBox11.Enabled = false;
                textBox11.Text = "0";
            }
        }

        private void SpicyThaiBasilChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (SpicyThaiBasilChicken.Checked)
            {
                textBox12.Enabled = true;
                textBox12.Focus();
                textBox12.Text = "";
            }
            else
            {
                textBox12.Enabled = false;
                textBox12.Text = "0";
            }
        }

        private void ThaiChickenLettuceWraps_CheckedChanged(object sender, EventArgs e)
        {
            if (ThaiChickenLettuceWraps.Checked)
            {
                textBox13.Enabled = true;
                textBox13.Focus();
                textBox13.Text = "";
            }
            else
            {
                textBox13.Enabled = false;
                textBox13.Text = "0";
            }
        }

        private void ThaiDrunkenNoodles_CheckedChanged(object sender, EventArgs e)
        {
            if (ThaiDrunkenNoodles.Checked)
            {
                textBox14.Enabled = true;
                textBox14.Focus();
                textBox14.Text = "";
            }
            else
            {
                textBox14.Enabled = false;
                textBox14.Text = "0";
            }
        }

        private void ThaiSpringRolls_CheckedChanged(object sender, EventArgs e)
        {
            if (ThaiSpringRolls.Checked)
            {
                textBox15.Enabled = true;
                textBox15.Focus();
                textBox15.Text = "";
            }
            else
            {
                textBox15.Enabled = false;
                textBox15.Text = "0";
            }
        }

        private void ChaiParothaSabji_CheckedChanged(object sender, EventArgs e)
        {
            if (ChaiParothaSabji.Checked)
            {
                textBox6.Enabled = true;
                textBox6.Focus();
                textBox6.Text = "";
            }
            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }

        private void ChickenTikkaMasala_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenTikkaMasala.Checked)
            {
                textBox16.Enabled = true;
                textBox16.Focus();
                textBox16.Text = "";
            }
            else
            {
                textBox16.Enabled = false;
                textBox16.Text = "0";
            }
        }

        private void Curriedrice_CheckedChanged(object sender, EventArgs e)
        {
            if (Curriedrice.Checked)
            {
                textBox17.Enabled = true;
                textBox17.Focus();
                textBox17.Text = "";
            }
            else
            {
                textBox18.Enabled = false;
                textBox18.Text = "0";
            }
        }

        private void MeduWada_CheckedChanged(object sender, EventArgs e)
        {
            if (MeduWada.Checked)
            {
                textBox19.Enabled = true;
                textBox19.Focus();
                textBox19.Text = "";
            }
            else
            {
                textBox19.Enabled = false;
                textBox19.Text = "0";
            }
        }

        private void PaneerKathiRolls_CheckedChanged(object sender, EventArgs e)
        {
            if (PaneerKathiRolls.Checked)
            {
                textBox20.Enabled = true;
                textBox20.Focus();
                textBox20.Text = "";
            }
            else
            {
                textBox20.Enabled = false;
                textBox20.Text = "0";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }
       

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if(!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void v(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            itemcost[1] = double.Parse(textBox1.Text);
            itemcost[2] = double.Parse(textBox2.Text);
            itemcost[3] = double.Parse(textBox3.Text);
            itemcost[4] = double.Parse(textBox4.Text);
            itemcost[5] = double.Parse(textBox5.Text);

            itemcost[6] = double.Parse(textBox6.Text);
            itemcost[7] = double.Parse(textBox7.Text);
            itemcost[8] = double.Parse(textBox8.Text);
            itemcost[9] = double.Parse(textBox9.Text);
            itemcost[10] = double.Parse(textBox10.Text);

            itemcost[11] = double.Parse(textBox11.Text);
            itemcost[12] = double.Parse(textBox12.Text);
            itemcost[13] = double.Parse(textBox13.Text);
            itemcost[14] = double.Parse(textBox14.Text);
            itemcost[15] = double.Parse(textBox15.Text);

            itemcost[16] = double.Parse(textBox16.Text);
            itemcost[17] = double.Parse(textBox17.Text);
            itemcost[18] = double.Parse(textBox18.Text);
            itemcost[19] = double.Parse(textBox19.Text);
            itemcost[20] = double.Parse(textBox20.Text);


            stot = (itemcost[1] * chinesefood01) + (itemcost[2] * chinesefood02) + (itemcost[3] * chinesefood03) + (itemcost[4] * chinesefood04) + (itemcost[5] * chinesefood05) + (itemcost[6] * korianfood01) + (itemcost[7] * korianfood02) + (itemcost[8] * korianfood03) + (itemcost[9] * korianfood04) + (itemcost[10] * korianfood05) + (itemcost[11] * thaifood01) + (itemcost[12] * thaifood02) + (itemcost[13] * thaifood03) + (itemcost[14] * thaifood04) + (itemcost[15] * thaifood05) + (itemcost[16] * indianfood01) + (itemcost[17] * indianfood02) + (itemcost[18] * indianfood03) + (itemcost[19] * indianfood04) + (itemcost[20] * indianfood05);
            icharge = (stot * servicecharge) / 100;

            textBox21.Text = stot.ToString();
            textBox22.Text = icharge.ToString();
            double tot = stot + icharge;
            textBox23.Text = tot.ToString();


        }

    }
}
