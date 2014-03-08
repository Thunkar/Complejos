using Complejos.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Popups;

namespace Complejos.Converters
{
    class PiConverter : IValueConverter
    {
        private char pi = (char)960;
        private double[,] array;


        public string ConvertToSomethingOfPI(double n)
        {
            n = PrincipalArg(n);
            this.array = new double[100,100];
            if (n == 0) return n.ToString("F2");
            if (Math.Abs(n - Math.PI) <= 0.001) return "" + pi;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    array[i,j] = ((double)(i + 1) / (double)(j + 1)) * Math.PI;
                }
            }
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (Math.Abs(n - array[i,j]) <= 0.0001)
                    {
                        if (i + 1 == 1) return pi + "/" + (j + 1).ToString();
                        else return (i + 1).ToString() + pi + "/" + (j + 1).ToString();
                    }
       
                }
                
            }
            return n.ToString("F2");
        }


        public double ConvertFromSomethingOfPI(string inputA)
        {
            if (inputA == "") return 0;
            try
            {
                return Double.Parse(inputA);
            }
            catch
            {
                char[] input = new char[inputA.ToCharArray().Length];
                input = inputA.ToCharArray();
                double denomin = 1;
                double numera = 0;
                int j = 1;
                int s = 1;
                if (input[0].Equals('-'))
                {
                    j = 2;
                    s = -1;
                }

                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (input[i] == "/".ToCharArray()[0])
                    {
                        if (input[j-1] == (char)960)
                        {
                            numera = 1;
                            denomin = Int32.Parse(input[i + 1].ToString());
                            return s*Math.PI / denomin;
                        }
                        else
                        {
                            numera = Int32.Parse(input[i-2].ToString());
                            denomin = Int32.Parse(input[i + 1].ToString());
                            return s*Math.PI * (numera / denomin);
                        }
                    }
                }
            }
            return Math.PI;
        }

        public double PrincipalArg(double n)
        {
            while (n > (2*Math.PI))
            {
                n = n - Math.PI;
            }
            return n;
        }


        public object Convert(object value, Type targetType, object parameter, string language)
        {
            double result = (double)value;
            return ConvertToSomethingOfPI(result);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            string result = (string)value;
            return ConvertFromSomethingOfPI(result).ToString("F2");
        }
    }
}
