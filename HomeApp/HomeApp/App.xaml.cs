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
            //MainPage = new RegisterPage();
            //MainPage = new RoomsPage();a
            MainPage = new DevicesPage();
            //MainPage = new ClimatePage();
            //MainPage = new AboutPage();
            //MainPage = new GridPage();
            //MainPage = new MergeGridPage();
            //MainPage = new NewDevicePage();
            //MainPage = new DeviceControlPage();
            //MainPage = new ProfilePage();
            //MainPage = new WebPage();



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
