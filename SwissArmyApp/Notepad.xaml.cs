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
using System.IO;
using Microsoft.Win32;

namespace SwissArmyApp
{
    /// <summary>
    /// Interaction logic for Notepad.xaml
    /// </summary>
    public partial class Notepad : Window
    {
        public Notepad()
        {
            ///System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("sv-SE");
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


        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == true)
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            if ((pd.ShowDialog() == true))
            {
                RichTextBox richTB = new RichTextBox();
                richTB.Document.Blocks.Add(new Paragraph(new Run(textBox.Text)));

                pd.PrintDocument((((IDocumentPaginatorSource)richTB.Document).DocumentPaginator), "PDF");
            }
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            FontWindow p = new FontWindow(this);
            p.ShowDialog();

            {

            }

        }



    }
}