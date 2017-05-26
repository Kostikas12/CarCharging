using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Threading;
using System.Data.SqlClient;

namespace CarCharging
{
    public class ConnString
    {
        private static string connectionstring;
        private static string applicationpath;

        public void AppPathSet(string value) 
        { 
            applicationpath = value; 
        }
        public string AppPathGet()
        {
            if (applicationpath == null)
            {
                MakeConnString();
            }
            return applicationpath;
        }

        public void ConStringSet(string value)
        {
            connectionstring = value;
        }
        public string ConStringGet()
        {
            if (connectionstring==null)
            {
                MakeConnString();
            }
            return connectionstring;
        }

        private void MakeConnString()
        {
            string fullpath = Path.GetDirectoryName(Application.ExecutablePath);  // Dynamic connection string 10
            int firstindex = fullpath.IndexOf("\\bin", 0);
            string applicationpath = fullpath.Remove(firstindex, fullpath.Length - firstindex);
            new ConnString().AppPathSet(applicationpath);
            SqlConnectionStringBuilder connbuilder = new SqlConnectionStringBuilder();
            connbuilder.DataSource = @".\SQLEXPRESS";
            connbuilder.AttachDBFilename = applicationpath + @"\CarCharging.mdf";
            connbuilder.IntegratedSecurity = true;
            connbuilder.UserInstance = true;
            string connstring = connbuilder.ConnectionString;
            new ConnString().ConStringSet(connstring);
        }
    }
}
