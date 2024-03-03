using HRClient.Settings;
using HRClient.Settings.Model;
using System.Text.Json;

namespace HRClient
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void HelpClicked(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new System.Uri("https://learn.microsoft.com/dotnet/maui/fundamentals/shell"));
        }

    } 
}
