using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.IO;

namespace CarCharging
{
    public class Direction
    {
        // === Check old orders 1 day and change OrderStatus to cancel by system
        public void CheckOldOrders()
        {
            Thread th = new Thread(
                new ThreadStart(()=>
                    CheckOldOrdersStart()
                    )
                );
            th.Start();
        }
        private void CheckOldOrdersStart()
        {
            TimeSpan day = new TimeSpan(0, 24, 0, 0, 0);
            DateTime timedaybefore = DateTime.Now - day;

            // === LINQ query to database
            using (CarChargingEntities context = new CarChargingEntities())
            {
                AppDomain.CurrentDomain.SetData("DataDirectory", new ConnString().AppPathGet()); // ***** Solution of problem with ADO.NET
                var res = from p in context.Orders
                          where p.OrderStatus == "coming to charge"
                          select p;
                foreach (Orders order in res)
                {
                    if (order.OrderTime < timedaybefore)
                    {
                        order.OrderStatus = "cancel system";
                        var res1 = from p1 in context.Chargers
                                   where p1.ID_Charger == order.ID_Charger
                                   select p1;
                        foreach (Chargers charger in res1)
                        {
                            if (charger.NumOrderPlaces > 0)
                            {
                                charger.NumOrderPlaces--;
                            }
                        }
                    }
                }
                context.SaveChanges(); // saving
            }
            // === End LINQ query to database
        }
        // === End Check old orders 1 day

        // === Registration
        public void MainRegApply(TextBox textBName, TextBox textBLogin, TextBox textBPassword, TextBox textBAge, Label labelTextMess)
        {
            Drivers driver = new Drivers();
            driver.DriverName = textBName.Text;
            driver.DriverLogin = textBLogin.Text;
            driver.DriverPassword = textBPassword.Text;
            driver.Age = int.Parse(textBAge.Text);

            using (CarChargingEntities context = new CarChargingEntities())
            {
                var res = context.Drivers.Where(p=>p.DriverLogin==driver.DriverLogin);
                int n = res.Count();
                if (n>=1)
                {
                    labelTextMess.Text = "This Login is already exists!";
                    labelTextMess.Visible = true;
                }
                else
                {
                    labelTextMess.Text = "This Login is registering now...";
                    labelTextMess.Visible = true;
                    driver.DriverStatus = "offline";
                    driver.Probability = 1;
                    context.Drivers.Add(driver);
                    context.SaveChanges();
                    labelTextMess.Text = "This Login is registered!";
                    ControlReg.Instance.DisableReg();
                    ControlRegOk.Instance.Visible = true;
                    ControlRegOk.Instance.BringToFront();

                    // === Make log Registration
                    using (StreamWriter sw = File.AppendText("log.txt"))
                    {
                        sw.WriteLine("\n--------------------------------");
                        sw.WriteLine("Event: Registration.");
                        sw.WriteLine("Event time: '{0}'", DateTime.Now);
                        sw.WriteLine("Login '{0}' is registered.", driver.DriverLogin);
                        sw.WriteLine("--------------------------------\n");
                    }
                    // === End log
                }
            }
        }
        // === End Registration

