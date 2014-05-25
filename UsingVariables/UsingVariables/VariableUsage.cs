namespace UsingVariables
{
    public class VariableUsage
    {
        public void PrintStatistics(double[] statisticData, int endSearchIndex)
        {
            double maxInData = 0;

            for (var i = 0; i < endSearchIndex; i++)
            {
                if (statisticData[i] > maxInData)
                {
                    maxInData = statisticData[i];
                }
            }

            PrintMax(maxInData);
            double minInData = 0;

            for (var i = 0; i < endSearchIndex; i++)
            {
                if (statisticData[i] < minInData)
                {
                    minInData = statisticData[i];
                }
            }

            PrintMin(minInData);
            double summedData = 0;

            for (var i = 0; i < endSearchIndex; i++)
            {
                summedData += statisticData[i];
            }

            PrintAvg(summedData / endSearchIndex);
        }

        private void PrintAvg(double d)
        {
            throw new System.NotImplementedException();
        }

        private void PrintMin(double arrayMin)
        {
            throw new System.NotImplementedException();
        }

        private void PrintMax(double arrayMax)
        {
            throw new System.NotImplementedException();
        }
    }
}
