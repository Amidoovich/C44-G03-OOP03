using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB : TypeA
    {
        public TypeB() 
        {
            TypeA typeA = new TypeA();
            //typeA.A = 1;
            typeA.B = 2;
            typeA.C = 3;
            //typeA.X = 3;
            //typeA.Y = 3;
            typeA.Z = 3;
            //A = 10; // invalid - [Not Inherted] - private
            B = 10; // valid -  [Inherted] - internal
            C = 3; // valid -  [Inherted] - public

            X = 4; // inherted private protected => Private
            Y = 5; // inherted protected => Private
            Z = 6; // inherted protected Internal => Internal



        }
    }
}
