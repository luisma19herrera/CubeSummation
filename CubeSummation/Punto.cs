using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CubeSummation
{
    public class Punto
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public double w { get; set; }

        public Punto(int x, int y,  int z, double w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

    }
}