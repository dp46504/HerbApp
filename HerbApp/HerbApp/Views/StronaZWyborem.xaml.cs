using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HerbApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StronaZWyborem : ContentPage
    {
        public StronaZWyborem()
        {
            InitializeComponent();
        }

        private void GreenHerbClicked(object sender, EventArgs e)
        {
           Navigation.PushModalAsync(new Views.GreenHerbSite());
            
        }

        private void RedHerbClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Views.RedHerbSite());
        }

        private void BlackHerbClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Views.BlackHerbSite());
        }

        private void YerbaHerbClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Views.YerbaHerbSite());
        }

        private void WhiteHerbClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Views.WhiteHerbSite());
        }
    }
}