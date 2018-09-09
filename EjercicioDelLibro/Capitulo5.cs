using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDelLibro
{
    public class Capitulo5
    {

        //Ejercicio 4  funcion para calcular el factorial
        public void Factorial()
        {
            int numero;
            int resultado=1;
            int i;
            Console.WriteLine("Ejercicio 4  funcion para calcular el factorial \n");
            Console.WriteLine("Digite un numero para saber su factorial: ");
            numero = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= numero; i++)
            {
                resultado *= i;
            }
            Console.WriteLine("El factorial de  "+ numero+" es: " + resultado);
            Console.Read();
        }
        public void Ejercico5_4()
        {
            Factorial();
        }
        //Ejercicio 5 digite el numero (5) y devolvera el numero en letra
        public String NombreDeNumero()
        {
            int num;
            string numero= "Cinco";
            string otro = "Digite el numero que es: ";
            Console.WriteLine("Ejercicio 5 digite el numero (5) y devolvera el numero en letra ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 5)
            {

                Console.WriteLine( numero);
                Console.ReadKey();
            }
            else

                Console.ReadKey();
            return otro;
        }

          public void Ejercico5_5()
        {
            NombreDeNumero();
            
         
        }

        public void Menu()
        {
            int op;
            Console.WriteLine("Menu\n" +
                "1.Ejercicio5_4\n" +
                "2.Ejercicio5_5\n" +
                "Elija una Opcion: ");
            ;
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    {
                        Ejercico5_4();
                        break;
                    }
                case 2:
                    {
                        Ejercico5_5();
                        break;
                    }
            }

        }
        
    }
}
