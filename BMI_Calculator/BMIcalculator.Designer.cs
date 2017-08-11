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
            this.MyHeightButton = new System.Windows.Forms.Label();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.ResultButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.ImpericalButton = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CalculatorTableLayout.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculatorTableLayout
            // 
            this.CalculatorTableLayout.ColumnCount = 3;
            this.CalculatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.79166F));
            this.CalculatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.20833F));
            this.CalculatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.CalculatorTableLayout.Controls.Add(this.MyHeightButton, 0, 0);
            this.CalculatorTableLayout.Controls.Add(this.HeightUnitLabel, 2, 0);
            this.CalculatorTableLayout.Controls.Add(this.HeightTextBox, 1, 0);
            this.CalculatorTableLayout.Controls.Add(this.MyWeightLabel, 0, 1);
            this.CalculatorTableLayout.Controls.Add(this.WeightTextBox, 1, 1);
            this.CalculatorTableLayout.Controls.Add(this.ResultButton, 0, 2);
            this.CalculatorTableLayout.Controls.Add(this.ResultLabel, 0, 3);
            this.CalculatorTableLayout.Controls.Add(this.ResultTextBox, 1, 3);
            this.CalculatorTableLayout.Controls.Add(this.textBox2, 1, 4);
            this.CalculatorTableLayout.Controls.Add(this.WeightUnitLabel, 2, 1);
            this.CalculatorTableLayout.Location = new System.Drawing.Point(12, 115);
            this.CalculatorTableLayout.Name = "CalculatorTableLayout";
            this.CalculatorTableLayout.RowCount = 5;
            this.CalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayout.Size = new System.Drawing.Size(287, 273);
            this.CalculatorTableLayout.TabIndex = 0;
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
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.AutoSize = true;
            this.HeightUnitLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightUnitLabel.ForeColor = System.Drawing.Color.Black;
            this.HeightUnitLabel.Location = new System.Drawing.Point(195, 0);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(0, 23);
            this.HeightUnitLabel.TabIndex = 3;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTextBox.Location = new System.Drawing.Point(137, 3);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(50, 26);
            this.HeightTextBox.TabIndex = 3;
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightLabel.ForeColor = System.Drawing.Color.Black;
            this.MyWeightLabel.Location = new System.Drawing.Point(3, 54);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(98, 23);
            this.MyWeightLabel.TabIndex = 4;
            this.MyWeightLabel.Text = "My Weight:";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTextBox.Location = new System.Drawing.Point(137, 57);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(50, 26);
            this.WeightTextBox.TabIndex = 5;
            // 
            // ResultButton
            // 
            this.ResultButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultButton.ForeColor = System.Drawing.Color.Black;
            this.ResultButton.Location = new System.Drawing.Point(3, 111);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(125, 34);
            this.ResultButton.TabIndex = 7;
            this.ResultButton.Text = "Calculate BMI";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.Black;
            this.ResultLabel.Location = new System.Drawing.Point(3, 162);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(112, 24);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = "Your Result:";
            // 
            // ResultTextBox
            // 
            this.CalculatorTableLayout.SetColumnSpan(this.ResultTextBox, 2);
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.Location = new System.Drawing.Point(137, 165);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(147, 26);
            this.ResultTextBox.TabIndex = 6;
            // 
            // textBox2
            // 
            this.CalculatorTableLayout.SetColumnSpan(this.textBox2, 2);
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(137, 219);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 39);
            this.textBox2.TabIndex = 10;
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.AutoSize = true;
            this.WeightUnitLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightUnitLabel.ForeColor = System.Drawing.Color.Black;
            this.WeightUnitLabel.Location = new System.Drawing.Point(195, 54);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(0, 23);
            this.WeightUnitLabel.TabIndex = 11;
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
            this.MetricButton.CheckedChanged += new System.EventHandler(this.MetricButton_CheckedChanged);
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
            this.ImpericalButton.CheckedChanged += new System.EventHandler(this.ImpericalButton_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 29);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // BMIcalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.Load += new System.EventHandler(this.BMIcalculator_Load);
            this.CalculatorTableLayout.ResumeLayout(false);
            this.CalculatorTableLayout.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button ResultButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label HeightUnitLabel;
        private System.Windows.Forms.Label WeightUnitLabel;
    }
}

