using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser()
        {
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood(string message)
        {
            try
            {
                if (this.message.Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
            }
            catch
            {
                return "HAPPY";
            }
        }
    }
}
