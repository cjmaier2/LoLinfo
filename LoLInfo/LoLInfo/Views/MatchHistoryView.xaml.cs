﻿using System;
using System.Collections.Generic;
using LoLInfo.Models;
using Xamarin.Forms;

namespace LoLInfo
{
    public partial class MatchHistoryView : ContentPage
    {
        public MatchHistoryView(List<MatchInfo> matchHistory)
        {
            InitializeComponent();

            MatchHistoryListView.ItemsSource = matchHistory;
            MatchHistoryListView.ItemTapped += OnItemTapped;
        }

        public void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }
    }
}
