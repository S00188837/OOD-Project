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
        public int DateFormed { get; set; }
        public Recipe[] Recipes { get; set; }


        public override string ToString()
        {
            return string.Format($"{Name} - {DateFormed}");
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

    class Dessert : Category
    {
        public Dessert()
        {
            Recipes = new Recipe[5];
        }
    }

    class Dinner : Category
    {
        public Dinner()
        {
            Recipes = new Recipe[5];
        }
    }
}
