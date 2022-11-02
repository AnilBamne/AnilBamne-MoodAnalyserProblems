using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserAssignments;

namespace MoodAnalyserAssignmentsTest
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

        [TestMethod]
        public void RefactorUC1Test()
        {
            //Arrange
            string message = "I am Sad today";
            Refactor1 rf1 = new Refactor1(message);

            //Act
            string Expected = "Sad";
            string Actual = rf1.AnalyseMood();
            
            //Assert
            Assert.AreEqual(Expected, Actual);
        }
    }
}
