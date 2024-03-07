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
            AppSettings.Pages.Add(this);

            cabinet_name.Text = "ООО КИТ Информационные технологии";
            cabinet_description.Text = "Компания, специализирующаяся на разработке и внедрении современных информационных технологий" +
                " для различных сфер деятельности. Основными направлениями работы организации являются создание программного обеспечения," +
                " веб-разработка, а также консалтинг и аутсорсинг в области IT. Компания стремится к постоянному совершенствованию своих" +
                " продуктов и услуг, следуя последним тенденциям в сфере информационных технологий. Она ориентирована на удовлетворение" +
                " потребностей клиентов и предоставление им высококачественных решений, способствующих оптимизации бизнес-процессов и повышению" +
                " эффективности работы. Команда специалистов \"ООО КИТ Информационные технологии\" обладает высоким профессиональным уровнем и" +
                " большим опытом в области IT, что позволяет ей успешно реализовывать проекты любой сложности. Клиентоориентированность," +
                " инновационный подход и качество – основные принципы работы компании, делающие ее надежным партнером в сфере информационных " +
                "технологий.";
        }


        private void OnPointerEnteredImageButton(object sender, EventArgs e)
        {
            ((ImageButton)sender).Padding = 2;
            ((ImageButton)sender).BorderWidth = 1;
            ((ImageButton)sender).BorderColor = Colors.Black;
        }

        private void OnPointerExitedImageButton(object sender, EventArgs e)
        {
            ((ImageButton)sender).Padding = 0;
            ((ImageButton)sender).BorderWidth = 0;
            ((ImageButton)sender).BorderColor = Colors.Transparent;
        }
    }

}
