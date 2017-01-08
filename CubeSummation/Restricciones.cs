using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CubeSummation
{
    public class Restricciones
    {
        bool validaT(int t) {
            bool sw = false;
            if (t >= 1 && t <= 50)
            {
                sw = true;
            }
            else {
                sw = false;
            }

            return sw;
        }

        bool validaN(int n) {

            bool sw = false;

            if (n >= 1 && n <= 100)
            {
                sw = true;
            }
            else
            {
                sw = false;
            }

            return sw;
        }

        bool validaM(int m)
        {

            bool sw = false;

            if (m >= 1 && m <= 1000)
            {
                sw = true;
            }
            else
            {
                sw = false;
            }

            return sw;
        }

        bool validaPuntos(int punto1, int punto2, int n) {
            bool sw = false;

            if (punto1 >= 1 && punto2 >= punto1 && punto2 <= n)
            {
                sw = true;
            }
            else {
                sw = false;
            }

            return sw;
        }


        bool validaCoordenadas(int x, int y, int z, int n) {
            bool sw = false;

            if (x >= 1 && x <= n && y >= 1 && y <= n && z >= 1 && z <= n)
            {
                sw = true;
            }
            else {
                sw = false;
            }

            return sw;
        }

        bool validarW(double w) {
            double valorInferior = Math.Pow(-10,9);
            double valorSuperior = Math.Pow(10, 9);
            bool sw = false;

            if (w >= valorInferior && w <= valorSuperior)
            {
                sw = true;
            }
            else {
                sw = false;
            }

            return sw;
        }

        bool validaBloques(Punto p0, Punto p1, Punto p2) {
            bool sw = false;

            if (p1.x <= p0.x && p0.x <= p2.x && p1.y <= p0.y && p0.y <= p2.y && p1.z <= p0.z && p0.z <= p2.z)
            {
                sw = true;
            }
            else {
                sw = false;
            }

            return sw;

        }
    }
}