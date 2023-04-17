using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Windows;

namespace Personal_Project
{
    public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
        PopulateStandingsListBox();
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
}

}
