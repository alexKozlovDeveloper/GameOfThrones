using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GameOfThrones.MapItems
{
    class Map
    {
        public Grid Grid { get; private set; }

        public Map(Grid grid)
        {
            Grid = grid;
        }

        //public
    }
}
