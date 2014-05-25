namespace ControlStructures
{
    using System;

    class RefactorForLoop
    {
        private const int expectedValue = 150;
        private const int MaxIndex = 100;
        private int[] array = new int[1000];

        public void FindValue()
        {
            for (int i = 0; i < MaxIndex; i++)
            {
                Console.WriteLine(array[i]);

                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                    }
                }
            }
        }
    }
}
