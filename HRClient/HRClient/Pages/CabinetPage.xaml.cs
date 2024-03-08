using HRClient.Settings;
using HRClient.Settings.Model;
using Microsoft.Maui.Platform;
using System.Text.Json;

namespace HRClient.Pages
{
    public class UserCard 
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
    }


    public partial class CabinetPage : ContentPage
    {
        List<UserCard> _users = new List<UserCard>();

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

            UserCard user = new UserCard
            {
                Username = "Oleg",
                Email = "hello.test24@mail.ru",
                Photo = "user_photo_default.png",
                Id = 1
            };
            for(int i=0; i <6; i++) _users.Add(user);

            RedrawUserLisr();
        }



        private void RedrawUserLisr()
        {
            foreach(UserCard user in _users)
            {
                var mainFrame = new Frame
                {
                    Margin = new Thickness(0, 10, 0, 0),
                    //Padding = new Thickness(0, 10, 0, 0),
                    HasShadow = true,
                    CornerRadius = 10,
                    BorderColor = Colors.LightGray
                };

                var tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += (sender, e) =>
                {
                };

                var pointerGestureRecognizer = new PointerGestureRecognizer();
                pointerGestureRecognizer.PointerEntered += OnPointerEnteredFrameUserList;
                pointerGestureRecognizer.PointerExited += OnPointerExitedFrameUserList;
                mainFrame.GestureRecognizers.Add(pointerGestureRecognizer);
                mainFrame.GestureRecognizers.Add(tapGestureRecognizer);

                var stackLayout = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal
                };

                Label labelId = new Label
                {
                    Text = user.Id.ToString(),
                    IsVisible = false,
                };
                stackLayout.Add(labelId);

                var userImageFrame = new Frame
                {
                    CornerRadius = 100,
                    Padding = 0,
                    WidthRequest = 60,
                    HeightRequest = 60
                };
                var userImage = new Image
                {
                    Source = user.Photo,
                    Aspect = Aspect.AspectFill
                };
                userImageFrame.Content = userImage;

                var grid = new Grid();
                grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

                var nameLabel = new Label
                {
                    Text = user.Username,
                    TextColor = Colors.DarkTurquoise,
                    FontFamily = "monospace",
                    FontSize = 16,
                    FontAttributes = FontAttributes.Bold,
                    Padding = new Thickness(10, 5, 0, 0)
                };

                var emailLabel = new Label
                {
                    Text = user.Email,
                    TextColor = Colors.DarkTurquoise,
                    FontFamily = "monospace",
                    FontSize = 12,
                    FontAttributes = FontAttributes.Bold,
                    Padding = new Thickness(10, 10, 0, 0)
                };

                grid.Children.Add(emailLabel);
                grid.Children.Add(nameLabel);
                Grid.SetRow(nameLabel, 1);
                Grid.SetRow(emailLabel, 0);

                stackLayout.Children.Add(userImageFrame);
                stackLayout.Children.Add(grid);

                mainFrame.Content = stackLayout;

                user_list.Add(mainFrame);
            }
        }



        private void OnPointerEnteredImageButton(object sender, EventArgs e)
        {
            ((ImageButton)sender).Padding = ((ImageButton)sender).Padding +2;
            ((ImageButton)sender).BorderWidth = 1;
            ((ImageButton)sender).BorderColor = Colors.Black;
        }

        private void OnPointerExitedImageButton(object sender, EventArgs e)
        {
            ((ImageButton)sender).Padding = ((ImageButton)sender).Padding - 2;
            ((ImageButton)sender).BorderWidth = 0;
            ((ImageButton)sender).BorderColor = Colors.Transparent;
        }



        private void OnPointerEnteredFrameUserList(object sender, EventArgs e)
        {
            ((Frame)sender).BackgroundColor = Colors.LightGray;
        }

        private void OnPointerExitedFrameUserList(object sender, EventArgs e)
        {
            ((Frame)sender).BackgroundColor = Colors.White;
        }
    }

}
