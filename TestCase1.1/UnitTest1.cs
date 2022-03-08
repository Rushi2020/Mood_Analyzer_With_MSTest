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
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string mood = "I am in sad mood";
            string expected = "sad";
            // string actual = moodAnalyzer.AnalyzeMood(mood);
            // Assert.AreEqual(expected, actual);
            string result = moodAnalyzer.AnalyzeMood(mood);
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void Given_Happy_nor_Sad_Return_Happy()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string mood = "I am in any mood";
            //string expected = "happy";
            // string actual = moodAnalyzer.AnalyzeMood(mood);
            // Assert.AreEqual(expected, actual);
            string result = moodAnalyzer.AnalyzeMood(mood);
            Assert.AreEqual("happy", result);

        }
    }
}