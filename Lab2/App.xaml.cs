using Xamarin.Forms;
using Lab2;

namespace Lab2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Lab2.Views.TabPagesControlView();
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
