using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace HelloWorld
{
    public partial class App : Application
    {
        public const string keypadOutput =  "keypadOutput";
        public App()
        {
            InitializeComponent();

            //ContentPage page = new ContentPage();
            //StackLayout layout = new StackLayout();
            //Label lbl = new Label();
            //lbl.Text = "Welcome to Xamarin CESAR School";
            //layout.Children.Add(lbl);
            //page.Content = layout;


            ContentPage mainPage = new ContentPage {
                Title = "New Page",
                Content = new StackLayout {
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin CESAR School"
                        }
                    },
                    VerticalOptions = LayoutOptions.Center
                }
            };

            MyPage page = new MyPage();
            this.MainPage = new NavigationPage(page);

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
