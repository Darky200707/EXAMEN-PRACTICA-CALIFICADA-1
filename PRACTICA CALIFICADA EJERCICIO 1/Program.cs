using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_CALIFICADA_EJERCICIO_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int aprob = 0, desaprob = 0, exo = 0, cantAlumnos,nota;
            Console.WriteLine("Ingrese la cantidad de alumnos: ");
            cantAlumnos = int.Parse(Console.ReadLine());
            if (cantAlumnos > 0)
            {
                for (int i = 1; i <= cantAlumnos; i++)
                {
                    Console.WriteLine("Ingrese la nota del alumno " + i + " (0 a 20): ");
                    nota = int.Parse(Console.ReadLine());

                    if (nota >= 18)
                    {
                        exo = exo + 1;
                        aprob = aprob + 1;
                    }
                    else if (nota >= 10)
                    {
                        aprob = aprob + 1;
                    }
                    else
                        desaprob = desaprob + 1;
                }
                Console.WriteLine("La cantidad de alumnos aprobados es de:" + aprob);
                Console.WriteLine("La cantidad de alumnos desaprobados es de:" + desaprob);
                Console.WriteLine("La cantidad de alumnos exonerados es de:" + exo);
            }
            else
                Console.WriteLine("ERROR AL INGRESAR LOS DATOS");
            //CAMBIOS PARA EL GITHUB
            //IGNORAR
        }
    }
}
