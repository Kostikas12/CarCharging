using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CarCharging
{
    class ChargingNow
    {
        private int ID_Charging;
        private int ID_Driver;
        private int ID_Car;
        private int ID_Charger;
        private double ProbabilitySecond;
        private DateTime TimeStartCharging;
        private DateTime TimeEndChargingExpect;

        public ChargingNow()
        { 
        }

        public ChargingNow(SqlDataReader reader)
        {
            this.ID_Charging = reader.GetInt32(0);
            this.ID_Driver = reader.GetInt32(1);
            this.ID_Car = reader.GetInt32(2);
            this.ID_Charger = reader.GetInt32(3);
            this.ProbabilitySecond = reader.GetDouble(4);
            this.TimeStartCharging = reader.GetDateTime(5);
            this.TimeEndChargingExpect = reader.GetDateTime(6);
        }

        public int ID_ChargingGetSet
        {
            get { return ID_Charging; }
            set { ID_Charging = value; }
        }
        public int ID_DriverGetSet
        {
            get { return ID_Driver; }
            set { ID_Driver = value; }
        }
        public int ID_CarGetSet
        {
            get { return ID_Car; }
            set { ID_Car = value; }
        }
        public int ID_ChargerGetSet
        {
            get { return ID_Charger; }
            set { ID_Charger = value; }
        }
        public double ProbabilitySecondGetSet
        {
            get { return ProbabilitySecond; }
            set { ProbabilitySecond = value; }
        }
        public DateTime TimeStartChargingGetSet
        {
            get { return TimeStartCharging; }
            set { TimeStartCharging = value; }
        }
        public DateTime TimeEndChargingExpectGetSet
        {
            get { return TimeEndChargingExpect; }
            set { TimeEndChargingExpect = value; }
        }
    }
}
