using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Threading;

namespace CarCharging
{
    public partial class ControlOrderCurrent : UserControl
    {
        public ControlOrderCurrent()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            OrderCurrentVisibleDefault();
        }

        private static ControlOrderCurrent ControlOrderCurrentInstance;
        public static ControlOrderCurrent Instance
        {
            get
            {
                if (ControlOrderCurrentInstance == null)
                {
                    ControlOrderCurrentInstance = new ControlOrderCurrent();
                }
                return ControlOrderCurrentInstance;
            }
        }

        private void OrderCurrentVisibleDefault()
        {
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 100;
            progressBar1.Value = 1;

            btnStopCharging.Enabled = false;
            lbStopCharging.Visible = false;

            tbCar.Enabled = false;
            tbBattery.Enabled = false;
            tbTimeToCharge.Enabled = false;
            tbSelectedCharger.Enabled = false;
            tbAddress.Enabled = false;
            tbGPS.Enabled = false;
            tbOrderTime.Enabled = false;

            lbPercent.Visible = false;
            progressBar1.Visible = false;
            lbStartTime.Visible = false;
            lbEndTimeExpect.Visible = false;
            lbTimePassedMin.Visible = false;
            lbCurrentTime.Visible = false;
            lbBatteryProgress.Visible = false;

            lbBatteryProgressVal.Visible = false;
            lbStartTimeVal.Visible = false;
            lbEndTimeExpectVal.Visible = false;
            lbTimePassedMinVal.Visible = false;
            lbCurrentTimeVal.Visible = false;
        }

        public void LoadFromOrder()
        {
            LoadStandartParams();
        }

        public void LoadFromEnter()
        {
            LoadStandartParams();
            if (new DriverInfo().DriverOrderGet().OrderStatusGetSet == "charging") // Check the status order (charging) - > progressbar and Threads go on!
            {
                CountTimerIntervalsContinue(); // Count new

                timer1.Start();                // Start timer 1 sec time
                timerStepProgressBar.Start();  // Start ProgressBar
                timerBattery.Start();          // Start timer Battery
                
                // === visual only

                btnStartCharging.Enabled = false;
                btCancel.Enabled = false;
                btnStopCharging.Enabled = true;

                progressBar1.Visible = true;
                lbPercent.Visible = true;

                lbStartTime.Visible = true;
                lbEndTimeExpect.Visible = true;
                lbCurrentTime.Visible = true;
                lbTimePassedMin.Visible = true;
                lbBatteryProgress.Visible = true;

                lbStartTimeVal.Visible = true;
                lbEndTimeExpectVal.Visible = true;
                lbCurrentTimeVal.Visible = true;
                lbTimePassedMinVal.Visible = true;
                lbBatteryProgressVal.Visible = true;

            }
        }



        private void LoadStandartParams()
        {
            lbDriverLogin.Text = new DriverInfo().LoginGet();
            tbCar.Text = new DriverInfo().CarGet().CarTypeGetSet;
            tbBattery.Text = new DriverInfo().CarGet().CarBatteryLevelGetSet.ToString();
            tbTimeToCharge.Text = new DriverInfo().CarGet().CarTimeToChargeGetSet.ToString();
            tbSelectedCharger.Text = new DriverInfo().ChargerSelectedGet().ChargerNameGetSet;
            tbAddress.Text = new DriverInfo().ChargerSelectedGet().ChargerAddressGetSet;
            tbGPS.Text = new DriverInfo().ChargerSelectedGet().ChargerGPSGetSet;
            tbOrderTime.Text = new DriverInfo().DriverOrderGet().OrderTimeGetSet.ToString();
            btCancel.Enabled = true;
        }


        private void ExitLoginCurrentOrder_Click(object sender, EventArgs e)
        {
            OrderCurrentExitClear();
        }

        public void OrderCurrentExitClear()
        {
            timer1.Stop();
            timerStepProgressBar.Stop();
            timerBattery.Stop();
            new DriverInfo().CarSet(null);
            new DriverInfo().CarsListSet(null);
            new DriverInfo().DriverClear();
            new DriverInfo().ChargerSelectedSet(null);
            new DriverInfo().DriverOrderSet(null);
            new DriverInfo().LoginPassOfflineClear();

            lbDriverLogin.Text = "lbDriverLogin";
            btnStartCharging.Enabled = true;
            btnStopCharging.Enabled = false;
            lbStopCharging.Visible = false;

            tbCar.Clear();
            tbBattery.Clear();
            tbTimeToCharge.Clear();
            tbSelectedCharger.Clear();
            tbAddress.Clear();
            tbGPS.Clear();
            tbOrderTime.Clear();

            lbStartTimeVal.Text = "text";
            lbEndTimeExpectVal.Text = "text";
            lbTimePassedMinVal.Text = "text";
            lbCurrentTimeVal.Text = "text";
            lbBatteryProgressVal.Text = "text";

            lbPercent.Visible = false;
            progressBar1.Visible = false;
            lbStartTime.Visible = false;
            lbEndTimeExpect.Visible = false;
            lbTimePassedMin.Visible = false;
            lbCurrentTime.Visible = false;
            lbBatteryProgress.Visible = false;

            lbStartTimeVal.Visible = false;
            lbEndTimeExpectVal.Visible = false;
            lbTimePassedMinVal.Visible = false;
            lbCurrentTimeVal.Visible = false;
            lbBatteryProgressVal.Visible = false;

            lbPercent.Text = "%";
            lbPercent.Visible = false;

            ControlMain.Instance.TimerStart();
            ControlMain.Instance.BringToFront();
            ControlMain.Instance.Visible = true;
        }

