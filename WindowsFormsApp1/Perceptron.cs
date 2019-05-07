using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     public class Perceptron
    {
        private Random random = new Random();
        private int L;
        double min, max;
        List<double> newE = new List<double>();
        private bool isAdaptive, isRunning;
        public bool secondMethod;
        List<double> trainingE = new List<double>();
        
        public int start,stop;
        private List<List<double>> weights = new List<List<double>>();
        public List<List<double>> weight
        {
            get { return weights; }
        }
        public bool IsRunning
        {
            get { return isRunning; }
        }
        public List<double> yList
        {
            get { return y; }
        }
        public List<double> newEList
        {
            get { return newE; }
        }
        public List<double> tList
        {
            get { return threshold; }
        }
        public List<double> eList
        {
            get { return e; }
        }
        public List<double> preYList
        {
            get { return predictY; }
        }
        public List<double> EsList
        {
            get { return EsPerEpoch; }
        }
        public List<double> epochEs
        {
            get { return EsPerEpoch; }
        }
        public int numberOfInputs, numberOfPoints;
        private double learningStep, Ee=0, preY=0, Es=0;
        private List<double> EsPerEpoch = new List<double>(), y = new List<double>(), e = new List<double>(), threshold = new List<double>(), predictY = new List<double>();
                private List<double> tempE = new List<double>();

        private double GetRandomNumber(double minimum, double maximum)
        {
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        private void CalcNewDesired(List<double> e)
        {
            foreach (var item in e)
            {
                newE.Add((((item - min) * 2) / (max - min)) - 1);
            }            
            this.e = newE;
            
        }

        public Perceptron(int numberOfInputs, int numberOfPoints, double learningStep, List<double> e,bool isAdaptive, double ee)
        {
            L = numberOfPoints - numberOfInputs ;
            this.e = e;
            min = e.Min();
            max = e.Max();
           
            if (isAdaptive)
            {
                this.isAdaptive = isAdaptive;
                this.learningStep = learningStep;
            }
            this.numberOfPoints = numberOfPoints;
            this.numberOfInputs = numberOfInputs;
            for (int i = 0; i < numberOfPoints; i++)
            {
                trainingE.Add(e[i]);

            }
            Ee = ee;                       
        }
        private void ClearAll()
        {
            y.Clear();
            weight.Clear();
            threshold.Clear();
            EsPerEpoch.Clear();
        }
        public void Train2()
        {
            ClearAll();
            CalcNewDesired(e);
            GenerateStartValues();
            int counterY = 0;            
            double tmp=0;
            double mi = e.Min();
            double ma = e.Max(); 
            do
            {
                isRunning = true;
                for(int i=0;i<L; i++)
                {
                    for(int j = 0; j < numberOfInputs; j++)
                    {
                        //var xx = weights[j].Last();
                        //var xxx = e[i + j];
                        preY += weights[j].Last() * e[i + j] ;
                    }
                    preY -= threshold.Last();
                    y.Add((2/(1 + Math.Pow(Math.E,-2*preY)))-1);
                    preY = 0;
                    if (isAdaptive)
                    {
                        for (int k = 0; k < numberOfInputs; k++)
                        {
                            tmp += Math.Pow(e[i + k], 2);                            

                         }                   
                        tmp += 1;
                        learningStep = 1 / tmp;
                        tmp = 0;
                    }
                    CalcNewWeights(i);
                    
                }
                for (int i = 0+counterY; i < L+counterY; i++)
                {                   
                    Es += 0.5 * Math.Pow((y[i] - e[(i - counterY) + numberOfInputs]), 2);
                }
                counterY += L;
                EsPerEpoch.Add(Es);
                double testEs = Es;
                Es = 0;
                
            } while (EsPerEpoch.Last() > Ee || (EsPerEpoch.Count > 1 ? Math.Abs((EsPerEpoch.Last() - EsPerEpoch[EsPerEpoch.Count - 2])) < 0.001 : true));
            isRunning = false;               
        }
        public void Train()
        {
            ClearAll();
            GenerateStartValues();
            int counterY = 0;
            double tmp = 0;
            do
            {
                isRunning = true;
                for (int i = 0; i < L; i++)
                {
                    for (int j = 0; j < numberOfInputs; j++)
                    {
                        //var xx = weights[j].Last();
                        //var xxx = e[i + j];
                        preY += weights[j].Last() * e[i + j];
                    }
                    preY -= threshold.Last();
                    y.Add(preY);
                    preY = 0;
                    if (isAdaptive)
                    {
                        for (int k = 0; k < numberOfInputs; k++)
                        {
                            tmp += Math.Pow(e[i + k], 2);

                        }
                        tmp += 1;
                        learningStep = 1 / tmp;
                        tmp = 0;
                    }
                    CalcNewWeights(i);

                }
                for (int i = 0 + counterY; i < L + counterY; i++)
                {
                    Es += 0.5 * Math.Pow((y[i] - e[(i - counterY) + numberOfInputs]), 2);
                }
                counterY += L;
                EsPerEpoch.Add(Es);
                Es = 0;

            } while (EsPerEpoch.Last() > Ee || (EsPerEpoch.Count > 1 ? Math.Abs((EsPerEpoch.Last() - EsPerEpoch[EsPerEpoch.Count - 2])) < 0.001 : true));
            isRunning = false;
        }

        private void GenerateStartValues()
        {
            //List = { W1...Wn, T}
            for (int i = 0; i < numberOfInputs; i++)
            {
                weights.Add(new List<double> { });
            }
            for (int i = 0; i < numberOfInputs; i++)
            {
            weights[i].Add(GetRandomNumber(-1,1));

            }
            threshold.Add(GetRandomNumber(-1, 1));
            
            if (!isAdaptive)
            {
                learningStep = 0.009;
            }
        }

        private void CalcNewWeights(int pattern)
        {
            if (secondMethod)
            {
                for (int i = 0; i < numberOfInputs; i++)
                {
                    weights[i].Add(weights[i].Last() - (learningStep  * (y.Last() - e[pattern + numberOfInputs]) * e[i + pattern] * (1 - Math.Pow(y.Last(),2))));
                }
                threshold.Add(threshold.Last() + (learningStep * (y.Last() - e[pattern + numberOfInputs]) * (1 - Math.Pow(y.Last(), 2))));
            }
            else
            {
                for (int i = 0; i < numberOfInputs; i++)
                {
                    weights[i].Add(weights[i].Last() - (learningStep * e[i + pattern]*(y.Last() - e[pattern + numberOfInputs])));
                }
                threshold.Add(threshold.Last() + (learningStep * (y.Last() - e[pattern + numberOfInputs])));
            }
        }

        private void SaveWeights(double finalWeights)
        {
            for (int i = 0; i < numberOfInputs; i++)
            {
                weights[i].Add(finalWeights);
            }
        }

        public void TestTraining()
        {
            y.Clear();
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < numberOfInputs; j++)
                {
                    preY += weights[j].Last() * e[i + j];
                }
                preY -= threshold.Last();
                if (secondMethod)
                {
                    y.Add((2 / (1 + Math.Pow(Math.E, -2 * preY))) - 1);
                }
                else
                {
                y.Add(preY);

                }
                preY = 0;
                CalcNewWeights(i);
            }
            for (int i = 0; i < L; i++)
            {
                Es += 0.5 * Math.Pow((y[i] - e[i + numberOfInputs]), 2);
            }
            EsPerEpoch.Add(Es);
            Es = 0;
        }

        public void PredictNextNumbers(int start, int stop)
        {
            this.start = start;
            this.stop = stop;
            y.Clear();
            for (int i = start; i <= stop; i++)
            {
                for (int j = 0; j < numberOfInputs ; j++)
                {
                    preY += weights[j].Last() * e[i-numberOfInputs-1 +j];
                }
                preY -= threshold.Last();
                if (secondMethod)
                {
                    y.Add((2 / (1 + Math.Pow(Math.E, -2 * preY))) - 1);
                }
                else
                {

                y.Add(preY);
                }
                preY = 0;
               
            }
            
        }

        public void Predict(int numberToPredict)
        {
            
            predictY.Clear();
            if (secondMethod)
            {
                for (int i = 0; i < numberOfPoints; i++)
                {
                    trainingE.Add(e[i]);

                }
            }
            
            for (int i = 0; i < numberToPredict; i++)
            {
                for (int j = 0; j < numberOfInputs; j++)
                {                    
                   preY += weights[j].Last() * trainingE[trainingE.Count -  numberOfInputs + j];
                    
                }                
                preY -= threshold.Last();
                y.Add(preY);
                trainingE.Add(y.Last());
                predictY.Add(y.Last());
                preY = 0;

            }
            
        }
    }
}
