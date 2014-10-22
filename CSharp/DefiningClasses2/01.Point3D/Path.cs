using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points3d
{
    /* 04.Create a class Path to hold a sequence of points in the 3D space. */
    public class Path
    {
        private List<Point3D> pointSeq = new List<Point3D>();

        public List<Point3D> PointSeq
        {
            get { return this.pointSeq; }
        }

        public void AddPoint(Point3D point)
        {
            this.pointSeq.Add(point);
        }
    }
}
