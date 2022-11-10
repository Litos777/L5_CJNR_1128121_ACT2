using System;

namespace L5_CJNR_1128121_ACT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio No. 2");
            Console.WriteLine("Ingresar un numero del 1 al 7");
            Console.WriteLine("Para encontrar un dia de la semana");
            int gg;
            gg = Convert.ToInt32(Console.ReadLine());
            if (gg == 1)
            {
                Console.WriteLine("Lunes");
            }
            else if (gg == 2)
            {
                Console.WriteLine("Martes");
            }
            else if (gg == 3)
            {
                Console.WriteLine("Miercoles");
            }
            else if (gg == 4)
            {
                Console.WriteLine("Jueves");
            }
            else if (gg == 5)
            {
                Console.WriteLine("Viernes");
            }
            else if (gg == 6)
            {
                Console.WriteLine("Sabado");
            }
            else if (gg == 7)
            {
                Console.WriteLine("Domingo");
            }
        }
    }
}
