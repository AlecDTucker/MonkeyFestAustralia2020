using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MonkeyFestAustralia2020
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselExampleView : ContentPage
    {
        public CarouselExampleView()
        {
            InitializeComponent();
            BindingContext = new CarouselExampleViewModel();
        }
    }
}