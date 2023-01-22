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
        public static Player player1 = new Player();
        public static Player player2 = new Player();
        public static Player player3 = new Player();
        public static Player player4 = new Player();
        public static Player player5 = new Player();
        public static Player player6 = new Player();
        public static Player player7 = new Player();
        public static Player player8 = new Player();
        public static Player player9 = new Player();
        public static Player player10 = new Player();
        public static Player player11 = new Player();
        public static Player player12 = new Player();
        public static Player player13 = new Player();
        public static Player player14 = new Player();
        public static Player player15 = new Player();
        public static Player player16 = new Player();
        public static Player player17 = new Player();
        public static Player player18 = new Player();
        public static Player player19 = new Player();
        public static Player player20 = new Player();
        public static Player[] allPlayers = new Player[] { player1, player2, player3, player4, player5, player6, player7, player8, player9, player10, player11, player12, player13, 
            player14, player15, player16, player17, player18, player19, player20 };
        public static ComboBox[] comboBoxes;
        public static TextBlock[] comboTexts;
        public static int pageIndex = 0;
        public MainWindow() // Runs when loading
        {
            InitializeComponent();
            comboBoxes = new ComboBox[] { combo1, combo2, combo3, combo4, combo5, combo6, combo7, combo8, combo9, combo10, combo11, combo12, combo13, combo14, combo15, combo16, combo17, combo18, combo19, combo20};
            comboTexts = new TextBlock[] { combo1B, combo2B, combo3B, combo4B, combo5B, combo6B, combo7B, combo8B, combo9B, combo10B, combo11B, combo12B, combo13B, combo14B, combo15B, combo16B, combo17B, combo18B, 
                combo19B, combo20B };
            comboTeam.ItemsSource = new string[] { "Individual", "Team" }; // Provides the values for the combo box
            comboFirst.ItemsSource = new string[] { "Yes", "No" }; // Provides the values for the combo box
            comboSecond.ItemsSource = new string[] { "Yes", "No" }; // Provides the values for the combo box
            comboThird.ItemsSource = new string[] { "Yes", "No" }; // Provides the values for the combo box
            comboFourth.ItemsSource = new string[] { "Yes", "No" }; // Provides the values for the combo box
            comboFifth.ItemsSource = new string[] { "Yes", "No" }; // Provides the values for the combo box
            comboFirstP.ItemsSource = new string[] { "Yes", "No" }; // Provides the values for the combo box
            comboSecondP.ItemsSource = new string[] { "Yes", "No" }; // Provides the values for the combo box
            comboThirdP.ItemsSource = new string[] { "Yes", "No" }; // Provides the values for the combo box
            comboFourthP.ItemsSource = new string[] { "Yes", "No" }; // Provides the values for the combo box
            comboFifthP.ItemsSource = new string[] { "Yes", "No" }; // Provides the values for the combo box
            eventPrevBtn.Visibility = Visibility.Hidden; // Temporary
            eventErrorRect.Fill = Brushes.Transparent; // Temporary
            defineEventPage.Visibility = Visibility.Visible; // Temporary
            defineTeamsPage.Visibility = Visibility.Hidden; // Temporary
            definePlayersPage.Visibility = Visibility.Hidden; // Temporary
            enterPlacementsPage.Visibility = Visibility.Hidden; // Temporary
            teamsErrorRect.Fill = Brushes.Transparent; // Temporary
        }
        private void playersEndBtnClicked(object sender, RoutedEventArgs e)
        {
            if (playerName.Text == "" || comboTeamP.Text == "" || (comboFirstP.Visibility == Visibility.Visible && comboFirstP.Text == "") || (comboSecondP.Visibility == Visibility.Visible
                && comboSecondP.Text == "") || (comboThirdP.Visibility == Visibility.Visible && comboThirdP.Text == "") || (comboFourthP.Visibility == Visibility.Visible && comboFourthP.Text == "")
                || (comboFifthP.Visibility == Visibility.Visible && comboFifthP.Text == ""))
            {
                // Insert Error Code!
                return;
            }
            foreach (Team team in allTeams)
            {
                if (comboTeamP.Text == team.teamName && team.players.Count == 5 && !team.players.Contains(allPlayers[pageIndex]))
                {
                    return;
                }
            }
            SavePlayerData();
            pageIndex = 0;
            // Insert "Save to File" Code!
            if (event1.isTeamEvent)
            {
                AddTeamPlacements();
            } else
            {
                AddIndividualPlacements();
            }
            definePlayersPage.Visibility = Visibility.Hidden;
            enterPlacementsPage.Visibility = Visibility.Visible;
        }
        private void playersPrevBtnClicked(object sender, RoutedEventArgs e)
        {
            if (playerName.Text == "" || comboTeamP.Text == "" || (comboFirstP.Visibility == Visibility.Visible && comboFirstP.Text == "") || (comboSecondP.Visibility == Visibility.Visible
                && comboSecondP.Text == "") || (comboThirdP.Visibility == Visibility.Visible && comboThirdP.Text == "") || (comboFourthP.Visibility == Visibility.Visible && comboFourthP.Text == "")
                || (comboFifthP.Visibility == Visibility.Visible && comboFifthP.Text == ""))
            {
                // Insert Error Code!
                return;
            }
            foreach (Team team in allTeams)
            {
                if (comboTeamP.Text == team.teamName && team.players.Count == 5 && !team.players.Contains(allPlayers[pageIndex]))
                {
                    return;
                }
            }
            SavePlayerData();
            pageIndex--;
            LoadNextPlayer();
        }
        private void playersNextBtnClicked(object sender, RoutedEventArgs e)
        {
            if (playerName.Text == "" || comboTeamP.Text == "" || (comboFirstP.Visibility == Visibility.Visible && comboFirstP.Text == "") || (comboSecondP.Visibility == Visibility.Visible 
                && comboSecondP.Text == "") || (comboThirdP.Visibility == Visibility.Visible && comboThirdP.Text == "") || (comboFourthP.Visibility == Visibility.Visible && comboFourthP.Text == "")
                || (comboFifthP.Visibility == Visibility.Visible && comboFifthP.Text == ""))
            {
                // Insert Error Code!
                return;
            }
            foreach (Team team in allTeams)
            {
                if (comboTeamP.Text == team.teamName && team.players.Count == 5 && !team.players.Contains(allPlayers[pageIndex]))
                {
                    return;
                }
            }
            SavePlayerData();
            pageIndex++;
            LoadNextPlayer();
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
            int currRow = 5;
            if (!event1.isTeamEvent)
            {
                Grid.SetRow(comboFirstBP, currRow);
                comboFirstBP.Visibility = Visibility.Visible;
                comboFirstBP.Text = $"{event1.eventTitle}?: ";
                Grid.SetRow(comboFirstP, currRow);
                comboFirstP.Visibility = Visibility.Visible;
                currRow++;
            }
            if (!event2.isTeamEvent)
            {
                Grid.SetRow(comboSecondBP, currRow);
                comboSecondBP.Visibility = Visibility.Visible;
                comboSecondBP.Text = $"{event2.eventTitle}?: ";
                Grid.SetRow(comboSecondP, currRow);
                comboSecondP.Visibility = Visibility.Visible;
                currRow++;
            }
            if (!event3.isTeamEvent)
            {
                Grid.SetRow(comboThirdBP, currRow);
                comboThirdBP.Visibility = Visibility.Visible;
                comboThirdBP.Text = $"{event3.eventTitle}?: ";
                Grid.SetRow(comboThirdP, currRow);
                comboThirdP.Visibility = Visibility.Visible;
                currRow++;
            }
            if (!event4.isTeamEvent)
            {
                Grid.SetRow(comboFourthBP, currRow);
                comboFourthBP.Visibility = Visibility.Visible;
                comboFourthBP.Text = $"{event4.eventTitle}?: ";
                Grid.SetRow(comboFourthP, currRow);
                comboFourthP.Visibility = Visibility.Visible;
                currRow++;
            }
            if (!event5.isTeamEvent)
            {
                Grid.SetRow(comboFifthBP, currRow);
                comboFifthBP.Visibility = Visibility.Visible;
                comboFifthBP.Text = $"{event5.eventTitle}?: ";
                Grid.SetRow(comboFifthP, currRow);
                comboFifthP.Visibility = Visibility.Visible;
                currRow++;
            }
            Grid.SetRow(playersPrevBtn, currRow);
            Grid.SetRow(playersNextBtn, currRow);
            Grid.SetRow(playersEndBtn, currRow);
            comboFirstP.DataContext = event1;
            comboSecondP.DataContext = event2;
            comboThirdP.DataContext = event3;
            comboFourthP.DataContext = event4;
            comboFifthP.DataContext = event5;
            playersPrevBtn.Visibility = Visibility.Hidden;
            comboTeamP.ItemsSource = new string[] { team1.teamName, team2.teamName, team3.teamName, team4.teamName };
            defineTeamsPage.Visibility = Visibility.Hidden;
            definePlayersPage.Visibility = Visibility.Visible;
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
                    foreach (UIElement element in defineTeamsPage.Children)
                    {
                        if (element is ComboBox)
                        {
                            ComboBox cb = (ComboBox)element;
                            CollegeEvent _event = (CollegeEvent)cb.DataContext;
                            if (cb.Text == "Yes") { _event.teams.Add(team1); }
                        }
                    }
                    break;
                case 1:
                    team2.teamName = teamName.Text;
                    foreach (UIElement element in defineTeamsPage.Children)
                    {
                        if (element is ComboBox)
                        {
                            ComboBox cb = (ComboBox)element;
                            CollegeEvent _event = (CollegeEvent)cb.DataContext;
                            if (cb.Text == "Yes") { _event.teams.Add(team2); }
                        }
                    }
                    break;
                case 2:
                    team3.teamName = teamName.Text;
                    foreach (UIElement element in defineTeamsPage.Children)
                    {
                        if (element is ComboBox)
                        {
                            ComboBox cb = (ComboBox)element;
                            CollegeEvent _event = (CollegeEvent)cb.DataContext;
                            if (cb.Text == "Yes") { _event.teams.Add(team3); }
                        }
                    }
                    break;
                case 3:
                    team4.teamName = teamName.Text;
                    foreach (UIElement element in defineTeamsPage.Children)
                    {
                        if (element is ComboBox)
                        {
                            ComboBox cb = (ComboBox)element;
                            CollegeEvent _event = (CollegeEvent)cb.DataContext;
                            if (cb.Text == "Yes") { _event.teams.Add(team4); }
                        }
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
        public void SavePlayerData()
        {
            foreach (Team team in allTeams)
            {
                team.players.Remove(allPlayers[pageIndex]);
            }
            allPlayers[pageIndex].name = playerName.Text;
            foreach (Team team in allTeams)
            {
                if (comboTeamP.Text == team.teamName)
                {
                    team.players.Add(allPlayers[pageIndex]);
                    break;
                }
            }
            foreach (UIElement element in definePlayersPage.Children)
            {
                if (element is ComboBox && element != comboTeamP)
                {
                    ComboBox cb = (ComboBox)element;
                    CollegeEvent _event = (CollegeEvent)cb.DataContext;
                    _event.players.Remove(allPlayers[pageIndex]);
                    if (cb.Text == "Yes") { _event.players.Add(allPlayers[pageIndex]); }
                }
            }
        }
        public void LoadNextPlayer()
        {
            switch(pageIndex)
            {
                case 0:
                    playersHeading.Text = "1st Participant";
                    playersPrevBtn.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    playersHeading.Text = "2nd Participant";
                    playersPrevBtn.Visibility = Visibility.Visible;
                    break;
                case 2:
                    playersHeading.Text = "3rd Participant";
                    break;
                case 18:
                    playersHeading.Text = "19th Participant";
                    playersNextBtn.Visibility = Visibility.Visible;
                    break;
                case 19:
                    playersHeading.Text = "20th Participant";
                    playersNextBtn.Visibility = Visibility.Hidden;
                    break;
                default:
                    playersHeading.Text = $"{pageIndex + 1}th Participant";
                    break;
            }
            playerName.Text = allPlayers[pageIndex].name;
            foreach (Team team in allTeams)
            {
                comboTeamP.Text = "";
                if (team.players.Contains(allPlayers[pageIndex]))
                {
                    comboTeamP.Text = team.teamName;
                    break;
                }
            }
            foreach (UIElement element in definePlayersPage.Children)
            {
                if (element is ComboBox && element != comboTeamP)
                {
                    ComboBox cb = (ComboBox)element;
                    CollegeEvent _event = (CollegeEvent)cb.DataContext;
                    if (_event.players.Contains(allPlayers[pageIndex])) { cb.Text = "Yes"; } else { cb.Text = "No"; }
                }
            }
        }
        public void AddIndividualPlacements()
        {
            for (int i = 0; i < event1.players.Count; i++)
            {
                comboTexts[i].Visibility = Visibility.Visible;
                comboBoxes[i].Visibility = Visibility.Visible;
            }
        }
        public void AddTeamPlacements()
        {
            combo6B.Text = "1st Place: ";
            combo9B.Text = "2nd Place: ";
            combo12B.Text = "3rd Place: ";
            combo15B.Text = "4th Place: ";
            switch(event1.teams.Count)
            {
                case 1:
                    combo6B.Visibility = Visibility.Visible;
                    combo6.Visibility = Visibility.Visible;
                    Grid.SetRow(stack1, 6);
                    Grid.SetRow(stack2, 6);
                    break;
                case 2:
                    combo6B.Visibility = Visibility.Visible;
                    combo6.Visibility = Visibility.Visible;
                    combo9B.Visibility = Visibility.Visible;
                    combo9.Visibility = Visibility.Visible;
                    Grid.SetRow(stack1, 7);
                    Grid.SetRow(stack2, 7);
                    break;
                case 3:
                    combo6B.Visibility = Visibility.Visible;
                    combo6.Visibility = Visibility.Visible;
                    combo9B.Visibility = Visibility.Visible;
                    combo9.Visibility = Visibility.Visible;
                    combo12B.Visibility = Visibility.Visible;
                    combo12.Visibility = Visibility.Visible;
                    Grid.SetRow(stack1, 8);
                    Grid.SetRow(stack2, 8);
                    break;
                case 4:
                    combo6B.Visibility = Visibility.Visible;
                    combo6.Visibility = Visibility.Visible;
                    combo9B.Visibility = Visibility.Visible;
                    combo9.Visibility = Visibility.Visible;
                    combo12B.Visibility = Visibility.Visible;
                    combo12.Visibility = Visibility.Visible;
                    combo15B.Visibility = Visibility.Visible;
                    combo15.Visibility = Visibility.Visible;
                    Grid.SetRow(stack1, 9);
                    Grid.SetRow(stack2, 9);
                    break;
            }
        }
    }
}
