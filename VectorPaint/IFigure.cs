using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorPaint
{
    public interface IFigure
    {
        List<Point> GetPoints();
        void SetPoints(Point firstLocation, Point lastLocation);
    }
}
