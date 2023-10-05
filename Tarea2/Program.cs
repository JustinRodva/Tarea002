using System;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precio = 0;
            int cantidad = 0;
            int opcion = 0;

            do
            {
                Console.WriteLine("*************");
                Console.WriteLine("1-Ejercicio 1");
                Console.WriteLine("2-Ejercicio 2");
                Console.WriteLine("3-Ejercicio 3");
                Console.WriteLine("4-Salir");
                Console.WriteLine("Digite su opción");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Ejercicio1(); break;
                    case 2: Ejercicio2(); break;
                    case 3: Ejercicio3(); break;
                    case 4:
                        Console.WriteLine("Muchas gracias");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción incorrecta");
                        Console.ReadLine();
                        break;
                }

            } while (opcion != 4);

            Console.ReadLine();
        }

        static void Ejercicio1()
        {
            Console.WriteLine("Ejercicio 1");
            int cantidad = 0;
            float precio = 0;

            Console.Write("Digite la cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            Console.Write("Digite el precio: ");
            precio = float.Parse(Console.ReadLine());

            if (cantidad == 1)
            {
                Console.WriteLine($"El precio de la camisa es de {cantidad * precio}");
            }
            else if (cantidad >= 2 && cantidad <= 5)
            {
                Console.WriteLine($"El precio de la camisa es de {(cantidad * precio) * 0.85f} con descuento de 15%");
            }
            else if (cantidad > 5)
            {
                Console.WriteLine($"El precio de la camisa es de {(cantidad * precio) * 0.80f} con descuento de 20%");
            }
        }

        static void Ejercicio2()
        {
            Console.WriteLine("Ejercicio 2");

            string carnet, nombre;
            float quiz1, quiz2, quiz3, tarea1, tarea2, tarea3, examen1, examen2, examen3;
            float promedioFinal = 0;

            Console.Write("Ingrese el carnet: ");
            carnet = Console.ReadLine();
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese la nota del quiz 1: ");
            quiz1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota del quiz 2: ");
            quiz2 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota del quiz 3: ");
            quiz3 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota de la tarea 1: ");
            tarea1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota de la tarea 2: ");
            tarea2 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota de la tarea 3: ");
            tarea3 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota del examen 1: ");
            examen1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota del examen 2: ");
            examen2 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota del examen 3: ");
            examen3 = float.Parse(Console.ReadLine());
         
            float porcentajeQuices = ((quiz1 + quiz2 + quiz3) / 30) * 25;
            float porcentajeTareas = ((tarea1 + tarea2 + tarea3) / 30) * 30;
            float porcentajeExamenes = ((examen1 + examen2 + examen3) / 90) * 45;
            promedioFinal = (int)(porcentajeQuices + porcentajeTareas + porcentajeExamenes);



            Console.WriteLine("Carnet: " + carnet);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Porcentaje de Quices: " + porcentajeQuices + "%");
            Console.WriteLine("Porcentaje de Tareas: " + porcentajeTareas + "%");
            Console.WriteLine("Porcentaje de Examenes: " + porcentajeExamenes + "%");
            Console.WriteLine("Promedio Final: " + promedioFinal);



            if (promedioFinal >= 70)
            {
                Console.WriteLine("Condición: Aprobado");
            }
            else if (promedioFinal >= 50 && promedioFinal < 70)
            {
                Console.WriteLine("Condición: Aplazado");
            }
            else
            {
                Console.WriteLine("Condición: Reprobado");
            }
        }

        static void Ejercicio3()
        {
            Console.WriteLine("Ejercicio 3");

            Console.Write("Ingrese la cantidad de productos: ");
            int cantidadProductos = int.Parse(Console.ReadLine());

            double precioPorProducto;

            if (cantidadProductos <= 10)
            {
                precioPorProducto = 20.0;
            }
            else
            {
                precioPorProducto = 15.0;
            }

            double total = cantidadProductos * precioPorProducto;

            Console.WriteLine($"El precio por producto es de ${precioPorProducto}");
            Console.WriteLine($"El total a pagar es de ${total}");
        }
    }
}
