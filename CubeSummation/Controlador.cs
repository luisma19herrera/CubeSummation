using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CubeSummation
{
    public class Controlador
    {
        public int t = 0;
        public int n = 0;
        public int m = 0;

        int x = 0;
        int y = 0;

        public CRUD crud = new CRUD();
        public Restricciones restriccion = new Restricciones();
        public BloquesAsignados bloques = new BloquesAsignados();

        public List<double> resultado = new List<double>();

        

        

        public string update(int x, int y, int z, double w) {
            string respuesta = "";
            if (restriccion.validaCoordenadas(x, y, z, n) && restriccion.validarW(w))
            {
                crud.create(x, y, z, w, bloques.Lpunto);
                respuesta = "Bloque actualizado con éxito";

            }
            else {
                respuesta = "Los datos ingresados no son válidos";
            }

            return respuesta;
                            
        }

        public void query(int x1, int y1, int z1, int x2, int y2, int z2) {
            double suma = 0;

            if (restriccion.validaPuntos(x1,x2,n) && restriccion.validaPuntos(y1, y2, n) && restriccion.validaPuntos(z1, z2, n)) {
                Punto p1 = bloques.Lpunto.Find(x => x.x == x1 && x.y == y1 && x.z == z1);
                Punto p2 = bloques.Lpunto.Find(x => x.x == x2 && x.y == y2 && x.z == z2);

                if (p1 == null && p2 != null)
                {
                    suma = suma + p2.w;
                }
                else {
                    if (p2 == null && p1 != null)
                    {
                        suma = suma + p1.w;
                    }
                    else {
                        if (p1 != null && p2 != null) {
                            if (p1 != p2)
                            {
                                suma = suma + p1.w + p2.w;
                            }
                            else {
                                suma = suma + p1.w;
                            }
                        }
                    }
                }
                

                foreach (Punto p in bloques.Lpunto) {
                    if (p1 != null && p2 != null)
                    {
                        if (restriccion.validaBloques(p, p1, p2) && p.x != p1.x && p.y != p1.y && p.z != p1.z && p.x != p2.x && p.y != p2.y && p.z != p2.z)
                        {
                            suma = suma + p.w;
                        }
                    }
                    else {
                        Punto puntoA = new Punto(x1, y1, z1, 0);
                        Punto puntoB = new Punto(x2, y2, z2, 0);


                        if (restriccion.validaBloques(p,puntoA, puntoB) && p.x != puntoA.x && p.y != puntoA.y && p.z != puntoA.z && p.x != puntoB.x && p.y != puntoB.y && p.z != puntoB.z)
                        {
                            suma = suma + p.w;
                        }
                    }
                    
                }
            }

            resultado.Add(suma);
        }



    }
}