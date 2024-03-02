namespace HRClient.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void TogglePasswordVisibility(object sender, EventArgs e)
    {
        password_entry.IsPassword = !password_entry.IsPassword;
    }


    private void Login(object sender, EventArgs e)
    {
        info_label.Text = "Не верный логин или пароль";
        info_label.TextColor = Colors.Red;
        info_label.IsVisible = true;
    }


    private void RestorePassword(object sender, EventArgs e)
    {
    }

    private void Registration(object sender, EventArgs e)
    {
    }
}