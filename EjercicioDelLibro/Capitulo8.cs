using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDelLibro
{
    class Capitulo8
    {
        //Hacer un programa que muestre la hora del día en formato AM/FM seguida del año, el día y el mes actual.
        public void Ejercicio8_3()
        {
            string hora, fecha;

            hora = DateTime.Now.ToString("h:mm:ss tt");
            fecha = DateTime.Now.ToString("yyy/dd/MM");
            Console.WriteLine("La Hora es:{0}", hora);
            Console.WriteLine("La Fecha es:{0}", fecha);
            Console.ReadKey();


        }
       //Hacer un programa que le solicite al usuario dos cadenas y luego las muestre en orden alfabético.
        public void Ejercicio8_5()

        {

            ArrayList cadenas = new ArrayList();

            Console.WriteLine("Digite la Cadena");
            string cad = Console.ReadLine();
            cadenas.Add(cad);

            Console.WriteLine("Digite la Cadena");
            string cade = Console.ReadLine();
            cadenas.Add(cade);
            cadenas.Sort();

            foreach (string caden in cadenas)
            {
                Console.WriteLine("{0}", caden);
            }
            Console.ReadKey();
        }
        public void Menu()
        {
            int op;
            Console.WriteLine("Menu\n" +
                "1.Ejercicio8_3\n" +
                "2.Ejercicio8_5\n" +
                "Elija una Opcion: ");
            ;
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    {
                        Ejercicio8_3();
                        break;
                    }
                case 2:
                    {
                        Ejercicio8_5();
                        break;
                    }
            }

        }
    }
}
