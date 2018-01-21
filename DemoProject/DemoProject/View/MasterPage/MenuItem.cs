using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.View.MasterPage
{
    public class MenuItem
    {
        public MenuTypes MenuType { get; set; }
        public string Title { get; set; }
        public string IconSource { get; set; }
    }

    public enum MenuTypes
    {
        Home1,
        Home2        
    }
}
