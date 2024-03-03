using HRClient.Settings;

namespace HRClient.Pages;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
        AppSettings.ExecuteSettings(this);
    }
}