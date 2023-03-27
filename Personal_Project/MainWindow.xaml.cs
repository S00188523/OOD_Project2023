using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Windows;
using Newtonsoft;


namespace Personal_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PopulateStandingsListBox();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Standings> standings = new List<Standings>();
            lbxTable.ItemsSource = standings;

        }

        private async void PopulateStandingsListBox()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://premier-league-standings1.p.rapidapi.com/"),
                Headers =
                {
                 { "X-RapidAPI-Key", "d99ef4d195mshf7ef03579a02ac0p1916b4jsn5524649b62a4" },
                     { "X-RapidAPI-Host", "premier-league-standings1.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON response into a list of Standings objects
                var standings = JsonSerializer.Deserialize<List<Standings>>(json);

                // Filter out any standings with null values
                standings = standings.Where(s => s.TeamName != null && s.Played != null && s.Won != null && s.Drawn != null && s.Lost != null && s.Points != null).ToList();

                // Sort the standings by points
                standings = standings.OrderByDescending(s => s.Points).ToList();

                // Bind the standings list to the ListBox
                lbxTable.ItemsSource = standings;
            }
        }


    }

}
