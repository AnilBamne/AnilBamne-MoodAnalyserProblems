using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserAssignments
{
    public class Refactor1
    {
        private string message;

        ///<summary>
        ///Default Constuctor
        /// </summary>
        public Refactor1()
        {

        }

        ///<summary>
        /// Constructor with parameter
        /// </summary>
        public Refactor1(string message)
        {
            this.message = message;
        }

        ///<summary>
        ///Method for analysing mood
        ///</summary>
        public string AnalyseMood()
        {
            
            try
            {
                if (this.message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch
            {
                return "Happy";
            }
        }

    }
}
