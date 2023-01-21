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

namespace TourneyScoreSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static CollegeEvent event1 = new CollegeEvent();
        public static CollegeEvent event2 = new CollegeEvent();
        public static CollegeEvent event3 = new CollegeEvent();
        public static CollegeEvent event4 = new CollegeEvent();
        public static CollegeEvent event5 = new CollegeEvent();
        public static int pageIndex = 0;
        public MainWindow() // Runs when loading
        {
            InitializeComponent();
            comboTeam.ItemsSource = new string[] { "Individual", "Team" }; // Provides the values for the combo box
            eventPrevBtn.Visibility = Visibility.Hidden; // Temporary
            eventErrorRect.Fill = Brushes.Transparent; // Temporary
        }
        private void eventNextBtnClicked(object sender, RoutedEventArgs e)
        {
            if (eventTitle.Text == "" || comboTeam.Text == "")
            {
                eventErrorRect.Fill = Brushes.Red;
                return;
            }
            eventErrorRect.Fill = Brushes.Transparent;
            SaveEventData();
            pageIndex++;
            LoadNextEvent();
        }
        private void eventPrevBtnClicked(object sender, RoutedEventArgs e)
        {
            if (eventTitle.Text == "" || comboTeam.Text == "")
            {
                eventErrorRect.Fill = Brushes.Red;
                return;
            }
            eventErrorRect.Fill = Brushes.Transparent;
            SaveEventData();
            pageIndex--;
            LoadNextEvent();
        }
        private void eventEndBtnClicked(object sender, RoutedEventArgs e)
        {
            if (eventTitle.Text == "" || comboTeam.Text == "")
            {
                eventErrorRect.Fill = Brushes.Red;
                return;
            }
            eventErrorRect.Fill = Brushes.Transparent;
            event5.eventTitle = eventTitle.Text;
            event5.isTeamEvent = comboTeam.Text == "Team";
            // Insert "Save to File" Code!
            defineEventPage.Visibility = Visibility.Hidden;
            // Insert "Open Teams Page" Code!
        }
        public void SaveEventData()
        {
            switch (pageIndex) // Saving Data to Variables
            {
                case 0: // First Event
                    event1.eventTitle = eventTitle.Text;
                    event1.isTeamEvent = comboTeam.Text == "Team";
                    break;
                case 1: // Second Event
                    event2.eventTitle = eventTitle.Text;
                    event2.isTeamEvent = comboTeam.Text == "Team";
                    break;
                case 2: // Third Event
                    event3.eventTitle = eventTitle.Text;
                    event3.isTeamEvent = comboTeam.Text == "Team";
                    break;
                case 3: // Fourth Event
                    event4.eventTitle = eventTitle.Text;
                    event4.isTeamEvent = comboTeam.Text == "Team";
                    break;
                case 4: // Fifth Event
                    event5.eventTitle = eventTitle.Text;
                    event5.isTeamEvent = comboTeam.Text == "Team";
                    break;
            }
        }
        public void LoadNextEvent()
        {
            switch (pageIndex) // Loading Next Event
            {
                case 0: // First Event
                    eventPrevBtn.Visibility = Visibility.Hidden;
                    eventHeading.Text = "1st Event";
                    eventTitle.Text = event1.eventTitle;
                    comboTeam.Text = event1.isTeamEvent ? "Team" : "Individual";
                    break;
                case 1: // Second Event
                    eventPrevBtn.Visibility = Visibility.Visible;
                    eventHeading.Text = "2nd Event";
                    eventTitle.Text = event2.eventTitle;
                    comboTeam.Text = event2.isTeamEvent ? "Team" : "Individual";
                    break;
                case 2: // Third Event
                    eventHeading.Text = "3rd Event";
                    eventTitle.Text = event3.eventTitle;
                    comboTeam.Text = event3.isTeamEvent ? "Team" : "Individual";
                    break;
                case 3: // Fourth Event
                    eventNextBtn.Visibility = Visibility.Visible;
                    eventHeading.Text = "4th Event";
                    eventTitle.Text = event4.eventTitle;
                    comboTeam.Text = event4.isTeamEvent ? "Team" : "Individual";
                    break;
                case 4: // Fifth Event
                    eventNextBtn.Visibility = Visibility.Hidden;
                    eventHeading.Text = "5th Event";
                    eventTitle.Text = event5.eventTitle;
                    comboTeam.Text = event5.isTeamEvent ? "Team" : "Individual";
                    break;
            }
        }
    }
}
