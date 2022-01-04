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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SwissArmyApp
{
    /// <summary>
    /// Interaction logic for OlympicRingAnnihilator.xaml
    /// </summary>
    public partial class OlympicRingAnnihilator : Window
    {
        public OlympicRingAnnihilator()
        {
            InitializeComponent();
        }

        private void Annihilator_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation();
            a.From = 165;
            a.To = 1000;
            a.Duration = new Duration(TimeSpan.Parse("0:0:2"));
            Blue.BeginAnimation(Canvas.LeftProperty, a);

            DoubleAnimation b = new DoubleAnimation();
            b.From = 100;
            b.To = 1000;
            b.Duration = new Duration(TimeSpan.Parse("0:0:4"));
            Black.BeginAnimation(Canvas.TopProperty, b);

            DoubleAnimation c = new DoubleAnimation();
            c.From = 100;
            c.To = -1000;
            c.Duration = new Duration(TimeSpan.Parse("0:0:5"));
            Red.BeginAnimation(Canvas.TopProperty, c);

            DoubleAnimation d = new DoubleAnimation();
            d.From = 175;
            d.To = -1000;
            d.Duration = new Duration(TimeSpan.Parse("0:0:3"));
            Yellow.BeginAnimation(Canvas.TopProperty, d);

            DoubleAnimation f = new DoubleAnimation();
            f.From = 405;
            f.To = -1000;
            f.Duration = new Duration(TimeSpan.Parse("0:0:4"));
            Green.BeginAnimation(Canvas.LeftProperty, f);
        }
    }
}
