using System;

namespace ToyBox.ML.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            ML.SentimentAnalysis.Example.Run();
        }
    }
}