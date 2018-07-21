using System;
using Xamarin.Auth;
using Newtonsoft.Json;
using System.Json;
using Befriended.Droid.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Befriended.Droid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void Sign_In_Clicked(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if(user.VerifyUser())
            {
                DisplayAlert("Login", "Login Successful", "Cancel");
            }
            else
            {
                DisplayAlert("Login", "Login Failed", "Try Again");
            }

        }
    }
}