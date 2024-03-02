
using HRClient.Pages;

namespace HRClient
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
            //MainPage = new LoginPage();
            //MainPage = new ProfilePage();
        }
    }
}
