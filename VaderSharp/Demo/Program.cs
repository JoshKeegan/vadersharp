using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaderSharp;

namespace Demo
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            SentimentIntensityAnalyzer sa = new SentimentIntensityAnalyzer();
            SentimentAnalysisResults results = sa.PolarityScores("ok if you have a 2nd dvd player.");

            Console.WriteLine("Positive score: " + results.Positive);
            Console.WriteLine("Negative score: " + results.Negative);
            Console.WriteLine("Neutral score: " + results.Neutral);
            Console.WriteLine("Compound score: " + results.Compound);
        }
    }
}
