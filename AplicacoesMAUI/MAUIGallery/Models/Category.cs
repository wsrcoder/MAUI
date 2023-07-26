using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIGallery.Models
{
    internal class Category
    {
        public string Name { get; set; } = String.Empty;

        public List<Component> Components { get; set; }
    }
}
