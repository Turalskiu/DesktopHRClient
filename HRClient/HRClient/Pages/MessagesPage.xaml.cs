using HRClient.Settings;

namespace HRClient.Pages;

public partial class MessagesPage : ContentPage
{
	public MessagesPage()
	{
		InitializeComponent();
        AppSettings.ExecuteSettings(this);
        AppSettings.Pages.Add(this);
    }
}