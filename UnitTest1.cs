using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC1_AbilityToAnalyseMood;

namespace UC1TestProj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ///<summary>
            ///Arraange-Act-Assert
            /// </summary>

            string message = "I Am In Any Mood";
            MoodAnalyser mood = new MoodAnalyser(message);

            string Expected = "HAPPY";
            string Actual = mood.AnalyseMoodMeathod();

            Assert.AreEqual(Expected, Actual);
        }
    }
}
