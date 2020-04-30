using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOD_RecipeApp
{
    class Recipe
    {
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public RichTextBox RichBox { get; set; }

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
