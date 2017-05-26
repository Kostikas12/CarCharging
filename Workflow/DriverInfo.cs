using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.Data.SqlClient;
using System.IO;

namespace CarCharging
{
    public class DriverInfo
    {
        // === LoginPass
        private static string login;
        private static string pass;
        private static Driver driver;

        public void LoginPassSet(string login1, string pass1)
        {
            login = login1;
            pass = pass1;
        }
        public string LoginGet()
        {
            return login;
        }
        public string PassGet()
        {
            return pass;
        }
        public void LoginPassClear()
        {
            LoginPassSet(null, null);
            CarSet(null);
        }
        public void LoginPassOfflineClear()
        {
            using (SqlConnection connection = new SqlConnection(new ConnString().ConStringGet()))
            {
                connection.Open();
                string sql1 = string.Format(" Update Drivers"
                                           + " Set DriverStatus='offline'"
                                           + " Where DriverLogin=@DriverLogin AND DriverPassword=@DriverPassword");
                SqlCommand cmd1 = new SqlCommand(sql1, connection);
                cmd1.Parameters.AddWithValue("@DriverLogin", LoginGet());
                cmd1.Parameters.AddWithValue("@DriverPassword", PassGet());
                cmd1.ExecuteNonQuery();
            }
            // === Make log Exit
            using (StreamWriter sw = File.AppendText("log.txt"))
            {
                sw.WriteLine("\n--------------------------------");
                sw.WriteLine("Event: Exit from login.");
                sw.WriteLine("Exit time: '{0}'", DateTime.Now);
                sw.WriteLine("Login '{0}' is exit.", DriverGet().LoginGetSet);
                sw.WriteLine("--------------------------------\n");
            }
            // === End log
            LoginPassClear();
        }


        public Driver DriverGet()
        {
                using(SqlConnection connection = new SqlConnection(new ConnString().ConStringGet()))
                {
                    connection.Open();
                    string sql = string.Format(" Select ID_Driver,DriverName,DriverLogin,DriverPassword,Age,DriverStatus,Probability"
                                             + " From Drivers"
                                             + " Where DriverLogin=@DriverLogin AND DriverPassword=@DriverPassword");
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@DriverLogin", this.LoginGet());
                    cmd.Parameters.AddWithValue("@DriverPassword", this.PassGet());
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            driver = new Driver(reader);
                        }
                        reader.Close();
                    }
                }                
            return driver;
        }

        public void DriverClear()
        {
            if (driver!=null)
            {
                driver = null;
            }
        }

        // === End LoginPass

        // === Selected Car and carlist
        private static Car car;
        public void CarSet(Car car1)
        {
            car = car1;
        }
        public Car CarGet()
        {
            return car;
        }

        private static List<Car> listcars;

        public List<Car> CarsListGet()
        {
            return listcars;
        }
        public void CarsListSet(List<Car> list)
        {
            listcars = new List<Car>();
            listcars = list;
        }
        // === End Selected Car and Carlist

        // === Chargers 
        private static List<Charger> chargerlist;
        private static Charger chargerselected;

        public void ChargerListSet(List<Charger> list)
        {
            chargerlist = new List<Charger>();
            chargerlist = list;
        }
        public List<Charger> ChargerListGet()
        {
            return chargerlist;
        }

        // ===

        public void ChargerSelectedSet(Charger charger)
        {
            chargerselected = new Charger();
            chargerselected = charger;
        }
        public Charger ChargerSelectedGet()
        {
            return chargerselected;
        }

        // === End Chargers

        // === Order current
        private static Order ordercurrent;

        public void DriverOrderSet(Order order)
        {
            ordercurrent = new Order();
            ordercurrent = order;
        }

        public Order DriverOrderGet()
        {
            return ordercurrent;
        }

        // === End Order current
    }
}
