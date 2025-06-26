using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Servicio
    {
        

        private int acumulador;
        public int contador;
        public int maximo;
        public int minimo;

        public Servicio()
        {
            acumulador = 0;
            contador = 0;
            maximo = 0;
            minimo = 0;
        }

        public double CalcularPromedio()
        {
            double promedio;
            promedio = 1.0 * ((double)acumulador / contador);
            return promedio;
        }

        public void RegistrarValor(int valor)
        {
            acumulador += valor;
            contador++;

            if (contador == 1)
            {
                maximo = valor;
                minimo = valor;
            }
            else
            {
                if (valor > maximo)
                {
                    maximo = valor;
                }
                if (valor < minimo)
                {
                    minimo = valor;
                }
            }
        }
        
    }


}
