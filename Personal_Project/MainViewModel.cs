﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.VisualStudio.Services.Organization.Client;

namespace Personal_Project
{
    public class MainViewModel : INotifyPropertyChanged
    {
        // ...

        private ObservableCollection<Team> _teams;

        public ObservableCollection<Team> Teams
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
                RequestUri = new Uri("https://football98.p.rapidapi.com/premierleague/table"),
                Headers =
                {
                    { "X-RapidAPI-Key", "d99ef4d195mshf7ef03579a02ac0p1916b4jsn5524649b62a4" },
                    { "X-RapidAPI-Host", "football98.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON into a list of Team objects
                var teams = JsonSerializer.Deserialize<List<Team>>(json);

                // Populate the games played, won, drawn, lost, and points properties for each team
                //foreach (var team in teams)
                //{
                //    var teamRequest = new HttpRequestMessage
                //    {
                //        Method = HttpMethod.Get,
                //        RequestUri = new Uri($"https://football98.p.rapidapi.com/team/{team.Name}"),
                //        Headers =
                //        {
                //            { "X-RapidAPI-Key", "d99ef4d195mshf7ef03579a02ac0p1916b4jsn5524649b62a4" },
                //            { "X-RapidAPI-Host", "football98.p.rapidapi.com" },
                //        },
                //    };

                //    using (var teamResponse = await client.SendAsync(teamRequest))
                //    {
                //        teamResponse.EnsureSuccessStatusCode();
                //        var teamJson = await teamResponse.Content.ReadAsStringAsync();
                //        var teamData = JsonSerializer.Deserialize<Team>(teamJson);
                //        team.Played = teamData.Played;
                //        team.Won = teamData.Won;
                //        team.Drawn = teamData.Drawn;
                //        team.Lost = teamData.Lost;
                //        team.Points = teamData.Points;
                //    }
                //}

                Teams = new ObservableCollection<Team>(teams);
            }
        }
    }
}