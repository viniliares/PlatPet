﻿using PlatPet.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PlatPet
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new MasterDetailsPageView());
            //MainPage = new ContentPageViewAgendarConsulta();

            //MainPage = new ContentPageViewApresentacaoA();
            MainPage = new ContentPageCadastroUsuarioView();

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