        // === Enter
        public void EnterPress(TextBox tbLogin, TextBox tbPass, Label lbTextMess, Button Enter)
        {
            using (CarChargingEntities context = new CarChargingEntities())
            {
                var res = context.Drivers.Where(p=>p.DriverLogin==tbLogin.Text && p.DriverPassword==tbPass.Text);
                int num = res.Count();
                if (num == 0)
                {
                    lbTextMess.Visible = true;
                }
                else
                {
                    Drivers driver = new Drivers();
                    driver.DriverLogin = tbLogin.Text;
                    driver.DriverPassword = tbPass.Text;
                    new DriverInfo().LoginPassSet(driver.DriverLogin, driver.DriverPassword);

                    var res1 = context.Drivers.Where(p=>p.DriverLogin==driver.DriverLogin && p.DriverPassword==driver.DriverPassword);
                    foreach(Drivers d in res1)
                    {
                        d.DriverStatus = "online";
                    }
                    context.SaveChanges();
                    lbTextMess.Visible = false;
                    tbLogin.Clear();
                    tbPass.Clear();
                    Enter.Enabled = false;

                    // === Check exists orders
                    var res2 = context.Drivers.Where(p=>p.DriverLogin==driver.DriverLogin && p.DriverPassword==driver.DriverPassword);
                    int id_driver = res2.First().ID_Driver; // find out the id_driver

                    var res3 = context.Orders.Where(p => p.ID_Driver == id_driver && (p.OrderStatus == "coming to charge" || p.OrderStatus == "charging"));
                    if (res3.Count()==0)
                    {
                        ToMenu(); // To Menu Dafault
                    }
                    else
                    {
                        Orders order = res3.First();
                        Order orderset = new Order();
                        orderset.ID_OrderGetSet = order.ID_Order;
                        orderset.ID_DriverGetSet = order.ID_Driver;
                        orderset.ID_CarGetSet = order.ID_Car;
                        orderset.ID_ChargerGetSet = order.ID_Charger;
                        orderset.OrderStatusGetSet = order.OrderStatus;
                        orderset.OrderTimeGetSet = order.OrderTime;
                        orderset.TimeStartChargingExpectGetSet = order.TimeStartChargingExpect;
                        orderset.TimeChargingExpectGetSet = order.TimeChargingExpect;
                        orderset.TimeStartChargingGetSet = order.TimeStartCharging.GetValueOrDefault();
                        orderset.TimeEndChargingGetSet = order.TimeEndCharging.GetValueOrDefault();
                        orderset.TimeChargingGetSet = order.TimeCharging.GetValueOrDefault();
                        orderset.KilowattGetSet = order.Kilowatt.GetValueOrDefault();
                        orderset.ProbabilityOrderGetSet = order.ProbabilityOrder;
                        new DriverInfo().DriverOrderSet(orderset);  // Loading exist order

                        // Loading info Driver, selected Car, selected Charger
                        new DriverInfo().DriverGet();  // Loading Driver using Login and Pass

                        // Loading Car
                        int id_car = new DriverInfo().DriverOrderGet().ID_CarGetSet;
                        var res4 = context.Cars.Where(p=>p.ID_Car==id_car);
                        if (res4.Count()!=0)
                        {
                            Cars cars = res4.First();
                            Car carset = new Car();
                            carset.ID_CarGetSet = cars.ID_Car;
                            carset.ID_DriverGetSet = cars.ID_Driver;
                            carset.CarTypeGetSet = cars.CarType;
                            carset.CarBatteryLevelGetSet = cars.CarBatteryLevel.GetValueOrDefault();
                            carset.CarTimeToChargeGetSet = cars.CarTimeToCharge.GetValueOrDefault();
                            new DriverInfo().CarSet(carset);
                        }

                        // Loading Charger
                        int id_charger = new DriverInfo().DriverOrderGet().ID_ChargerGetSet;
                        var res5 = context.Chargers.Where(p=>p.ID_Charger==id_charger);
                        if (res5.Count()!=0)
                        {
                            Chargers charger = res5.First();
                            Charger chargerset = new Charger();
                            chargerset.ID_ChargerGetSet = charger.ID_Charger;
                            chargerset.ChargerNameGetSet = charger.ChargerName;
                            chargerset.ChargerAddressGetSet = charger.ChargerAddress;
                            chargerset.ChargerGPSGetSet = charger.ChargerGPS;
                            chargerset.ChargerStatusGetSet = charger.ChargerStatus;
                            chargerset.NumAllPlacesGetSet = charger.NumAllPlaces;
                            chargerset.NumEmptyPlacesGetSet = charger.NumEmptyPlaces;
                            chargerset.NumOrderPlacesGetSet = charger.NumOrderPlaces;
                            new DriverInfo().ChargerSelectedSet(chargerset);
                        }
                        //End loading 

                        ControlOrderCurrent.Instance.LoadFromEnter();
                        ControlOrderCurrent.Instance.Visible = true;
                        ControlOrderCurrent.Instance.BringToFront();
                    }
                    // === End checking exists orders

                    // === Make log Enter
                    using (StreamWriter sw = File.AppendText("log.txt"))
                    {
                        sw.WriteLine("\n--------------------------------");
                        sw.WriteLine("Event: Enter in login.");
                        sw.WriteLine("Enter time: '{0}'", DateTime.Now);
                        sw.WriteLine("Login '{0}' is entered.", driver.DriverLogin);
                        sw.WriteLine("--------------------------------\n");
                    }
                    // === End log
                }
            }
        }
        // === End Enter

        // === Menu
        public void ToMenu()
        {
            ControlMenu.Instance.ControlMenuGo();
            ControlMenu.Instance.BringToFront();
        }
        public void ToSettings()
        {
            ControlSettings.Instance.Visible = true;
            ControlSettings.Instance.BringToFront();
        }
        public void DeleteLoginAndToMain()
        {
            using (CarChargingEntities context = new CarChargingEntities())
            {
                string login = new DriverInfo().LoginGet();
                string pass = new DriverInfo().PassGet();
                var res1 = context.Drivers.Where(p => p.DriverLogin == login && p.DriverPassword == pass);
                int id_driver = res1.First().ID_Driver;

                // === delete cars
                var res2 = context.Cars;
                foreach(Cars car in res2)
                {
                    if (car.ID_Driver == id_driver)
                    {
                        context.Cars.Remove(car);
                    }
                }
                context.SaveChanges();

                // === delete orders
                var res3 = context.Orders;
                foreach (Orders order in res3)
                {
                    if (order.ID_Driver == id_driver)
                    {
                        context.Orders.Remove(order);
                    }
                }
                context.SaveChanges();

                //=== delete driver
                var res4 = context.Drivers;
                foreach (Drivers driver in res4)
                {
                    if (driver.ID_Driver == id_driver)
                    {
                        context.Drivers.Remove(driver);
                    }
                }
                context.SaveChanges();
            }
            // === Make log Delete Login
            using (StreamWriter sw = File.AppendText("log.txt"))
            {
                sw.WriteLine("\n--------------------------------");
                sw.WriteLine("Event: Delete login.");
                sw.WriteLine("Delete time: '{0}'", DateTime.Now);
                sw.WriteLine("Login '{0}' is deleted.", new DriverInfo().LoginGet());
                sw.WriteLine("--------------------------------\n");
            }
            // === End log

            new DriverInfo().LoginPassClear();
            new DriverInfo().DriverClear();
            new DriverInfo().ChargerSelectedSet(null);
            new DriverInfo().ChargerListSet(null);
            new DriverInfo().CarsListSet(null);
            new DriverInfo().CarSet(null);
            ControlMain.Instance.TimerStart();
            ControlSettingsYesNo.Instance.Visible = false;
            ControlMain.Instance.Visible = true;
            ControlMain.Instance.BringToFront();
        }

        private static int indexexistcars;
        public int IndexExistCarsGet()
        {
            return indexexistcars;
        }
        private void IndexExistCarsSet(int value)
        {
            indexexistcars = value;
        }

