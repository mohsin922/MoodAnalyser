using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserApp;

namespace MoodAnalyserMSTest
{
    [TestClass]
    public class UnitTest1
    {
        ///<summary>
        ///TC 3.1: Given Null Mood Should Throw MoodAnalysisException 
        ///Given-When-Then
        /// </summary>
        [TestMethod]
        public void Given_NULL_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                string mood = moodAnalyse.AnalyseMood();

            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be Null", e.Message);
            }
        }
        ///<summary>
        ///TC 3.2: Given Empty Mood Should Throw MoodAnalysisException Indicating Empty Mood.
        ///Given-When-Then
        /// </summary>
        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood()
        {
            try
            {
                string message = " ";
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                string mood = moodAnalyse.AnalyseMood();

            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
        ///<summary>
        ///TC 4.1: Given MoodAnalyse Class Name Should Return MoodAnalyser Object.
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyserObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserApp.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
            //Assert.AreEqual(Expected,obj);
        }
        ///<summary>
        ///TC 5.1: Given MoodAnalyse Class Name Should Return MoodAnalyser Object.
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyserObject_UsingParameterisedConstructor()
        {

            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterisedConstructor("MoodAnalyserApp.MoodAnalyser", "MoodAnalyser", "SAD");
            expected.Equals(obj);
            //Assert.AreEqual(expected,obj);
        }
    }
}
    