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
 * version 0.2 - Added functionality to Calculate BMI button AND Addded a new method so that the user must select any of the unit values
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
                HeightUnitLabel.Text = "Meter";
                WeightUnitLabel.Text = "Kilogram";
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
            
            if (MetricButton.Checked)
            {
                double height = 0;
                double weight = 0;
                height = Convert.ToDouble(HeightTextBox.Text);
                weight = Convert.ToDouble(WeightTextBox.Text);
                double BMI = 0;
                BMI = (weight) / (height * height);
                ResultTextBox.Text = "" + BMI;
            }
            if(ImpericalButton.Checked)
            {
                double height = 0;
                double weight = 0;
                height = Convert.ToDouble(HeightTextBox.Text);
                weight = Convert.ToDouble(WeightTextBox.Text);
                double BMI = 0;
                BMI = (weight * 703) / (height * height);
                ResultTextBox.Text = "" + BMI;
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
    }
}
