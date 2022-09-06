using NUnit.Framework;
using Mood_Analyser;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace Unit_Test_Mood
{
    public class MoodAnalyserTest
    {
        [TestMethod]
        public void GivenIAmInSadMood_ShouldReturnSad()
        {
            //Arrange
            string message = "I am in sad mood.";
            string expectedValue = "SAD";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string result = moodAnalyser.AnalyseMood(message);
            //Assert
            Assert.AreEqual(expectedValue, result);
        }
        [TestMethod]
        public void GivenIAmInAnyMood_ShouldReturnHappy()
        {
            //Arrange
            string message = "I am in happy mood.";
            string expectedValue = "HAPPY";
            MoodAnalyser moodAnalyzer = new MoodAnalyser(message);
            //Act
            string result = moodAnalyzer.AnalyseMood(message);
            //Assert
            Assert.AreEqual(expectedValue, result);
        }
        [TestMethod]
        [DataRow(null)]
        public void GivenNull_ShouldReturnHappy(string message)
        {
            ///Arrange
            string ecpectedValue = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            ///Act
            string result = moodAnalyser.AnalyseMood(message);
            ///Assert
            Assert.AreEqual(result, ecpectedValue);
        }
    }
}