        public void MenuCheckCars(DataGridView dataGridView1, Label lbNoCars, Button OrderCharge, Button DelCar, Button Update, Button btnToXML)
        {
            using (CarChargingEntities context = new CarChargingEntities())
            {
                string login = new DriverInfo().LoginGet();
                string pass = new DriverInfo().PassGet();
                var res1 = context.Drivers.Where(p=>p.DriverLogin==login && p.DriverPassword==pass);
                int id_driver = res1.First().ID_Driver;
                var res2 = context.Cars.Where(p=>p.ID_Driver==id_driver);

                if (res2.Count()==0)
                {
                    IndexExistCarsSet(0);
                    new DriverInfo().CarSet(null);
                    new DriverInfo().CarsListSet(null);
                    lbNoCars.Visible = true;
                    OrderCharge.Enabled = false;
                    DelCar.Enabled = false;
                    Update.Enabled = false;
                    btnToXML.Enabled = false;

                    if (dataGridView1.Rows.Count != 0)
                    {
                        dataGridView1.CurrentCell = null;
                        dataGridView1.Rows[0].Visible = false;
                    }
                }
                else
                {
                    IndexExistCarsSet(1);
                    lbNoCars.Visible = false;
                    OrderCharge.Enabled = true;
                    DelCar.Enabled = true;
                    Update.Enabled = true;
                    btnToXML.Enabled = true;

                    List<Car> listcar = new List<Car>();
                    foreach(Cars c in res2)
                    {
                        Car car = new Car();
                        car.ID_CarGetSet = c.ID_Car;
                        car.ID_DriverGetSet = c.ID_Driver;
                        car.CarTypeGetSet = c.CarType;
                        car.CarBatteryLevelGetSet = c.CarBatteryLevel.GetValueOrDefault();
                        car.CarTimeToChargeGetSet = c.CarTimeToCharge.GetValueOrDefault();
                        listcar.Add(car);
                    }
                    new DriverInfo().CarsListSet(listcar);
                    new DriverInfo().CarSet(listcar.ElementAt(0)); // default selected car

                    // === GridView Fill with SQL
                    using (SqlConnection connection = new SqlConnection(new ConnString().ConStringGet()))
                    {
                        string sql = string.Format(" Select CarType As 'Car',CarBatteryLevel As 'Baterry (%)',CarTimeToCharge As 'Charge (min)'"
                                                 + " From Cars"
                                                 + " Where ID_Driver = (Select ID_Driver From Drivers"
                                                 + " Where DriverLogin=@DriverLogin And DriverPassword=@DriverPassword)");
                        SqlCommand cmd = new SqlCommand(sql, connection);
                        cmd.Parameters.AddWithValue("@DriverLogin", new DriverInfo().LoginGet());
                        cmd.Parameters.AddWithValue("@DriverPassword", new DriverInfo().PassGet());
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        DataTable datatable = new DataTable();
                        adapter.Fill(datatable);
                        BindingSource bsource = new BindingSource();
                        bsource.DataSource = datatable;
                        dataGridView1.DataSource = bsource;
                        adapter.Update(datatable);
                        dataGridView1.Refresh();

                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            column.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                    }
                }
            }
        }

        public void MenuDeleteSelectedCar()
        {
            using (CarChargingEntities context = new CarChargingEntities())
            {
                Car car = new DriverInfo().CarGet();
                var res = context.Cars.Where(p=>p.ID_Car==car.ID_CarGetSet);
                Cars cardel = res.First();
                context.Cars.Remove(cardel);
                context.SaveChanges();
            }
            ControlMenu.Instance.RefreshCars();
        }

        public void MenuToXML()
        {
            ControlMenu.Instance.DisableMenu();
            try   // save to xml-file select table from table Cars
            {
                XDocument docxml = new XDocument(new XElement("сars.xml")); // XML-file
                docxml.Save("cars.xml");
                if (new DriverInfo().CarsListGet() != null)
                {
                    foreach (Car car in new DriverInfo().CarsListGet())
                    {
                        XElement caradd = new XElement("Cars",
                        new XElement("ID_Car", car.ID_CarGetSet),
                        new XElement("ID_Driver", car.ID_DriverGetSet),
                        new XElement("CarType", car.CarTypeGetSet),
                        new XElement("CarBatteryLevel", car.CarBatteryLevelGetSet),
                        new XElement("CarTimeToCharge"), car.CarTimeToChargeGetSet);
                        docxml.Root.Add(caradd);
                        docxml.Save("cars.xml");
                    }
                    ControlMenuCarsXml.Instance.Visible = true;
                    ControlMenuCarsXml.Instance.BringToFront();                    
                }
            }
            catch (Exception exc)
            {
                if (exc.Source != null)
                {
                    MessageBox.Show("Error! Файл 'towns.xml' не создан!");
                }
            }
        }

        public void MenuAddCar(TextBox tbCarType, TextBox tbBattery, TextBox tbChargeTime)
        {
            using (CarChargingEntities context = new CarChargingEntities())
            {
                string login = new DriverInfo().LoginGet();
                string pass = new DriverInfo().PassGet();
                var res = context.Drivers.Where(p => p.DriverLogin == login && p.DriverPassword== pass);
                int id_driver = res.First().ID_Driver;

                Cars car = new Cars();
                car.ID_Driver = id_driver;
                car.CarType = tbCarType.Text;
                car.CarBatteryLevel = double.Parse(tbBattery.Text);
                car.CarTimeToCharge = double.Parse(tbChargeTime.Text);
                context.Cars.Add(car);
                context.SaveChanges();
                ControlMenu.Instance.RefreshCars();
                ControlMenuNewCar.Instance.CancelClickFun();
            }
        }

