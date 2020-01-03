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

namespace ExamenOpdrachtVersie2
{
    /// <summary>
    /// Interaction logic for MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        private MainWindow mainwindow;

        public MenuPage(MainWindow mainwindow)
        {
            InitializeComponent();
            this.mainwindow = mainwindow;
        }

        private void PersonBtn_Click(object sender, RoutedEventArgs e)
        {
            mainwindow.Content = new PersonOverviewPage(mainwindow);
        }
    }
}