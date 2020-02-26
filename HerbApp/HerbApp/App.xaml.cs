using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HerbApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MasterDetailPage menu = new MasterDetailPage();
            menu.Detail = new Views.StronaPowitalna() { Title = "Strona powitalna"};
            menu.Master = new Views.StronaZWyborem() { Title="Strona z wyborem"};
            MainPage = menu;
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
