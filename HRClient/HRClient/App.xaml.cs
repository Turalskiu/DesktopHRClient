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
            ReadAppSettingsFile();

            MainPage = new AppShell();
            //MainPage = new LoginPage();
            //MainPage = new ProfilePage();
            //MainPage = new SettingsPage();
        }


        private async Task ReadAppSettingsFile()
        {
            using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync("AppSettings.json");
            using StreamReader streamReader = new StreamReader(fileStream);

            string line;
            string jsonString = "";
            while ((line = streamReader.ReadLine()) != null) 
            {
                jsonString += line;
            }

            var settings = JsonSerializer.Deserialize<AppSettingsModel>(jsonString);
            AppSettings.BackgroundImage = settings.BackgroundImage;

            //AppSettings.ExecuteSettings();
        }
    }
}
