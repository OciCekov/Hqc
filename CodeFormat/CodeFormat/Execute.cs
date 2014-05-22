namespace CodeFormat
{
    using System;

    public class Execute
    {
        public static EventHolder Events = new EventHolder();

        public static void Main(string[] args)
        {
            while (Commands.ExecuteNextCommand())
            {
            }

            Console.WriteLine(Messages.Output);
        }
    }
}