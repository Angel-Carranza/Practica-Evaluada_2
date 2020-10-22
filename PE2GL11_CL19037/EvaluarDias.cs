using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2GL11_CL19037
{
    //Guia: -
    // Ejercicio: -
    //Practica Evaluada 2
    // Fecha: del 21 al 23 de octubre de 2020
    // Autor: Carranza López, Angel Adan
    // Carnet: CL19037
    // GL: 11
    // Instructor: Ing. Ruben Asencio
    class EvaluarDias
    {
        //Atributos
        double dia, frio;
        int caliente, conteoFrio;

        //Propiedades
        public double Dia
        {
            get
            {
                return dia;
            }

            set
            {
                dia = value;
            }
        }
        public int Caliente
        {
            get
            {
                return caliente;
            }

            set
            {
                caliente = value;
            }
        }
        public double Frio
        {
            get
            {
                return frio;
            }

            set
            {
                frio = value;
            }
        }
        public int ConteoFrio
        {
            get
            {
                return conteoFrio;
            }

            set
            {
                conteoFrio = value;
            }
        }

        //Metodos
        //Metodo para evaluar si es un dia frio o caluroso
        public string Condicion()
        {
            string condicion = null;
            if (dia < 30)
            {
                condicion = "Frio";
            }
            else
                if (dia >= 30)
            {
                condicion = "Caluroso";
            }
            return condicion;
        }
        //Metodo para hacer un conteo de dias calurosos a la semana
        public int ConteoCaluroso()
        {
            int conteo = 0;
            if (dia >= 30)
            {
                conteo = caliente + 1;
            }else
            {
                conteo = caliente;
            }
            return conteo;
        }
        //metodo para calcular el promedio de temperaturas menores a 25°
        public double PromedioFrio()
        {
            double promedio;
            promedio = frio / conteoFrio;
            return promedio;
        }
    }
}
