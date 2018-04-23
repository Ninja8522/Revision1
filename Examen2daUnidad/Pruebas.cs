using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2daUnidad
{
    class Pruebas
    {
        public double suma(double[] numeros)
        {
            double suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                suma = suma + numeros[i];
            }
            return suma;
        }
        public double promedio(double[] numeros)
        {
            double suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                suma = suma + numeros[i];
            }
            return (suma / numeros.Length);
        }
        public double moda(double[] numeros)
        {
            double numero = 0;
            double[] aux = new double[10];
            int pos = 0;
            double mayor = 0;
            int posicionmayor = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                aux[i] = 0;
            }
            for (int x = 0; x < numeros.Length; x++)
            {
                numero = numeros[x];
                pos = x;
                for (int y = 0; y < numeros.Length; y++)
                {
                    if (numeros[y] == numero)
                    {
                        aux[pos]++;
                    }
                }
            }
            mayor = aux[0];
            posicionmayor = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (aux[i] > mayor)
                {
                    posicionmayor = i;
                    mayor = aux[i];
                }
            }
            return numeros[posicionmayor];
        }
        public double mediana(double[] numeros)
        {

            return (numeros[numeros.Length / 2]);
        }
    }
}

