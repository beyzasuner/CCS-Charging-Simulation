using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BDVOProject
{
    public class VehicleInlet
    {
        public ProximityPilotPin PP = new ProximityPilotPin();
        public ControlPilotPin CP = new ControlPilotPin();
        public ProtectiveEarthPin PE = new ProtectiveEarthPin();
        public NeutralPin N = new NeutralPin();
        public L1Pin L1 = new L1Pin();
        public L2Pin L2 = new L2Pin();
        public L3Pin L3 = new L3Pin();
        public DCPlusPin DCPlus;
        public DCMinusPin DCMinus;

        public VehicleInlet(bool hasCCS)
        {
            if (hasCCS)
            {
                DCPlus = new DCPlusPin();
                DCMinus = new DCMinusPin();
        
            }
        }
    }
}
