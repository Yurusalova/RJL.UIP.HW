using RJL.UIP.HW9.EarthAreaCalculator.BAL.Services;
using RJL.UIP.HW9.EarthAreaCalculator.Core.DI;
using RJL.UIP.HW9.EarthAreaCalculator.Shared.Interfaces;
using RJL.UIP.HW9.EarthAreaCalculator.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RJL.UIP.HW9.EarthAreaCalculator.UI.WPF.Controls
{
    /// <summary>
    /// Interaction logic for PointInputView.xaml
    /// </summary>
    public partial class PointInputView : UserControl
    {
        private bool IsInitialized = false;

        public event EventHandler DeletePointEvent;

        public ILogger Logger { get; set; }

        public PointInputView()
        {
            InitializeComponent();
            AppContainer.ConfigureContainer();
            IsInitialized = true;
            Logger = AppContainer.Resolve<ILogger>();
        }

        public Point GetPoint()
        {
            bool isXValid = Double.TryParse(PointX.Text, out double x);
            bool isYValid = Double.TryParse(PointY.Text, out double y);
            var result = isXValid && isYValid ? new Point(x, y) : new Point(0,0);
            return result;
        }

        protected void DeletePoint_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var handler = DeletePointEvent;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!IsInitialized) {
                return;
            }
            bool valXres = int.TryParse(PointX.Text, out int resultX);
            bool valYres = int.TryParse(PointY.Text, out int resultY);
            if (!valXres || !valYres) {
                ValidationBlock.Visibility = System.Windows.Visibility.Visible;
                ValidationBlock.Text = "input value is not valid";
                Logger.Warn($"[{this.GetType().Name}]: Invalid input for Point");
            } else
            {
               ValidationBlock.Visibility = System.Windows.Visibility.Collapsed;
               ValidationBlock.Text = "";
            }
        }
    }
}
