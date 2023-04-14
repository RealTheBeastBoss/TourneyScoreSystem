using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TourneyScoreSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static CollegeEvent event1 = new CollegeEvent(0);
        public static CollegeEvent event2 = new CollegeEvent(1);
        public static CollegeEvent event3 = new CollegeEvent(2);
        public static CollegeEvent event4 = new CollegeEvent(3);
        public static CollegeEvent event5 = new CollegeEvent(4);
        public static CollegeEvent[] collegeEvents = new CollegeEvent[] { event1, event2, event3, event4, event5 };
        public static Team team1 = new Team(0);
        public static Team team2 = new Team(1);
        public static Team team3 = new Team(2);
        public static Team team4 = new Team(3);
        public static Team[] allTeams = new Team[] { team1, team2, team3, team4 };
        public static Player player1 = new Player(0);
        public static Player player2 = new Player(1);
        public static Player player3 = new Player(2);
        public static Player player4 = new Player(3);
        public static Player player5 = new Player(4);
        public static Player player6 = new Player(5);
        public static Player player7 = new Player(6);
        public static Player player8 = new Player(7);
        public static Player player9 = new Player(8);
        public static Player player10 = new Player(9);
        public static Player player11 = new Player(10);
        public static Player player12 = new Player(11);
        public static Player player13 = new Player(12);
        public static Player player14 = new Player(13);
        public static Player player15 = new Player(14);
        public static Player player16 = new Player(15);
        public static Player player17 = new Player(16);
        public static Player player18 = new Player(17);
        public static Player player19 = new Player(18);
        public static Player player20 = new Player(19);
        public static Player[] allPlayers = new Player[] { player1, player2, player3, player4, player5, player6, player7, player8, player9, player10, player11, player12, player13, 
            player14, player15, player16, player17, player18, player19, player20 };
        public static ComboBox[] comboBoxes;
        public static TextBlock[] comboTexts;
        public static ComboBox[] teamBoxes;
        public static string[] displayGridTexts;
        public static Grid[] displayGrids;
        public static Grid[] displayEventGrids;
        public static Grid[] displayTeamGrids;
        public static TextBlock[] teamRankings;
        public static TextBlock[] teamRankingTexts;
        public static TextBlock[] playerRankings;
        public static TextBlock[] playerRankingTexts;
        public static TextBlock[] event1Rankings;
        public static TextBlock[] event1RankingTexts;
        public static TextBlock[] event2Rankings;
        public static TextBlock[] event2RankingTexts;
        public static TextBlock[] event3Rankings;
        public static TextBlock[] event3RankingTexts;
        public static TextBlock[] event4Rankings;
        public static TextBlock[] event4RankingTexts;
        public static TextBlock[] event5Rankings;
        public static TextBlock[] event5RankingTexts;
        public static TextBlock[] teamARankings;
        public static TextBlock[] teamARankingTexts;
        public static TextBlock[] teamBRankings;
        public static TextBlock[] teamBRankingTexts;
        public static TextBlock[] teamCRankings;
        public static TextBlock[] teamCRankingTexts;
        public static TextBlock[] teamDRankings;
        public static TextBlock[] teamDRankingTexts;
        public static Dictionary<int, int> rankPoints = new Dictionary<int, int>
        {
            { 1, 100 },
            { 2, 95 },
            { 3, 90 },
            { 4, 85 },
            { 5, 80 },
            { 6, 75 },
            { 7, 70 },
            { 8, 65 },
            { 9, 60 },
            { 10, 55 },
            { 11, 50 },
            { 12, 45 },
            { 13, 40 },
            { 14, 35 },
            { 15, 30 },
            { 16, 25 },
            { 17, 20 },
            { 18, 15 },
            { 19, 10 },
            { 20, 5 }
        };
        public static int pageIndex = 0;
        public MainWindow() // Runs when loading
        {
            InitializeComponent();
            comboBoxes = new ComboBox[] { combo1, combo2, combo3, combo4, combo5, combo6, combo7, combo8, combo9, combo10, combo11, combo12, combo13, combo14, combo15, combo16, combo17, 
                combo18, combo19, combo20};
            comboTexts = new TextBlock[] { combo1B, combo2B, combo3B, combo4B, combo5B, combo6B, combo7B, combo8B, combo9B, combo10B, combo11B, combo12B, combo13B, combo14B, combo15B, 
                combo16B, combo17B, combo18B, combo19B, combo20B };
            teamBoxes = new ComboBox[] { combo6, combo9, combo12, combo15 };
            displayGrids = new Grid[] { displayTeamRanking, displayParticipantRanking, displayEvent1Ranking, displayEvent2Ranking, displayEvent3Ranking, displayEvent4Ranking, displayEvent5Ranking, 
                displayTeamARanking, displayTeamBRanking, displayTeamCRanking, displayTeamDRanking };
            teamRankings = new TextBlock[] { team1stPlacement, team2ndPlacement, team3rdPlacement, team4thPlacement };
            teamRankingTexts = new TextBlock[] { team1stPlacementT, team2ndPlacementT, team3rdPlacementT, team4thPlacementT };
            playerRankings = new TextBlock[] { player1stPlacement, player2ndPlacement, player3rdPlacement, player4thPlacement, player5thPlacement, player6thPlacement, player7thPlacement,
                player8thPlacement, player9thPlacement, player10thPlacement, player11thPlacement, player12thPlacement, player13thPlacement, player14thPlacement, player15thPlacement, 
                player16thPlacement, player17thPlacement, player18thPlacement, player19thPlacement, player20thPlacement };
            playerRankingTexts = new TextBlock[] { player1stPlacementT, player2ndPlacementT, player3rdPlacementT, player4thPlacementT, player5thPlacementT, player6thPlacementT, 
                player7thPlacementT, player8thPlacementT, player9thPlacementT, player10thPlacementT, player11thPlacementT, player12thPlacementT, player13thPlacementT, player14thPlacementT, 
                player15thPlacementT, player16thPlacementT, player17thPlacementT, player18thPlacementT, player19thPlacementT, player20thPlacementT };
            event1Rankings = new TextBlock[] { event1_1stPlacement, event1_2ndPlacement, event1_3rdPlacement, event1_4thPlacement, event1_5thPlacement, event1_6thPlacement, event1_7thPlacement,
                event1_8thPlacement, event1_9thPlacement, event1_10thPlacement, event1_11thPlacement, event1_12thPlacement, event1_13thPlacement, event1_14thPlacement, event1_15thPlacement,
                event1_16thPlacement, event1_17thPlacement, event1_18thPlacement, event1_19thPlacement, event1_20thPlacement };
            event1RankingTexts = new TextBlock[] { event1_1stPlacementT, event1_2ndPlacementT, event1_3rdPlacementT, event1_4thPlacementT, event1_5thPlacementT, event1_6thPlacementT,
                event1_7thPlacementT, event1_8thPlacementT, event1_9thPlacementT, event1_10thPlacementT, event1_11thPlacementT, event1_12thPlacementT, event1_13thPlacementT, event1_14thPlacementT,
                event1_15thPlacementT, event1_16thPlacementT, event1_17thPlacementT, event1_18thPlacementT, event1_19thPlacementT, event1_20thPlacementT };
            event2Rankings = new TextBlock[] { event2_1stPlacement, event2_2ndPlacement, event2_3rdPlacement, event2_4thPlacement, event2_5thPlacement, event2_6thPlacement, event2_7thPlacement,
                event2_8thPlacement, event2_9thPlacement, event2_10thPlacement, event2_11thPlacement, event2_12thPlacement, event2_13thPlacement, event2_14thPlacement, event2_15thPlacement,
                event2_16thPlacement, event2_17thPlacement, event2_18thPlacement, event2_19thPlacement, event2_20thPlacement };
            event2RankingTexts = new TextBlock[] { event2_1stPlacementT, event2_2ndPlacementT, event2_3rdPlacementT, event2_4thPlacementT, event2_5thPlacementT, event2_6thPlacementT,
                event2_7thPlacementT, event2_8thPlacementT, event2_9thPlacementT, event2_10thPlacementT, event2_11thPlacementT, event2_12thPlacementT, event2_13thPlacementT, event2_14thPlacementT,
                event2_15thPlacementT, event2_16thPlacementT, event2_17thPlacementT, event2_18thPlacementT, event2_19thPlacementT, event2_20thPlacementT };
            event3Rankings = new TextBlock[] { event3_1stPlacement, event3_2ndPlacement, event3_3rdPlacement, event3_4thPlacement, event3_5thPlacement, event3_6thPlacement, event3_7thPlacement,
                event3_8thPlacement, event3_9thPlacement, event3_10thPlacement, event3_11thPlacement, event3_12thPlacement, event3_13thPlacement, event3_14thPlacement, event3_15thPlacement,
                event3_16thPlacement, event3_17thPlacement, event3_18thPlacement, event3_19thPlacement, event3_20thPlacement };
            event3RankingTexts = new TextBlock[] { event3_1stPlacementT, event3_2ndPlacementT, event3_3rdPlacementT, event3_4thPlacementT, event3_5thPlacementT, event3_6thPlacementT,
                event3_7thPlacementT, event3_8thPlacementT, event3_9thPlacementT, event3_10thPlacementT, event3_11thPlacementT, event3_12thPlacementT, event3_13thPlacementT, event3_14thPlacementT,
                event3_15thPlacementT, event3_16thPlacementT, event3_17thPlacementT, event3_18thPlacementT, event3_19thPlacementT, event3_20thPlacementT };
            event4Rankings = new TextBlock[] { event4_1stPlacement, event4_2ndPlacement, event4_3rdPlacement, event4_4thPlacement, event4_5thPlacement, event4_6thPlacement, event4_7thPlacement,
                event4_8thPlacement, event4_9thPlacement, event4_10thPlacement, event4_11thPlacement, event4_12thPlacement, event4_13thPlacement, event4_14thPlacement, event4_15thPlacement,
                event4_16thPlacement, event4_17thPlacement, event4_18thPlacement, event4_19thPlacement, event4_20thPlacement };
            event4RankingTexts = new TextBlock[] { event4_1stPlacementT, event4_2ndPlacementT, event4_3rdPlacementT, event4_4thPlacementT, event4_5thPlacementT, event4_6thPlacementT,
                event4_7thPlacementT, event4_8thPlacementT, event4_9thPlacementT, event4_10thPlacementT, event4_11thPlacementT, event4_12thPlacementT, event4_13thPlacementT, event4_14thPlacementT,
                event4_15thPlacementT, event4_16thPlacementT, event4_17thPlacementT, event4_18thPlacementT, event4_19thPlacementT, event4_20thPlacementT };
            event5Rankings = new TextBlock[] { event5_1stPlacement, event5_2ndPlacement, event5_3rdPlacement, event5_4thPlacement, event5_5thPlacement, event5_6thPlacement, event5_7thPlacement,
                event5_8thPlacement, event5_9thPlacement, event5_10thPlacement, event5_11thPlacement, event5_12thPlacement, event5_13thPlacement, event5_14thPlacement, event5_15thPlacement,
                event5_16thPlacement, event5_17thPlacement, event5_18thPlacement, event5_19thPlacement, event5_20thPlacement };
            event5RankingTexts = new TextBlock[] { event5_1stPlacementT, event5_2ndPlacementT, event5_3rdPlacementT, event5_4thPlacementT, event5_5thPlacementT, event5_6thPlacementT,
                event5_7thPlacementT, event5_8thPlacementT, event5_9thPlacementT, event5_10thPlacementT, event5_11thPlacementT, event5_12thPlacementT, event5_13thPlacementT, event5_14thPlacementT,
                event5_15thPlacementT, event5_16thPlacementT, event5_17thPlacementT, event5_18thPlacementT, event5_19thPlacementT, event5_20thPlacementT };
            teamARankings = new TextBlock[] { teamA1stPlacement, teamA2ndPlacement, teamA3rdPlacement, teamA4thPlacement, teamA5thPlacement };
            teamARankingTexts = new TextBlock[] { teamA1stPlacementT, teamA2ndPlacementT, teamA3rdPlacementT, teamA4thPlacementT, teamA5thPlacementT };
            teamBRankings = new TextBlock[] { teamB1stPlacement, teamB2ndPlacement, teamB3rdPlacement, teamB4thPlacement, teamB5thPlacement };
            teamBRankingTexts = new TextBlock[] { teamB1stPlacementT, teamB2ndPlacementT, teamB3rdPlacementT, teamB4thPlacementT, teamB5thPlacementT };
            teamCRankings = new TextBlock[] { teamC1stPlacement, teamC2ndPlacement, teamC3rdPlacement, teamC4thPlacement, teamC5thPlacement };
            teamCRankingTexts = new TextBlock[] { teamC1stPlacementT, teamC2ndPlacementT, teamC3rdPlacementT, teamC4thPlacementT, teamC5thPlacementT };
            teamDRankings = new TextBlock[] { teamD1stPlacement, teamD2ndPlacement, teamD3rdPlacement, teamD4thPlacement, teamD5thPlacement };
            teamDRankingTexts = new TextBlock[] { teamD1stPlacementT, teamD2ndPlacementT, teamD3rdPlacementT, teamD4thPlacementT, teamD5thPlacementT };
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
        }
        private void displayBoxChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            Grid currGrid;
            foreach (Grid _grid in displayGrids)
            {
                _grid.Visibility = Visibility.Hidden;
                if (_grid.DataContext.ToString() == (string)cb.SelectedItem)
                {
                    _grid.Visibility = Visibility.Visible;
                    currGrid = _grid;
                }
            }
        }
        private void placementsEndBtnClicked(object sender, RoutedEventArgs e)
        {
            foreach (ComboBox cb in comboBoxes)
            {
                if (cb.Visibility == Visibility.Visible && cb.Text == "")
                {
                    placementErrorRect.Fill = Brushes.Red;
                    placementErrorText.Text = "You Must Enter Values for all Fields to Continue";
                    return;
                }
            }
            List<string> names = new List<string>();
            foreach (ComboBox cb in comboBoxes)
            {
                if (cb.Visibility == Visibility.Visible)
                {
                    string _name = "";
                    if (collegeEvents[pageIndex].isTeamEvent)
                    {
                        Team _team = (Team)cb.SelectedItem;
                        _name = _team.name;
                    }
                    else
                    {
                        Player _player = (Player)cb.SelectedItem;
                        _name = _player.name;
                    }
                    names.Add(_name);
                }
            }
            List<string> text = names.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key).ToList();
            if (text.Count != 0)
            {
                placementErrorRect.Fill = Brushes.Red;
                placementErrorText.Text = "You Cannot Have Duplicate Placements";
                return;
            }
            placementErrorRect.Fill = Brushes.Transparent;
            SavePlacementData();
            CalculatePoints();
            // Insert "Save to File" Code!
            enterPlacementsPage.Visibility = Visibility.Hidden;
            displayModeGrid.Visibility = Visibility.Visible;
        }
        private void placementsPrevBtnClicked(object sender, RoutedEventArgs e)
        {
            foreach (ComboBox cb in comboBoxes)
            {
                if (cb.Visibility == Visibility.Visible && cb.Text == "")
                {
                    placementErrorRect.Fill = Brushes.Red;
                    placementErrorText.Text = "You Must Enter Values for all Fields to Continue";
                    return;
                }
            }
            List<string> names = new List<string>();
            foreach (ComboBox cb in comboBoxes)
            {
                if (cb.Visibility == Visibility.Visible)
                {
                    string _name = "";
                    if (collegeEvents[pageIndex].isTeamEvent)
                    {
                        Team _team = (Team)cb.SelectedItem;
                        _name = _team.name;
                    }
                    else
                    {
                        Player _player = (Player)cb.SelectedItem;
                        _name = _player.name;
                    }
                    names.Add(_name);
                }
            }
            List<string> text = names.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key).ToList();
            if (text.Count != 0)
            {
                placementErrorRect.Fill = Brushes.Red;
                placementErrorText.Text = "You Cannot Have Duplicate Placements";
                return;
            }
            placementErrorRect.Fill = Brushes.Transparent;
            SavePlacementData();
            pageIndex--;
            LoadNextPlacement();
        }
        private void placementsNextBtnClicked(object sender, RoutedEventArgs e)
        {
            foreach (ComboBox cb in comboBoxes)
            {
                if (cb.Visibility == Visibility.Visible && cb.Text == "")
                {
                    placementErrorRect.Fill = Brushes.Red;
                    placementErrorText.Text = "You Must Enter Values for all Fields to Continue";
                    return;
                }
            }
            List<string> names = new List<string>();
            foreach (ComboBox cb in comboBoxes)
            {
                if (cb.Visibility == Visibility.Visible)
                {
                    string _name = "";
                    if (collegeEvents[pageIndex].isTeamEvent)
                    {
                        Team _team = (Team)cb.SelectedItem;
                        _name = _team.name;
                    } else
                    {
                        Player _player = (Player)cb.SelectedItem;
                        _name = _player.name;
                    }
                    names.Add(_name);
                }
            }
            List<string> text = names.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key).ToList();
            if (text.Count != 0)
            {
                placementErrorRect.Fill = Brushes.Red;
                placementErrorText.Text = "You Cannot Have Duplicate Placements";
                return;
            }
            placementErrorRect.Fill = Brushes.Transparent;
            SavePlacementData();
            pageIndex++;
            LoadNextPlacement();
        }
        private void playersEndBtnClicked(object sender, RoutedEventArgs e)
        {
            if (playerName.Text == "" || comboTeamP.Text == "" || (comboFirstP.Visibility == Visibility.Visible && comboFirstP.Text == "") || (comboSecondP.Visibility == Visibility.Visible
                && comboSecondP.Text == "") || (comboThirdP.Visibility == Visibility.Visible && comboThirdP.Text == "") || (comboFourthP.Visibility == Visibility.Visible && comboFourthP.Text == "")
                || (comboFifthP.Visibility == Visibility.Visible && comboFifthP.Text == ""))
            {
                playerErrorRect.Fill = Brushes.Red;
                playerErrorText.Text = "You Must Enter Values for all Fields to Continue";
                return;
            }
            foreach (Player _player in allPlayers)
            {
                if (playerName.Text == _player.name && _player.ID != pageIndex)
                {
                    playerErrorRect.Fill = Brushes.Red;
                    playerErrorText.Text = "You Cannot Have Duplicate Participant IDs";
                    return;
                }
            }
            Team _team = (Team)comboTeamP.SelectedItem;
            if (_team.players.Count == 5 && !_team.players.Contains(allPlayers[pageIndex]))
            {
                playerErrorRect.Fill = Brushes.Red;
                playerErrorText.Text = "This Team Is Full";
                return;
            }
            playerErrorRect.Fill = Brushes.Transparent;
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
            LoadNextPlacement();
            definePlayersPage.Visibility = Visibility.Hidden;
            enterPlacementsPage.Visibility = Visibility.Visible;
        }
        private void playersPrevBtnClicked(object sender, RoutedEventArgs e)
        {
            if (playerName.Text == "" || comboTeamP.Text == "" || (comboFirstP.Visibility == Visibility.Visible && comboFirstP.Text == "") || (comboSecondP.Visibility == Visibility.Visible
                && comboSecondP.Text == "") || (comboThirdP.Visibility == Visibility.Visible && comboThirdP.Text == "") || (comboFourthP.Visibility == Visibility.Visible && comboFourthP.Text == "")
                || (comboFifthP.Visibility == Visibility.Visible && comboFifthP.Text == ""))
            {
                playerErrorRect.Fill = Brushes.Red;
                playerErrorText.Text = "You Must Enter Values for all Fields to Continue";
                return;
            }
            foreach (Player _player in allPlayers)
            {
                if (playerName.Text == _player.name && _player.ID != pageIndex)
                {
                    playerErrorRect.Fill = Brushes.Red;
                    playerErrorText.Text = "You Cannot Have Duplicate Participant IDs";
                    return;
                }
            }
            Team _team = (Team)comboTeamP.SelectedItem;
            if (_team.players.Count == 5 && !_team.players.Contains(allPlayers[pageIndex]))
            {
                playerErrorRect.Fill = Brushes.Red;
                playerErrorText.Text = "This Team Is Full";
                return;
            }
            playerErrorRect.Fill = Brushes.Transparent;
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
                playerErrorRect.Fill = Brushes.Red;
                playerErrorText.Text = "You Must Enter Values for all Fields to Continue";
                return;
            }
            foreach (Player _player in allPlayers)
            {
                if (playerName.Text == _player.name && _player.ID != pageIndex)
                {
                    playerErrorRect.Fill = Brushes.Red;
                    playerErrorText.Text = "You Cannot Have Duplicate Participant IDs";
                    return;
                }
            }
            Team _team = (Team)comboTeamP.SelectedItem;
            if (_team.players.Count == 5 && !_team.players.Contains(allPlayers[pageIndex]))
            {
                playerErrorRect.Fill = Brushes.Red;
                playerErrorText.Text = "This Team Is Full";
                return;
            }
            playerErrorRect.Fill = Brushes.Transparent;
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
                teamsErrorText.Text = "You Must Enter Values for all Fields to Continue";
                return;
            }
            foreach (Team _team in allTeams)
            {
                if (teamName.Text == _team.name && _team.ID != pageIndex)
                {
                    teamsErrorRect.Fill = Brushes.Red;
                    teamsErrorText.Text = "You Cannot Have Duplicate Team Names";
                    return;
                }
            }
            teamsErrorRect.Fill = Brushes.Transparent;
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
            comboTeamP.ItemsSource = allTeams;
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
                teamsErrorText.Text = "You Must Enter Values for all Fields to Continue";
                return;
            }
            foreach (Team _team in allTeams)
            {
                if (teamName.Text == _team.name && _team.ID != pageIndex)
                {
                    teamsErrorRect.Fill = Brushes.Red;
                    teamsErrorText.Text = "You Cannot Have Duplicate Team Names";
                    return;
                }
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
                teamsErrorText.Text = "You Must Enter Values for all Fields to Continue";
                return;
            }
            foreach (Team _team in allTeams)
            {
                if (teamName.Text == _team.name && _team.ID != pageIndex)
                {
                    teamsErrorRect.Fill = Brushes.Red;
                    teamsErrorText.Text = "You Cannot Have Duplicate Team Names";
                    return;
                }
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
                eventErrorText.Text = "You Must Enter Values for all Fields to Continue";
                return;
            }
            foreach (CollegeEvent _event in collegeEvents)
            {
                if (eventTitle.Text == _event.eventTitle && _event.ID != pageIndex)
                {
                    eventErrorRect.Fill = Brushes.Red;
                    eventErrorText.Text = "You Cannot Have Duplicate Event Titles";
                    return;
                }
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
                eventErrorText.Text = "You Must Enter Values for all Fields to Continue";
                return;
            }
            foreach (CollegeEvent _event in collegeEvents)
            {
                if (eventTitle.Text == _event.eventTitle && _event.ID != pageIndex)
                {
                    eventErrorRect.Fill = Brushes.Red;
                    eventErrorText.Text = "You Cannot Have Duplicate Event Titles";
                    return;
                }
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
                eventErrorText.Text = "You Must Enter Values for all Fields to Continue";
                return;
            }
            foreach (CollegeEvent _event in collegeEvents)
            {
                if (eventTitle.Text == _event.eventTitle && _event.ID != pageIndex)
                {
                    eventErrorRect.Fill = Brushes.Red;
                    eventErrorText.Text = "You Cannot Have Duplicate Event Titles";
                    return;
                }
            }
            eventErrorRect.Fill = Brushes.Transparent;
            event5.eventTitle = eventTitle.Text;
            event5.isTeamEvent = comboTeam.Text == "Team";
            // Insert "Save to File" Code!
            int currRow = 4;
            pageIndex = 0;
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
            collegeEvents[pageIndex].eventTitle = eventTitle.Text;
            collegeEvents[pageIndex].isTeamEvent = comboTeam.Text == "Team";
        }
        public void LoadNextEvent()
        {
            eventTitle.Text = collegeEvents[pageIndex].eventTitle;
            comboTeam.Text = collegeEvents[pageIndex].isTeamEvent ? "Team" : "Individual";
            switch (pageIndex) // Loading Next Event
            {
                case 0: // First Event
                    eventPrevBtn.Visibility = Visibility.Hidden;
                    eventHeading.Text = "1st Event";
                    break;
                case 1: // Second Event
                    eventPrevBtn.Visibility = Visibility.Visible;
                    eventHeading.Text = "2nd Event";
                    break;
                case 2: // Third Event
                    eventHeading.Text = "3rd Event";
                    break;
                case 3: // Fourth Event
                    eventNextBtn.Visibility = Visibility.Visible;
                    eventHeading.Text = "4th Event";
                    break;
                case 4: // Fifth Event
                    eventNextBtn.Visibility = Visibility.Hidden;
                    eventHeading.Text = "5th Event";
                    break;
            }
        }
        public void SaveTeamsData()
        {
            foreach (CollegeEvent _event in collegeEvents)
            {
                _event.teams.Remove(allTeams[pageIndex]);
            }
            allTeams[pageIndex].name = teamName.Text;
            foreach (UIElement element in defineTeamsPage.Children)
            {
                if (element is ComboBox)
                {
                    ComboBox cb = (ComboBox)element;
                    CollegeEvent _event = (CollegeEvent)cb.DataContext;
                    if (cb.Text == "Yes") { _event.teams.Add(allTeams[pageIndex]); }
                }
            }
        }
        public void LoadNextTeam()
        {
            teamName.Text = allTeams[pageIndex].name;
            foreach (UIElement element in defineTeamsPage.Children)
            {
                if (element is ComboBox)
                {
                    ComboBox cb = (ComboBox)element;
                    CollegeEvent _event = (CollegeEvent)cb.DataContext;
                    if (_event.teams.Contains(allTeams[pageIndex])) { cb.Text = "Yes"; } else { cb.Text = "No"; }
                }
            }
            switch (pageIndex)
            {
                case 0:
                    teamsPrevBtn.Visibility = Visibility.Hidden;
                    teamName.Text = team1.name;
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
                    teamName.Text = team2.name;
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
                    teamName.Text = team3.name;
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
                    teamName.Text = team4.name;
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
            Team _team = (Team)comboTeamP.SelectedItem;
            _team.players.Add(allPlayers[pageIndex]);
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
                    comboTeamP.SelectedItem = team;
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
            for (int i = 0; i < comboBoxes.Length; i++)
            {
                comboBoxes[i].Visibility = Visibility.Hidden;
                comboTexts[i].Visibility = Visibility.Hidden;
            }
            combo6B.Text = "6th Place: ";
            combo9B.Text = "9th Place: ";
            combo12B.Text = "12th Place: ";
            combo15B.Text = "15th Place: ";
            for (int i = 0; i < collegeEvents[pageIndex].players.Count; i++)
            {
                comboTexts[i].Visibility = Visibility.Visible;
                comboBoxes[i].Visibility = Visibility.Visible;
            }
            foreach (ComboBox cb in comboBoxes)
            {
                cb.ItemsSource = collegeEvents[pageIndex].players;
            }
            Grid.SetRow(stack1, 11);
            Grid.SetRow(stack2, 11);
        }
        public void AddTeamPlacements()
        {
            for (int i = 0; i < comboBoxes.Length; i++)
            {
                comboBoxes[i].Visibility = Visibility.Hidden;
                comboTexts[i].Visibility = Visibility.Hidden;
            }
            combo6B.Text = "1st Place: ";
            combo9B.Text = "2nd Place: ";
            combo12B.Text = "3rd Place: ";
            combo15B.Text = "4th Place: ";
            switch(collegeEvents[pageIndex].teams.Count)
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
            foreach (ComboBox cb in comboBoxes)
            {
                cb.ItemsSource = collegeEvents[pageIndex].teams;
            }
        }
        public void SavePlacementData()
        {
            if (collegeEvents[pageIndex].isTeamEvent)
            {
                collegeEvents[pageIndex].teamRanking.Clear();
                foreach (var (cb, i) in teamBoxes.Select((value, i) => (value, i)))
                {
                    if (cb.Visibility == Visibility.Visible)
                    {
                        collegeEvents[pageIndex].teamRanking.Add(i + 1, (Team)cb.SelectedItem);
                    }
                }
            }
            else
            {
                collegeEvents[pageIndex].playerRanking.Clear();
                foreach (var (cb, i) in comboBoxes.Select((value, i) => (value, i)))
                {
                    if (cb.Visibility == Visibility.Visible)
                    {
                        collegeEvents[pageIndex].playerRanking.Add(i + 1, (Player)cb.SelectedItem);
                    }
                }
            }
        }
        public void LoadNextPlacement()
        {
            placementsHeading.Text = collegeEvents[pageIndex].eventTitle;
            switch (pageIndex)
            {
                case 0:
                    placementPrevBtn.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    placementPrevBtn.Visibility = Visibility.Visible;
                    break;
                case 3:
                    placementNextBtn.Visibility = Visibility.Visible;
                    break;
                case 4:
                    placementNextBtn.Visibility = Visibility.Hidden;
                    break;
            }
            if (collegeEvents[pageIndex].isTeamEvent)
            {
                AddTeamPlacements();
                if (collegeEvents[pageIndex].teamRanking.Count == 0)
                {
                    foreach (ComboBox cb in teamBoxes)
                    {
                        cb.Text = "";
                    }
                }
                for (int i = 0; i < collegeEvents[pageIndex].teamRanking.Count; i++)
                {
                    teamBoxes[i].SelectedItem = collegeEvents[pageIndex].teamRanking[i + 1];
                }
            }
            else
            {
                AddIndividualPlacements();
                if (collegeEvents[pageIndex].playerRanking.Count == 0)
                {
                    foreach (ComboBox cb in comboBoxes)
                    {
                        cb.Text = "";
                    }
                }
                for (int i = 0; i < collegeEvents[pageIndex].playerRanking.Count; i++)
                {
                    comboBoxes[i].SelectedItem = collegeEvents[pageIndex].playerRanking[i + 1];
                }
            }
        }
        public void CalculatePoints()
        {
            List<(Team, int)> teamOrder = new List<(Team, int)>();
            List<(Player, int)> playerOrder = new List<(Player, int)>();
            foreach (CollegeEvent _event in collegeEvents)
            {
                if (_event.isTeamEvent)
                {
                    List<(Team, int)> teamPoints = new List<(Team, int)>();
                    for (int i = 0; i < _event.teamRanking.Count; i++)
                    {
                        _event.teamRanking[i + 1].teamPoints += rankPoints[i + 1];
                        teamPoints.Add((_event.teamRanking[i + 1], rankPoints[i + 1]));
                    }
                    int _nextRank = 1;
                    IOrderedEnumerable<IGrouping<int, (Team, int)>> orderedGroupedItems = teamPoints.GroupBy(item => item.Item2).OrderByDescending(group => group.Key);
                    foreach (IGrouping<int, (Team, int)> _group in orderedGroupedItems)
                    {
                        List<(Team, int)> _groupList = _group.ToList();
                        foreach ((Team, int) _team in _groupList)
                        {
                            _event.teamOrderPoints.Add((_team.Item1, _nextRank, _team.Item2));
                        }
                        _nextRank += _groupList.Count;
                    }
                } else
                {
                    List<(Player, int)> playerPoints = new List<(Player, int)>();
                    for (int i = 0; i < _event.playerRanking.Count; i++)
                    {
                        _event.playerRanking[i + 1].points += rankPoints[i + 1];
                        playerPoints.Add((_event.playerRanking[i + 1], rankPoints[i + 1]));
                    }
                    int _nextRank = 1;
                    IOrderedEnumerable<IGrouping<int, (Player, int)>> orderedGroupedItems = playerPoints.GroupBy(item => item.Item2).OrderByDescending(group => group.Key);
                    foreach (IGrouping<int, (Player, int)> _group in orderedGroupedItems)
                    {
                        List<(Player, int)> _groupList = _group.ToList();
                        foreach ((Player, int) _player in _groupList)
                        {
                            _event.playerOrderPoints.Add((_player.Item1, _nextRank, _player.Item2));
                        }
                        _nextRank += _groupList.Count;
                    }
                }
            }
            int nextRank;
            for (int i = 0; i < 4; i++)
            {
                nextRank = 1;
                IOrderedEnumerable<IGrouping<int, Player>> _orderedGroupedPlayers = allTeams[i].players.GroupBy(item => item.points).OrderByDescending(group => group.Key);
                foreach (IGrouping<int, Player> _group in _orderedGroupedPlayers)
                {
                    List<Player> groupList = _group.ToList();
                    foreach(Player _player in groupList)
                    {
                        _player.points += allTeams[i].teamPoints / 5;
                        allTeams[i].playerOrder.Add((_player, nextRank));
                    }
                    nextRank += groupList.Count;
                }
            }
            nextRank = 1;
            IOrderedEnumerable<IGrouping<int, Team>> orderedGroupedTeams = allTeams.GroupBy(item => item.teamPoints).OrderByDescending(group => group.Key);
            foreach (IGrouping<int, Team> _group in orderedGroupedTeams)
            {
                List<Team> groupList = _group.ToList();
                foreach (Team team in groupList)
                {
                    teamOrder.Add((team, nextRank));
                }
                nextRank += groupList.Count;
            }
            nextRank = 1;
            IOrderedEnumerable<IGrouping<int, Player>> orderedGroupedPlayers = allPlayers.GroupBy(item => item.points).OrderByDescending(group => group.Key);
            foreach (IGrouping<int, Player> _group in orderedGroupedPlayers)
            {
                List<Player> groupList = _group.ToList();
                foreach (Player player in groupList)
                {
                    playerOrder.Add((player, nextRank));
                }
                nextRank += groupList.Count;
            }
            // Generate Team Ranking Values:
            for (int i = 0; i < 4; i++)
            {
                switch(teamOrder[i].Item2)
                {
                    case 1:
                        teamRankingTexts[i].Text = "1st Place: ";
                        break;
                    case 2:
                        teamRankingTexts[i].Text = "2nd Place: ";
                        break;
                    case 3:
                        teamRankingTexts[i].Text = "3rd Place: ";
                        break;
                    case 4:
                        teamRankingTexts[i].Text = "4th Place: ";
                        break;
                }
                teamRankings[i].Text = $"{teamOrder[i].Item1.name}, {teamOrder[i].Item1.teamPoints}pts";
            }
            // Generate Individual Ranking Values:
            for (int i = 0; i < 20; i++)
            {
                switch(playerOrder[i].Item2)
                {
                    case 1:
                        playerRankingTexts[i].Text = "1st: ";
                        break;
                    case 2:
                        playerRankingTexts[i].Text = "2nd: ";
                        break;
                    case 3:
                        playerRankingTexts[i].Text = "3rd: ";
                        break;
                    default:
                        playerRankingTexts[i].Text = $"{playerOrder[i].Item2}th: ";
                        break;
                }
                playerRankings[i].Text = $"{playerOrder[i].Item1.name}, {playerOrder[i].Item1.points}pts";
            }
            // Generate Event 1 Ranking Values:
            displayEvent1Ranking.DataContext = $"{event1.eventTitle} Ranking";
            event1Heading.Text = (string)displayEvent1Ranking.DataContext;
            if (event1.isTeamEvent)
            {
                TextBlock[] rankings = new TextBlock[] { event1_8thPlacement, event1_11thPlacement, event1_14thPlacement, event1_17thPlacement };
                TextBlock[] rankingTexts = new TextBlock[] { event1_8thPlacementT, event1_11thPlacementT, event1_14thPlacementT, event1_17thPlacementT };
                // Change Grid Layout:
                Thickness left = event1Border1.Margin;
                left.Right = 220;
                Thickness right = event1Border2.Margin;
                right.Left = 220;
                event1Border1.SetValue(Grid.ColumnSpanProperty, 4);
                event1Border1.Margin = left;
                event1Border2.SetValue(Grid.ColumnSpanProperty, 4);
                event1Border2.SetValue(Grid.ColumnProperty, 4);
                event1Border2.Margin = right;
                event1Border3.SetValue(Grid.ColumnSpanProperty, 4);
                event1Border3.Margin = left;
                event1Border4.SetValue(Grid.ColumnSpanProperty, 4);
                event1Border4.Margin = right;
                event1Border4.SetValue(Grid.ColumnProperty, 4);
                foreach (ColumnDefinition column in displayEvent1Ranking.ColumnDefinitions)
                {
                    column.Width = new GridLength(1, GridUnitType.Star);
                }
                for (int i = 0; i < event1.teamOrderPoints.Count; i++)
                {
                    rankings[i].FontSize = 30;
                    rankingTexts[i].FontSize = 30;
                    rankings[i].SetValue(Grid.ColumnSpanProperty, 4);
                    rankings[i].Visibility = Visibility.Visible;
                    rankingTexts[i].Visibility = Visibility.Visible;
                    switch(event1.teamOrderPoints[i].Item2)
                    {
                        case 1:
                            rankingTexts[i].Text = "1st Place: ";
                            break;
                        case 2:
                            rankingTexts[i].Text = "2nd Place: ";
                            break;
                        case 3:
                            rankingTexts[i].Text = "3rd Place: ";
                            break;
                        case 4:
                            rankingTexts[i].Text = "4th Place: ";
                            break;
                    }
                    rankings[i].Text = $"{event1.teamOrderPoints[i].Item1.name}, {event1.teamOrderPoints[i].Item3}pts";
                }
            } else
            {
                for (int i = 0; i < event1.playerOrderPoints.Count; i++)
                {
                    event1Rankings[i].Visibility = Visibility.Visible;
                    event1RankingTexts[i].Visibility = Visibility.Visible;
                    switch (event1.playerOrderPoints[i].Item2)
                    {
                        case 1:
                            event1RankingTexts[i].Text = "1st: ";
                            break;
                        case 2:
                            event1RankingTexts[i].Text = "2nd: ";
                            break;
                        case 3:
                            event1RankingTexts[i].Text = "3rd: ";
                            break;
                        default:
                            event1RankingTexts[i].Text = $"{event1.playerOrderPoints[i].Item2}th: ";
                            break;
                    }
                    event1Rankings[i].Text = $"{event1.playerOrderPoints[i].Item1.name}, {event1.playerOrderPoints[i].Item3}pts";
                }
            }
            // Generate Event 2 Ranking Values:
            displayEvent2Ranking.DataContext = $"{event2.eventTitle} Ranking";
            event2Heading.Text = (string)displayEvent2Ranking.DataContext;
            if (event2.isTeamEvent)
            {
                TextBlock[] rankings = new TextBlock[] { event2_8thPlacement, event2_11thPlacement, event2_14thPlacement, event2_17thPlacement };
                TextBlock[] rankingTexts = new TextBlock[] { event2_8thPlacementT, event2_11thPlacementT, event2_14thPlacementT, event2_17thPlacementT };
                // Change Grid Layout:
                Thickness left = event2Border1.Margin;
                left.Right = 220;
                Thickness right = event2Border2.Margin;
                right.Left = 220;
                event2Border1.SetValue(Grid.ColumnSpanProperty, 4);
                event2Border1.Margin = left;
                event2Border2.SetValue(Grid.ColumnSpanProperty, 4);
                event2Border2.SetValue(Grid.ColumnProperty, 4);
                event2Border2.Margin = right;
                event2Border3.SetValue(Grid.ColumnSpanProperty, 4);
                event2Border3.Margin = left;
                event2Border4.SetValue(Grid.ColumnSpanProperty, 4);
                event2Border4.Margin = right;
                event2Border4.SetValue(Grid.ColumnProperty, 4);
                foreach (ColumnDefinition column in displayEvent2Ranking.ColumnDefinitions)
                {
                    column.Width = new GridLength(1, GridUnitType.Star);
                }
                for (int i = 0; i < event2.teamOrderPoints.Count; i++)
                {
                    rankings[i].FontSize = 30;
                    rankingTexts[i].FontSize = 30;
                    rankings[i].SetValue(Grid.ColumnSpanProperty, 4);
                    rankings[i].Visibility = Visibility.Visible;
                    rankingTexts[i].Visibility = Visibility.Visible;
                    switch (event2.teamOrderPoints[i].Item2)
                    {
                        case 1:
                            rankingTexts[i].Text = "1st Place: ";
                            break;
                        case 2:
                            rankingTexts[i].Text = "2nd Place: ";
                            break;
                        case 3:
                            rankingTexts[i].Text = "3rd Place: ";
                            break;
                        case 4:
                            rankingTexts[i].Text = "4th Place: ";
                            break;
                    }
                    rankings[i].Text = $"{event2.teamOrderPoints[i].Item1.name}, {event2.teamOrderPoints[i].Item3}pts";
                }
            }
            else
            {
                for (int i = 0; i < event2.playerOrderPoints.Count; i++)
                {
                    event2Rankings[i].Visibility = Visibility.Visible;
                    event2RankingTexts[i].Visibility = Visibility.Visible;
                    switch (event2.playerOrderPoints[i].Item2)
                    {
                        case 1:
                            event2RankingTexts[i].Text = "1st: ";
                            break;
                        case 2:
                            event2RankingTexts[i].Text = "2nd: ";
                            break;
                        case 3:
                            event2RankingTexts[i].Text = "3rd: ";
                            break;
                        default:
                            event2RankingTexts[i].Text = $"{event2.playerOrderPoints[i].Item2}th: ";
                            break;
                    }
                    event2Rankings[i].Text = $"{event2.playerOrderPoints[i].Item1.name}, {event2.playerOrderPoints[i].Item3}pts";
                }
            }
            // Generate Event 3 Ranking Values:
            displayEvent3Ranking.DataContext = $"{event3.eventTitle} Ranking";
            event3Heading.Text = (string)displayEvent3Ranking.DataContext;
            if (event3.isTeamEvent)
            {
                TextBlock[] rankings = new TextBlock[] { event3_8thPlacement, event3_11thPlacement, event3_14thPlacement, event3_17thPlacement };
                TextBlock[] rankingTexts = new TextBlock[] { event3_8thPlacementT, event3_11thPlacementT, event3_14thPlacementT, event3_17thPlacementT };
                // Change Grid Layout:
                Thickness left = event3Border1.Margin;
                left.Right = 220;
                Thickness right = event3Border2.Margin;
                right.Left = 220;
                event3Border1.SetValue(Grid.ColumnSpanProperty, 4);
                event3Border1.Margin = left;
                event3Border2.SetValue(Grid.ColumnSpanProperty, 4);
                event3Border2.SetValue(Grid.ColumnProperty, 4);
                event3Border2.Margin = right;
                event3Border3.SetValue(Grid.ColumnSpanProperty, 4);
                event3Border3.Margin = left;
                event3Border4.SetValue(Grid.ColumnSpanProperty, 4);
                event3Border4.Margin = right;
                event3Border4.SetValue(Grid.ColumnProperty, 4);
                foreach (ColumnDefinition column in displayEvent3Ranking.ColumnDefinitions)
                {
                    column.Width = new GridLength(1, GridUnitType.Star);
                }
                for (int i = 0; i < event3.teamOrderPoints.Count; i++)
                {
                    rankings[i].FontSize = 30;
                    rankingTexts[i].FontSize = 30;
                    rankings[i].SetValue(Grid.ColumnSpanProperty, 4);
                    rankings[i].Visibility = Visibility.Visible;
                    rankingTexts[i].Visibility = Visibility.Visible;
                    switch (event3.teamOrderPoints[i].Item2)
                    {
                        case 1:
                            rankingTexts[i].Text = "1st Place: ";
                            break;
                        case 2:
                            rankingTexts[i].Text = "2nd Place: ";
                            break;
                        case 3:
                            rankingTexts[i].Text = "3rd Place: ";
                            break;
                        case 4:
                            rankingTexts[i].Text = "4th Place: ";
                            break;
                    }
                    rankings[i].Text = $"{event3.teamOrderPoints[i].Item1.name}, {event3.teamOrderPoints[i].Item3}pts";
                }
            }
            else
            {
                for (int i = 0; i < event3.playerOrderPoints.Count; i++)
                {
                    event3Rankings[i].Visibility = Visibility.Visible;
                    event3RankingTexts[i].Visibility = Visibility.Visible;
                    switch (event3.playerOrderPoints[i].Item2)
                    {
                        case 1:
                            event3RankingTexts[i].Text = "1st: ";
                            break;
                        case 2:
                            event3RankingTexts[i].Text = "2nd: ";
                            break;
                        case 3:
                            event3RankingTexts[i].Text = "3rd: ";
                            break;
                        default:
                            event3RankingTexts[i].Text = $"{event3.playerOrderPoints[i].Item2}th: ";
                            break;
                    }
                    event3Rankings[i].Text = $"{event3.playerOrderPoints[i].Item1.name}, {event3.playerOrderPoints[i].Item3}pts";
                }
            }
            // Generate Event 4 Ranking Values:
            displayEvent4Ranking.DataContext = $"{event4.eventTitle} Ranking";
            event4Heading.Text = (string)displayEvent4Ranking.DataContext;
            if (event4.isTeamEvent)
            {
                TextBlock[] rankings = new TextBlock[] { event4_8thPlacement, event4_11thPlacement, event4_14thPlacement, event4_17thPlacement };
                TextBlock[] rankingTexts = new TextBlock[] { event4_8thPlacementT, event4_11thPlacementT, event4_14thPlacementT, event4_17thPlacementT };
                // Change Grid Layout:
                Thickness left = event4Border1.Margin;
                left.Right = 220;
                Thickness right = event4Border2.Margin;
                right.Left = 220;
                event4Border1.SetValue(Grid.ColumnSpanProperty, 4);
                event4Border1.Margin = left;
                event4Border2.SetValue(Grid.ColumnSpanProperty, 4);
                event4Border2.SetValue(Grid.ColumnProperty, 4);
                event4Border2.Margin = right;
                event4Border3.SetValue(Grid.ColumnSpanProperty, 4);
                event4Border3.Margin = left;
                event4Border4.SetValue(Grid.ColumnSpanProperty, 4);
                event4Border4.Margin = right;
                event4Border4.SetValue(Grid.ColumnProperty, 4);
                foreach (ColumnDefinition column in displayEvent4Ranking.ColumnDefinitions)
                {
                    column.Width = new GridLength(1, GridUnitType.Star);
                }
                for (int i = 0; i < event4.teamOrderPoints.Count; i++)
                {
                    rankings[i].FontSize = 30;
                    rankingTexts[i].FontSize = 30;
                    rankings[i].SetValue(Grid.ColumnSpanProperty, 4);
                    rankings[i].Visibility = Visibility.Visible;
                    rankingTexts[i].Visibility = Visibility.Visible;
                    switch (event4.teamOrderPoints[i].Item2)
                    {
                        case 1:
                            rankingTexts[i].Text = "1st Place: ";
                            break;
                        case 2:
                            rankingTexts[i].Text = "2nd Place: ";
                            break;
                        case 3:
                            rankingTexts[i].Text = "3rd Place: ";
                            break;
                        case 4:
                            rankingTexts[i].Text = "4th Place: ";
                            break;
                    }
                    rankings[i].Text = $"{event4.teamOrderPoints[i].Item1.name}, {event4.teamOrderPoints[i].Item3}pts";
                }
            }
            else
            {
                for (int i = 0; i < event4.playerOrderPoints.Count; i++)
                {
                    event4Rankings[i].Visibility = Visibility.Visible;
                    event4RankingTexts[i].Visibility = Visibility.Visible;
                    switch (event4.playerOrderPoints[i].Item2)
                    {
                        case 1:
                            event4RankingTexts[i].Text = "1st: ";
                            break;
                        case 2:
                            event4RankingTexts[i].Text = "2nd: ";
                            break;
                        case 3:
                            event4RankingTexts[i].Text = "3rd: ";
                            break;
                        default:
                            event4RankingTexts[i].Text = $"{event4.playerOrderPoints[i].Item2}th: ";
                            break;
                    }
                    event4Rankings[i].Text = $"{event4.playerOrderPoints[i].Item1.name}, {event4.playerOrderPoints[i].Item3}pts";
                }
            }
            // Generate Event 5 Ranking Values:
            displayEvent5Ranking.DataContext = $"{event5.eventTitle} Ranking";
            event5Heading.Text = (string)displayEvent5Ranking.DataContext;
            if (event5.isTeamEvent)
            {
                TextBlock[] rankings = new TextBlock[] { event5_8thPlacement, event5_11thPlacement, event5_14thPlacement, event5_17thPlacement };
                TextBlock[] rankingTexts = new TextBlock[] { event5_8thPlacementT, event5_11thPlacementT, event5_14thPlacementT, event5_17thPlacementT };
                // Change Grid Layout:
                Thickness left = event5Border1.Margin;
                left.Right = 220;
                Thickness right = event5Border2.Margin;
                right.Left = 220;
                event5Border1.SetValue(Grid.ColumnSpanProperty, 4);
                event5Border1.Margin = left;
                event5Border2.SetValue(Grid.ColumnSpanProperty, 4);
                event5Border2.SetValue(Grid.ColumnProperty, 4);
                event5Border2.Margin = right;
                event5Border3.SetValue(Grid.ColumnSpanProperty, 4);
                event5Border3.Margin = left;
                event5Border4.SetValue(Grid.ColumnSpanProperty, 4);
                event5Border4.Margin = right;
                event5Border4.SetValue(Grid.ColumnProperty, 4);
                foreach (ColumnDefinition column in displayEvent5Ranking.ColumnDefinitions)
                {
                    column.Width = new GridLength(1, GridUnitType.Star);
                }
                for (int i = 0; i < event5.teamOrderPoints.Count; i++)
                {
                    rankings[i].FontSize = 30;
                    rankingTexts[i].FontSize = 30;
                    rankings[i].SetValue(Grid.ColumnSpanProperty, 4);
                    rankings[i].Visibility = Visibility.Visible;
                    rankingTexts[i].Visibility = Visibility.Visible;
                    switch (event5.teamOrderPoints[i].Item2)
                    {
                        case 1:
                            rankingTexts[i].Text = "1st Place: ";
                            break;
                        case 2:
                            rankingTexts[i].Text = "2nd Place: ";
                            break;
                        case 3:
                            rankingTexts[i].Text = "3rd Place: ";
                            break;
                        case 4:
                            rankingTexts[i].Text = "4th Place: ";
                            break;
                    }
                    rankings[i].Text = $"{event5.teamOrderPoints[i].Item1.name}, {event5.teamOrderPoints[i].Item3}pts";
                }
            }
            else
            {
                for (int i = 0; i < event5.playerOrderPoints.Count; i++)
                {
                    event5Rankings[i].Visibility = Visibility.Visible;
                    event5RankingTexts[i].Visibility = Visibility.Visible;
                    switch (event5.playerOrderPoints[i].Item2)
                    {
                        case 1:
                            event5RankingTexts[i].Text = "1st: ";
                            break;
                        case 2:
                            event5RankingTexts[i].Text = "2nd: ";
                            break;
                        case 3:
                            event5RankingTexts[i].Text = "3rd: ";
                            break;
                        default:
                            event5RankingTexts[i].Text = $"{event5.playerOrderPoints[i].Item2}th: ";
                            break;
                    }
                    event5Rankings[i].Text = $"{event5.playerOrderPoints[i].Item1.name}, {event5.playerOrderPoints[i].Item3}pts";
                }
            }
            // Generate Team A Ranking Values:
            displayTeamARanking.DataContext = $"{team1.name} Ranking";
            teamAHeading.Text = (string)displayTeamARanking.DataContext;
            for (int i = 0; i < 5; i++)
            {
                switch(team1.playerOrder[i].Item2)
                {
                    case 1:
                        teamARankingTexts[i].Text = "1st Place: ";
                        break;
                    case 2:
                        teamARankingTexts[i].Text = "2nd Place: ";
                        break;
                    case 3:
                        teamARankingTexts[i].Text = "3rd Place: ";
                        break;
                    default:
                        teamARankingTexts[i].Text = $"{team1.playerOrder[i].Item2}th Place: ";
                        break;
                }
                teamARankings[i].Text = $"{team1.playerOrder[i].Item1.name}, {team1.playerOrder[i].Item1.points}pts";
            }
            // Generate Team B Ranking Values:
            displayTeamBRanking.DataContext = $"{team2.name} Ranking";
            teamBHeading.Text = (string)displayTeamBRanking.DataContext;
            for (int i = 0; i < 5; i++)
            {
                switch (team2.playerOrder[i].Item2)
                {
                    case 1:
                        teamBRankingTexts[i].Text = "1st Place: ";
                        break;
                    case 2:
                        teamBRankingTexts[i].Text = "2nd Place: ";
                        break;
                    case 3:
                        teamBRankingTexts[i].Text = "3rd Place: ";
                        break;
                    default:
                        teamBRankingTexts[i].Text = $"{team2.playerOrder[i].Item2}th Place: ";
                        break;
                }
                teamBRankings[i].Text = $"{team2.playerOrder[i].Item1.name}, {team2.playerOrder[i].Item1.points}pts";
            }
            // Generate Team C Ranking Values:
            displayTeamCRanking.DataContext = $"{team3.name} Ranking";
            teamCHeading.Text = (string)displayTeamCRanking.DataContext;
            for (int i = 0; i < 5; i++)
            {
                switch (team3.playerOrder[i].Item2)
                {
                    case 1:
                        teamCRankingTexts[i].Text = "1st Place: ";
                        break;
                    case 2:
                        teamCRankingTexts[i].Text = "2nd Place: ";
                        break;
                    case 3:
                        teamCRankingTexts[i].Text = "3rd Place: ";
                        break;
                    default:
                        teamCRankingTexts[i].Text = $"{team3.playerOrder[i].Item2}th Place: ";
                        break;
                }
                teamCRankings[i].Text = $"{team3.playerOrder[i].Item1.name}, {team3.playerOrder[i].Item1.points}pts";
            }
            // Generate Team D Ranking Values:
            displayTeamDRanking.DataContext = $"{team4.name} Ranking";
            teamDHeading.Text = (string)displayTeamDRanking.DataContext;
            for (int i = 0; i < 5; i++)
            {
                switch (team4.playerOrder[i].Item2)
                {
                    case 1:
                        teamDRankingTexts[i].Text = "1st Place: ";
                        break;
                    case 2:
                        teamDRankingTexts[i].Text = "2nd Place: ";
                        break;
                    case 3:
                        teamDRankingTexts[i].Text = "3rd Place: ";
                        break;
                    default:
                        teamDRankingTexts[i].Text = $"{team4.playerOrder[i].Item2}th Place: ";
                        break;
                }
                teamDRankings[i].Text = $"{team4.playerOrder[i].Item1.name}, {team4.playerOrder[i].Item1.points}pts";
            }
            comboDisplay.ItemsSource = new string[] { displayTeamRanking.DataContext.ToString(), displayParticipantRanking.DataContext.ToString(), displayEvent1Ranking.DataContext.ToString(),
                displayEvent2Ranking.DataContext.ToString(), displayEvent3Ranking.DataContext.ToString(), displayEvent4Ranking.DataContext.ToString(), displayEvent5Ranking.DataContext.ToString(),
                displayTeamARanking.DataContext.ToString(), displayTeamBRanking.DataContext.ToString(), displayTeamCRanking.DataContext.ToString(), displayTeamDRanking.DataContext.ToString() };
        }
    }
}
