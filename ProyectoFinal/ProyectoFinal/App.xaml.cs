using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace ProyectoFinal
{
    public partial class App : Application
    {
        public static FlyoutPage FlyoutP { get; set; }
        public static string GlobalUrl = "https://79ed-181-78-13-143.ngrok.io/api";
        public static string GlobalMedialUrl = "https://79ed-181-78-13-143.ngrok.io";
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginIU());
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