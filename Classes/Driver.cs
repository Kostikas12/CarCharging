using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.Data.SqlClient;

namespace CarCharging
{
    public class Driver
    {
        private int id_driver;
        private string drivername;
        private string login;
        private string password;
        private int age;
        private string driverstatus;
        private double probability;

        public Driver()
        {
        }
        public Driver(SqlDataReader reader)
        {
            this.ID_DriverGetSet = reader.GetInt32(0);
            this.DriverNameGetSet = reader.GetString(1);
            this.LoginGetSet = reader.GetString(2);
            this.PasswordGetSet = reader.GetString(3);
            this.AgeGetSet = reader.GetInt32(4);
            this.DriverStatusGetSet = reader.GetString(5);
            this.ProbabilityGetSet = reader.GetDouble(6);
        }

        public int ID_DriverGetSet
        {
            get { return id_driver; }
            set { id_driver = value; }
        }
        public string DriverNameGetSet
        {
            get { return drivername; }
            set { drivername = value; }
        }
        public string LoginGetSet
        {
            get { return login; }
            set { login = value; }
        }
        public string PasswordGetSet
        {
            get { return password; }
            set { password = value; }
        }
        public int AgeGetSet
        {
            get { return age; }
            set { age = value; }
        }
        public string DriverStatusGetSet
        {
            get { return driverstatus; }
            set { driverstatus = value; }
        }
        public double ProbabilityGetSet
        {
            get { return probability; }
            set { probability = value; }
        }
    }
}
