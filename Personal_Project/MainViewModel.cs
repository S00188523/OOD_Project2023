using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.VisualStudio.Services.Organization.Client;
using Microsoft.VisualStudio.Services.Common;

namespace Personal_Project
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Team2> _teams;

        public ObservableCollection<Team2> Teams
        {
            get { return _teams; }
            set
            {
                _teams = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Teams)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public async Task LoadJson()
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
            
                // Deserialize the JSON into a list of Team objects
                var teams = JsonSerializer.Deserialize<List<Root>>(json);

                List<Team2> teams2 = new List<Team2>();

                foreach (var team in teams)
                {
                    Team2 newTeam = new Team2();
                    newTeam.Rank = team.stats.rank;
                    newTeam.Logo = team.team.logo;
                    newTeam.Name = team.team.name;

                    newTeam.GamesPlayed = team.stats.gamesPlayed;
                    newTeam.Wins = team.stats.wins;
                    newTeam.Ties = team.stats.ties;
                    newTeam.Losses = team.stats.losses;
                    newTeam.GoalsFor = team.stats.goalsFor;
                    newTeam.GoalsAgainst = team.stats.goalsAgainst;
                    newTeam.GoalDifference = team.stats.goalDifference;



                    teams2.Add(newTeam);
                }

                Teams = new ObservableCollection<Team2>(teams2);
            }
        }
    }
}
