using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GameOfThrones.MapItems
{
    class MapFactory
    {
        public static Map GetMap(Grid grid)
        {
            var map = new Map(grid);

            return map;
        }
    }
}
