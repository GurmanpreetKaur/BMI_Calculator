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
 * version 0.4 - Modified the ResultButton_Click method and added proper comments for all the methods
 * */
namespace BMI_Calculator
{
    public partial class BMIcalculator : Form
    {
        
        //private instance variables ------------------------
        private double _height;
        private double _weight;
        private double _result;

        //public properties-------------------
        public new double Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }
        public double Weight
        {
            get
            {
                return this._weight;
            }
            set
            {
                this._weight = value;
            }
        }
  
        public double Result
        {
            get
            {
                return this._result;
            }
            set
            {
                this._result = value;
            }
        }

        public BMIcalculator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the method that shows unit values if Metric Button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricButton_CheckedChanged(object sender, EventArgs e)
        {
            if(MetricButton.Checked)
            {
                HeightUnitLabel.Text = "Meters";
                WeightUnitLabel.Text = "Kilograms";
            }
            
        }

        /// <summary>
        /// This is the method that shows unit values if Imperial Button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImpericalButton_CheckedChanged(object sender, EventArgs e)
        {
            if(ImpericalButton.Checked)
            {
                HeightUnitLabel.Text = "Inches";
                WeightUnitLabel.Text = "Pounds";
            }
           
        }
        /// <summary>
        /// This is the method that does the calculation when calculate BMI buttonis pressed based on the unit value selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResultButton_Click(object sender, EventArgs e)
        {
            if (HeightTextBox.Text == null || WeightTextBox.Text == null)
            {
                ResultTextBox.Text = "Please enter any value!!";
            }
            if (MetricButton.Checked)
                {
                this.Height = Convert.ToDouble(HeightTextBox.Text);
                this.Weight = Convert.ToDouble(WeightTextBox.Text);
                    this.Result = this.Weight / (this.Height * this.Height);
                    this.Result = Math.Round(this.Result, 2);
                    ResultTextBox.Text = this.Result.ToString();
                }
            if (ImpericalButton.Checked)
            {
                this.Height = Convert.ToDouble(HeightTextBox.Text);
                this.Weight = Convert.ToDouble(WeightTextBox.Text);
                this.Result = (this.Weight * 703) / (this.Height * this.Height);
                    this.Result = Math.Round(this.Result,2);
                    ResultTextBox.Text = this.Result.ToString();
                }
            BMIscale();
        }

        /// <summary>
        /// This is the method that shows the message according to the BMI calculated
        /// </summary>
        private void BMIscale()
        {
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

        /// <summary>
        /// This is the method that gives 0 to height and weight by default and it askes the user to select any of the unit values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
           
        }

        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {
        }

      

        private void BMIscaleTextBox_TextChanged_1(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// This is the method that forces the user to enter only numeric values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /* I found this code from this site : https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers */
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
        /// <summary>
        /// This is the method that forces the user to enter only numeric values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// this method describes the function of Reset Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            _clear();
        }
        /// <summary>
        /// This is the clear method that clears everything 
        /// </summary>
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
