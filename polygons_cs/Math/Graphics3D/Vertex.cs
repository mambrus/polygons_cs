using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using polygons_cs.Math.LinearAlgebra;


namespace polygons_cs.Math.Graphics3D
{
    class Vertex : Base.Vector<double>
    {
        //A vertex is a 1 dimentional Vector<double> with a size
        // of 3 (3 as in x, y, z value)
        Vertex() : base(3)
        {
            throw new System.NotImplementedException();
        }
    }
}

