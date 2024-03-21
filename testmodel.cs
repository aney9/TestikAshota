using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class testmodel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string FisrtAnswer { get; set; }
        public string SecondAnswer { get; set; }
        public string ThirdAnswer { get; set; }
        public pravilni PravilniOtvet { get; set; }
    }
        public enum pravilni
        {
            FirstAnswer,
            SecondAnswer,
            ThirdAnswer,
        }
}
