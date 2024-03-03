using CommunityToolkit.Maui.Views;

namespace HRClient.Pages.Modal;

public partial class UpdateUsernameModal: Popup
{
	public UpdateUsernameModal(string username)
	{
		InitializeComponent();
        entry_new_username.Text = username;

    }


    private async void CloseClicked(object sender, EventArgs e)
    {
        Close();
    }

    private void SaveClicked(object sender, EventArgs e)
    {
        info_label.Text = "����� �����";
        info_label.TextColor = Colors.Red;
        info_label.IsVisible = true;
    }
}