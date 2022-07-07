using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinMenuTester
{
    internal class NextTabPage2 : ContentPage
    {
        public NextTabPage2()
        {
            var label = new Label { Text = "Menus are NOT at the expected place" };

            Content = label;
            Title = "Tab2";
        }
    }
}
