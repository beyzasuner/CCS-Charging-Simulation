using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BDVOProject
{
    public class ControlPilotPin
    {
        private int voltage;

        public int Voltage
        {
            get { return voltage; }
            set { voltage = value; }
        }

        private Boolean faulty;

        public Boolean Faulty
        {
            get { return faulty; }
            set { faulty = value; }
        }

    }

    public class ProximityPilotPin
    {
        private int isConnected;

        public int IsConnected
        {
            get { return isConnected; }
            set { isConnected = value; }
        }

        private Boolean faulty;

        public Boolean Faulty
        {
            get { return faulty; }
            set { faulty = value; }
        }
    }

    public class ProtectiveEarthPin
    {
        private Boolean faulty;

        public Boolean Faulty
        {
            get { return faulty; }
            set { faulty = value; }
        }
    }

    public class NeutralPin
    {
        private Boolean enabled;

        public Boolean Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }


        private Boolean faulty;

        public Boolean Faulty
        {
            get { return faulty; }
            set { faulty = value; }
        }
    }

    public class L1Pin
    {
        private Boolean enabled;

        public Boolean Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        private Boolean faulty;

        public Boolean Faulty
        {
            get { return faulty; }
            set { faulty = value; }
        }
    }

    public class L2Pin
    {
        private Boolean enabled;

        public Boolean Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        private Boolean faulty;

        public Boolean Faulty
        {
            get { return faulty; }
            set { faulty = value; }
        }
    }

    public class L3Pin
    {
        private Boolean enabled;

        public Boolean Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        private Boolean faulty;

        public Boolean Faulty
        {
            get { return faulty; }
            set { faulty = value; }
        }
    }

    public class DCPlusPin
    {
        private Boolean faulty;

        public Boolean Faulty
        {
            get { return faulty; }
            set { faulty = value; }
        }
    }

    public class DCMinusPin
    {
        private Boolean faulty;

        public Boolean Faulty
        {
            get { return faulty; }
            set { faulty = value; }
        }
    }
}
