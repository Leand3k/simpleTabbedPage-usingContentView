using System;
using tabbedwithContentView.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tabbedwithContentView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomeTabbedPage());
            //MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}