using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayEnteros;
            int[,] matrizEnteros; //declaracion de matriz

            arrayEnteros = new int[3];
            matrizEnteros = new int[2, 3]; //inicializa matriz y le da tamaño 2x3

            arrayEnteros[0] = 102;
            arrayEnteros[1] = 53;


            Console.Write("ARRAY ORIGINAL:\n{0}\n{1}\n\n", arrayEnteros[0], arrayEnteros[1]);

            Array.Sort(arrayEnteros, 0, 2);
            //array, donde empieza, hasta donde va (ascendente)
            Console.Write("USO DE SORT ASCENDENTE:\n{0}\n{1}\n\n", arrayEnteros[0], arrayEnteros[1]);

            Array.Sort(arrayEnteros, 2, 0);
            //array, donde empieza, hasta donde va (descendente)
            Console.Write("USO DEL SORT DESCENDENTE:\n{0}\n{1}\n\n", arrayEnteros[0], arrayEnteros[1]);

            Console.Write("USO DEL FOREACH:\n");
            foreach (int i in arrayEnteros) //sirve para trabajar con el tamaño exacto del array (como un For pero sin indices)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

        }
    }
}
