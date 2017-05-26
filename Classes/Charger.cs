using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.Data.SqlClient;

namespace CarCharging
{
    public class Charger
    {
        private int id_charger;
        private string chargername;
        private string chargeraddress;
        private string chargergps;
        private string chargerstatus;
        private int numallplaces;
        private int numemptyplaces;
        private int numorderplaces;

        public Charger()
        {
        }

        public Charger(SqlDataReader reader)
        {
            ID_ChargerGetSet = reader.GetInt32(0);
            ChargerNameGetSet = reader.GetString(1);
            ChargerAddressGetSet = reader.GetString(2);
            ChargerGPSGetSet = reader.GetString(3);
            ChargerStatusGetSet = reader.GetString(4);
            NumAllPlacesGetSet = reader.GetInt32(5);
            NumEmptyPlacesGetSet = reader.GetInt32(6);
            NumOrderPlacesGetSet = reader.GetInt32(7);
        }

        public int ID_ChargerGetSet
        {
            get { return id_charger; }
            set { id_charger = value; }
        }
        public string ChargerNameGetSet
        {
            get { return chargername; }
            set { chargername = value; }
        }
        public string ChargerAddressGetSet
        {
            get { return chargeraddress; }
            set { chargeraddress = value; }
        }
        public string ChargerGPSGetSet
        {
            get { return chargergps; }
            set { chargergps = value; }
        }
        public string ChargerStatusGetSet
        {
            get { return chargerstatus; }
            set { chargerstatus = value; }
        }
        public int NumAllPlacesGetSet
        {
            get { return numallplaces; }
            set { numallplaces = value; }
        }
        public int NumEmptyPlacesGetSet
        {
            get { return numemptyplaces; }
            set { numemptyplaces = value; }
        }
        public int NumOrderPlacesGetSet
        {
            get { return numorderplaces; }
            set { numorderplaces = value; }
        }
    }
}
