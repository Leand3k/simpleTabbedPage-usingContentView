using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using tabbedwithContentView.Models;

namespace tabbedwithContentView.ViewModels
{
    public class MenuHomeViewModel : INotifyPropertyChanged
    {
        public MenuOptions BarAndHotels { get; }

        public MenuOptions FineDining { get; }
        public MenuOptions Cafes { get; }
        public MenuOptions Nearby { get; }
        public MenuOptions FastFoods { get; }
        public MenuOptions FeaturedFoods { get; }

        public MenuHomeViewModel()
        {
            BarAndHotels = new MenuOptions("Bar & Hotels", "42 Places", "BarsAndHotels.png");
            FineDining = new MenuOptions("Fine Dining", "15 Places", "FineDining.png");
            Cafes = new MenuOptions("Cafes", "28 Places", "Cafes.png");
            Nearby = new MenuOptions("Nearby", "34 Places", "Nearby.png");
            FastFoods = new MenuOptions("Fast Foods", "29 Places", "FastFoods.png");
            FeaturedFoods = new MenuOptions("Featured Foods", "21 Places", "FeaturedFoods.png");
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}