        private void btnStopCharging_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timerStepProgressBar.Stop();
            timerBattery.Stop();
            Car carupd = new DriverInfo().CarGet();
            carupd.CarBatteryLevelGetSet = carbatterylevel;
            new DriverInfo().CarSet(carupd);     // Updating static car %
            btnStopCharging.Enabled = false;
            lbStopCharging.Text = "Charging is stopped!";
            lbStopCharging.Visible = true;
            new Direction().StopCharging(DateTime.Now, carbatterylevel);            
        }

        private void btnStartCharging_Click(object sender, EventArgs e)
        {
            new Direction().StartCharging(); // === Record Changes to base

            CountTimerIntervals();

            timer1.Start();                // Start timer 1 sec time
            timerStepProgressBar.Start();  // Start ProgressBar
            timerBattery.Start();          // Start timer Battery

            btnStartCharging.Enabled = false;
            btCancel.Enabled = false;
            btnStopCharging.Enabled = true;

            progressBar1.Visible = true;

            lbStartTime.Visible = true;
            lbEndTimeExpect.Visible = true;
            lbCurrentTime.Visible = true;
            lbTimePassedMin.Visible = true;
            lbBatteryProgress.Visible = true;

            lbPercent.Visible = true;
            lbStartTimeVal.Visible = true;
            lbEndTimeExpectVal.Visible = true;
            lbCurrentTimeVal.Visible = true;
            lbTimePassedMinVal.Visible = true;
            lbBatteryProgressVal.Visible = true;
        }

        // === Start Timers ===
        private int carbatterylevel;
        private void CountTimerIntervals()
        {
            lbStartTimeVal.Text = DateTime.Now.ToString();
            DateTime endtimeexpect = DateTime.Now.AddMinutes(new DriverInfo().CarGet().CarTimeToChargeGetSet);
            lbEndTimeExpectVal.Text = endtimeexpect.ToString();

            progressBar1.Value = 1;
            lbPercent.Text = string.Format("0%");
            lbCurrentTimeVal.Text = string.Format("{0}", DateTime.Now);
            lbTimePassedMinVal.Text = string.Format("{0}", 0);
            lbBatteryProgressVal.Text = string.Format("{0}%", Convert.ToInt32(new DriverInfo().CarGet().CarBatteryLevelGetSet));

            DateTime timestartcharging = new DriverInfo().DriverOrderGet().TimeStartChargingGetSet;
            DateTime timeendcharging = new DriverInfo().DriverOrderGet().TimeStartChargingGetSet.AddMinutes(new DriverInfo().CarGet().CarTimeToChargeGetSet);
            TimeSpan time = timeendcharging - timestartcharging;
            double milliseconds = time.Milliseconds + (time.Seconds + time.Minutes * 60 + time.Hours * 60 * 60 + time.Days * 24 * 60 * 60) * 1000;
            double intervalProgressBar = milliseconds / 99;
            timerStepProgressBar.Interval = Convert.ToInt32(intervalProgressBar);  // timer interval create ProgressBar 

            double carbatterystart = new DriverInfo().CarGet().CarBatteryLevelGetSet;
            carbatterylevel = Convert.ToInt32(carbatterystart);
            if (carbatterystart < 100)
            {
                double intervalBattery = milliseconds / (100 - carbatterystart);
                timerBattery.Interval = Convert.ToInt32(intervalBattery);        // timer interval create Battery
            }
            else
            {
                progressBar1.Value = 100;
                lbBatteryProgressVal.Text = "100%";
                lbPercent.Text = string.Format("{0}%",  progressBar1.Value);
            }
        }

        private void CountTimerIntervalsContinue()
        {
            lbCurrentTimeVal.Text = string.Format("{0}", DateTime.Now);
            TimeSpan mininterval = DateTime.Now - new DriverInfo().DriverOrderGet().TimeStartChargingGetSet;
            lbTimePassedMinVal.Text = string.Format("{0}", mininterval.Seconds + 60 * (mininterval.Minutes + mininterval.Hours * 60 + mininterval.Days * 24 * 60));

            DateTime starttime = new DriverInfo().DriverOrderGet().TimeStartChargingGetSet;
            DateTime endtimeexpect = starttime.AddMinutes(new DriverInfo().CarGet().CarTimeToChargeGetSet);
            lbStartTimeVal.Text = starttime.ToString();
            lbEndTimeExpectVal.Text = endtimeexpect.ToString();

            // === 

            DateTime timestartcharging = new DriverInfo().DriverOrderGet().TimeStartChargingGetSet;
            DateTime timeendcharging = new DriverInfo().DriverOrderGet().TimeStartChargingGetSet.AddMinutes(new DriverInfo().CarGet().CarTimeToChargeGetSet);
            TimeSpan time = timeendcharging - timestartcharging;
            double milliseconds = time.Milliseconds + (time.Seconds + time.Minutes * 60 + time.Hours * 60 * 60 + time.Days * 24 * 60 * 60) * 1000;
            TimeSpan timenow = DateTime.Now - timestartcharging;
            double millisecondsnow = timenow.Milliseconds + (timenow.Seconds + timenow.Minutes * 60 + timenow.Hours * 60 * 60 + timenow.Days * 24 * 60 * 60) * 1000;

            // === count progressBar.Value and %
            // ProgressBar (100-1) <==> (timeendcharging - timestartcharging).Milliseconds;
            // ProgressBarNOW?     <==> (DateTime.Now - timestartcharging).Milliseconds

            int progressBarVal = Convert.ToInt32((100 - 1) * millisecondsnow / milliseconds);
            if (progressBarVal>=100)
            {
                progressBar1.Value = 100;
            }
            else
            {
                progressBar1.Value = progressBarVal;
            }

            double intervalProgressBar = milliseconds / (100-1);
            timerStepProgressBar.Interval = Convert.ToInt32(intervalProgressBar);  // timer interval create ProgressBar 

            // === count Battery
            // carbatteryALL (100-battery start%) <==> (timeendcharging - timestartcharging).Milliseconds;
            // carbatterystartNOW?                <==> (DateTime.Now - timestartcharging).Milliseconds

            double carbatterystart = new DriverInfo().CarGet().CarBatteryLevelGetSet;

            if (carbatterystart == 100)
            {
                carbatterylevel = 100;
                progressBar1.Value = 100;
            }
            else
            {
                double intervalBattery = milliseconds / (100 - carbatterystart);
                timerBattery.Interval = Convert.ToInt32(intervalBattery);        // timer interval create Battery
                carbatterylevel = Convert.ToInt32(carbatterystart) + Convert.ToInt32((100 - carbatterystart) * millisecondsnow / milliseconds);  
                if (carbatterylevel>=100)
                {
                    carbatterylevel = 100;
                }
            }
            lbBatteryProgressVal.Text = string.Format("{0}%", carbatterylevel);  // UpdateBattery
            lbPercent.Text = string.Format("{0}%", progressBar1.Value);
        }

        private void timerStepProgressBar_Tick(object sender, EventArgs e)   // interval dynamic millicesonds ProgressBar
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Invoke(
                    new Action(() =>
                    {
                        progressBar1.Value++;
                    }
                    ));

                lbPercent.Invoke(
                    new Action(() =>
                    {
                        lbPercent.Text = string.Format("{0}%", progressBar1.Value);
                    }
                    ));
            }
            else
            {
                lbStopCharging.Text = "Battery is full!";
                lbStopCharging.Visible = true;
                timerStepProgressBar.Stop();
            }
        }

        private void timerBattery_Tick(object sender, EventArgs e)   // interval dynamic millicesonds Battery
        {
            if (carbatterylevel < 100)
            {
                lbBatteryProgressVal.Invoke(
                    new Action(() =>
                        {
                            lbBatteryProgressVal.Text = string.Format("{0}%", ++carbatterylevel);
                        }
                        ));
            }
            else
            {
                if (carbatterylevel >=100)
                {
                    carbatterylevel = 100;
                    lbBatteryProgressVal.Invoke(
                        new Action(() =>
                        {
                            lbBatteryProgressVal.Text = string.Format("{0}%", carbatterylevel);
                        }
                            ));
                    timerBattery.Stop();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)  // one second timer's interval
        {             
            lbCurrentTimeVal.Invoke(              
                new Action(() =>                               
                {                                
                    lbCurrentTimeVal.Text = string.Format("{0}", DateTime.Now);                                      
                }                              
                ));
             
            lbTimePassedMinVal.Invoke(               
                new Action(() =>                                    
                {                      
                    TimeSpan mininterval = DateTime.Now - new DriverInfo().DriverOrderGet().TimeStartChargingGetSet;                
                    lbTimePassedMinVal.Text = string.Format("{0}", mininterval.Seconds + 60 * (mininterval.Minutes + mininterval.Hours * 60 + mininterval.Days * 24 * 60));                                    
                }    
                ));
        }
        // === End Timers === 

        private void ControlOrderCurrent_Load(object sender, EventArgs e)
        {

        }

        private void tbTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            OrderCurrentDisable();
            ControlOrderCurrentCalcel.Instance.Visible = true;
            ControlOrderCurrentCalcel.Instance.BringToFront();
        }

        private void OrderCurrentDisable()
        {
            btCancel.Enabled = false;
            btnStartCharging.Enabled = false;
            ExitLoginCurrentOrder.Enabled = false;
        }
        public void OrderCurrentEnable()
        {
            btCancel.Enabled = true;
            btnStartCharging.Enabled = true;
            ExitLoginCurrentOrder.Enabled = true;
        }
    }
}
