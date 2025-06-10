using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDVOProject
{

    public class EVSE
    {
        public Combo2Connector comboConnector = new Combo2Connector();
        public Type2Connector type2Connector = new Type2Connector();

        private string stationCode;

        public string StationCode
        {
            get { return stationCode; }
            set { stationCode = value; }
        }

        private string xCor;

        public string XCor
        {
            get { return xCor; }
            set { xCor = value; }
        }

        private string yCor;

        public string YCor
        {
            get { return yCor; }
            set { yCor = value; }
        }

        private string adress;

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        private int availableSockets;

        public int AvailableSockets
        {
            get { return availableSockets; }
            set { availableSockets = value; }
        }

        public int TotalSockets = 2;

        private double type2CostPerKwh;

        public double Type2CostPerKwh
        {
            get { return type2CostPerKwh; }
            set { type2CostPerKwh = value; }
        }

        private double ccsCostPerKwh;

        public double CcsCostPerKwh
        {
            get { return ccsCostPerKwh; }
            set { ccsCostPerKwh = value; }
        }

        private int isItAvailable;

        public int IsItAvailable
        {
            get { return isItAvailable; }
            set { isItAvailable = value; }
        }

        public EVSE(string stationCode, string xCor, string yCor, string adress, 
            double type2CostPerKwh, double CcsCostPerMin) 
        {
            comboConnector.CP.Voltage = 0;
            type2Connector.CP.Voltage = 0;

            StationCode = stationCode;
            XCor = xCor; 
            YCor = yCor;
            Adress = adress;
            Type2CostPerKwh = type2CostPerKwh;
            CcsCostPerKwh = CcsCostPerMin;
            AvailableSockets = TotalSockets;
        }
    }
}
