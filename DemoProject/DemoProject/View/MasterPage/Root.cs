using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoProject.View.MasterPage
{
    public class Root : MasterDetailPage
    {
        MenuPage menupage = new MenuPage();
        public Root()
        {
            Title = "Root";
            Detail = new NavigationPage(new HomePage1());
            Master = menupage;

        }

        public  void NavigateTo(MenuItem menu)
        {
            if (menu != null)
            {

                 GetMenuPage(menu);

                //Detail = displayPage;
                int coun = Navigation.NavigationStack.Count;
                Detail.Title = menu.Title;

                // menuPage.Menu.SelectedItem = null;
                IsPresented = false;
                IsGestureEnabled = false;
                this.MasterBehavior = MasterBehavior.Popover;


            }
        }

        void GetMenuPage(MenuItem menuItem)
        {
           Page page = new Page();
            try
            {
                switch (menuItem.MenuType)
                {
                    case MenuTypes.Home1:
                        Detail = new NavigationPage(new HomePage1());
                        break;
                    case MenuTypes.Home2:
                        Detail = new NavigationPage(new HomePage2());
                        break;
                    default:
                        Detail = new NavigationPage(new HomePage1());
                        break;
                }
            }
            catch (Exception ex)
            {
                
            }            

        }
    }
}

