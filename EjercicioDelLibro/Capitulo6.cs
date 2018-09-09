using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDelLibro
{
    class Capitulo6
    {
        ///Ejercicio 1,2,3,4
        public void Ejercicio()
        {
            
            int cantidad = 0; 
            int salones = 0; 
            int n = 0; 
            int m = 0; 
            string valor = " ";
       
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f; 
            float maxima = 0.0f; 
            
            Console.WriteLine("Dame la cantidad de salones");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);
        
            float[][] calif = new float[salones][];
            
            for (n = 0; n < salones; n++) 
            {
                Console.WriteLine("Dame la cantidad de  alumnos para el salon ");
                valor = Console.ReadLine();
                cantidad = Convert.ToInt32(valor);
              
                calif[n] = new float[cantidad];
            }
           
            for (n = 0; n < salones; n++) 
            {
                Console.WriteLine("Salon {0}", n);
                for (m = 0; m < calif[n].GetLength(0); m++) 
                {
                    Console.Write("Dame la calificación ");
                    valor = Console.ReadLine();
                    calif[n][m] = Convert.ToSingle(valor);
                }
            }
            
            Console.WriteLine("—— Información ——");
            for (n = 0; n < salones; n++) 
            {
                Console.WriteLine("Salon {0}", n);
                for (m = 0; m < calif[n].GetLength(0); m++) 
                {
                    Console.WriteLine("El alumno {0} tiene {1} ", m, calif[n][m]);
                }
            }

            
            for (n = 0; n < salones; n++) 
            {
                for (m = 0; m < cantidad; m++)
                {
                    suma += calif[n][m];

                }

            }
            promedio = suma / (cantidad * salones);

           
            for (n = 0; n < salones; n++)
            {
                for (m = 0; m < cantidad; m++)
                {
                    if (calif[n][m] < minima)
                    {
                        minima = calif[n][m];
                    }
                }

            }

            
            for (n = 0; n < salones; n++)
            {
                for (m = 0; m < cantidad; m++)
                {
                    if (calif[n][m] > maxima)
                    {
                        maxima = calif[n][m];
                    }
                }

            }

            Console.WriteLine("El Promedio es {0}", promedio);
            Console.WriteLine("La calificacion minima es {0}", minima);
            Console.WriteLine("La calificacion maxima es {0}", maxima);
            Console.ReadKey();
        }
        //Un programa que pase un arreglo jagged como parámetro a una función.
        public void ejercicio6()
        {
            int[] nota = new int[6];
            int num = 0;
            for (num = 0; num < 6; num++)
            {
                Console.WriteLine("Digite un numero");
                nota[num] = Convert.ToInt32(Console.ReadLine());
            }

            ArregloFuncion(nota);
        }

        public void ArregloFuncion(int[] arreglo)
        {
            int num = 0;
            for (num = 0; num < 5; num++)
            {
                Console.WriteLine("El numero del arreglo es{0}:", arreglo[num]);
                Console.ReadLine();
            }

        }
    }
}
