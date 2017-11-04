﻿
using App.Views;
using App.Views.NavigationPage;
using App.Views.PaginaEmAbas;
using Xamarin.Forms;

namespace App
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();

      MainPage = new XAba01View();
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
