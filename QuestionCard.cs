using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduktion_C_
{
    public class QuestionCard
    {
        private string fråga;
        private string svar;

        public QuestionCard(string f, string s)
        {
            fråga = f;
            svar = s;
        }
        public string GetQuestion()
        {
            return fråga;
        }

        public bool IsCorrect(string gissning)
        {
            return svar == gissning;
        }
    }
}
