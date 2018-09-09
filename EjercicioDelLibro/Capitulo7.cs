using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDelLibro
{
    class Capitulo7
    {
        //Promedio, calificación máxima y mínima en un salón de clases usando el ArrayList
        public void Ejercicio7_1()
        {
            int calificaciones;
            int promedio = 0, maxima = 0, minima = 0;
            string calif;
            ArrayList clase = new ArrayList(); ;
            Console.WriteLine("Cantidad de Estudiantes: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x < n; x++)
            {
                Console.WriteLine("Digite calificaciones");
                calif = Console.ReadLine();
                calificaciones = Convert.ToInt32(calif);
                if (calificaciones == 0)
                    break;
                clase.Add(calificaciones);

            }

            foreach (int datos in clase)
            {

                promedio += datos;
                if (minima == 0)
                    minima = datos;
                if (datos > maxima)
                    maxima = datos;
                if (minima > datos)
                    minima = datos;
            }

            Console.WriteLine("Promedio:{0} ", promedio);
            Console.WriteLine("Maximo:{0} ", maxima);
            Console.WriteLine("Menor:{0} ", minima);
            Console.ReadKey();
        }
       //Hacer un programa que funcione como un diccionario, con palabra y definición, usando el Hashtable.
        public void Ejercicio7_2()
        {
            Hashtable Dic = new Hashtable();
            string palabras;

            Dic.Add("variable", "es un valor que puede variar");
            Dic.Add("palabras reservadas", "parablar unica del lleguaje que no se pueden usar como identificador");
            Dic.Add("java", "leguaje de programacion orientado a objetos");

            Console.WriteLine("Palabras: Lunes, Enero y anos");
            Console.WriteLine("Eliga una palabras");
            palabras = Console.ReadLine();
            foreach (DictionaryEntry pal in Dic)
            {
                if (palabras == (string)pal.Key)
                {
                    Console.WriteLine("La palabras definida {0} es: {1}", pal.Key, pal.Value);
                    break;
                }
            }
            Console.ReadKey();

        }

      
        public struct agendas
        {
            public string nom;
            public string tel;
        }

        //agenda telefónica y que guarde el nombre de la persona y su número telefónico.
        public void Ejercicio7_5()
        {
            ArrayList Ang = new ArrayList();
            agendas c = new agendas();

            for(int i=0; ;i++)
            {
                Console.WriteLine("Ingrese el nombre");
                c.nom = Console.ReadLine();
                Console.WriteLine("Ingrese el numero de telefono");
                c.tel = (Console.ReadLine());

                Ang.Add(c);
                break;
            }

            foreach(agendas cont in Ang)
            {
                Console.Write("Contacto:{0} {1} {2} {3}", "Nombre:", cont.nom, "Numero", cont.tel);
            }

            Console.ReadKey();

        }
        public void Menu()
        {
            int op;
            Console.WriteLine("Menu\n" +
                "1.Ejercicio7_1\n" +
                "2.Ejercicio7_2\n" +
                "3.Ejercicio7_5\n" +
                "Elija una Opcion: ");
            ;
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    {
                        Ejercicio7_1();
                        break;
                    }
                case 2:
                    {
                        Ejercicio7_2();
                        break;
                    }
                case 3:
                    {
                        Ejercicio7_5();
                        break;
                    }
            }

        }
    }
}
