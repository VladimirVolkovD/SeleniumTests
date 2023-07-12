using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesObject.SwagLabs.PageObject
{
    internal class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
