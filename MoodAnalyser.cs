using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1_AbilityToAnalyseMood
{
    public class MoodAnalyser
    {
        ///<summary>
        ///global variable declaration
        ///</summary>

        private string message;

        ///<summary>
        ///constructor
        ///</summary>
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        ///<summary>
        ///methode declaration
        /// </summary>
        public string AnalyseMoodMeathod()
        {
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }

    }
}