        public void MenuUpdateCar(Car car)
        {
            using (CarChargingEntities context = new CarChargingEntities())
            {
                int id_car = new DriverInfo().CarGet().ID_CarGetSet;
                var res = context.Cars.Where(p => p.ID_Car == id_car);
                int num = 0;
                foreach(Cars c in res)
                {
                    c.CarType = car.CarTypeGetSet;
                    c.CarBatteryLevel = car.CarBatteryLevelGetSet;
                    c.CarTimeToCharge = car.CarTimeToChargeGetSet;
                    num++;
                }
                context.SaveChanges();
                if (num != 1)
                {
                    MessageBox.Show("Ошибка! Обновлено " + num + " машин");
                }
            }
        }
        // === End Menu

        // === Order charger
        public void ToOrderCharge()
        {
            ControlOrderCharge.Instance.OrderChargeLoad();
            ControlOrderCharge.Instance.Visible = true;
            ControlOrderCharge.Instance.BringToFront();
        }
        public void OrderChargeAddChargers(ListBox listBox1, Label lbNoChargers)
        {
            using (CarChargingEntities context = new CarChargingEntities())
            {
                var res = context.Chargers.Where(p=>p.ChargerStatus=="online");
                if (res.Count()!=0)
                {
                    List<Charger> list = new List<Charger>();
                    foreach (Chargers c in res)
                    {
                        Charger charger = new Charger();
                        charger.ID_ChargerGetSet = c.ID_Charger;
                        charger.ChargerNameGetSet = c.ChargerName;
                        charger.ChargerAddressGetSet = c.ChargerAddress;
                        charger.ChargerGPSGetSet = c.ChargerGPS;
                        charger.ChargerStatusGetSet = c.ChargerStatus;
                        charger.NumAllPlacesGetSet = c.NumAllPlaces;
                        charger.NumEmptyPlacesGetSet = c.NumEmptyPlaces;
                        charger.NumOrderPlacesGetSet = c.NumOrderPlaces;
                        list.Add(charger);
                        string str = string.Format("{0}", charger.ChargerNameGetSet);
                        listBox1.Items.Add(str);
                    }
                    new DriverInfo().ChargerListSet(list);
                }
                else
                {
                    lbNoChargers.Visible = true;
                }
            }
        }

        // === Count Probability of Charger Station from table ChargingNow (EmptyPlaces == 0)

