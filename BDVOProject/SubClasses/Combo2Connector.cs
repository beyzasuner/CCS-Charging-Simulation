using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDVOProject
{
    public class Combo2Connector : Type2Connector
    {
        //Add two more DC mins for extra charging
        public DCPlusPin DCPlus = new DCPlusPin();
        public DCMinusPin DCMinus = new DCMinusPin();
    }
}
