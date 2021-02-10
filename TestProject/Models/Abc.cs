using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Models
{
    public struct Abc
    {
        const string A = "a";
        const string B = "b";
        const string C = "c";

        public string LetterA
        {
            get { return A; }
        }

        public string LetterB
        {
            get { return B; }
        }

        public string LetterC
        {
            get { return C; }
        }

        public List<string> Spell()
        {
            return new List<string> {
                    LetterA,
                    B,
                    C
                };
        }
    }
}
