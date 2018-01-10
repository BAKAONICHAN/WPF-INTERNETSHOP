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

namespace MyProject
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private MainWindow mainWindow;
        public MainPage()
        {
            InitializeComponent();
        }
        public MainPage(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void Race_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Content = new Race();
        }

        private void Indi_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Content = new Indi();
        }

        private void Casual_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Content = new Casual();
        }

        private void Action_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Content = new Action();
        }

        private void Adventure_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Content = new Adventure();
        }

        private void Strategy_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Content = new Strategy();
        }

        private void Role_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Content = new Role();
        }

        private void Simulator_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Content = new Simulator();
        }

        private void Sport_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Content = new Sportive();
        }

        private void MMO_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Content = new MMO();
        }
    }
}
