using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC2;

namespace UC2TestProject
{
    [TestClass]
    public class UC2TestClass
    {
        [TestMethod]
        public void ForAnythingMoodReturnHappy()
        {
            ///<summary>
            ///Arraange-Act-Assert
            /// </summary>
            
            string message = "I Am In Any Mood";
            MoodAnalyser mood = new MoodAnalyser( message);

            string Expected = "HAPPY";
            string Actual = mood.AnalyseMoodMeathod();

            Assert.AreEqual(Expected, Actual);

        }
    }
}
