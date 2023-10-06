using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArreglos1
{
    internal class Metodos
    {
        public void MostrarArreglos()
        {
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Ingresa los numeros que quieras: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int z = 0; z < a.Length; z++)
            {
                Console.WriteLine($"Ingresaste {a[z]}");
            }
        }

        public void MostrarMedia() 
        {
            float [] a = new float[10];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Ingresa un número");
                a[i] = float.Parse(Console.ReadLine());
            }
            float media = (a[0] + a[1] + a[2] + a[3] + a[4] + a[5] + a[6] + a[7] + a[8] + a[9] )/10;
            Console.WriteLine(media);
        }
        public void MostrarMultiplos()
        {
            Console.WriteLine("De cuanto sera la cadena?");
            int x = int.Parse(Console.ReadLine());
            int[]a = new int[x];
            Console.WriteLine("Por cuanto se multiplicara?");
            int multiplos = int.Parse(Console.ReadLine());

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = multiplos * (i+1);
                Console.WriteLine(a[i]);
            }
            

        }
        public void MostrarNombresConLongitud()
        {
            Console.WriteLine("Elige el tamaño del arreglo");
            int tamaño = int.Parse(Console.ReadLine());
            string[] nombre = new string[tamaño];
            int[] nombreLongitud = new int[tamaño];
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre");
                nombre[i] = Console.ReadLine();
            }
            for (int i = 0; i < nombreLongitud.Length; i++) 
            {
                nombreLongitud[i] = nombre[i].Length;
            }
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine($"El nombre {nombre[i]} tiene {nombreLongitud[i]} letras");
            }
        }

    }
}
