using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIApp
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        //when Reset, instead of clearing it to blank, shows titles of each measuring system
        private void resetBtn_Click(object sender, EventArgs e)
        {
            cmBox.Text = "Centimeters";
            cmBox.ForeColor = Color.DarkGray;

            feetBox.Text = "Feet";
            feetBox.ForeColor = Color.DarkGray;

            inchesBox.Text = "Inches";
            inchesBox.ForeColor = Color.DarkGray;

            kgBox.Text = "Kilograms";
            kgBox.ForeColor = Color.DarkGray;

            stoneBox.Text = "Stones";
            stoneBox.ForeColor = Color.DarkGray;

            poundBox.Text = "";
            poundBox.ForeColor = Color.DarkGray;

            resultBox.Text = "";

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double height = 0;
            double weight = 0;
            double result = 0.0;
            string bmiresult = "";



            if (heightFT.Checked == true && feetBox.Text.Any(Char.IsDigit) && inchesBox.Text.Any(Char.IsDigit))
            {
                height = (((Convert.ToDouble(feetBox.Text) * 30.48) + (Convert.ToDouble(inchesBox.Text) * 2.54)) / 100);
            }
            else if (heightFT.Checked == true && !feetBox.Text.Any(Char.IsDigit) && !inchesBox.Text.Any(Char.IsDigit) || heightFT.Checked == true && feetBox.Text.Any(Char.IsDigit) && !inchesBox.Text.Any(Char.IsDigit) || heightFT.Checked == true && !feetBox.Text.Any(Char.IsDigit) && inchesBox.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("please enter height in feet and inches");
                return;
            }
            else if (heightCM.Checked == true && cmBox.Text.Any(Char.IsDigit))
            {
                height = (Convert.ToDouble(cmBox.Text) / 100);
            }
            else if (heightCM.Checked == true && !cmBox.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("please enter height in centimeters");
                return;
            }
            else
            {
                

            }


            if (weightST.Checked == true && stoneBox.Text.Any(Char.IsDigit) && poundBox.Text.Any(Char.IsDigit))
            {
                weight = (Convert.ToDouble(stoneBox.Text) * 6.350293) + (Convert.ToDouble(poundBox.Text) / 2.205);

            }
            else if (weightST.Checked == true && !stoneBox.Text.Any(Char.IsDigit) && !poundBox.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("please enter weight in stones and pounds");
                return;
            }
            else if (weightKG.Checked == true && kgBox.Text.Any(Char.IsDigit))
            {
                weight = Convert.ToDouble(kgBox.Text);

            }
            else if (weightKG.Checked == true && !kgBox.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("please enter weight in kilograms");
                return;
            }
            else
            {
                weight = 0;

            }

            result = weight / (height * height);

            if (result < 18.5)
            {
                bmiresult = "You are underweight";
            }
            else if (result < 25)
            {
                bmiresult = "You are normal weight";
            }
            else if (result < 30)
            {
                bmiresult = "You are overweight";
            }
            else if (result >= 30)
            {
                bmiresult = "You are obese";
            }

            resultBox.Text = "Your BMI is: " + result.ToString("#.##") + "\r\n" + bmiresult;

        }




        //**************************************
        //PLACEHOLDERS FOR TEXTBOXES + ENSURING USER USES CORRECT MEASURING

        private void cmBox_Enter(object sender, EventArgs e)
        {
            if(cmBox.Text =="Centimeters")
            {
                cmBox.Text = "";
                cmBox.ForeColor = Color.Black;

            }
        }

        private void cmBox_Leave(object sender, EventArgs e)
        {
            if(cmBox.Text == "")
            {
                cmBox.Text = "Centimeters";
                cmBox.ForeColor = Color.DarkGray;
            }
        }

        private void feetBox_Enter(object sender, EventArgs e)
        {
            if (feetBox.Text == "Feet")
            {
                feetBox.Text = "";
                feetBox.ForeColor = Color.Black;

            }
        }

        private void feetBox_Leave(object sender, EventArgs e)
        {
            if (feetBox.Text == "")
            {
                feetBox.Text = "Feet";
                feetBox.ForeColor = Color.DarkGray;
            }
        }

        private void inchesBox_Enter(object sender, EventArgs e)
        {
            if (inchesBox.Text == "Inches")
            {
                inchesBox.Text = "";
                inchesBox.ForeColor = Color.Black;

            }
        }

        private void inchesBox_Leave(object sender, EventArgs e)
        {
            if (inchesBox.Text == "")
            {
                inchesBox.Text = "Inches";
                inchesBox.ForeColor = Color.DarkGray;
            }

            int inchHeight;
            if (int.TryParse(inchesBox.Text, out inchHeight))
            {
                if (inchHeight > 11 && inchesBox.Text != "")
                {
                    inchesBox.Text = "11";
                    MessageBox.Show("Maximum height in inches is 11");
                }
            }
        }

        private void kgBox_Enter(object sender, EventArgs e)
        {
            if (kgBox.Text == "Kilograms")
            {
                kgBox.Text = "";
                kgBox.ForeColor = Color.Black;

            }
        }

        private void kgBox_Leave(object sender, EventArgs e)
        {
            if (kgBox.Text == "")
            {
                kgBox.Text = "Kilograms";
                kgBox.ForeColor = Color.DarkGray;
            }
        }

        private void stoneBox_Enter(object sender, EventArgs e)
        {
            if (stoneBox.Text == "Stones")
            {
                stoneBox.Text = "";
                stoneBox.ForeColor = Color.Black;

            }
        }

        private void stoneBox_Leave(object sender, EventArgs e)
        {
            if (stoneBox.Text == "")
            {
                stoneBox.Text = "Stones";
                stoneBox.ForeColor = Color.DarkGray;
            }
        }

        private void poundBox_Enter(object sender, EventArgs e)
        {
            if (poundBox.Text == "Pounds")
            {
                poundBox.Text = "";
                poundBox.ForeColor = Color.Black;

            }
        }

        private void poundBox_Leave(object sender, EventArgs e)
        {
            if (poundBox.Text == "")
            {
                poundBox.Text = "Pounds";
                poundBox.ForeColor = Color.DarkGray;
            }

            int poundWeight;
            if (int.TryParse(poundBox.Text, out poundWeight))
            {
                if (poundWeight > 13 && poundBox.Text != "")
                {
                    poundBox.Text = "13";
                    MessageBox.Show("Maximum weight in pounds is 13");
                }
            }
        }
        // END OF PLACEHOLDERS 
        //****************************


        private void heightCM_CheckedChanged(object sender, EventArgs e)
        {
            cmBox.Visible = true;
            feetBox.Visible = false;
            inchesBox.Visible = false;

        }

        private void heightFT_CheckedChanged_1(object sender, EventArgs e)
        {
            cmBox.Visible = false;
            feetBox.Visible = true;
            inchesBox.Visible = true;

            cmBox.Text = "";
        }

        private void weightKG_CheckedChanged(object sender, EventArgs e)
        {
            kgBox.Visible = true;
            stoneBox.Visible = false;
            poundBox.Visible = false;
        }

        private void weightST_CheckedChanged(object sender, EventArgs e)
        {
            kgBox.Visible = false;
            stoneBox.Visible = true;
            poundBox.Visible = true;
        }


        //************
        //STOPS USER FROM INPUTTING ANYTHING OTHER THAN DIGITS
        private void cmBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void feetBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inchesBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void kgBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void stoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void poundBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        //******** ENDED - ANYTHING OTHER THAN DIGIT
    }

}
