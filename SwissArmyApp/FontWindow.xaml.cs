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
using System.Windows.Shapes;

namespace SwissArmyApp
{
    /// <summary>
    /// Interaction logic for FontWindow.xaml
    /// </summary>
    public partial class FontWindow : Window

    {
        TextBox box;

        public FontWindow(Notepad main)
        {
            InitializeComponent();
            box = main.textBox;
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)fontsCombo.Items[fontsCombo.SelectedIndex];
            box.FontSize = item.FontSize;
            this.Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
