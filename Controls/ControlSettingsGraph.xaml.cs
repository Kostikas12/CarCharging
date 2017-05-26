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
    /// Interaction logic for ControlSettingsGraph.xaml
    /// </summary>
    public partial class ControlSettingsGraph : UserControl
    {
        DispatcherTimer timer1;
        Rectangle rect;
        public ControlSettingsGraph()
        {
            InitializeComponent();
            timer1 = new DispatcherTimer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = new TimeSpan(0,0,0,0,40);

            GraphUnvisible();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BorderColorChange();
        }

        private void BorderColorChange()  
        {
            if (border1.Opacity != 1)
            {
                border1.Opacity += 0.01;
                grid1.Opacity += 0.01;
            }
            else
            {
                timer1.Stop();
            }
        }

        public void GraphUnvisible()
        {
            this.Visibility = System.Windows.Visibility.Hidden;
            timer1.Stop();
        }
        public void GraphVisible()
        {
            this.Visibility = System.Windows.Visibility.Visible;
            border1.Opacity = 0;
            grid1.Opacity = 0;
            timer1.Start();
        }

        public void MakeGraph()
        {
            // === Invalidate drawing

            Rectangle rectall = new Rectangle();
            rectall.StrokeThickness = 0;
            rectall.Margin = new Thickness(10, 10, 10, 10); // 300x 200y
            SolidColorBrush brush1 = new SolidColorBrush(Colors.Wheat);
            rectall.Fill = brush1;
            grid1.Children.Add(rectall);

            // === 
            
            Line linex = new Line(); 
            Line liney = new Line();  
            Line linex1 = new Line();
            Line linex2 = new Line();
            Line linex3 = new Line();

            linex.Stroke = Brushes.DarkBlue;
            liney.Stroke = Brushes.DarkBlue;
            linex1.Stroke = Brushes.DarkGreen;
            linex2.Stroke = Brushes.Black;
            linex3.Stroke = Brushes.Black;

            linex.StrokeThickness = 3;
            liney.StrokeThickness = 3;
            linex1.StrokeThickness = 2;
            linex2.StrokeThickness = 1;
            linex3.StrokeThickness = 1;

            linex.X1 = 80;
            linex.Y1 = 170;
            linex.X2 = 250;
            linex.Y2 = 170;

            liney.X1 = 82;
            liney.Y1 = 170;
            liney.X2 = 82;
            liney.Y2 = 25; 

            linex1.X1 = 80;
            linex1.Y1 = 170-35;
            linex1.X2 = 250;
            linex1.Y2 = 170-35;

            linex2.X1 = 80;
            linex2.Y1 = 170 - 35 * 2;
            linex2.X2 = 250;
            linex2.Y2 = 170 - 35 * 2;

            linex3.X1 = 80;
            linex3.Y1 = 170 - 35 * 3;
            linex3.X2 = 250;
            linex3.Y2 = 170 - 35 * 3;

            grid1.Children.Add(linex1);
            grid1.Children.Add(linex2);
            grid1.Children.Add(linex3);
            grid1.Children.Add(liney);

            Label lbval0 = new Label();
            lbval0.Content = "0";
            lbval0.Margin = new Thickness(65, 170, 0, 0);
            grid1.Children.Add(lbval0);

            Label lbval1 = new Label();
            lbval1.Content = "1";
            lbval1.Margin = new Thickness(65, 170-35-10, 0, 0);
            grid1.Children.Add(lbval1);

            Label lbval2 = new Label();
            lbval2.Content = "2";
            lbval2.Margin = new Thickness(65, 170-35*2-10, 0, 0);
            grid1.Children.Add(lbval2);

            Label lbval3 = new Label();
            lbval3.Content = "3";
            lbval3.Margin = new Thickness(65, 170-35*3-10, 0, 0);
            grid1.Children.Add(lbval3);

            double probability = new DriverInfo().DriverGet().ProbabilityGetSet;

            Label labelp = new Label();
            labelp.Content = string.Format("P = {0:0.00}", probability);
            labelp.Margin = new Thickness(130+8, 170 - 35 * probability-20, 100, 30);
            grid1.Children.Add(labelp);

            Label labelprobability = new Label();
            labelprobability.Content = "[Probability]";
            labelprobability.Margin = new Thickness(10, 15, 60, 35);
            grid1.Children.Add(labelprobability);

            //Rectangle rect = new Rectangle();
            rect = new Rectangle();
            rect.Stroke = Brushes.Orange;
            rect.StrokeThickness = 2;
            rect.Margin = new Thickness(130, 170 - 35 * probability, 100, 30);
            LinearGradientBrush brush = new LinearGradientBrush();
            brush.GradientStops.Add(new GradientStop(Colors.Blue, 0.3));
            brush.GradientStops.Add(new GradientStop(Colors.CornflowerBlue, 0.6));
            brush.GradientStops.Add(new GradientStop(Colors.DarkBlue, 0.9)); // rgb(246,210,13)
            rect.Fill = brush;
            grid1.Children.Add(rect);

            grid1.Children.Add(linex);
        }
    }
}
