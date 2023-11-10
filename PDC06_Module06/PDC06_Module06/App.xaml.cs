﻿using PDC06_Module06;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC06_Module06
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
