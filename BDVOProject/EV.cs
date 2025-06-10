using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDVOProject
{
    public class EV
    {
        private bool isRunning;

        public bool IsRunning
        {
            get { return isRunning; }
            set { isRunning = value; }
        }


        //create the inlet
        public VehicleInlet Inlet;
        

        //add DC pins if EV has CCS support
        public EV(bool hasCCS) 
        {
            Inlet = new VehicleInlet(hasCCS);
        } 


    }
}
