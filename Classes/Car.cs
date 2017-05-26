using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.Data.SqlClient;

namespace CarCharging
{
    public class Car
    {
        private int id_car;
        private int id_driver;
        private string cartype;
        private double carbatterylevel;
        private double cartimetocharge;
        public Car()
        {
        }
        public Car(SqlDataReader reader) // + overload 1
        {
            this.ID_CarGetSet = reader.GetInt32(0);
            this.ID_DriverGetSet = reader.GetInt32(1);
            this.CarTypeGetSet = reader.GetString(2);
            this.CarBatteryLevelGetSet = reader.GetDouble(3);
            this.CarTimeToChargeGetSet = reader.GetDouble(4);
        }
        public Car(int id_driver, string cartype, double carbatterylevel, double cartimetocharge)
        {
            this.id_driver = id_driver;
            this.cartype = cartype;
            this.carbatterylevel = carbatterylevel;
            this.cartimetocharge = cartimetocharge;
        }
        public int ID_CarGetSet
        {
            get { return id_car; }
            set { id_car = value; }
        }
        public int ID_DriverGetSet
        {
            get { return id_driver; }
            set { id_driver = value; }
        }
        public string CarTypeGetSet
        {
            get { return cartype; }
            set { cartype = value; }
        }
        public double CarBatteryLevelGetSet
        {
            get { return carbatterylevel; }
            set { carbatterylevel = value; }
        }
        public double CarTimeToChargeGetSet
        {
            get { return cartimetocharge; }
            set { cartimetocharge = value; }
        }
    }
}
