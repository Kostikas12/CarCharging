using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.Data.SqlClient;

namespace CarCharging
{
    static class Program
    {
        [STAThread]  // For WPF integration by element-host
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
