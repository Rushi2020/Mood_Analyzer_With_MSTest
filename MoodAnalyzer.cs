using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyzer_With_MSTest
{
    public class MoodAnalyzer {
         
        // string message = "SAD";
            public string AnalyzeMood(string mood)
            {
                if (mood.ToLower().Contains("sad"))
                    return "sad";
                else
                    return "happy";
            }
        
    }
}