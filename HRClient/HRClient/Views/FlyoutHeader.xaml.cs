namespace HRClient.Views;

public partial class FlyoutHeader : ContentView
{
	public FlyoutHeader()
	{
		InitializeComponent();

		photo.Source = "user_photo_default.png";
		label_email.Text = "ibishov.tural20@mail.ru";
		label_username.Text = "Turalskiu";
    }
}