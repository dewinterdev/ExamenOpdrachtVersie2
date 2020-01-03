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
    /// Interaction logic for EditPersonPage.xaml
    /// </summary>
    public partial class EditPersonPage : Page
    {
        private MainWindow mainWindow;
        private Person person;

        public EditPersonPage(MainWindow mainWindow, Person person)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.person = person;
            FirstNameTextBox.Text = person.FirstName;
            LastNameTextBox.Text = person.LastName;
            GenderComboBox.SelectedItem = person.Gender;
            BirthdateDatePicker.SelectedDate = person.BirthDate;
        }

        private void UpdateEditPersonBtnIsEnabled()
        {
            if (EditPersonBtn != null)
            {
                EditPersonBtn.IsEnabled =
                    FirstNameTextBox.Text.Trim() != string.Empty &&
                    LastNameTextBox.Text.Trim() != string.Empty &&
                    GenderComboBox.SelectedItem != null &&
                    BirthdateDatePicker.SelectedDate != null;
            }
        }

        private void FirstNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateEditPersonBtnIsEnabled();
        }

        private void LastNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateEditPersonBtnIsEnabled();
        }

        private void GenderComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateEditPersonBtnIsEnabled();
        }

        private void BirthdateDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateEditPersonBtnIsEnabled();
        }

        private void EditPersonBtn_Click(object sender, RoutedEventArgs e)
        {
            person.FirstName = FirstNameTextBox.Text.Trim();
            person.LastName = LastNameTextBox.Text.Trim();
            person.Gender = (Gender)GenderComboBox.SelectedItem;
            person.BirthDate = (DateTime)BirthdateDatePicker.SelectedDate;

            person.UpdateDB();
            mainWindow.Content = new ExistingPersonPage(mainWindow);
        }

        private void ReturnToMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Content = new MenuPage(mainWindow);
        }
    }
}