using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class StarterData
    {
        public List<double> data, x;
        private double a, b, d;
        private int neurons;


        public StarterData(int inputs, double a, double b, double d)
        {
            neurons = inputs;
            this.a = a;
            this.b = b;
            this.d = d;

        }

        public List<double> GenerateStartPoints(int numberOfPoints)
        {
            data = new List<double>();
            x = new List<double>();
            GenerateX(numberOfPoints);
            for (int i = 0; i < numberOfPoints; i++)
            {
                 data.Add(Equation(x[i]));
               // data.Add(x[i]);
            }
            return data;
        }

        private void GenerateX(int value)
        {
            if (x.Count == 0)
            {
                x.Add(0);
                for (int i = 0; i < value; i++)
                {
                     x.Add((x.Count - 1) + 0.1);
                    //x.Add(i + 1);
                }
            }
            else
            {
                x.Clear();
            }
        }

        private double Equation(double value)
        {
            return a * Math.Sin(b * value) + d;
        }
    }
}
