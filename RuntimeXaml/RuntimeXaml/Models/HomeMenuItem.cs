using System;
using System.Collections.Generic;
using System.Text;

namespace RuntimeXaml.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Sample1,
        Sample2
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
