using HRClient.Pages;
using HRClient.Settings;
using HRClient.Settings.Model;
using System.Text.Json;

namespace HRClient
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //считываем настройки из файла
            AppSettings.ReadSettings();

            MainPage = new AppShell();
            //MainPage = new LoginPage();
            //MainPage = new ProfilePage();
            //MainPage = new SettingsPage();
        }


    }
}
