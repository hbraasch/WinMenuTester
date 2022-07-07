using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinMenuTester
{
    internal class NextTabPage1: ContentPage
    {
        public NextTabPage1()
        {
            var label = new Label { Text = "Menus are NOT at the expected place" };

            Content = label;
            Title = "Tab1";
        }
    }
}
