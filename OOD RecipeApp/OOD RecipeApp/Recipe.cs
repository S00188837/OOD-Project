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
        public DateTime Created { get; set; }

        public override string ToString()
        {
            return (this.Name + " - " + DateTime.Now.ToShortTimeString());
        }

    }
}
