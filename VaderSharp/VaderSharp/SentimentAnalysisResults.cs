using System;

namespace VaderSharp
{
    /// <summary>
    /// A model to represent the result of analysis.
    /// </summary>
    public class SentimentAnalysisResults
    {
        private const double TOLERANCE = 0.05;

        /// <summary>
        /// The proportion of words in the sentence with negative valence.
        /// </summary>
        public double Negative { get; set; }

        /// <summary>
        /// The proportion of words in the sentence with no valence.
        /// </summary>
        public double Neutral { get; set; }

        /// <summary>
        /// The proportion of words in the sentence with positive valence.
        /// </summary>
        public double Positive { get; set; }
        
        /// <summary>
        /// Normalized sentiment score between -1 and 1.
        /// </summary>
        public double Compound { get; set; }

        public override bool Equals(object o)
        {
            SentimentAnalysisResults r = o as SentimentAnalysisResults;

            if (r == null)
            {
                return false;
            }

            return Math.Abs(r.Negative - Negative) < TOLERANCE && Math.Abs(r.Neutral - Neutral) < TOLERANCE &&
                   Math.Abs(r.Positive - Positive) < TOLERANCE && Math.Abs(r.Compound - Compound) < TOLERANCE;
        }

        public override int GetHashCode()
        {
            var hashCode = -1024570712;
            hashCode = hashCode * -1521134295 + Negative.GetHashCode();
            hashCode = hashCode * -1521134295 + Neutral.GetHashCode();
            hashCode = hashCode * -1521134295 + Positive.GetHashCode();
            hashCode = hashCode * -1521134295 + Compound.GetHashCode();
            return hashCode;
        }
    }
}