        public void CountChargerProbability(TextBox tbWaitForEmpty, TextBox tbProbability)
        { 
            using(SqlConnection connection = new SqlConnection(new ConnString().ConStringGet()))
            {
                connection.Open();
                string sql1 = string.Format(" Select ID_Order,ID_Driver,ID_Car,ID_Charger,OrderStatus,OrderTime,"
                                          + " TimeStartChargingExpect,TimeChargingExpect,TimeStartCharging,"
                                          + " TimeEndCharging,TimeCharging,Kilowatt,ProbabilityOrder"
                                          + " From Orders"
                                          + " Where ID_Charger=@ID_Charger AND (OrderStatus='coming to charge' OR OrderStatus='charging')");
                SqlCommand cmd1 = new SqlCommand(sql1, connection);
                cmd1.Parameters.AddWithValue("@ID_Charger", new DriverInfo().ChargerSelectedGet().ID_ChargerGetSet);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (!reader1.HasRows)
                {
                    MessageBox.Show("Ошибка! Свободных мест нет, но активные заказы не найдены!");
                }
                else
                {
                    // === Find all current orders at this station
                    List<Order> listordercoming = new List<Order>();
                    List<Order> listordercharging = new List<Order>();
                    while(reader1.Read())
                    {
                        Order order = new Order(reader1);
                        if (order.OrderStatusGetSet == "charging")
                        {
                            listordercharging.Add(order);
                        }
                        else
                        {
                            if (order.OrderStatusGetSet == "coming to charge")
                            {
                                listordercoming.Add(order);
                            }
                        }
                    }
                    reader1.Close();

                    // === Check orders at station and in queue
                    int orderscoming = listordercoming.Count;
                    int orderscharging = listordercharging.Count;
                    double probabilityStation;
                    DateTime TimeEndChargingMax;
                    DateTime TimeEndChargingMaxWithProbability;  // max(TimeEndCharging)  * ProbabilityDriverLast
                    if (listordercoming.Count == 0 && listordercharging.Count != 0)   // only charging count in ChargingNow
                    {
                        string sql2 = string.Format(" Select ID_Charging, ID_Driver,ID_Car,ID_Charger,ProbabilitySecond,"
                                                  + " TimeStartCharging,TimeEndChargingExpect"
                                                  + " From ChargingNow"
                                                  + " Where ID_Charger=@ID_Charger");
                        SqlCommand cmd2 = new SqlCommand(sql2, connection);
                        cmd2.Parameters.AddWithValue("@ID_Charger", new DriverInfo().ChargerSelectedGet().ID_ChargerGetSet);
                        SqlDataReader reader2 = cmd2.ExecuteReader();
                        if (!reader2.HasRows)
                        {
                            MessageBox.Show("Ошибка! При отсутствии свободных мест - нет текущих заказов на станциях!");
                        }
                        else
                        {
                            List<double> listprobability = new List<double>();
                            List<ChargingNow> listchargingnow = new List<ChargingNow>();
                            while(reader2.Read())
                            {
                                ChargingNow chargingnow = new ChargingNow(reader2);
                                listprobability.Add(chargingnow.ProbabilitySecondGetSet);
                                listchargingnow.Add(chargingnow);
                            }
                            reader2.Close();

                            ChargingNow charginglastdriver = new ChargingNow();  // car with last time to end charging
                            foreach(ChargingNow ch in listchargingnow)
                            {
                                if (ch.TimeEndChargingExpectGetSet >= charginglastdriver.TimeEndChargingExpectGetSet)
                                {
                                    charginglastdriver = ch;
                                }
                            }

                            // === count Probability avg and time to wait
                            probabilityStation = listprobability.Average(); // counting avg probability

                            // === count time to wait
                            TimeEndChargingMax = charginglastdriver.TimeEndChargingExpectGetSet;
                            TimeSpan timechargingexpect = charginglastdriver.TimeEndChargingExpectGetSet - charginglastdriver.TimeStartChargingGetSet;
                            TimeEndChargingMaxWithProbability = charginglastdriver.TimeStartChargingGetSet.AddMinutes((timechargingexpect.Minutes + timechargingexpect.Hours*60 + timechargingexpect.Days*24*60 ) * charginglastdriver.ProbabilitySecondGetSet);  // * probability

                            TimeSpan timetowaitlast = TimeEndChargingMaxWithProbability - DateTime.Now;
                            int timetowaitlastmin = timetowaitlast.Minutes + timetowaitlast.Hours * 60 + timetowaitlast.Days*24*60;
                            if (timetowaitlastmin <0)
                            {
                                timetowaitlastmin = 0;
                            }
                            // === Show Probability station and time to wait
                            tbProbability.Text = string.Format("P = {0:0.00}, orders coming = {1}", probabilityStation, orderscoming);
                            tbWaitForEmpty.Text = string.Format("{0} min need to wait!", timetowaitlastmin);
                        }
                    }
                    else
                    {
                        if (listordercoming.Count !=0 || listordercharging.Count!=0)  // charging and coming
                        {
                            // === Select orders that's coming to this charge (ID_Charger) from exist List<> listordercoming
                            Order orderlastmaked = new Order();
                            List<double> listprobabilityorderscoming = new List<double>();
                            foreach(Order order in listordercoming)
                            {
                                listprobabilityorderscoming.Add(order.ProbabilityOrderGetSet);  // list probability
                                if (order.OrderTimeGetSet >= orderlastmaked.OrderTimeGetSet)
                                {
                                    orderlastmaked = order;
                                }
                            }

                            // === Count probability orders
                            probabilityStation = listprobabilityorderscoming.Average();

                            // === Count time to wait using 2 probabilities : Probability of last order and probability of all orders coming
                            double timechargingexpect = orderlastmaked.TimeChargingExpectGetSet;
                            double timechargingexpectProbability = timechargingexpect * orderlastmaked.ProbabilityOrderGetSet * probabilityStation;

                            DateTime timeendchargingwithProbability = orderlastmaked.TimeStartChargingExpectGetSet.AddMinutes( timechargingexpectProbability );  // time end with probability
                            TimeSpan timetowait = timeendchargingwithProbability - DateTime.Now;
                            int timetowaitlastordermin = timetowait.Minutes + timetowait.Hours * 60 + timetowait.Days * 24 * 60;
                            if (timetowaitlastordermin < 0)
                            {
                                timetowaitlastordermin = 0;
                            }
                            // === Show Probability station and time to wait
                            tbProbability.Text = string.Format("P = {0:0.00}, orders coming = {1}", probabilityStation, orderscoming);
                            tbWaitForEmpty.Text = string.Format("{0} min waiting forecast!", timetowaitlastordermin);
                        }
                    }
                }
            }
        }
        // === End of Count

