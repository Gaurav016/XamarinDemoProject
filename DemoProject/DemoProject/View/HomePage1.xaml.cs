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
    public partial class HomePage1 : ContentPage
    {
        ProfileDataViewModel profileDataViewModel;
        public HomePage1()
        {
            InitializeComponent();
            profileDataViewModel = new ProfileDataViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            profileDataViewModel.GetDataModel();
            menulist.ItemsSource = profileDataViewModel.GetprofileDataList;
        }
    }
}