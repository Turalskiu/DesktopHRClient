using HRClient.Models.Interface;
using HRClient.Settings;
using System.Reflection.PortableExecutable;

namespace HRClient.Pages;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
        AppSettings.ExecuteSettings(this);
        AppSettings.Pages.Add(this);
    }


    private async void UpdateTheme(object sender, EventArgs e)
    {
        BackgroundThemeSettings current = (BackgroundThemeSettings)carouselView.CurrentItem;

        AppSettings.BackgroundImage = current.ImagePath;
    
        AppSettings.SaveSettings();
        AppSettings.ExecuteSettingsAllPages();
    }

    private void carouselViewCurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    {
        BackgroundThemeSettings? current = e.CurrentItem as BackgroundThemeSettings;
        BackgroundThemeSettings? previous = e.PreviousItem as BackgroundThemeSettings;
        //header.Text = $"Current: {current?.Name}  Previous: {previous?.Name}";
    }
}