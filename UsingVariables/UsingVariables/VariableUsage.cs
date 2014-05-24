using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingVariables
{
    public class Somethin
    {
        public void PrintStatistics(double[] arr, int count)
        {
            double max = 0;
            double tmp =0;

            for (var i = 0; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            PrintMax(max);
            tmp = 0;
            max = 0;
            for (var i = 0; i < count; i++)
            {
                if (arr[i] < max)
                {
                    max = arr[i];
                }
            }
            PrintMin(max);

            tmp = 0;
            for (var i = 0; i < count; i++)
            {
                tmp += arr[i];
            }
            PrintAvg(tmp / count);
        }

        private void PrintMax(double max)
        {
            throw new NotImplementedException();
        }

        private void PrintMin(double max)
        {
            throw new NotImplementedException();
        }

        private void PrintAvg(double d)
        {
            throw new NotImplementedException();
        }
    }
}
