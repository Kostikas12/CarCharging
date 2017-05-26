using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CarCharging
{
    /// <summary>
    /// Interaction logic for ControlWLog.xaml
    /// </summary>
    public partial class ControlWLog : UserControl
    {
        DispatcherTimer timer1;
        public ControlWLog()
        {
            InitializeComponent();
            index = 1;
            ellipse1.Opacity = 0;
            ellipse2.Opacity = 0;
            ellipse3.Opacity = 0;
            timer1 = new DispatcherTimer();
            timer1.Tick+=timer1_Tick;
            timer1.Interval = new TimeSpan(0,0,0,0,20);
            timer1.Start();
        }

        public void TimerStop()
        {
            timer1.Stop();
        }

        private static int index; // 1 2 3 
        private void timer1_Tick(object sender, EventArgs e)
        {
            double p = 0.05;
            if (index==1)
            {
                if (ellipse3.Opacity>0)
                {
                    ellipse3.Opacity -= (p+0.05);
                }
                else
                {
                    if (ellipse1.Opacity < 1)
                    {
                        ellipse1.Opacity += p;
                    }
                    else
                    {
                        index = 2;
                    }
                }
            }
            else
            {
                if (index==2)
                {
                    if (  ellipse1.Opacity>0 || ellipse2.Opacity<1  )
                    {
                        ellipse2.Opacity += p;
                        ellipse1.Opacity -= p;
                    }
                    else
                    {
                        index = 3;
                    }
                }
                else
                {
                    if (index==3)
                    {
                        if (ellipse2.Opacity > 0 || ellipse3.Opacity < 1)
                        {
                            ellipse3.Opacity += p;
                            ellipse2.Opacity -= p;
                        }
                        else
                        {
                            index = 1;
                        }
                    }
                }
            }
        }
    }
}
