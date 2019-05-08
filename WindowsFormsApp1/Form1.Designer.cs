namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.trainingPointsTextBox = new System.Windows.Forms.TextBox();
            this.aTextView = new System.Windows.Forms.TextBox();
            this.bTextView = new System.Windows.Forms.TextBox();
            this.dTextView = new System.Windows.Forms.TextBox();
            this.neuronsTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.learningStepTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.generateNumbersTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.startTextBox = new System.Windows.Forms.TextBox();
            this.stopTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.adaptiveCheckBox = new System.Windows.Forms.CheckBox();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.button4 = new System.Windows.Forms.Button();
            this.predictBox1 = new System.Windows.Forms.TextBox();
            this.cartesianChart3 = new LiveCharts.WinForms.CartesianChart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.detailsChartCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 105);
            this.button1.TabIndex = 0;
            this.button1.Text = "Learn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trainingPointsTextBox
            // 
            this.trainingPointsTextBox.Location = new System.Drawing.Point(76, 9);
            this.trainingPointsTextBox.Name = "trainingPointsTextBox";
            this.trainingPointsTextBox.Size = new System.Drawing.Size(76, 20);
            this.trainingPointsTextBox.TabIndex = 1;
            this.trainingPointsTextBox.Text = "30";
            // 
            // aTextView
            // 
            this.aTextView.Location = new System.Drawing.Point(48, 76);
            this.aTextView.Name = "aTextView";
            this.aTextView.Size = new System.Drawing.Size(39, 20);
            this.aTextView.TabIndex = 2;
            this.aTextView.Text = "1";
            // 
            // bTextView
            // 
            this.bTextView.Location = new System.Drawing.Point(48, 102);
            this.bTextView.Name = "bTextView";
            this.bTextView.Size = new System.Drawing.Size(39, 20);
            this.bTextView.TabIndex = 3;
            this.bTextView.Text = "8";
            // 
            // dTextView
            // 
            this.dTextView.Location = new System.Drawing.Point(48, 124);
            this.dTextView.Name = "dTextView";
            this.dTextView.Size = new System.Drawing.Size(39, 20);
            this.dTextView.TabIndex = 4;
            this.dTextView.Text = "0,3";
            // 
            // neuronsTextBox
            // 
            this.neuronsTextBox.Location = new System.Drawing.Point(48, 154);
            this.neuronsTextBox.Name = "neuronsTextBox";
            this.neuronsTextBox.Size = new System.Drawing.Size(39, 20);
            this.neuronsTextBox.TabIndex = 5;
            this.neuronsTextBox.Text = "5";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(265, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(273, 335);
            this.dataGridView1.TabIndex = 6;
            // 
            // learningStepTextBox
            // 
            this.learningStepTextBox.Location = new System.Drawing.Point(48, 189);
            this.learningStepTextBox.Name = "learningStepTextBox";
            this.learningStepTextBox.Size = new System.Drawing.Size(50, 20);
            this.learningStepTextBox.TabIndex = 7;
            this.learningStepTextBox.Text = "0,001";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Test after learning";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Training size";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "a:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "d:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "inputs";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "alpha";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // generateNumbersTextBox
            // 
            this.generateNumbersTextBox.Location = new System.Drawing.Point(104, 41);
            this.generateNumbersTextBox.Name = "generateNumbersTextBox";
            this.generateNumbersTextBox.Size = new System.Drawing.Size(48, 20);
            this.generateNumbersTextBox.TabIndex = 17;
            this.generateNumbersTextBox.Text = "120";
            this.generateNumbersTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Generate numbers";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Predict series";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // startTextBox
            // 
            this.startTextBox.Location = new System.Drawing.Point(90, 257);
            this.startTextBox.Name = "startTextBox";
            this.startTextBox.Size = new System.Drawing.Size(37, 20);
            this.startTextBox.TabIndex = 22;
            this.startTextBox.Text = "1";
            // 
            // stopTextBox
            // 
            this.stopTextBox.Location = new System.Drawing.Point(144, 257);
            this.stopTextBox.Name = "stopTextBox";
            this.stopTextBox.Size = new System.Drawing.Size(37, 20);
            this.stopTextBox.TabIndex = 23;
            this.stopTextBox.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "<";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(183, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = ">";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(130, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = ";";
            // 
            // adaptiveCheckBox
            // 
            this.adaptiveCheckBox.AutoSize = true;
            this.adaptiveCheckBox.Location = new System.Drawing.Point(170, 11);
            this.adaptiveCheckBox.Name = "adaptiveCheckBox";
            this.adaptiveCheckBox.Size = new System.Drawing.Size(68, 17);
            this.adaptiveCheckBox.TabIndex = 27;
            this.adaptiveCheckBox.Text = "Adaptive";
            this.adaptiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(544, 10);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(334, 337);
            this.cartesianChart1.TabIndex = 28;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Location = new System.Drawing.Point(12, 355);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(1353, 295);
            this.cartesianChart2.TabIndex = 29;
            this.cartesianChart2.Text = "cartesianChart2";
            this.cartesianChart2.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(74, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 26);
            this.button4.TabIndex = 30;
            this.button4.Text = "Predict next numbers";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // predictBox1
            // 
            this.predictBox1.Location = new System.Drawing.Point(14, 327);
            this.predictBox1.Name = "predictBox1";
            this.predictBox1.Size = new System.Drawing.Size(54, 20);
            this.predictBox1.TabIndex = 31;
            this.predictBox1.Text = "1";
            this.predictBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // cartesianChart3
            // 
            this.cartesianChart3.Location = new System.Drawing.Point(890, 9);
            this.cartesianChart3.Name = "cartesianChart3";
            this.cartesianChart3.Size = new System.Drawing.Size(460, 338);
            this.cartesianChart3.TabIndex = 32;
            this.cartesianChart3.Text = "cartesianChart3";
            this.cartesianChart3.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart3_ChildChanged);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(-3, 353);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Real";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Desired";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(1353, 306);
            this.chart1.TabIndex = 33;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // detailsChartCheckBox
            // 
            this.detailsChartCheckBox.AutoSize = true;
            this.detailsChartCheckBox.Location = new System.Drawing.Point(170, 44);
            this.detailsChartCheckBox.Name = "detailsChartCheckBox";
            this.detailsChartCheckBox.Size = new System.Drawing.Size(85, 17);
            this.detailsChartCheckBox.TabIndex = 34;
            this.detailsChartCheckBox.Text = "Details chart";
            this.detailsChartCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Desired Error";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 37;
            this.textBox1.Text = "0,6";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label12.Location = new System.Drawing.Point(539, 663);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(313, 25);
            this.label12.TabIndex = 38;
            this.label12.Text = "Copyright by Mateusz Sawczuk";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 697);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.detailsChartCheckBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cartesianChart3);
            this.Controls.Add(this.predictBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cartesianChart2);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.adaptiveCheckBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.stopTextBox);
            this.Controls.Add(this.startTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.generateNumbersTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.learningStepTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.neuronsTextBox);
            this.Controls.Add(this.dTextView);
            this.Controls.Add(this.bTextView);
            this.Controls.Add(this.aTextView);
            this.Controls.Add(this.trainingPointsTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox trainingPointsTextBox;
        private System.Windows.Forms.TextBox aTextView;
        private System.Windows.Forms.TextBox bTextView;
        private System.Windows.Forms.TextBox dTextView;
        private System.Windows.Forms.TextBox neuronsTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox learningStepTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox generateNumbersTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox startTextBox;
        private System.Windows.Forms.TextBox stopTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox adaptiveCheckBox;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox predictBox1;
        private LiveCharts.WinForms.CartesianChart cartesianChart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox detailsChartCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
    }
}

