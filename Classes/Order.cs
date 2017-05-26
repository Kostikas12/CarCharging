using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CarCharging
{
    public class Order
    {
        private int ID_Order;
        private int ID_Driver;
        private int ID_Car;
        private int ID_Charger;
        private string OrderStatus;   // 1. coming to charge 2. charging 3. ready 4. cancel user 5. cancel system
        private DateTime OrderTime;
        private DateTime TimeStartChargingExpect;
        private double TimeChargingExpect;
        private DateTime TimeStartCharging;
        private DateTime TimeEndCharging;
        private double TimeCharging;
        private double Kilowatt;
        private double ProbabilityOrder;

        public Order()
        {
        }

        public Order(SqlDataReader reader)
        {
            this.ID_Order = reader.GetInt32(0);
            this.ID_Driver = reader.GetInt32(1);
            this.ID_Car = reader.GetInt32(2);
            this.ID_Charger = reader.GetInt32(3);
            this.OrderStatus = reader.GetString(4);
            this.OrderTime = reader.GetDateTime(5);
            this.TimeStartChargingExpect = reader.GetDateTime(6);
            this.TimeChargingExpect = reader.GetDouble(7);

            if (!reader.IsDBNull(8))
            {
                this.TimeStartCharging = reader.GetDateTime(8);
            }
            if (!reader.IsDBNull(9))
            {
                this.TimeEndCharging = reader.GetDateTime(9);
            }
            if (!reader.IsDBNull(10))
            {
                this.TimeCharging = reader.GetDouble(10);
            }
            if (!reader.IsDBNull(11))
            {
                this.Kilowatt = reader.GetDouble(11);
            }

            this.ProbabilityOrder = reader.GetDouble(12);
        }

        public int ID_OrderGetSet
        {
            get { return ID_Order; }
            set { ID_Order = value; }
        }
        public int ID_DriverGetSet
        {
            get { return ID_Driver; }
            set { ID_Driver = value;  }
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

        public string OrderStatusGetSet
        {
            get { return OrderStatus; }
            set { OrderStatus = value; }
        }

        public DateTime OrderTimeGetSet
        {
            get { return OrderTime; }
            set { OrderTime = value; }
        }

        public DateTime TimeStartChargingExpectGetSet
        {
            get { return TimeStartChargingExpect; }
            set { TimeStartChargingExpect = value; }
        }
        public double TimeChargingExpectGetSet
        {
            get { return TimeChargingExpect; }
            set { TimeChargingExpect = value; }
        }

        public DateTime TimeStartChargingGetSet
        {
            get { return TimeStartCharging; }
            set { TimeStartCharging = value; }
        }

        public DateTime TimeEndChargingGetSet
        {
            get { return TimeEndCharging; }
            set { TimeEndCharging = value; }
        }
        public double TimeChargingGetSet
        {
            get { return TimeCharging; }
            set { TimeCharging = value; }
        }
        public double KilowattGetSet
        {
            get { return Kilowatt; }
            set { Kilowatt = value; }
        }
        public double ProbabilityOrderGetSet
        {
            get { return ProbabilityOrder; }
            set { ProbabilityOrder = value; }
        }
    }
}
