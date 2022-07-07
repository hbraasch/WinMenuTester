using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinMenuTester
{
    internal class StartupPage : ContentPage
    {
        public StartupPage()
        {
            var label = new Label { Text = "Menus are at the expected place" };

            Content = label;

            var mi1 = new MenuBarItem
            {
                Text = "Click me"
            };
            
            mi1.Add(new MenuFlyoutItem { Text = "Go to tabbed page", Command = new Command(async () => {

                await Application.Current.MainPage.Navigation.PushAsync(new NavigationPage(new NextTabbedPage()));
            
            })});

            MenuBarItems.Add(mi1);
            MenuBarItems.Add(new MenuBarItem { Text = "MenuItem1" });


        }
    }
}
