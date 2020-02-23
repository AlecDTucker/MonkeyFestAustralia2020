using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MonkeyFestAustralia2020
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "IndicatorView_Experimental", "SwipeView_Experimental" });

            MainPage = new NavigationPage(new CollectionExampleView());
            // MainPage = new NavigationPage(new CarouselExampleView());
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
