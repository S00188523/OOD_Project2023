using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace Personal_Project
{
    public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

    }

    private async void PopulateStandingsListBox()
    {
        try
        {
            var viewModel = (MainViewModel)DataContext;
            await viewModel.LoadJson();
        }
        catch (Exception ex)
        {
            // Handle the exception here
            MessageBox.Show($"An error occurred while populating the standings list: {ex.Message}");
        }
    }

        private void lbxTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the selected team from the ListBox control
            var selectedTeam = lbxTable.SelectedItem as Team2;

            if (selectedTeam != null)
            {
                Window1 window1 = new Window1(selectedTeam);
                window1.ShowDialog();               
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
            PopulateStandingsListBox();
        }
    }

}
