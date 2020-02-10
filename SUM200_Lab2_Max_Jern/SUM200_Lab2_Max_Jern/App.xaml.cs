﻿using SUM200_AndroidLab_Max_Jern.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SUM200_Lab2_Max_Jern
{
    public partial class App : Application
    {
        public static DogViewModel DogModel { get; set; } = new DogViewModel();
        public App()
        {
            InitializeComponent();
            //Starts by getting a random dog. For your pleasure :]
            App.DogModel.GetRandomDog();
            MainPage = new NavigationPage(new MainPage());

            MainPage = new MainPage();
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