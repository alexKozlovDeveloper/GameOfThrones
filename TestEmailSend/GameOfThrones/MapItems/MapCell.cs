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
    class MapCell
    {
        public Rectangle Rec { get; private set; }
        public Grid Grid { get; private set; }

        public int X { get; set; }
        public int Y { get; set; }

        public MapCell(Grid grid, int x, int y)
        {
            Grid = grid;

            X = x;
            Y = y;

            Rec =  new Rectangle
            {
                Width = 75,
                Height = 75,
                Fill = new SolidColorBrush(Colors.Red),
                Margin = new Thickness(0, 0, 0, 0)
            };

            //Grid.Children.Add(rect);
        }
    }
}
