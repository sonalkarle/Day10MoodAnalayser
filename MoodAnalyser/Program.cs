using System;

namespace MoodAnalyserNameSpace
{
    public class MoodAnalyserClass
    {
        string message;

        public MoodAnalyserClass(string message)
        {
            this.message = message;
        }
        public MoodAnalyserClass()
        {

        }

        public string MoodAnalyserMethod(string message)
        {
            try
            {

                if (message.ToLower().Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch(NullReferenceException)
            {
                return "Invalid";
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood analyser");
        }
    }
}