        public void MakeOrder(TextBox tbTimeToCharger)
        {
            // === Take one place on selected charger

            using(SqlConnection connection = new SqlConnection(new ConnString().ConStringGet()))
            {
                Charger chargerupdate = new DriverInfo().ChargerSelectedGet();
                chargerupdate.NumOrderPlacesGetSet += 1;   // + one order place

                connection.Open();
                string sql = string.Format(" Update Chargers" 
                                         + " Set NumEmptyPlaces=@NumEmptyPlaces,NumOrderPlaces=@NumOrderPlaces"
                                         + " Where ID_Charger=@ID_Charger");
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@NumEmptyPlaces", chargerupdate.NumEmptyPlacesGetSet);
                cmd.Parameters.AddWithValue("@NumOrderPlaces", chargerupdate.NumOrderPlacesGetSet);
                cmd.Parameters.AddWithValue("@ID_Charger", chargerupdate.ID_ChargerGetSet);
                int n = cmd.ExecuteNonQuery();
                if (n==0)
                {
                    MessageBox.Show("Кол-во свободных мест на станции не изменено!");
                }
                else
                {
                    new DriverInfo().ChargerSelectedSet(chargerupdate);  // Update static charger (instead from new query)
                }
            }

            // === Get info from Driver, Selected Car and Selected Charger

            Driver driver = new DriverInfo().DriverGet();
            Car car = new DriverInfo().CarGet();
            Charger charger = new DriverInfo().ChargerSelectedGet();

            // === Making the new Order and record it

            Order order = new Order();
            order.ID_DriverGetSet = driver.ID_DriverGetSet;
            order.ID_CarGetSet = car.ID_CarGetSet;
            order.ID_ChargerGetSet = charger.ID_ChargerGetSet;
            order.OrderStatusGetSet = "coming to charge";
            order.OrderTimeGetSet = DateTime.Now;
            order.TimeStartChargingExpectGetSet = DateTime.Now+TimeSpan.FromMinutes(int.Parse(tbTimeToCharger.Text));
            order.TimeChargingExpectGetSet = car.CarTimeToChargeGetSet;
            order.ProbabilityOrderGetSet = driver.ProbabilityGetSet;

            using(SqlConnection connection = new SqlConnection(new ConnString().ConStringGet()))
            {
                connection.Open();
                string sql = string.Format(" Insert Into Orders(ID_Driver,ID_Car,ID_Charger,OrderStatus,OrderTime,TimeStartChargingExpect,TimeChargingExpect,ProbabilityOrder)" 
                                         + " Values(@ID_Driver,@ID_Car,@ID_Charger,@OrderStatus,@OrderTime,@TimeStartChargingExpect,@TimeChargingExpect,@ProbabilityOrder)");
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("ID_Driver", order.ID_DriverGetSet);
                cmd.Parameters.AddWithValue("ID_Car", order.ID_CarGetSet);
                cmd.Parameters.AddWithValue("ID_Charger", order.ID_ChargerGetSet);
                cmd.Parameters.AddWithValue("OrderStatus", order.OrderStatusGetSet);
                cmd.Parameters.AddWithValue("OrderTime", order.OrderTimeGetSet);
                cmd.Parameters.AddWithValue("TimeStartChargingExpect", order.TimeStartChargingExpectGetSet);
                cmd.Parameters.AddWithValue("TimeChargingExpect", order.TimeChargingExpectGetSet);
                cmd.Parameters.AddWithValue("ProbabilityOrder", order.ProbabilityOrderGetSet);

                int n = cmd.ExecuteNonQuery();
                if (n==0)
                {
                    MessageBox.Show("Заказ не записан!");
                }
                else
                {
                    new DriverInfo().DriverOrderSet(order);    // Set static order
                }
            }
        }

        // === End Order

        // === Cancel Order
        public void OrderCurrentCancelByUser()
        {
            using(SqlConnection connection = new SqlConnection(new ConnString().ConStringGet()))
            {
                connection.Open();
                // Update Orders to history
                string sql = string.Format(" Update Orders "
                                         + " Set OrderStatus='cancel user'"
                                         + " Where ID_Driver=@ID_Driver AND OrderStatus='coming to charge'");
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@ID_Driver", new DriverInfo().DriverGet().ID_DriverGetSet);
                int n = cmd.ExecuteNonQuery();
                if (n!=1)
                {
                    MessageBox.Show("Ошибка обновления отмены заказа!");
                }
                // Update Chargers --Order
                string sql1 = string.Format(" Update Chargers"
                                          + " Set NumOrderPlaces=@NumOrderPlaces"
                                          + " Where ID_Charger=@ID_Charger");
                SqlCommand cmd1 = new SqlCommand(sql1, connection);
                cmd1.Parameters.AddWithValue("@NumOrderPlaces", --new DriverInfo().ChargerSelectedGet().NumOrderPlacesGetSet);
                cmd1.Parameters.AddWithValue("@ID_Charger", new DriverInfo().DriverOrderGet().ID_ChargerGetSet);
                int n1 = cmd1.ExecuteNonQuery();
                if (n1!=1)
                {
                    MessageBox.Show("Ошибка обновления кол-ва заказов на зарядной станции (--)!");
                }
            }
        }
        // === End Cancel of Order

        // === StartCharging and ProgressBar (operations async)

