using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CubeSummation
{
    public class CRUD
    {
        BloquesAsignados bloques = new BloquesAsignados();

        public void create(int x, int y, int z, double w) {

            Punto p1 = read(x, y, z);
            if (p1 == null)
            {
                Punto p = new Punto(x, y, z, w);
                bloques.Lpunto.Add(p);
            }
            else {
                update(x,y,z,w);
            }

        }

        public Punto read(int x1, int y1, int z1) {
            Punto p = bloques.Lpunto.Find(x => x.x == x1 && x.y == y1 && x.z == z1);
            return p;            
        }

        public Punto update(int x1, int y1, int z1, double w1) {

            bloques.Lpunto.Find(x => x.x == x1 && x.y == y1 && x.z == z1).w = w1;

            return bloques.Lpunto.Find(x => x.x == x1 && x.y == y1 && x.z == z1);
        }

        public void delete() {
        }
    }
}