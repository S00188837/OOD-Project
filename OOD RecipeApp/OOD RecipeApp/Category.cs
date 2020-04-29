using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_RecipeApp
{
    class Category : IComparable
    {
        public string Name { get; set; }
        public int Date { get; set; }
        public List<Recipe> Recipes { get; set; }

        public Category(string name, int date)
        {
            Name = name;
            Date = date;
            Recipes = new List<Recipe>();
        }

        public override string ToString()
        {
            return Name + " " + Date;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Category otherCategory = obj as Category;

            if (otherCategory != null)
            {
                return this.Name.CompareTo(otherCategory.Name);
            }
            else
            {
                throw new NotImplementedException("Obejct is not a category");
            }
        }
    }

}
