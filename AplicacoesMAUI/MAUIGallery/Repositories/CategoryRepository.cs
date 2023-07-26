using MAUIGallery.Models;
using MAUIGallery.Views.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIGallery.Repositories
{
    internal class CategoryRepository
    {
        public CategoryRepository()
        {
            
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();

            categories.Add(new Category { 
                Name="Layout",
                Components = new List<Component> {
                    new Component { 
                        Title="StackLayout",
                        Description="Organização Sequêncial dos Elementos",
                        Page = typeof(StackLayoutGalleryPage)
                    }   
                }
            });

            return categories;
        }
    }
}
