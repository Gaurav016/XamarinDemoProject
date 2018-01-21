using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoProject.View.MasterPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
       
        public MenuPage()
        {
            InitializeComponent();
            List<MenuItem> menuitem = new List<MenuItem>()
            {
                new MenuItem() { MenuType = MenuTypes.Home1, Title = "List" },
                new MenuItem() { MenuType=MenuTypes.Home2, Title="Add"}
            };
            menulist.ItemsSource = menuitem;
            menulist.ItemTapped += Menulist_ItemTapped;
        }

        private void Menulist_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Root.NavigateTo(e.Item as MenuItem);
        }
    }
}