using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDVOProject
{
    public class ChargingCable
    {
        //create five pins of Type2 Charger
        public ControlPilotPin CP = new ControlPilotPin();
        public ProximityPilotPin PP  = new ProximityPilotPin();
        public ProtectiveEarthPin PE = new ProtectiveEarthPin();
        public NeutralPin N = new NeutralPin();
        public L1Pin L1 = new L1Pin();
        public L2Pin L2 = new L2Pin();
        public L3Pin L3 = new L3Pin();

        private Boolean locked;

        public Boolean Locked
        {
            get { return locked; }
            set { locked = value; }
        }

    }
}
