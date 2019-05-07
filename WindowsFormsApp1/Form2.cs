using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form    {
        
        public Form2(Perceptron perceptron)
        {
            InitializeComponent();

            dataGridView1.Columns.Add("Es - training", null);
                       
            dataGridView1[0,0].Value = perceptron.EsList[perceptron.EsList.Count-2];
            dataGridView1.Columns.Add("Es - after training", null);
            dataGridView1[1, 0].Value = perceptron.EsList.Last() ;

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Y - learning",
                    Values = new ChartValues<double>(),
                },
                new LineSeries
                {
                    Title = "Y - after learning",
                    Values = new ChartValues<double>(),
                }
            };

            cartesianChart1.AxisY.Clear();
            cartesianChart1.AxisX.Clear();
            cartesianChart1.LegendLocation = LegendLocation.Right;

            int counter = perceptron.numberOfInputs;
            for (int i = 0; i < perceptron.yList.Count; i++)
            {
                cartesianChart1.Series[0].Values.Add(perceptron.yList[i]);
                if (!perceptron.secondMethod)
                {
                    cartesianChart1.Series[1].Values.Add(perceptron.eList[counter]);
                }
                else
                {
                    cartesianChart1.Series[1].Values.Add(perceptron.newEList[counter]);
                }
                if (counter == perceptron.numberOfPoints-1)
                {
                    counter = perceptron.numberOfInputs;
                }
                else
                {
                    counter++;

                }
            }



        }
       

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
