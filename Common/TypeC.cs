using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeC : TypeB
    {
        public TypeC()
        {
            B = 10; // valid -  [Inherted] - internal
            C = 3; // valid -  [Inherted] - public

            X = 4; // inherted private protected => Private
            Y = 5; // inherted protected => Private
            Z = 6; // inherted protected Internal => Internal
        }

        public void Test()
        {
            TypeB typeB = new TypeB();
            typeB.B = 10;
            typeB.C = 3;
            //typeB.X = 10;
            //typeB.Y = 10;
            typeB.Z = 3;
        }

    }
}
