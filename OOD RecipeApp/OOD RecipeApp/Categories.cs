using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_RecipeApp
{
    class Categories
    {
        public string Name { get; set; }
        public int Time { get; set; }
        public List<Recipe> Recipes { get; set; }

        public Categories(string name, int time)
        {
            Name = name;
            Time = time;
            Recipes = new List<Recipe>();
        }

        public override string ToString()
        {
            return Name + " " + Time;
        }

       
    }
}
