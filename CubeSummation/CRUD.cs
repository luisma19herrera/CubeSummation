using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CubeSummation
{
    public class CRUD
    {
        

        public void create(int x, int y, int z, double w, List<Punto> bloques) {

            Punto p1 = read(x, y, z, bloques);
            if (p1 == null)
            {
                Punto p = new Punto(x, y, z, w);
                bloques.Add(p);
            }
            else {
                update(x,y,z,w, bloques);
            }

        }

        public Punto read(int x1, int y1, int z1, List<Punto> bloques) {
            Punto p = bloques.Find(x => x.x == x1 && x.y == y1 && x.z == z1);
            return p;            
        }

        public Punto update(int x1, int y1, int z1, double w1, List<Punto> bloques) {

            bloques.Find(x => x.x == x1 && x.y == y1 && x.z == z1).w = w1;

            return bloques.Find(x => x.x == x1 && x.y == y1 && x.z == z1);
        }

        public void delete() {
        }
    }
}