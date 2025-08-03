using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class TypeB:TypeA
    {
        public TypeB() 
        {
            //A = 1; //invalid
            //B = 2; //valid
            //C = 3; //valid
            //X = 4; //valid
            //Y = 5; //valid
            //Z = 6; //valid
        }
        public void print()
        {
            //TypeA typeA = new TypeA();
            //typeA.A = 1; //invalid
            //typeA.B = 2; //valid
            //typeA.C = 3; //valid
            //typeA.X= 4; //invalid
            //typeA.Y= 5; //invalid
            //typeA.Z= 6; //valid
        }
    }
}
