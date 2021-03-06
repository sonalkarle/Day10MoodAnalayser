using NUnit.Framework;
using MoodAnalyserNameSpace;

namespace MoodAnalyserTest
{
    public class Tests
    {
        MoodAnalyserClass moodAnalyser;
        [SetUp]
        public void Setup()
        {
            moodAnalyser = new MoodAnalyserClass();
        }

        [Test]
        // TC 1.1: Given message "I am in SAD Mood " return the "SAD"
        public void Given_Message_Should_Return_Sad()
        {
            string message = "I am in SAD mood";
            string expected = "SAD";
            string actual = moodAnalyser.MoodAnalyserMethod(message);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        //TC 1.2: Given message "I am in HAPPY Mood " return the "HAPPY"

        public void Given_Message_Should_Return_Happy()
        {
            string message = "I am in HAPPY    mood";
            string expected = "HAPPY";
            string actual = moodAnalyser.MoodAnalyserMethod(message);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        //TC2: Handle Null Exception

        public void Handle_Null_Exception()
        {
            string expected = "Invalid";
            string actual = moodAnalyser.MoodAnalyserMethod(null);
            Assert.AreEqual(expected, actual);


        }
        // TU3.1 Given Null mood should throw moodAnalyser exception
        
        [Test]
        public void GivenMessageWhenNullUsingCustomExceptionShouldReturnNullMood()
        {
            string message = null;
            try
            {
                moodAnalyser = new MoodAnalyserClass(message);
                string result = moodAnalyser.MoodAnalyseNullAndEmpty();
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual("Mood should not be null", exception.Message);
            }
        }
        
        // 3.2 given empty mood shoud throws moodAnalyser exception
        
        [Test]
        public void GivenMessageWhenEmptyUsingCustomExceptionShouldReturnEmptyMood()
        {
            string message = "";
            try
            {
                moodAnalyser = new MoodAnalyserClass(message);
                string result = moodAnalyser.MoodAnalyseNullAndEmpty();
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual("Mood should not be empty", exception.Message);
            }
        }


    }
}