using DemoProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoProject.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage2 : ContentPage
    {
        ProfileDataViewModel profileDataViewModel;
        public HomePage2()
        {
            InitializeComponent();
            profileDataViewModel = new ProfileDataViewModel();
            BindingContext = profileDataViewModel;
        }
    }
}