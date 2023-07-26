using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIGallery.Models
{
    internal class Component
    {

        public string Title { get; set; }   = String.Empty;

        public string Description { get; set; } = String.Empty;

        public Type Page { get; set; }
    }
}
