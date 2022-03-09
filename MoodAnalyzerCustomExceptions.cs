using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mood_Analyzer_With_MSTest;


namespace Mood_Analyzer_With_MSTest
{
    public class MoodAnalyzerCustomExceptions : Exception
    {
        
            public enum ExceptionType
            {
                NULL_MESSAGE, EMPTY_MESSAGE
            }
            public ExceptionType Type;

            public MoodAnalyzerCustomExceptions(ExceptionType type, string mood) : base(mood)
            {
                Type = type;
            }




        
    }
}