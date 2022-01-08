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
        public void Reflection_Return_Default_Constructor()
        {
            MoodAnalyser expected = new MoodAnalyser();
            object obj = null;
            try
            {
                MoodAnalyserFactory f = new MoodAnalyserFactory();
                obj = f.CreateMoodAnalyse("MoodAnalyserApp.MoodAnalyser", "MoodAnalyser");

            }
            catch (MoodAnalyserCustomException ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        //Neagtive Case
        [TestMethod]
        public void Reflection_Return_Default_Constructor_No_Class_Found()
        {
            string expected = "Class not found";
            object obj = null;
            try
            {
                MoodAnalyserFactory f = new MoodAnalyserFactory();
                obj = f.CreateMoodAnalyse("MoodAnalyserApp.MoodAnalyser", "MoodAnalyser");

            }
            catch (MoodAnalyserCustomException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
        //Neagtive Case
        [TestMethod]
        public void Reflection_Return_Default_Constructor_No_Constructor_Found()
        {
            string expected = "Constructor not found";
            object obj = null;
            try
            {
                MoodAnalyserFactory f = new MoodAnalyserFactory();
                obj = f.CreateMoodAnalyse("MoodAnalyserApp.MoodAnalyser", "MoodAnalyser");

            }
            catch (MoodAnalyserCustomException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
        /// <summary>
        /// Using Reflection-UC5-Parameterized Constructor
        /// </summary>
        [TestMethod]
        public void Reflection_Return_Parameterized_Constructor()
        {
            string message = "I am in happy mood";
            MoodAnalyser expected = new MoodAnalyser(message);
            object actual = null;
            try
            {
                MoodAnalyserFactory f = new MoodAnalyserFactory();
                actual = f.CreateMoodAnalyseUsingParameterisedConstructor("MoodAnalyserApp.MoodAnalyser", "MoodAnalyser", message);

            }
            catch (MoodAnalyserCustomException ex)
            {
                throw new System.Exception(ex.Message);
            }
            actual.Equals(expected);
        }
        //Invalid case
        [TestMethod]
        public void Reflection_Return_Parameterized_Class_Invalid()
        {
            string message = "I am in happy mood";
            MoodAnalyser expected = new MoodAnalyser(message);
            object actual = null;
            try
            {
                MoodAnalyserFactory f = new MoodAnalyserFactory();
                actual = f.CreateMoodAnalyseUsingParameterisedConstructor("MoodAnalyserApp.MoodAnalyser", "MoodAnalyser", message);

            }
            catch (MoodAnalyserCustomException actual1)
            {
                Assert.AreEqual(expected, actual1.Message);
            }
        }
        /// <summary>
        /// UC6-Using Reflection-Invoke Method
        /// </summary>
        [TestMethod]
        public void Reflection_Return_Method()
        {
            string expected = "HAPPY";
            MoodAnalyserFactory f = new MoodAnalyserFactory();
            string actual = f.InvokeAnalyserMethod("HAPPY", "AnalyseMood");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Reflection_Return_Invalid_Method()
        {
            string expected = "HAPPY";
            MoodAnalyserFactory f = new MoodAnalyserFactory();
            string actual = f.InvokeAnalyserMethod("HAPPY", "Analyse");

            Assert.AreEqual(expected, actual);
        }
    }
}
    