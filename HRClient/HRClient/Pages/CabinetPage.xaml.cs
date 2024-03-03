using HRClient.Settings;
using HRClient.Settings.Model;
using Microsoft.Maui.Platform;
using System.Text.Json;

namespace HRClient.Pages
{
    public partial class CabinetPage : ContentPage
    {
        int count = 0;

        public CabinetPage()
        {
            InitializeComponent();
            AppSettings.ExecuteSettings(this);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
