using Microsoft.Win32;
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

namespace WPFandSQLstudy
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void openFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
        }

        private void saveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void timesNewRoman_Click(object sender, RoutedEventArgs e)
        {
            text.FontFamily = new FontFamily("Times New Roman");
            verdanaFont.IsChecked = false;
        }

        private void verdanaFont_Click(object sender, RoutedEventArgs e)
        {
            text.FontFamily = new FontFamily("Verdana");
            timesNewRomanFont.IsChecked = false;
        }

        private void changeFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontSize = changeFontSize.SelectedItem.ToString();
            fontSize = fontSize.Substring(fontSize.Length - 2);
            switch (fontSize)
            {
                case "10":
                    text.FontSize = 10;
                    break;
                case "14":
                    text.FontSize = 14;
                    break;
                case "16":
                    text.FontSize = 16;
                    break;
                case "20":
                    text.FontSize = 20;
                    break;
                case "24":
                    text.FontSize = 24;
                    break;
                case "32":
                    text.FontSize = 32;
                    break;
                case "48":
                    text.FontSize = 48;
                    break;



            }
        }
    }
}
