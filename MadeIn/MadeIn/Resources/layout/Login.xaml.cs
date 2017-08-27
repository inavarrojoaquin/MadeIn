
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MadeIn.Resources.layout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false); // hide title bar

            this.BackgroundColor = Color.PaleVioletRed;

            this.btnFacebook.Image = "facebookLogin.png";
            this.btnGoogle.Image = "googleLogin.png";

        }

        async void OnLogInButton(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Home());            
        }

        async void OnRegisterButton(object sender, EventArgs args)
        {            
            await Navigation.PushAsync(new Register(), true);
        }

    }
}