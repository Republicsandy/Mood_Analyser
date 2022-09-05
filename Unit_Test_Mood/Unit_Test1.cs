using NUnit.Framework;
using Mood_Analyser;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace Unit_Test_Mood
{
    [TestClass]
    public class UNit_Test1
    {
        [Test]
        public void Given_I_Am_In_Sad_Mood_Should_Return_SAD()
        {
            //Arrange
            string message = "I am in sad mood.";
            MoodAnalyser moodanalyser = new MoodAnalyser();
            //Act
            string result = moodanalyser.AnalyseMood(message);
            //Assert
            Assert.AreEqual("SAD", result);
        }
        [Test]
        public void Given_I_Am_In_Happy_Mood_should_return_Happy()
        {
            //Arrange
            string message = "I am in Happy Mood";
            string expected = "HAPPY";
            MoodAnalyser moodanalyser = new MoodAnalyser();
            //Act
            string result = moodanalyser.AnalyseMood(message);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}