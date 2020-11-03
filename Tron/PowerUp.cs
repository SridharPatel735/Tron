using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tron
{
    class PowerUp
    {
        int x, y, size;
        public PowerUp(int _x, int _y, int _size)
        {
            x = _x;
            y = _y;
            size = _size;
        }

        public bool powerUpCollide(Rider r)
        {
            Rectangle riderRec = new Rectangle(r.X, r.Y, r.riderWidth, r.riderHeight);
            Rectangle powerRec = new Rectangle(x, y, size, size);
            Boolean powerCollide = false;

            if(powerRec.IntersectsWith(riderRec))
            {
                powerCollide = true;
            }

            return powerCollide;
        }
    }
}
