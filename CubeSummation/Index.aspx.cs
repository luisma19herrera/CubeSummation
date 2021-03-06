﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

namespace CubeSummation
{
    public partial class Index : System.Web.UI.Page
    {
        public static Controlador cont = new Controlador();

        public static int contadorP = 0;
        public static int contadorO = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            contadorO = 0;
            contadorP = 0;
        }

        [WebMethod]
        public static string update(int x, int y, int z, double w)
        {
            string resultado = "";

            if (cont.m != 0 && cont.t != 0 && cont.n != 0)
            {
                if (contadorP <= cont.t - 1)
                {
                    if (contadorO <= cont.m - 1)
                    {
                        cont.update(x, y, z, w);
                        contadorO = contadorO + 1;
                        resultado = "Guardado";
                    }
                    else
                    {
                        contadorO = 0;
                        cont.bloques.Lpunto.Clear();
                        contadorP = contadorP + 1;
                        resultado = "Fin de la prueba " + contadorP;
                    }
                }
                else
                {
                    resultado = "Fin de todas las pruebas";
                }
            }
            else {
                resultado = "Debe inicializar las variables T,N,M para continuar";
            }
            
               
            return resultado;
            
        }

        [WebMethod]
        public static string query(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            string resultado = "";
            if (cont.m != 0 && cont.t != 0 && cont.n != 0)
            {
                if (contadorP <= cont.t - 1)
                {
                    if (contadorO <= cont.m - 1)
                    {
                        cont.query(x1, y1, z1, x2, y2, z2);
                        contadorO = contadorO + 1;
                        resultado = "Guardado";
                    }
                    else
                    {
                        contadorO = 0;
                        cont.bloques.Lpunto.Clear();
                        contadorP = contadorP + 1;
                        resultado = "Fin de la prueba " + contadorP;
                    }
                }
                else
                {
                    resultado = "Fin de todas las pruebas";
                }
            }
            else {
                resultado = "Debe inicializar las variables T,N,M para continuar";
            }
            
            return resultado;
        }

        [WebMethod]
        public static bool validar(int t, int n, int m)
        {
            bool resultado = false;
            if (cont.restriccion.validaT(t) && cont.restriccion.validaN(n) && cont.restriccion.validaM(m))
            {
                cont.t = t;
                cont.n = n;
                cont.m = m;

                

                resultado = true;

            }
            else
            {
                resultado = false;
            }
            return resultado;
        }

        [WebMethod]
        public static string getResult() {
            string resultado = "";

            foreach (double d in cont.resultado) {
                resultado = resultado + d + ",";
            }
            return resultado;
        }
    }
}