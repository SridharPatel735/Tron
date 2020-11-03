using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron
{
    class Trail
    {
        public int trailX, trailY, trailWidth = 5, trailHeight = 5;
        public Brush colour;

        public Trail(int _trailX, int _trailY, Brush _colour)
        {
            trailX = _trailX;
            trailY = _trailY;
            colour = _colour;
        }
    }
}