        public void StartCharging()
        {
            // === Charging is starting - record changes to base
            using (SqlConnection connection = new SqlConnection(new ConnString().ConStringGet()))
            {
                connection.Open();
                // 1. OrderStatus=charging  2. Update TimeStartCharging
                string sql1 = string.Format(" Update Orders"
                                          + " Set OrderStatus='charging', TimeStartCharging=@TimeStartCharging"
                                          + " Where ID_Driver=@ID_Driver AND OrderStatus='coming to charge'");
                SqlCommand cmd1 = new SqlCommand(sql1, connection);
                cmd1.Parameters.AddWithValue("@ID_Driver", new DriverInfo().DriverOrderGet().ID_DriverGetSet);
                cmd1.Parameters.AddWithValue("@TimeStartCharging", DateTime.Now);
                int n1 = cmd1.ExecuteNonQuery();
                if (n1 != 1)
                {
                    MessageBox.Show("Ошибка обновления заказа (OrderStatus and TimeStartCharging)!");
                }
                else
                {
                    Order orderupd = new DriverInfo().DriverOrderGet();
                    orderupd.OrderStatusGetSet = "charging";
                    orderupd.TimeStartChargingGetSet = DateTime.Now;
                    new DriverInfo().DriverOrderSet(orderupd);  // update static order
                }

                // 3. Update Chargers NumEmptyPlaces-- if !=0
                if (new DriverInfo().ChargerSelectedGet().NumEmptyPlacesGetSet != 0)
                {
                    string sql2 = string.Format(" Update Chargers"
                                              + " Set NumEmptyPlaces=@NumEmptyPlaces"
                                              + " Where ID_Charger=@ID_Charger");
                    SqlCommand cmd2 = new SqlCommand(sql2, connection);
                    int placesupd = new DriverInfo().ChargerSelectedGet().NumEmptyPlacesGetSet;
                    if (placesupd > 0)
                    {
                        placesupd--;
                    }
                    cmd2.Parameters.AddWithValue("@NumEmptyPlaces", placesupd);
                    cmd2.Parameters.AddWithValue("@ID_Charger", new DriverInfo().ChargerSelectedGet().ID_ChargerGetSet);
                    int n2 = cmd2.ExecuteNonQuery();
                    if (n2 != 1)
                    {
                        MessageBox.Show("Ошибка обновления свободных мест на станции (--)!");
                    }
                    else
                    {
                        Charger chargerupd = new DriverInfo().ChargerSelectedGet();
                        chargerupd.NumEmptyPlacesGetSet = placesupd;
                        new DriverInfo().ChargerSelectedSet(chargerupd);   // update static charger
                    }
                }
                // 4. ChargingNow Insert new
                string sql3 = string.Format(" Insert Into ChargingNow(ID_Driver,ID_Car,ID_Charger,ProbabilitySecond,TimeStartCharging,TimeEndChargingExpect)"
                                           + " Values(@ID_Driver,@ID_Car,@ID_Charger,@ProbabilitySecond,@TimeStartCharging,@TimeEndChargingExpect)");
                SqlCommand cmd3 = new SqlCommand(sql3, connection);
                cmd3.Parameters.AddWithValue("@ID_Driver", new DriverInfo().DriverOrderGet().ID_DriverGetSet);
                cmd3.Parameters.AddWithValue("@ID_Car", new DriverInfo().DriverOrderGet().ID_CarGetSet);
                cmd3.Parameters.AddWithValue("@ID_Charger", new DriverInfo().DriverOrderGet().ID_ChargerGetSet);
                cmd3.Parameters.AddWithValue("@ProbabilitySecond", new DriverInfo().DriverOrderGet().ProbabilityOrderGetSet);

                DateTime timestart = new DriverInfo().DriverOrderGet().TimeStartChargingGetSet;
                DateTime timeend = new DriverInfo().DriverOrderGet().TimeStartChargingGetSet.AddMinutes(new DriverInfo().CarGet().CarTimeToChargeGetSet);
                cmd3.Parameters.AddWithValue("@TimeStartCharging", timestart);
                cmd3.Parameters.AddWithValue("@TimeEndChargingExpect", timeend);
                int n3 = cmd3.ExecuteNonQuery();
                if (n3 != 1)
                {
                    MessageBox.Show("Ошибка записи новой строки в ChargingNow");
                }
            }
        }
        // End StartCharging()

