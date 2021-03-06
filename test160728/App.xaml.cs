﻿using Xamarin.Forms;
using System;
using System.Collections.Generic;

namespace test160728
{
    public partial class App : Application
    {
        public static List<string> PhoneNumbers { get; set; }
        public static string ScreenName { get; set; }

        public App()
        {
            // InitializeComponent();
            ScreenName = "";
            PhoneNumbers = new List<string>();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
