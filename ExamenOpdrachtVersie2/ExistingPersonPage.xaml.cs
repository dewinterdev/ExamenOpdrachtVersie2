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
    /// Interaction logic for ExistingPersonPage.xaml
    /// </summary>
    public partial class ExistingPersonPage : Page
    {
        private MainWindow mainwindow;

        public ExistingPersonPage(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainwindow = mainWindow;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (PersonListBox != null)
            {
                List<Person> persons = Person.GetPersons();
                if (persons != null)
                {
                    PersonListBox.ItemsSource = persons;
                }
            }
        }

        private void UpdateSearchPersonBtnnIsEnabled()
        {
            FindPersonBtn.IsEnabled =
                FirstNameTextBox.Text.Trim() != string.Empty &&
                LastNameTextBox.Text.Trim() != string.Empty;
        }

        private void FirstNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateSearchPersonBtnnIsEnabled();
        }

        private void LastNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateSearchPersonBtnnIsEnabled();
        }

        private void FindPersonBtn_Click(object sender, RoutedEventArgs e)
        {
            List<Person> persons = Person.GetTheRightPerson(FirstNameTextBox.Text.Trim(), LastNameTextBox.Text.Trim());
            PersonListBox.ItemsSource = persons;
        }

        private void PersonListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (PersonListBox.SelectedItem != null)
            {
                Person person = (Person)PersonListBox.SelectedItem;
                mainwindow.Content = new EditPersonPage(mainwindow, person);
            }
        }
    }
}