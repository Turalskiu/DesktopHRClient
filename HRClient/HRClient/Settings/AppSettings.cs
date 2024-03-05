using HRClient.Settings.Model;
using System.Text.Json;

namespace HRClient.Settings
{
    class AppSettings
    {
        public static List<ContentPage> Pages { get; set; } = new List<ContentPage>();
        public static string? BackgroundImage { get; set; }

        public AppSettings() { }


        public static void ExecuteSettings(ContentPage page)
        {
            if(page == null) return;
            if (BackgroundImage != null)
            {
                page.BackgroundImageSource = BackgroundImage;
                page.Opacity = 0.9;
            }
        }



        public static void ExecuteSettingsAllPages()
        {
            foreach (var page in Pages)
            {
                ExecuteSettings(page);
            }
        }


        public static void ReadSettings()
        {
            string? jsonModel = Preferences.Default.Get<string?>("Settings", null);
            if(jsonModel != null)
            {
                AppSettingsModel model = JsonSerializer.Deserialize<AppSettingsModel>(jsonModel);
                BackgroundImage = model.BackgroundImage;
            }
        }


        public static void SaveSettings()
        {
            AppSettingsModel model = new AppSettingsModel 
            { 
                BackgroundImage = BackgroundImage
            };
            Preferences.Default.Set("Settings", JsonSerializer.Serialize(model));
        }

    }

}
