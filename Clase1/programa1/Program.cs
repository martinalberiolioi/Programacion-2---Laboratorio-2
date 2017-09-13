using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno;
            int numeroDos;
            int resultado;
                    //string dato;
                    //bool esNumero;

            Console.Write("Ingrese el primer numero: ");
                    //dato = Console.ReadLine();

            while(!int.TryParse(Console.ReadLine(), out numeroUno))
            {
                Console.Write("Error, reingrese numero: ");
            }

                    //numeroUno = int.Parse(dato); //parsea de string a int
                    //esNumero = int.TryParse(dato, out numeroUno);

                    //en Dato recibe el dato a parsear, y si lo logra hacer, devuelve 1 (o true)
                    //a esNumero y a numeroUno devuelve el dato parseado

            Console.Write("Ingrese el segundo numero: ");
                    //dato = Console.ReadLine();

               
            while(!int.TryParse(Console.ReadLine(), out numeroDos))
            {
                Console.Write("Error, reingrese numero: ");
            }

                    //numeroDos = int.Parse(dato); //parsea de string a int
                    // esNumero = int.TryParse(dato, out numeroDos);


            resultado = numeroUno + numeroDos;

            Console.Write("El resultado es: {0}", resultado);
                    //Console.Write("El resultado es: " + resultado); OTRA FORMA DE HACERLO

            Console.Read(); //el console.Read espera ENTER
        }
    }
}