        public void StopCharging(DateTime timeendcharging, int batterylevelnew)
        {
            using(SqlConnection connection = new SqlConnection(new ConnString().ConStringGet()))
            {
                connection.Open();

                // 1. Chargers update EmptyPlaces++  Orders--
                Charger chargernew = new DriverInfo().ChargerSelectedGet();
                if (chargernew.NumEmptyPlacesGetSet < chargernew.NumAllPlacesGetSet)
                {
                    chargernew.NumEmptyPlacesGetSet++;
                }

                if (chargernew.NumOrderPlacesGetSet >0)
                {
                    chargernew.NumOrderPlacesGetSet--;
                }
                string sqlcharger = string.Format(" Update Chargers"
                                                + " Set NumEmptyPlaces=@NumEmptyPlaces, NumOrderPlaces=@NumOrderPlaces"
                                                + " Where ID_Charger=@ID_Charger");
                SqlCommand cmdcharger = new SqlCommand(sqlcharger, connection);
                cmdcharger.Parameters.AddWithValue("@NumEmptyPlaces", chargernew.NumEmptyPlacesGetSet);
                cmdcharger.Parameters.AddWithValue("@NumOrderPlaces", chargernew.NumOrderPlacesGetSet);
                cmdcharger.Parameters.AddWithValue("@ID_Charger", new DriverInfo().DriverOrderGet().ID_ChargerGetSet);
                int n1 = cmdcharger.ExecuteNonQuery();
                if (n1 != 1)
                {
                    MessageBox.Show("Ошибка обновления Charger после окончания зарядки!");
                }
                else
                {
                    new DriverInfo().ChargerSelectedSet(chargernew);  // update static charger
                }

                // 2. ChargingNow delete one temp row
                string sqlchargingnow = string.Format(" Delete From ChargingNow"
                                                    + " Where ID_Driver=@ID_Driver");
                SqlCommand cmdchargingnow = new SqlCommand(sqlchargingnow, connection);
                cmdchargingnow.Parameters.AddWithValue("@ID_Driver", new DriverInfo().DriverOrderGet().ID_DriverGetSet);
                int n2 = cmdchargingnow.ExecuteNonQuery();
                if (n2 !=1)
                {
                    MessageBox.Show("Ошибка удаления кортежа из ChargingNow!");
                }

                // 3. Cars update battery 
                Car carnew = new DriverInfo().CarGet();
                int carbatterystartlevel = Convert.ToInt32(carnew.CarBatteryLevelGetSet);  // save old level battery
                carnew.CarBatteryLevelGetSet = batterylevelnew;   // Update battery level (100 kWT 100%)
                string sqlcar = string.Format(" Update Cars"
                                            + " Set CarBatteryLevel=@CarBatteryLevel"
                                            + " Where ID_Car=@ID_Car AND ID_Driver=@ID_Driver");
                SqlCommand cmdcar = new SqlCommand(sqlcar, connection);
                cmdcar.Parameters.AddWithValue("@CarBatteryLevel", carnew.CarBatteryLevelGetSet);
                cmdcar.Parameters.AddWithValue("@ID_Car", new DriverInfo().DriverOrderGet().ID_CarGetSet);
                cmdcar.Parameters.AddWithValue("@ID_Driver", new DriverInfo().DriverOrderGet().ID_DriverGetSet);
                int n3 = cmdcar.ExecuteNonQuery();
                if (n3 != 1)
                {
                    MessageBox.Show("Ошибка обновления батареи машины!");
                }
                else
                {
                    new DriverInfo().CarSet(carnew);  // Update static car 
                }

                // 4. Orders update probability and times and status (ready) (TimeStartChargingExpect, TimeStartCharging, TimeEndCharging)
                Order ordernew = new DriverInfo().DriverOrderGet();
                ordernew.TimeEndChargingGetSet = timeendcharging;  // Update
                TimeSpan timechargingfact = timeendcharging - new DriverInfo().DriverOrderGet().TimeStartChargingGetSet;
                ordernew.TimeChargingGetSet = (Convert.ToDouble(timechargingfact.Seconds) + Convert.ToDouble(timechargingfact.Minutes * 60) + Convert.ToDouble(timechargingfact.Hours * 60 * 60) + Convert.ToDouble(timechargingfact.Days * 24 * 60 * 60) ) / 60;  // Update
                ordernew.KilowattGetSet = batterylevelnew-carbatterystartlevel; // Update kWT

                // Probability  =  fact / theory
                double probability;
                if (ordernew.TimeStartChargingGetSet >= ordernew.TimeStartChargingExpectGetSet)
                {
                    TimeSpan time = ordernew.TimeStartChargingGetSet - ordernew.TimeStartChargingExpectGetSet;
                    double mint = (Convert.ToDouble(time.Seconds) + Convert.ToDouble(time.Minutes * 60) + Convert.ToDouble(time.Hours * 60 * 60) + Convert.ToDouble(time.Days * 24 * 60 * 60) ) / 60;   // sec / 60
                    probability = (ordernew.TimeChargingGetSet + mint) / ordernew.TimeChargingExpectGetSet;
                }
                else
                {
                    TimeSpan time = ordernew.TimeStartChargingExpectGetSet - ordernew.TimeStartChargingGetSet;
                    double mint = (Convert.ToDouble(time.Seconds) + Convert.ToDouble(time.Minutes * 60) + Convert.ToDouble(time.Hours * 60 * 60) + Convert.ToDouble(time.Days * 24 * 60 * 60)) / 60;   // sec / 60
                    probability = ordernew.TimeChargingGetSet / (ordernew.TimeChargingExpectGetSet + mint);
                }
                if (probability > 3.5)
                {
                    probability = 3.5; // max
                }
                ordernew.ProbabilityOrderGetSet = probability;   // Update probability

                string sqlorder = string.Format(" Update Orders"
                                              + " Set OrderStatus=@OrderStatus, TimeEndCharging=@TimeEndCharging, "
                                              + " TimeCharging=@TimeCharging, Kilowatt=@Kilowatt, ProbabilityOrder=@ProbabilityOrder"
                                              + " Where ID_Driver=@ID_Driver AND OrderStatus='charging'");
                SqlCommand cmdorder = new SqlCommand(sqlorder, connection);
                cmdorder.Parameters.AddWithValue("@OrderStatus", "ready");
                cmdorder.Parameters.AddWithValue("@TimeEndCharging", ordernew.TimeEndChargingGetSet);
                cmdorder.Parameters.AddWithValue("@TimeCharging", ordernew.TimeChargingGetSet);
                cmdorder.Parameters.AddWithValue("@Kilowatt", ordernew.KilowattGetSet);
                cmdorder.Parameters.AddWithValue("@ProbabilityOrder", ordernew.ProbabilityOrderGetSet);
                cmdorder.Parameters.AddWithValue("@ID_Driver", ordernew.ID_DriverGetSet);

                int n4 = cmdorder.ExecuteNonQuery();
                if (n4!=1)
                {
                    MessageBox.Show("Ошибка обновления Order!");
                }
                else
                {
                    new DriverInfo().DriverOrderSet(ordernew);  // Update static order
                }

                // 5. Drivers update probability 
                double probabilitydrivernew;
                List<double> listp = new List<double>();

                string sqlprobability = string.Format(" Select ProbabilityOrder"
                                                    + " From Orders"
                                                    + " Where ID_Driver=@ID_Driver");
                SqlCommand cmdprobability = new SqlCommand(sqlprobability, connection);
                cmdprobability.Parameters.AddWithValue("@ID_Driver", new DriverInfo().DriverOrderGet().ID_DriverGetSet);
                SqlDataReader readerprobability = cmdprobability.ExecuteReader();
                if (!readerprobability.HasRows)
                {
                    MessageBox.Show("Select не выбрал ни одной вероятности из заказов");
                }
                else
                {
                    listp = new List<double>();
                    while(readerprobability.Read())
                    {
                        listp.Add(readerprobability.GetDouble(0));
                    }
                    readerprobability.Close();
                }
                probabilitydrivernew = listp.Average();

                string sqldriver = string.Format(" Update Drivers"
                                               + " Set Probability=@Probability"
                                               + " Where ID_Driver=@ID_Driver");
                SqlCommand cmddriver = new SqlCommand(sqldriver, connection);
                cmddriver.Parameters.AddWithValue("@Probability", probabilitydrivernew);
                cmddriver.Parameters.AddWithValue("@ID_Driver", new DriverInfo().DriverOrderGet().ID_DriverGetSet);
                int n5 = cmddriver.ExecuteNonQuery();
                if (n5 != 1)
                {
                    MessageBox.Show("Ошибка обновления вероятности в Drivers!");
                }
                else
                {
                    new DriverInfo().DriverClear();
                }
            }
        }
    }
}
