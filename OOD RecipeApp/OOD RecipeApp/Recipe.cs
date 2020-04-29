using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_RecipeApp
{
    class Recipe
    {
        public string Name { get; set; }
        public DateTime Time { get; set; }

        public Recipe(string name, DateTime time)
        {
            Name = name;
            Time = time;
        }

        public override string ToString()
        {
            return Name + " " + Time.ToShortTimeString();
        }
    }
}
