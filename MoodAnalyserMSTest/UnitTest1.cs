using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserApp;

namespace MoodAnalyserMSTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC 1.2 & 2.1: Given? I am in HAPPY Mood? and null message Should return HAPPY
        /// </summary>
        [TestMethod]
        //[DataRow("I am in HAPPY Mood")]
        [DataRow(null)]
        public void GivenHAPPYMoodShouldReturnHAPPY(string message)
        {
            //Arrange
            string expected = "HAPPY";
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyse.AnalyseMood();

            //Asert
            Assert.AreEqual(expected, mood);
        }

    }
}
