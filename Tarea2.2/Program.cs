using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string carnet, nombre;
            int q1, q2, q3, tarea1, tarea2, tarea3, exam1, exam2, exam3;
            double quices, tareas, examenes, final;
            string condicion;
            Console.WriteLine("Ingrese el carnet del estudiante: ");
            carnet = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del estudiante: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la nota de Quiz1");
            q1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de Quiz2");
            q2=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de Quiz3");
            q3=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de Tarea1");
            tarea1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de Tarea2");
            tarea2=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de Tarea3");
            tarea3=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de Examen1");
            exam1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de Examen2");
            exam2=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de Examen3");
            exam3=int.Parse(Console.ReadLine());

            quices = (q1 * 0.33 + q2 * 0.33 + q3 * 0.33)*0.25;
            tareas = (tarea1 * 0.33 + tarea2 * 0.33 + tarea3 * 0.33) * 0.30;
            examenes = (exam1 * 0.33 + exam2 * 0.33 + exam3 * 0.33) * 0.45;
            final=quices+tareas+examenes;

            if (final >=70)
            {
                condicion = "Aprobado";
            }
            else if (final >= 50)
            {
                condicion = "Aplazado";
            }
            else
            {
                condicion = "Reprobado";
            }
            Console.Clear();
            Console.WriteLine($"El estudiante {nombre} con Carnet {carnet}, tiene las siguientes notas:\nQuices: {quices}\nTareas: {tareas}\nExamenes: {examenes}\nPromedio Final {final}\nSu condicion es: {condicion}");
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }

    }
}
