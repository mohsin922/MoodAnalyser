using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserApp;

namespace MoodAnalyserMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSad()
        {
            //Arrange
            string expected = "SAD"; 
            string message = "I am in Sad Mood";
            MoodAnalyser moodAnalyse = new MoodAnalyser(message); //Creating instance/object of the class.


            //Act
            string mood = moodAnalyse.AnalyseMood();    

            //Assert
            Assert.AreEqual(expected, mood);     


        }
    }
}
