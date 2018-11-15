using AGB_App.Messages;
using AGB_App.Pages;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AGB_App
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            Messenger.Default.Register<OpenMainPageMessage>(this, OpenMainPageMessage_Handler);
        }

        private async void OpenMainPageMessage_Handler(OpenMainPageMessage msg)
        {
            MainPage mainPage = new MainPage();
            Navigation.InsertPageBefore(mainPage, this);
            NavigationPage.SetHasNavigationBar(mainPage, false);
            await Navigation.PopAsync();
        }
    }
}
