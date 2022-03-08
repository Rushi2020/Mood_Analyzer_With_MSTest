using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyzer_With_MSTest;
using System;
namespace TestCase1._1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_SAD_Return_Sad()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("i am in sad mood");
            //string mood = "I am in sad mood";
            //string expected = "sad";
            // string actual = moodAnalyzer.AnalyzeMood(mood);
            // Assert.AreEqual(expected, actual);
            string result = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual("SAD", result);

        }
        [TestMethod]
        public void Given_Happy_nor_Sad_Return_Happy()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("i am in happy mood");
            //string mood = "I am in any mood";
            //string expected = "happy";
            // string actual = moodAnalyzer.AnalyzeMood(mood);
            // Assert.AreEqual(expected, actual);
            string result = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual("HAPPY", result);

        }
        [TestMethod]
        public void Giving_NULL_Message_Return_Happy()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string mood = "Null";
            //string expected = "happy";
            // string actual = moodAnalyzer.AnalyzeMood(mood);
            // Assert.AreEqual(expected, actual);
            string result = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual("HAPPY", result);

        }
    }
}