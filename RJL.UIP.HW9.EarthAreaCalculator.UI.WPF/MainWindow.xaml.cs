using RJL.UIP.HW9.EarthAreaCalculator.Core.DI;
using RJL.UIP.HW9.EarthAreaCalculator.Shared.Interfaces;
using RJL.UIP.HW9.EarthAreaCalculator.Shared.Models;
using RJL.UIP.HW9.EarthAreaCalculator.UI.WPF.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Point = RJL.UIP.HW9.EarthAreaCalculator.Shared.Models.Point;

namespace RJL.UIP.HW9.EarthAreaCalculator.UI.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppContainer.ConfigureContainer();
            AreaCalculator = AppContainer.Resolve<IAreaCalculator>();
            Logger = AppContainer.Resolve<ILogger>();
            FileStorage = AppContainer.Resolve<IFileStorage>();
        }
       
        public IAreaCalculator AreaCalculator { get; set; }

        public ILogger Logger { get; set; }

        private IFileStorage FileStorage;

        public void StartCalculation()
        {
            List<Point> points = GetPoints();
            ValidateAndCalculateArea(Logger, points);
        }

        public void ValidateAndCalculateArea(ILogger logger, List<Point> points)
        {
            double result = AreaCalculator.GetCalculationAreaResult(points);
            if (result > 0)
            {
                MessageBox.Show("Square of area is " + result);
            }
            else if (result==-1)
            {
                MessageBox.Show("Invalid value for points were inputed");
            }
            else if (result ==0)
            {
                MessageBox.Show("Calculating of area square is incorrect");
            }
        }

        private void ShowSquare_Click(object sender, RoutedEventArgs e)
        {
            Logger.Info($"[{this.GetType().Name}]: ShowSquare_Click");

            StartCalculation();
        }

        public List<Point> GetPoints()
        {
            var Points = new List<Point>();
            foreach (UIElement element in PointViewsContainer.Children)
            {
                if (element is PointInputView)
                {
                    Points.Add(((PointInputView)element).GetPoint());
                }
            }
            return Points;
        }

        private void AddPoint_Click(object sender, RoutedEventArgs e)
        {
            Logger.Info($"[{this.GetType().Name}]: AddPoint_Click");
            PointInputView pointInputView = new PointInputView();
            PointViewsContainer.Children.Add(pointInputView);
            pointInputView.DeletePointEvent += PointInputView_DeletePointEvent;
        }

        private void ShowLog_Click(object sender, RoutedEventArgs e)
        {
            Logger.Info($"[{this.GetType().Name}]: ShowLog_Click");
            List<LogRecord> logrecords = FileStorage.GetAllLogs();
            if (logrecords == null)
            {
                MessageBox.Show("Log file is empty");
                return;
            }
            foreach (var logrecord in logrecords)
            {
                LogData.ItemsSource = logrecords;
            }
        }

        private void PrintLine_Click(object sender, RoutedEventArgs e)
        {
            List<Point> points = GetPoints();
            PointsWindow win2 = new PointsWindow();
            win2.Show();
            for (int i = 0; i < points.Count(); i++)
            {
                if (i != points.Count()-1)
                {
                    var myLine = new Line();
                    myLine.Stroke = Brushes.Black;
                    myLine.StrokeThickness = 2;
                    myLine.X1 = points[i].X;
                    myLine.X2 = points[i + 1].X;
                    myLine.Y1 = points[i].Y;
                    myLine.Y2 = points[i+1].Y;
                    win2.PrintPointsContainer.Children.Add(myLine);
                }
                else {
                    var myLine = new Line();
                    myLine.Stroke = Brushes.Black;
                    myLine.StrokeThickness = 2;
                    myLine.X1 = points[i].X;
                    myLine.X2 = points[0].X;
                    myLine.Y1 = points[i].Y;
                    myLine.Y2 = points[0].Y;
                    win2.PrintPointsContainer.Children.Add(myLine);
                }
            }
        }

        private void PointInputView_DeletePointEvent(object sender, EventArgs e)
        {
            Logger.Info($"[{this.GetType().Name}]: PointInputView_DeletePointEvent");
            PointViewsContainer.Children.Remove((PointInputView)sender);
        }
    }
}
