using CommunityToolkit.Maui.Views;

namespace HRClient.Pages.Modal;

public partial class RestorePasswordModal : Popup
{
	public RestorePasswordModal()
	{
		InitializeComponent();
	}

    private async void CloseClicked(object sender, EventArgs e)
    {
        Close();
    }

    private void SendKeyClicked(object sender, EventArgs e)
    {
        button_restore_password.Text = "Обновить";
        button_restore_password.Clicked += SaveClicked;
        entry_code.IsVisible = true;

        entry_new_password.IsVisible = false;
        entry_new_password2.IsVisible = false;
        entry_username.IsVisible = false;
        frame_main.HeightRequest = 250;
    }

    private void SaveClicked(object sender, EventArgs e)
    {
        info_label.Text = "пароль обнавлен";
        info_label.TextColor = Colors.Green;
        info_label.IsVisible = true;
    }


    private void OnPointerEnteredButton(object sender, EventArgs e)
    {
        ((Button)sender).Opacity = 0.5;
    }

    private void OnPointerExitedButton(object sender, EventArgs e)
    {
        ((Button)sender).Opacity = 1;
    }
}