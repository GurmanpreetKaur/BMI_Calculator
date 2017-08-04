namespace BMI_Calculator
{
    partial class BMIcalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CalculatorTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.ImpericalButton = new System.Windows.Forms.RadioButton();
            this.MyHeightButton = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ResultButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.CalculatorTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculatorTableLayout
            // 
            this.CalculatorTableLayout.ColumnCount = 2;
            this.CalculatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CalculatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CalculatorTableLayout.Controls.Add(this.MyHeightButton, 0, 0);
            this.CalculatorTableLayout.Controls.Add(this.HeightTextBox, 1, 0);
            this.CalculatorTableLayout.Controls.Add(this.MyWeightLabel, 0, 1);
            this.CalculatorTableLayout.Controls.Add(this.WeightTextBox, 1, 1);
            this.CalculatorTableLayout.Controls.Add(this.ResultButton, 0, 2);
            this.CalculatorTableLayout.Controls.Add(this.ResultLabel, 0, 3);
            this.CalculatorTableLayout.Controls.Add(this.textBox1, 1, 3);
            this.CalculatorTableLayout.Location = new System.Drawing.Point(12, 156);
            this.CalculatorTableLayout.Name = "CalculatorTableLayout";
            this.CalculatorTableLayout.RowCount = 4;
            this.CalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayout.Size = new System.Drawing.Size(287, 273);
            this.CalculatorTableLayout.TabIndex = 0;
            // 
            // MetricButton
            // 
            this.MetricButton.AutoSize = true;
            this.MetricButton.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricButton.ForeColor = System.Drawing.Color.Black;
            this.MetricButton.Location = new System.Drawing.Point(24, 45);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(89, 29);
            this.MetricButton.TabIndex = 1;
            this.MetricButton.TabStop = true;
            this.MetricButton.Text = "Metric";
            this.MetricButton.UseVisualStyleBackColor = true;
            // 
            // ImpericalButton
            // 
            this.ImpericalButton.AutoSize = true;
            this.ImpericalButton.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImpericalButton.ForeColor = System.Drawing.Color.Black;
            this.ImpericalButton.Location = new System.Drawing.Point(164, 45);
            this.ImpericalButton.Name = "ImpericalButton";
            this.ImpericalButton.Size = new System.Drawing.Size(113, 29);
            this.ImpericalButton.TabIndex = 2;
            this.ImpericalButton.TabStop = true;
            this.ImpericalButton.Text = "Imperical";
            this.ImpericalButton.UseVisualStyleBackColor = true;
            // 
            // MyHeightButton
            // 
            this.MyHeightButton.AutoSize = true;
            this.MyHeightButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyHeightButton.ForeColor = System.Drawing.Color.Black;
            this.MyHeightButton.Location = new System.Drawing.Point(3, 0);
            this.MyHeightButton.Name = "MyHeightButton";
            this.MyHeightButton.Size = new System.Drawing.Size(94, 23);
            this.MyHeightButton.TabIndex = 0;
            this.MyHeightButton.Text = "My Height:";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTextBox.Location = new System.Drawing.Point(146, 3);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(50, 29);
            this.HeightTextBox.TabIndex = 3;
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightLabel.ForeColor = System.Drawing.Color.Black;
            this.MyWeightLabel.Location = new System.Drawing.Point(3, 68);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(98, 23);
            this.MyWeightLabel.TabIndex = 4;
            this.MyWeightLabel.Text = "My Weight:";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTextBox.Location = new System.Drawing.Point(146, 71);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(50, 29);
            this.WeightTextBox.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(146, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 6;
            // 
            // ResultButton
            // 
            this.ResultButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultButton.ForeColor = System.Drawing.Color.Black;
            this.ResultButton.Location = new System.Drawing.Point(3, 139);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(137, 31);
            this.ResultButton.TabIndex = 7;
            this.ResultButton.Text = "Calculate BMI";
            this.ResultButton.UseVisualStyleBackColor = true;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.Black;
            this.ResultLabel.Location = new System.Drawing.Point(3, 204);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(112, 24);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = "Your Result:";
            // 
            // BMIcalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ImpericalButton);
            this.Controls.Add(this.MetricButton);
            this.Controls.Add(this.CalculatorTableLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.Name = "BMIcalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMIcalculator";
            this.CalculatorTableLayout.ResumeLayout(false);
            this.CalculatorTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CalculatorTableLayout;
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.RadioButton ImpericalButton;
        private System.Windows.Forms.Label MyHeightButton;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ResultButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label ResultLabel;
    }
}

