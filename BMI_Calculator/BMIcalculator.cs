using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name  - Gurmanpreet Kaur 
 * Student Number - 300933392
 * description - Created the form for BMI Calculator
 * version 0.3 - Added SpalshForm and added the formclosing event handler
 * */
namespace BMI_Calculator
{
    public partial class BMIcalculator : Form
    {
        public BMIcalculator()
        {
            InitializeComponent();
        }

        private void MetricButton_CheckedChanged(object sender, EventArgs e)
        {
            if(MetricButton.Checked)
            {
                HeightUnitLabel.Text = "Meters";
                WeightUnitLabel.Text = "Kilograms";
            }
            
        }

        private void ImpericalButton_CheckedChanged(object sender, EventArgs e)
        {
            if(ImpericalButton.Checked)
            {
                HeightUnitLabel.Text = "Inches";
                WeightUnitLabel.Text = "Pounds";
            }
           
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            if (HeightTextBox.Text == null || WeightTextBox.Text == null)
            {
                ResultTextBox.Text = "Please enter any value!!";
            }
            else
            {
                if (MetricButton.Checked)
                {
                    double height = 0;
                    double weight = 0;
                    height = Convert.ToDouble(HeightTextBox.Text);
                    weight = Convert.ToDouble(WeightTextBox.Text);
                    double BMI = 0;
                    BMI = weight / (height * height);
                    BMI = Math.Round(BMI, 2);
                    ResultTextBox.Text = "" + BMI;
                }
            }
            if(ImpericalButton.Checked)
            {
                if (HeightTextBox.Text == null || WeightTextBox.Text == null)
                {
                    ResultTextBox.Text = "Please enter any value!!";
                }
                else
                {
                    double height = 0;
                    double weight = 0;
                    height = Convert.ToDouble(HeightTextBox.Text);
                    weight = Convert.ToDouble(WeightTextBox.Text);
                    double BMI = 0;
                    BMI = (weight * 703) / (height * height);
                    BMI = Math.Round(BMI,2);
                    ResultTextBox.Text = "" + BMI;
                }
            }
            if (Convert.ToDouble(ResultTextBox.Text) < 18.5)
            {
                BMIscaleTextBox.Text = "Your are UnderWeight";
            }
            if (Convert.ToDouble(ResultTextBox.Text) >= 18.5 && Convert.ToDouble(ResultTextBox.Text) <= 24.9)
            {
                BMIscaleTextBox.Text = "Your are Normal";
            }
            if (Convert.ToDouble(ResultTextBox.Text) >= 25 && Convert.ToDouble(ResultTextBox.Text) <= 29.9)
            {
                BMIscaleTextBox.Text = "Your are Overweight";
            }
            if (Convert.ToDouble(ResultTextBox.Text) >= 30)
            {
                BMIscaleTextBox.Text = "Your are Obesed";
            }
        }

        private void BMIcalculator_Load(object sender, EventArgs e)
        {
            HeightTextBox.Text = "0";
            WeightTextBox.Text = "0";
            if (MetricButton.Checked == false && ImpericalButton.Checked == false)
            {
                ResultTextBox.Text = "Please select unit value!!";
            }
      }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if(HeightTextBox.Text == "0")
            {
                HeightTextBox.Text = HeightTextBox.Text;
            }
        }

        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (WeightTextBox.Text == "0")
            {
                WeightTextBox.Text = WeightTextBox.Text;

                    }
        }

      

        private void BMIscaleTextBox_TextChanged_1(object sender, EventArgs e)
        {
           



        }

        private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// this is an event handler for the "FormClosing" event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMIcalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CalculatorTableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            _clear();
           
        }

        private void _clear()
        {
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";
            ImpericalButton.Checked = false;
            MetricButton.Checked = false;
            ResultTextBox.Text = "";
            BMIscaleTextBox.Text = "";
        }
    }
}
