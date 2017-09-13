using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 7; //NUMEROS: 3 4 5 10 8 2 1
            int numero;
            int contador = 0;
            bool flag = true;
            int max = 0; 
            int min = 0; 
            int cantidadPares = 0; 
            int ultimoImpar = 0;
            int primerPar = 0; 
            int lugarDelPrimerPar = 0; 
            int lugarDelUltimoImpar = 0; 
            int suma = 0; 
            float promedio = 0; 

            while (contador < cant)
            {
                contador++;

                Console.WriteLine("\nIngrese un numero: ");

                while(!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Error, ingrese solo numeros: ");
                }

                if (flag) //calcula primer par
                {
                    if (numero % 2 == 0)
                    {
                        primerPar = numero;
                        lugarDelPrimerPar = contador;
                        flag = false;
                    }
                }

                if (numero % 2 != 0)
                {
                    lugarDelUltimoImpar = contador;
                    ultimoImpar = numero;
                }

                if (numero % 2 == 0) //calcula cantidad de pares
                {
                    cantidadPares++;
                }

                

                if (contador == 1) //calcula maximo y minimo
                {
                    max = numero;
                    min = numero;
                }
                else
                {
                     if(numero > max)
                     {
                         max = numero;
                     }

                     if(numero < min)
                     {
                         min = numero;
                     }
                }

                suma += numero; //calcula la suma


            }

            promedio = suma / contador; //hace el promedio

            Console.WriteLine("Numero maximo ingresado: {0}\nNumero minimo ingresado: {1}\nSuma: {2}\nPromedio: {3}\nPrimer numero par: {4}\nCantidad de numeros pares: {5}\nLugar del primer par: {6}\nLugar del ultimo impar: {7}\nUltimo impar: {8}", max, min, suma, promedio, primerPar, cantidadPares, lugarDelPrimerPar, lugarDelUltimoImpar, ultimoImpar);
            Console.Read();
        }
    }
}
