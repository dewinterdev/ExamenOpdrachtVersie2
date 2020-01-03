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
    /// Interaction logic for CreatePersonPage.xaml
    /// </summary>
    public partial class CreatePersonPage : Page
    {
        private MainWindow mainWindow;

        public CreatePersonPage(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GenderComboBox.ItemsSource = Enum.GetValues(typeof(Gender));
            GenderComboBox.SelectedItem = Gender.Male;
        }

        private void CreatePersonBtn_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person(FirstNameTextBox.Text.Trim(), LastNameTextBox.Text.Trim(), (Gender)GenderComboBox.SelectedItem, BirthdateDatePicker.SelectedDate.Value);
            if (person.InsertPerson())
            {
                mainWindow.Content = new PersonOverviewPage(mainWindow);
            }
            else
            {
                MessageBox.Show("Sorry there was a database error, please try again and make sure everything is filled in.");
            }
        }

        private void UpdateCreatePersonBtnIsEnabled()
        {
            CreatePersonBtn.IsEnabled =
                FirstNameTextBox.Text.Trim() != string.Empty &&
                LastNameTextBox.Text.Trim() != string.Empty &&
                GenderComboBox.SelectedItem != null &&
                BirthdateDatePicker.SelectedDate != null;
        }

        private void FirstNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateCreatePersonBtnIsEnabled();
        }

        private void LastNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateCreatePersonBtnIsEnabled();
        }

        private void GenderComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateCreatePersonBtnIsEnabled();
        }

        private void BirthdateDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateCreatePersonBtnIsEnabled();
        }
    }
}