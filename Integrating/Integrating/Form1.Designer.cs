namespace Integrating {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.RectangularGBox = new System.Windows.Forms.GroupBox();
            this.numberOfIterRect = new System.Windows.Forms.NumericUpDown();
            this.LowerBoundRectVal = new System.Windows.Forms.NumericUpDown();
            this.UpperBoundRectVal = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MonteCarloGBox = new System.Windows.Forms.GroupBox();
            this.ThrowsMultMonteVal = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.NumStratsMonteVal = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.SupremumMonteVal = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.InfimumMonteVal = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.LowerBoundMonteVal = new System.Windows.Forms.NumericUpDown();
            this.UpperBoundMonteVal = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.RectangularGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfIterRect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerBoundRectVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperBoundRectVal)).BeginInit();
            this.MonteCarloGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThrowsMultMonteVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumStratsMonteVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupremumMonteVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfimumMonteVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerBoundMonteVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperBoundMonteVal)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(238, 19);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "f(x)";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(550, 390);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(23, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(127, 63);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Visualize";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Choose integration method";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rectangular",
            "Monte-Carlo(with stratification)",
            "Simpson\'s method"});
            this.comboBox1.Location = new System.Drawing.Point(6, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Rectangular";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(238, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(550, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // RectangularGBox
            // 
            this.RectangularGBox.Controls.Add(this.numberOfIterRect);
            this.RectangularGBox.Controls.Add(this.LowerBoundRectVal);
            this.RectangularGBox.Controls.Add(this.UpperBoundRectVal);
            this.RectangularGBox.Controls.Add(this.label4);
            this.RectangularGBox.Controls.Add(this.label3);
            this.RectangularGBox.Controls.Add(this.label2);
            this.RectangularGBox.Controls.Add(this.label1);
            this.RectangularGBox.Location = new System.Drawing.Point(23, 124);
            this.RectangularGBox.Name = "RectangularGBox";
            this.RectangularGBox.Size = new System.Drawing.Size(200, 96);
            this.RectangularGBox.TabIndex = 3;
            this.RectangularGBox.TabStop = false;
            this.RectangularGBox.Text = "Bounds";
            // 
            // numberOfIterRect
            // 
            this.numberOfIterRect.Location = new System.Drawing.Point(117, 65);
            this.numberOfIterRect.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numberOfIterRect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfIterRect.Name = "numberOfIterRect";
            this.numberOfIterRect.Size = new System.Drawing.Size(68, 20);
            this.numberOfIterRect.TabIndex = 9;
            this.numberOfIterRect.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // LowerBoundRectVal
            // 
            this.LowerBoundRectVal.DecimalPlaces = 5;
            this.LowerBoundRectVal.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.LowerBoundRectVal.Location = new System.Drawing.Point(85, 21);
            this.LowerBoundRectVal.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.LowerBoundRectVal.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.LowerBoundRectVal.Name = "LowerBoundRectVal";
            this.LowerBoundRectVal.Size = new System.Drawing.Size(100, 20);
            this.LowerBoundRectVal.TabIndex = 8;
            // 
            // UpperBoundRectVal
            // 
            this.UpperBoundRectVal.DecimalPlaces = 5;
            this.UpperBoundRectVal.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.UpperBoundRectVal.Location = new System.Drawing.Point(85, 43);
            this.UpperBoundRectVal.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.UpperBoundRectVal.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.UpperBoundRectVal.Name = "UpperBoundRectVal";
            this.UpperBoundRectVal.Size = new System.Drawing.Size(100, 20);
            this.UpperBoundRectVal.TabIndex = 7;
            this.UpperBoundRectVal.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of iterations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Upper bound";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lower bound";
            // 
            // MonteCarloGBox
            // 
            this.MonteCarloGBox.Controls.Add(this.ThrowsMultMonteVal);
            this.MonteCarloGBox.Controls.Add(this.label11);
            this.MonteCarloGBox.Controls.Add(this.NumStratsMonteVal);
            this.MonteCarloGBox.Controls.Add(this.label5);
            this.MonteCarloGBox.Controls.Add(this.SupremumMonteVal);
            this.MonteCarloGBox.Controls.Add(this.label10);
            this.MonteCarloGBox.Controls.Add(this.InfimumMonteVal);
            this.MonteCarloGBox.Controls.Add(this.label9);
            this.MonteCarloGBox.Controls.Add(this.LowerBoundMonteVal);
            this.MonteCarloGBox.Controls.Add(this.UpperBoundMonteVal);
            this.MonteCarloGBox.Controls.Add(this.label6);
            this.MonteCarloGBox.Controls.Add(this.label7);
            this.MonteCarloGBox.Controls.Add(this.label8);
            this.MonteCarloGBox.Location = new System.Drawing.Point(23, 126);
            this.MonteCarloGBox.Name = "MonteCarloGBox";
            this.MonteCarloGBox.Size = new System.Drawing.Size(200, 162);
            this.MonteCarloGBox.TabIndex = 4;
            this.MonteCarloGBox.TabStop = false;
            this.MonteCarloGBox.Text = "Bounds";
            this.MonteCarloGBox.Visible = false;
            // 
            // ThrowsMultMonteVal
            // 
            this.ThrowsMultMonteVal.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ThrowsMultMonteVal.Location = new System.Drawing.Point(99, 131);
            this.ThrowsMultMonteVal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ThrowsMultMonteVal.Name = "ThrowsMultMonteVal";
            this.ThrowsMultMonteVal.Size = new System.Drawing.Size(86, 20);
            this.ThrowsMultMonteVal.TabIndex = 17;
            this.ThrowsMultMonteVal.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "ThrowsMultiplier";
            // 
            // NumStratsMonteVal
            // 
            this.NumStratsMonteVal.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumStratsMonteVal.Location = new System.Drawing.Point(100, 109);
            this.NumStratsMonteVal.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumStratsMonteVal.Name = "NumStratsMonteVal";
            this.NumStratsMonteVal.Size = new System.Drawing.Size(85, 20);
            this.NumStratsMonteVal.TabIndex = 15;
            this.NumStratsMonteVal.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Number of strats";
            // 
            // SupremumMonteVal
            // 
            this.SupremumMonteVal.DecimalPlaces = 5;
            this.SupremumMonteVal.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.SupremumMonteVal.Location = new System.Drawing.Point(85, 87);
            this.SupremumMonteVal.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.SupremumMonteVal.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.SupremumMonteVal.Name = "SupremumMonteVal";
            this.SupremumMonteVal.Size = new System.Drawing.Size(100, 20);
            this.SupremumMonteVal.TabIndex = 13;
            this.SupremumMonteVal.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Supremum";
            // 
            // InfimumMonteVal
            // 
            this.InfimumMonteVal.DecimalPlaces = 5;
            this.InfimumMonteVal.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.InfimumMonteVal.Location = new System.Drawing.Point(85, 65);
            this.InfimumMonteVal.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.InfimumMonteVal.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.InfimumMonteVal.Name = "InfimumMonteVal";
            this.InfimumMonteVal.Size = new System.Drawing.Size(100, 20);
            this.InfimumMonteVal.TabIndex = 11;
            this.InfimumMonteVal.Value = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Infimum";
            // 
            // LowerBoundMonteVal
            // 
            this.LowerBoundMonteVal.DecimalPlaces = 5;
            this.LowerBoundMonteVal.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.LowerBoundMonteVal.Location = new System.Drawing.Point(85, 21);
            this.LowerBoundMonteVal.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.LowerBoundMonteVal.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.LowerBoundMonteVal.Name = "LowerBoundMonteVal";
            this.LowerBoundMonteVal.Size = new System.Drawing.Size(100, 20);
            this.LowerBoundMonteVal.TabIndex = 8;
            // 
            // UpperBoundMonteVal
            // 
            this.UpperBoundMonteVal.DecimalPlaces = 5;
            this.UpperBoundMonteVal.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.UpperBoundMonteVal.Location = new System.Drawing.Point(85, 43);
            this.UpperBoundMonteVal.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.UpperBoundMonteVal.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.UpperBoundMonteVal.Name = "UpperBoundMonteVal";
            this.UpperBoundMonteVal.Size = new System.Drawing.Size(100, 20);
            this.UpperBoundMonteVal.TabIndex = 7;
            this.UpperBoundMonteVal.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Upper bound";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Lower bound";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(108, 294);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 322);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MonteCarloGBox);
            this.Controls.Add(this.RectangularGBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Численное интегрирование";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.RectangularGBox.ResumeLayout(false);
            this.RectangularGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfIterRect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerBoundRectVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperBoundRectVal)).EndInit();
            this.MonteCarloGBox.ResumeLayout(false);
            this.MonteCarloGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThrowsMultMonteVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumStratsMonteVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupremumMonteVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfimumMonteVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerBoundMonteVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperBoundMonteVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox RectangularGBox;
        private System.Windows.Forms.NumericUpDown numberOfIterRect;
        private System.Windows.Forms.NumericUpDown LowerBoundRectVal;
        private System.Windows.Forms.NumericUpDown UpperBoundRectVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox MonteCarloGBox;
        private System.Windows.Forms.NumericUpDown SupremumMonteVal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown InfimumMonteVal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown LowerBoundMonteVal;
        private System.Windows.Forms.NumericUpDown UpperBoundMonteVal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown ThrowsMultMonteVal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown NumStratsMonteVal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label14;
    }
}

