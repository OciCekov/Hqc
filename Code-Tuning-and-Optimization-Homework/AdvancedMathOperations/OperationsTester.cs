namespace AdvancedMathOperations
{
    using System;
    using System.Diagnostics;

    public class AdvancedOperationsTester<T> where T : struct
    {
        private readonly T item;
        private Stopwatch timer;

        public AdvancedOperationsTester(T item)
        {
            this.timer = new Stopwatch();
            this.item = item;
        }

        public TimeSpan TestSquareRoot()
        {
            this.timer.Restart();
            Math.Sqrt((double)(dynamic)this.item);

            this.timer.Stop();
            return this.timer.Elapsed;
        }

        public TimeSpan TestLogarithm()
        {
            this.timer.Restart();

            Math.Log((double)(dynamic)this.item);

            this.timer.Stop();
            return this.timer.Elapsed;
        }

        public TimeSpan TestSinus()
        {
            this.timer.Restart();
            Math.Sin((double)(dynamic)this.item);
            this.timer.Stop();
            return this.timer.Elapsed;
        }
    }
}
