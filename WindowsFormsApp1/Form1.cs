using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private StarterData starterData;
        Perceptron perceptron;
        int epochConstantLength = 0;
        int epochConstantLength1 = 0;
        int epochAdaptiveLength = 0;
        int epochAdaptiveLength1 = 0;
        List<double> epochConstant = new List<double>();
        List<double> epochAdaptive = new List<double>();
        List<double> epochConstant1 = new List<double>();
        List<double> epochAdaptive1 = new List<double>();
        DataTable dt = new DataTable();
        Thread predictThread;
        List<double> tempList = new List<double>();
        int numberOfPoints;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            starterData = new StarterData(
                Convert.ToInt32(neuronsTextBox.Text),
                Convert.ToDouble(aTextView.Text),
                Convert.ToDouble(bTextView.Text),
                Convert.ToDouble(dTextView.Text)
                );

            numberOfPoints = (Convert.ToInt32(trainingPointsTextBox.Text));
            
            perceptron = new Perceptron(
                Convert.ToInt32(neuronsTextBox.Text),
                Convert.ToInt32(trainingPointsTextBox.Text),
                Convert.ToDouble(learningStepTextBox.Text),
                starterData.GenerateStartPoints(Convert.ToInt32(generateNumbersTextBox.Text)),
                adaptiveCheckBox.Checked,
                Convert.ToDouble(textBox1.Text)
                );
            perceptron.secondMethod = false;
            perceptron.Train();
            ClearZoom();
            VisualizationDataOnGrid();
            VisualisationDataOnPlot();
            
        }

        private void ClearZoom()
        {
            //to clear the current zoom/pan just set the axis limits to double.NaN

            cartesianChart1.AxisX[0].MinValue = double.NaN;
            cartesianChart1.AxisX[0].MaxValue = double.NaN;
            cartesianChart1.AxisY[0].MinValue = double.NaN;
            cartesianChart1.AxisY[0].MaxValue = double.NaN;
        }

        private void VisualisationDataOnPlot()
        {
            
            //Epoch chart line
            if (!perceptron.secondMethod)
            {
                cartesianChart1.Series.Clear();

                if (adaptiveCheckBox.Checked)
                {
                    epochAdaptive.Clear();
                    foreach (var item in perceptron.epochEs)
                    {

                        epochAdaptive.Add(item);
                    }
                    epochAdaptiveLength = epochAdaptive.Count();

                }
                else
                {
                    epochConstant.Clear();
                    foreach (var item in perceptron.epochEs)
                    {
                        epochConstant.Add(item);
                    }
                    epochConstantLength = epochConstant.Count();
                }
                cartesianChart1.Zoom = ZoomingOptions.X;                
                //cartesianChart1.AxisY.Add(
                //new Axis
                //{
                //    IsMerged = true,
                //    MinValue = 0
                    
                //});

                cartesianChart1.LegendLocation = LegendLocation.Right;

                if (epochConstantLength > 0)
                {
                    cartesianChart1.Series.Add(new LineSeries
                    {
                        Title = "Epoch - constant",
                        Values = new ChartValues<double>(),                       
                    });
                    cartesianChart1.Series[0].Values.Clear();
                    foreach (var item in epochConstant)
                    {
                        if (epochConstantLength > 0)
                        {
                            cartesianChart1.Series[0].Values.Add(item);

                        }
                    }
                }
                if (epochAdaptiveLength > 0)
                {
                    cartesianChart1.Series.Add(new LineSeries
                    {
                        Title = "Epoch - adaptive",
                        Values = new ChartValues<double>(),
                    });
                    cartesianChart1.Series[1].Values.Clear();
                    foreach (var item in epochAdaptive)
                    {
                        cartesianChart1.Series[1].Values.Add(item);


                    }
                }
            }
            else
            {
                //cartesianChart1.Series.Clear();
                //Epoch chart line
                epochAdaptive1.Clear();
                epochConstant1.Clear();
                if (adaptiveCheckBox.Checked)
                {
                    epochAdaptive1.Clear();
                    foreach (var item in perceptron.epochEs)
                    {

                        epochAdaptive1.Add(item);
                    }
                    epochAdaptiveLength1 = epochAdaptive1.Count();

                }
                else
                {
                    epochConstant1.Clear();
                    foreach (var item in perceptron.epochEs)
                    {
                        epochConstant1.Add(item);
                    }
                    epochConstantLength1 = epochConstant1.Count();
                }
                cartesianChart1.Zoom = ZoomingOptions.X;
                
                //cartesianChart1.AxisY.Add(
                //new Axis
                //{
                //    IsMerged = true,
                //    MinValue = 0
                //});

                cartesianChart1.LegendLocation = LegendLocation.Right;

                
                if (epochConstantLength1 > 0)
                {
                    cartesianChart1.Series.Add(new LineSeries
                    {
                        Title = "Epoch2 - constant",
                        Values = new ChartValues<double>(),
                    });
                    cartesianChart1.Series[2].Values.Clear();
                    foreach (var item in epochConstant1)
                    {
                        if (epochConstantLength1 > 0)
                        {
                            cartesianChart1.Series[2].Values.Add(item);

                        }
                    }
                }if (epochAdaptiveLength1 > 0)
                {
                    cartesianChart1.Series.Add(new LineSeries
                    {
                        Title = "Epoch2 - adaptive",
                        Values = new ChartValues<double>(),
                    });
                    cartesianChart1.Series[3].Values.Clear();
                    foreach (var item in epochAdaptive1)
                    {
                        cartesianChart1.Series[3].Values.Add(item);


                    }
                }
            }
            //Real and desired numbers - plot
            if (!detailsChartCheckBox.Checked)
            {
                cartesianChart2.Visible = false;
                chart1.Visible = true;                
                int counter = Convert.ToInt32(neuronsTextBox.Text);
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                for (int i = 0; i < perceptron.yList.Count; i++)
                {

                    chart1.Series["Real"].Points.AddXY(i, perceptron.yList[i]);
                    if (!perceptron.secondMethod)
                    {
                    chart1.Series["Desired"].Points.AddXY(i, perceptron.eList[counter]);

                    }
                    else
                    {
                        chart1.Series["Desired"].Points.AddXY(i, perceptron.newEList[counter]);
                    }

                    if (counter == Convert.ToInt32(trainingPointsTextBox.Text) - 1)
                    {
                        counter = Convert.ToInt32(neuronsTextBox.Text);
                    }
                    else
                    {
                        counter++;

                    }
                }
            }
            else
            {
                //Real and Desired chart line
                cartesianChart2.Visible = true;

                chart1.Visible = false;
               // cartesianChart2.Zoom = ZoomingOptions.X;
                cartesianChart2.LegendLocation = LegendLocation.Right;
                cartesianChart2.AxisY.Clear();
                cartesianChart2.AxisX.Clear();
                var yValues = new ChartValues<double>();
                yValues.AddRange(perceptron.yList);

                cartesianChart2.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Title = "Real",
                        Values = yValues,
                    },new LineSeries
                    {
                        Title = "Desired",
                        Values = new ChartValues<double>(),
                    }
                };

                int counter = Convert.ToInt32(neuronsTextBox.Text);
                if (!perceptron.secondMethod)
                {
                    for (int i = 0; i < perceptron.yList.Count; i++)
                    {
                        cartesianChart2.Series[1].Values.Add(perceptron.eList[counter]);
                        if (counter == Convert.ToInt32(trainingPointsTextBox.Text) - 1)
                        {
                            counter = Convert.ToInt32(neuronsTextBox.Text);
                        }
                        else
                        {
                            counter++;

                        }
                    }
                }
                else
                {
                    for (int i = 0; i < perceptron.yList.Count; i++)
                    {
                        cartesianChart2.Series[1].Values.Add(perceptron.newEList[counter]);
                        if (counter == Convert.ToInt32(trainingPointsTextBox.Text) - 1)
                        {
                            counter = Convert.ToInt32(neuronsTextBox.Text);
                        }
                        else
                        {
                            counter++;

                        }
                    }
                }
            }
        }

        private void VisualizationDataOnGrid()
        {
            var data = perceptron.weight;
            int tmp = 0;           

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Lp.", null);            

            for (int i = 0; i < data.Count; i++)
            {
                dataGridView1.Columns.Add("W" + (i+1).ToString(),null);
            }

            for (int i = 0; i < Convert.ToInt32(data[0].Count) + perceptron.numberOfInputs; i++)
            {
                dataGridView1.Rows.Add();
                
            }
            //Lp
            for (int i = 0; i < Convert.ToInt32(data[0].Count) + perceptron.numberOfInputs; i++)
            {
                dataGridView1[0, i].Value = i+1;
            }
            //weights
            for (int i = 0; i < data.Count; i++)
            {
                tmp = 0;
                foreach (var item in data[i])
                {
                    dataGridView1[i+1,tmp++].Value = item;
                }

            }

            dataGridView1.Columns.Add("T",null);
            tmp = 0;
            foreach (var item in perceptron.tList)
            {
               dataGridView1[data.Count+1, tmp++].Value = item;
            }

            dataGridView1.Columns.Add("Y",null);
            tmp = perceptron.numberOfInputs;
            for (int i = 0; i < perceptron.yList.Count; i++)
            {
                dataGridView1[data.Count + 2, tmp++].Value = perceptron.yList[i];
            }            

            dataGridView1.Columns.Add("E",null);
            tmp = 0;
            foreach (var item in perceptron.eList)
            {
                dataGridView1[data.Count + 3, tmp++].Value = item;
                if(tmp == numberOfPoints)
                {
                    break;
                }
            }                 

            dataGridView1.Columns.Add("Es", null);
            tmp = 0;
            foreach (var item in perceptron.epochEs)
            {
                tmp += Convert.ToInt32(trainingPointsTextBox.Text) - Convert.ToInt32(neuronsTextBox.Text);
                dataGridView1[data.Count + 4, tmp+4].Value = item;
            }       

        }

        private void button2_Click(object sender, EventArgs e)
        {
            perceptron.TestTraining();
            Form2 form2 = new Form2(perceptron);
            form2.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            perceptron.PredictNextNumbers(Convert.ToInt32(startTextBox.Text),Convert.ToInt32(stopTextBox.Text));
            Form3 form3 = new Form3(perceptron);
            form3.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            perceptron.Predict(Convert.ToInt32(predictBox1.Text));

            var yValues = new ChartValues<double>();

            cartesianChart3.LegendLocation = LegendLocation.Right;
            cartesianChart3.AxisY.Clear();
            cartesianChart3.AxisX.Clear();
            yValues.AddRange(perceptron.preYList);
            cartesianChart3.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Predict number",
                    Values = yValues,
                }
            };           

        }      

        private void cartesianChart3_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            starterData = new StarterData(
               Convert.ToInt32(neuronsTextBox.Text),
               Convert.ToDouble(aTextView.Text),
               Convert.ToDouble(bTextView.Text),
               Convert.ToDouble(dTextView.Text)
               );

            numberOfPoints = (Convert.ToInt32(trainingPointsTextBox.Text));

            perceptron = new Perceptron(
                Convert.ToInt32(neuronsTextBox.Text),
                Convert.ToInt32(trainingPointsTextBox.Text),
                Convert.ToDouble(learningStepTextBox.Text),
                starterData.GenerateStartPoints(Convert.ToInt32(generateNumbersTextBox.Text)),
                adaptiveCheckBox.Checked,
                Convert.ToDouble(textBox1.Text)
                );
            perceptron.secondMethod = true;
            perceptron.Train2();
            ClearZoom();
            VisualizationDataOnGrid();
            VisualisationDataOnPlot();

        }
    }
}
