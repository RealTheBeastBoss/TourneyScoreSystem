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
        public static CollegeEvent[] collegeEvents = new CollegeEvent[] { event1, event2, event3, event4, event5 };
        public static Team team1 = new Team();
        public static Team team2 = new Team();
        public static Team team3 = new Team();
        public static Team team4 = new Team();
        public static Team[] allTeams = new Team[] { team1, team2, team3, team4 };
        public static int pageIndex = 0;
        public MainWindow() // Runs when loading
        {
            InitializeComponent();
            comboTeam.ItemsSource = new string[] { "Individual", "Team" }; // Provides the values for the combo box
            comboFirst.ItemsSource = new string[] { "Yes", "No" }; // Provides the values for the combo box
            comboSecond.ItemsSource = new string[] { "Yes", "No" }; // Provides the values for the combo box
            comboThird.ItemsSource = new string[] { "Yes", "No" }; // Provides the values for the combo box
            comboFourth.ItemsSource = new string[] { "Yes", "No" }; // Provides the values for the combo box
            comboFifth.ItemsSource = new string[] { "Yes", "No" }; // Provides the values for the combo box
            eventPrevBtn.Visibility = Visibility.Hidden; // Temporary
            eventErrorRect.Fill = Brushes.Transparent; // Temporary
            defineEventPage.Visibility = Visibility.Visible; // Temporary
            defineTeamsPage.Visibility = Visibility.Hidden; // Temporary
            teamsErrorRect.Fill = Brushes.Transparent; // Temporary
        }
        private void teamsEndBtnClicked(object sender, RoutedEventArgs e)
        {
            if (teamName.Text == "" || (comboFirst.Visibility == Visibility.Visible && comboFirst.Text == "") || (comboSecond.Visibility == Visibility.Visible && comboSecond.Text == "")
                || (comboThird.Visibility == Visibility.Visible && comboThird.Text == "") || (comboFourth.Visibility == Visibility.Visible && comboFourth.Text == "")
                || (comboFifth.Visibility == Visibility.Visible && comboFifth.Text == ""))
            {
                teamsErrorRect.Fill = Brushes.Red;
                return;
            }
            SaveTeamsData();
            pageIndex = 0;
            // Insert "Save to File" Code!
            defineTeamsPage.Visibility = Visibility.Hidden;
        }
        private void teamsNextBtnClicked(object sender, RoutedEventArgs e)
        {
            if (teamName.Text == "" || (comboFirst.Visibility == Visibility.Visible && comboFirst.Text == "") || (comboSecond.Visibility == Visibility.Visible && comboSecond.Text == "")
                || (comboThird.Visibility == Visibility.Visible && comboThird.Text == "") || (comboFourth.Visibility == Visibility.Visible && comboFourth.Text == "")
                || (comboFifth.Visibility == Visibility.Visible && comboFifth.Text == ""))
            {
                teamsErrorRect.Fill = Brushes.Red;
                return;
            }
            teamsErrorRect.Fill = Brushes.Transparent;
            SaveTeamsData();
            pageIndex++;
            LoadNextTeam();
        }
        private void teamsPrevBtnClicked(object sender, RoutedEventArgs e)
        {
            if (teamName.Text == "" || (comboFirst.Visibility == Visibility.Visible && comboFirst.Text == "") || (comboSecond.Visibility == Visibility.Visible && comboSecond.Text == "")
                || (comboThird.Visibility == Visibility.Visible && comboThird.Text == "") || (comboFourth.Visibility == Visibility.Visible && comboFourth.Text == "")
                || (comboFifth.Visibility == Visibility.Visible && comboFifth.Text == ""))
            {
                teamsErrorRect.Fill = Brushes.Red;
                return;
            }
            teamsErrorRect.Fill = Brushes.Transparent;
            SaveTeamsData();
            pageIndex--;
            LoadNextTeam();
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
            pageIndex = 0;
            if (eventTitle.Text == "" || comboTeam.Text == "")
            {
                eventErrorRect.Fill = Brushes.Red;
                return;
            }
            eventErrorRect.Fill = Brushes.Transparent;
            event5.eventTitle = eventTitle.Text;
            event5.isTeamEvent = comboTeam.Text == "Team";
            // Insert "Save to File" Code!
            int currRow = 4;
            if (event1.isTeamEvent)
            {
                Grid.SetRow(comboFirstBlock, currRow);
                comboFirstBlock.Visibility = Visibility.Visible;
                comboFirstBlock.Text = $"{event1.eventTitle}?: ";
                Grid.SetRow(comboFirst, currRow);
                comboFirst.Visibility = Visibility.Visible;
                currRow++;
            }
            if (event2.isTeamEvent)
            {
                Grid.SetRow(comboSecondBlock, currRow);
                comboSecondBlock.Visibility = Visibility.Visible;
                comboSecondBlock.Text = $"{event2.eventTitle}?: ";
                Grid.SetRow(comboSecond, currRow);
                comboSecond.Visibility = Visibility.Visible;
                currRow++;
            }
            if (event3.isTeamEvent)
            {
                Grid.SetRow(comboThirdBlock, currRow);
                comboThirdBlock.Visibility = Visibility.Visible;
                comboThirdBlock.Text = $"{event3.eventTitle}?: ";
                Grid.SetRow(comboThird, currRow);
                comboThird.Visibility = Visibility.Visible;
                currRow++;
            }
            if (event4.isTeamEvent)
            {
                Grid.SetRow(comboFourthBlock, currRow);
                comboFourthBlock.Visibility = Visibility.Visible;
                comboFourthBlock.Text = $"{event4.eventTitle}?: ";
                Grid.SetRow(comboFourth, currRow);
                comboFourth.Visibility = Visibility.Visible;
                currRow++;
            }
            if (event5.isTeamEvent)
            {
                Grid.SetRow(comboFifthBlock, currRow);
                comboFifthBlock.Visibility = Visibility.Visible;
                comboFifthBlock.Text = $"{event5.eventTitle}?: ";
                Grid.SetRow(comboFifth, currRow);
                comboFifth.Visibility = Visibility.Visible;
                currRow++;
            }
            Grid.SetRow(teamsPrevBtn, currRow);
            Grid.SetRow(teamsNextBtn, currRow);
            Grid.SetRow(teamsEndBtn, currRow);
            comboFirst.DataContext = event1;
            comboSecond.DataContext = event2;
            comboThird.DataContext = event3;
            comboFourth.DataContext = event4;
            comboFifth.DataContext = event5;
            teamsPrevBtn.Visibility = Visibility.Hidden;
            defineEventPage.Visibility = Visibility.Hidden;
            defineTeamsPage.Visibility = Visibility.Visible;
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
        public void SaveTeamsData()
        {
            foreach (CollegeEvent _event in collegeEvents)
            {
                _event.teams.Remove(allTeams[pageIndex]);
            }
            switch (pageIndex)
            {
                case 0:
                    team1.teamName = teamName.Text;
                    if (event1.isTeamEvent && comboFirst.Text == "Yes")
                    {
                        event1.teams.Add(team1);
                    }
                    if (event2.isTeamEvent && comboSecond.Text == "Yes")
                    {
                        event2.teams.Add(team1);
                    }
                    if (event3.isTeamEvent && comboThird.Text == "Yes")
                    {
                        event3.teams.Add(team1);
                    }
                    if (event4.isTeamEvent && comboFourth.Text == "Yes")
                    {
                        event4.teams.Add(team1);
                    }
                    if (event5.isTeamEvent && comboFifth.Text == "Yes")
                    {
                        event5.teams.Add(team1);
                    }
                    break;
                case 1:
                    team2.teamName = teamName.Text;
                    if (event1.isTeamEvent && comboFirst.Text == "Yes")
                    {
                        event1.teams.Add(team2);
                    }
                    if (event2.isTeamEvent && comboSecond.Text == "Yes")
                    {
                        event2.teams.Add(team2);
                    }
                    if (event3.isTeamEvent && comboThird.Text == "Yes")
                    {
                        event3.teams.Add(team2);
                    }
                    if (event4.isTeamEvent && comboFourth.Text == "Yes")
                    {
                        event4.teams.Add(team2);
                    }
                    if (event5.isTeamEvent && comboFifth.Text == "Yes")
                    {
                        event5.teams.Add(team2);
                    }
                    break;
                case 2:
                    team3.teamName = teamName.Text;
                    if (event1.isTeamEvent && comboFirst.Text == "Yes")
                    {
                        event1.teams.Add(team3);
                    }
                    if (event2.isTeamEvent && comboSecond.Text == "Yes")
                    {
                        event2.teams.Add(team3);
                    }
                    if (event3.isTeamEvent && comboThird.Text == "Yes")
                    {
                        event3.teams.Add(team3);
                    }
                    if (event4.isTeamEvent && comboFourth.Text == "Yes")
                    {
                        event4.teams.Add(team3);
                    }
                    if (event5.isTeamEvent && comboFifth.Text == "Yes")
                    {
                        event5.teams.Add(team3);
                    }
                    break;
                case 3:
                    team4.teamName = teamName.Text;
                    if (event1.isTeamEvent && comboFirst.Text == "Yes")
                    {
                        event1.teams.Add(team4);
                    }
                    if (event2.isTeamEvent && comboSecond.Text == "Yes")
                    {
                        event2.teams.Add(team4);
                    }
                    if (event3.isTeamEvent && comboThird.Text == "Yes")
                    {
                        event3.teams.Add(team4);
                    }
                    if (event4.isTeamEvent && comboFourth.Text == "Yes")
                    {
                        event4.teams.Add(team4);
                    }
                    if (event5.isTeamEvent && comboFifth.Text == "Yes")
                    {
                        event5.teams.Add(team4);
                    }
                    break;
            }
        }
        public void LoadNextTeam()
        {
            switch (pageIndex)
            {
                case 0:
                    teamsPrevBtn.Visibility = Visibility.Hidden;
                    teamName.Text = team1.teamName;
                    teamsHeading.Text = "1st Team";
                    foreach (UIElement element in defineTeamsPage.Children)
                    {
                        if (element is ComboBox)
                        {
                            ComboBox cb = (ComboBox)element;
                            CollegeEvent _event = (CollegeEvent)cb.DataContext;
                            if (_event.teams.Contains(team1)) { cb.Text = "Yes"; } else { cb.Text = "No"; };
                        }
                    }
                    break;
                case 1:
                    teamsPrevBtn.Visibility = Visibility.Visible;
                    teamName.Text = team2.teamName;
                    teamsHeading.Text = "2nd Team";
                    foreach (UIElement element in defineTeamsPage.Children)
                    {
                        if (element is ComboBox)
                        {
                            ComboBox cb = (ComboBox)element;
                            CollegeEvent _event = (CollegeEvent)cb.DataContext;
                            if (_event.teams.Contains(team2)) { cb.Text = "Yes"; } else { cb.Text = "No"; };
                        }
                    }
                    break;
                case 2:
                    teamsNextBtn.Visibility = Visibility.Visible;
                    teamName.Text = team3.teamName;
                    teamsHeading.Text = "3rd Team";
                    foreach (UIElement element in defineTeamsPage.Children)
                    {
                        if (element is ComboBox)
                        {
                            ComboBox cb = (ComboBox)element;
                            CollegeEvent _event = (CollegeEvent)cb.DataContext;
                            if (_event.teams.Contains(team3)) { cb.Text = "Yes"; } else { cb.Text = "No"; };
                        }
                    }
                    break;
                case 3:
                    teamsNextBtn.Visibility = Visibility.Hidden;
                    teamName.Text = team4.teamName;
                    teamsHeading.Text = "4th Team";
                    foreach (UIElement element in defineTeamsPage.Children)
                    {
                        if (element is ComboBox)
                        {
                            ComboBox cb = (ComboBox)element;
                            CollegeEvent _event = (CollegeEvent)cb.DataContext;
                            if (_event.teams.Contains(team4)) { cb.Text = "Yes"; } else { cb.Text = "No"; };
                        }
                    }
                    break;
            }
        }
    }
}
