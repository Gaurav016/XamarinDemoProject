using DemoProject.View.MasterPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DemoProject
{
    public class App : Application
    {
        public static Root RootNavigation;
        public App()
        {          
            RootNavigation = new Root();
            Current.MainPage = RootNavigation;
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
