using Microsoft.Maui.Platform;

namespace HRClient.Pages
{
    public partial class CabinetPage : ContentPage
    {
        int count = 0;

        public CabinetPage()
        {
            InitializeComponent();
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
