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

namespace SwissArmyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = Properties.Resources.File;
            Title = Properties.Resources.Open;
            Title = Properties.Resources.Save;
            Title = Properties.Resources.Print;
            Title = Properties.Resources.Exit;
            Title = Properties.Resources.Edit;
            Title = Properties.Resources.Cut;
            Title = Properties.Resources.Copy;
            Title = Properties.Resources.Paste;
            Title = Properties.Resources.Format;
            Title = Properties.Resources.Font;
            Title = Properties.Resources.Font_Size;
            Title = Properties.Resources.OK;
            Title = Properties.Resources.Cancel;
            Title = Properties.Resources.Notepad;
            Title = Properties.Resources.AppName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Calculator calc = new Calculator();
            calc.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Notepad note = new Notepad();
            note.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OlympicRingAnnihilator delet = new OlympicRingAnnihilator();
            delet.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Browser net = new Browser();
            net.Show();
        }
    }
}
