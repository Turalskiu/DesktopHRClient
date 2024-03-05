using CommunityToolkit.Maui.Views;
using HRClient.Pages.Modal;
using HRClient.Settings;

namespace HRClient.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();

        AppSettings.ExecuteSettings(this);
        AppSettings.Pages.Add(this);

        photo.Source = "user_photo_default.png";

        username.Text = "Turalskiu";
        email.Text = "ibishov.tural20@mail.ru";
        roles.Text = "Администратор, HR, Администратор кабинета";
        number.Text = "+7 900 693 03 43";

        entry_first_name.Text = "Tural";
        entry_last_name.Text = "";
        entry_miidle_name.Text = "Ibishov";
        entry_age.Text = "22";
    }

    private void ReplacementPhoto(object sender, EventArgs e)
    {
    }

    private void UpdateUsername(object sender, EventArgs e)
    {
        this.ShowPopup(new UpdateUsernameModal(username.Text));
    }

    private void UpdateEmail(object sender, EventArgs e)
    {
    }

    private void UpdatePhoneNumber(object sender, EventArgs e)
    {
    }

    private void SaveUserInfo(object sender, EventArgs e)
    {
    }
}