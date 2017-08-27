using MadeIn.Resources.layout;

using Xamarin.Forms;

namespace MadeIn
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var userIsLogged = false;

            if (userIsLogged)
            {
                Current.MainPage = new NavigationPage(new Home());
            }
            else
            {
                Current.MainPage = new NavigationPage(new Login());
            }
            
            
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
