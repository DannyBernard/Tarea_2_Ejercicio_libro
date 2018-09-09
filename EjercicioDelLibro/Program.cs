using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDelLibro
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Capitulo5 c5 = new Capitulo5();
            Capitulo6 c6 = new Capitulo6();
            Capitulo7 c7 = new Capitulo7();
            Capitulo8 c8 = new Capitulo8();

            Console.Write("Menu \n" +
                "1. Capitulo 5 ");
            int op=0;
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    {
                        c5.Menu();
                    break;
                    }
                case 2:
                    {
                        c6.ejercicio6();
                        break;
                    }

                case 3:
                    {
                        c7.Menu();
                        break;
                    }
                case 4:
                    {
                        c8.Menu();
                        break;
                    }
            }
          
   

        }
    }
}
