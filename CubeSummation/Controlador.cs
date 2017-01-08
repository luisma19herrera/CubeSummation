using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CubeSummation
{
    public class Controlador
    {
        int t = 0;
        int n = 0;
        int m = 0;

        int x = 0;
        int y = 0;

        CRUD crud = new CRUD();
        Restricciones restriccion = new Restricciones();
        BloquesAsignados bloques = new BloquesAsignados();

        List<double> resultado = new List<double>();

        public string validar(int t, int n, int m) {
            string resultado = "";
            if (restriccion.validaT(t) && restriccion.validaN(n) && restriccion.validaM(m))
            {
                resultado = "Datos correctos";

            }
            else {
                resultado = "Datos incorrectos";
            }
            return resultado;
        }

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

                suma = suma + p1.w + p2.w;

                foreach (Punto p in bloques.Lpunto) {
                    if (restriccion.validaBloques(p,p1,p2)) {
                        suma = suma + p.w;
                    }
                }
            }

            resultado.Add(suma);
        }



    }
}