using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3(Perceptron perceptron)
        {
            int tmp = 0;
            List<double> deviation = new List<double>();
            InitializeComponent();
            dataGridView1.Columns.Add("Y", null);
            dataGridView1.Columns.Add("E", null);
            for (int i = 0; i < perceptron.eList.Count + 5; i++)
            {
                dataGridView1.Rows.Add();

            }
            //Add Y
            tmp = 0;
            for (int i = 0; i < perceptron.yList.Count; i++)
            {
                dataGridView1[0, tmp++].Value = perceptron.yList[i];
            }
            //Add E
            tmp = 0;
            if (!perceptron.secondMethod)
            {
                for (int i = 0; i <= perceptron.stop - perceptron.start; i++)
                {
                    dataGridView1[1, tmp++].Value = perceptron.eList[i+perceptron.start-1];
                }
            }
            else
            {
                for (int i = 0; i <= perceptron.stop - perceptron.start; i++)
                {
                    dataGridView1[1, tmp++].Value = perceptron.newEList[i + perceptron.start - 1];
                }
            }
            
            //Add W
            var data = perceptron.weight;
            for (int i = 0; i < data.Count; i++)
            {
                dataGridView2.Columns.Add("W" + (i + 1).ToString(), null);
            }
            for (int i = 0; i < data.Count+1; i++)
            {
                if(i == data.Count)
                {
                    //Add T
                    dataGridView2.Columns.Add("T", null);
                    dataGridView2[i, 0].Value = perceptron.tList.Last();
                    break;
                }
                dataGridView2[i, 0].Value = data[i].Last();
            }
                        
            tmp = 0;

            //add data to chart1
            cartesianChart1.Series = new SeriesCollection
            {
                 new LineSeries
                {
                    Title = "Desired",
                    Values = new ChartValues<double>(),
                },
                new LineSeries
                {
                    Title = "Real",
                    Values = new ChartValues<double>(),
                }
            };

            cartesianChart1.AxisY.Clear();
            cartesianChart1.AxisX.Clear();
            cartesianChart1.LegendLocation = LegendLocation.Right;

            if (!perceptron.secondMethod)
            {
                for (int i = 0; i <= perceptron.stop - perceptron.start; i++)
                {                
                    cartesianChart1.Series[0].Values.Add(perceptron.eList[i + perceptron.start - 1]);               

                }
            }
            else
            {
                for (int i = 0; i <= perceptron.stop - perceptron.start; i++)
                {
                    cartesianChart1.Series[0].Values.Add(perceptron.newEList[i + perceptron.start - 1]);

                }
            }
            for (int i = 0; i < perceptron.yList.Count; i++)
            {               
                cartesianChart1.Series[1].Values.Add(perceptron.yList[i]);
            }
            //add data to chart2
            cartesianChart2.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Deviation",
                    Values = new ChartValues<double>(),
                },
                
            };

            cartesianChart2.AxisY.Clear();
            cartesianChart2.AxisX.Clear();
            cartesianChart2.LegendLocation = LegendLocation.Right;
            deviation.Clear();
            if (!perceptron.secondMethod)
            {

                for (int i = 0; i < perceptron.yList.Count; i++)
                {
                    deviation.Add(perceptron.yList[i] - perceptron.eList[perceptron.start-1+i]);
                }
            }
            else
            {
                for (int i = 0; i < perceptron.yList.Count; i++)
                {
                    deviation.Add(perceptron.yList[i] - perceptron.newEList[perceptron.start - 1 + i]);
                }
            }
            for (int i = 0; i < deviation.Count; i++)
            {                
                cartesianChart2.Series[0].Values.Add(deviation[i]);

            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void cartesianChart2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
