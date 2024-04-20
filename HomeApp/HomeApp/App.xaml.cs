﻿using HomeApp.Pages;
using Xamarin.Forms;

namespace HomeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new LoadingPage();
            //MainPage = new LoginPage();
            MainPage = new RoomsPage();
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
