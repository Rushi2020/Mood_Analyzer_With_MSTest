using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyzer_With_MSTest
{
    public class MoodAnalyzer {

        string mood;
        public MoodAnalyzer()
        {
            this.mood = mood;
        }

        public string AnalyzeMood(string mood)
        {
            try
            {
                if (this.mood.ToUpper().Contains("HAPPY"))
                {
                    return "HAPPY";
                }
                else if (this.mood.ToUpper().Contains("SAD"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                return "HAPPY";
            }
        }



    }
}