using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinMenuTester
{
    internal class NextTabbedPage: TabbedPage
    {
        public NextTabbedPage()
        {
            Children.Add(new NextTabPage1());
            Children.Add(new NextTabPage2());

            Title = "Tabbed page";

            MenuBarItems.Add(new MenuBarItem { Text = "MenuItem1" });
            MenuBarItems.Add(new MenuBarItem { Text = "MenuItem2" });
        }
    }
}
