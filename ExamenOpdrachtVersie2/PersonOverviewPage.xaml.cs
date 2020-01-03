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
    /// Interaction logic for PersonOverviewPage.xaml
    /// </summary>
    public partial class PersonOverviewPage : Page
    {
        private MainWindow mainwindow;

        public PersonOverviewPage(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainwindow = mainWindow;
        }

        private void newPersonBtn_Click(object sender, RoutedEventArgs e)
        {
            mainwindow.Content = new CreatePersonPage(mainwindow);
        }

        private void ExistingPersonBtn_Click(object sender, RoutedEventArgs e)
        {
            mainwindow.Content = new ExistingPersonPage(mainwindow);
        }
    }
}