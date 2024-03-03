

namespace HRClient.Settings
{
    class AppSettings
    {
        public static string? BackgroundImage {  get; set; }

        public AppSettings() { }


        public static void ExecuteSettings(ContentPage page)
        {
            if(BackgroundImage != null) 
            {
                page.BackgroundImageSource = BackgroundImage;
                page.Opacity = 0.9;
            }
        }
    }
}
