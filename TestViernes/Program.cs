using System;

namespace TestViernes
{
    class Program
    {
        static void Main(string[] args)
        {
            // comentar y descomentar los ej, ya que no hay menu
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            Ejercicio4();
        }

        static void Ejercicio1()
        {
            try
            {
                // 1) Dadas dos variables numéricas A y B, que el usuario debe teclear, se pide realizar un algoritmo que intercambie los valores de ambas variables y muestre cuánto valen al final las dos variables (recuerda la asignación).
                Console.WriteLine("Escriba el primer valor (entero)");
                var a = Console.ReadLine();

                Console.WriteLine("Escriba el segundo valor (entero)");
                var b = Console.ReadLine();

                var total = int.Parse(a) + int.Parse(b);

                Console.WriteLine($"Primer valor: {b}, segundo valor: {a}, valor final de las dos: {b + a}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Los valores deben ser enteros");
                Ejercicio1();
            }
        }

        static void Ejercicio2()
        {
            try
            {
                // 2) Algoritmo que lea dos números y nos diga cuál de ellos es mayor o bien si son iguales (recuerda usar la estructura condicional SI).
                Console.WriteLine("Escriba el primer valor (entero)");
                var a = int.Parse(Console.ReadLine());

                Console.WriteLine("Escriba el segundo valor (entero)");
                var b =  int.Parse(Console.ReadLine());

                var mayor = a > b ? a : b;

                Console.WriteLine($"El mayor es {mayor}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Los valores deben ser enteros");
                Ejercicio2();
            }
        }

        static void Ejercicio3()
        {
            // Algoritmo que lea tres números distintos y nos diga cuál de ellos es el mayor (recuerda usar la estructura condicional Si y los operadores lógicos).

            try
            {
                // 2) Algoritmo que lea dos números y nos diga cuál de ellos es mayor o bien si son iguales (recuerda usar la estructura condicional SI).
                Console.WriteLine("Escriba el primer valor (entero)");
                var a = int.Parse(Console.ReadLine());

                Console.WriteLine("Escriba el segundo valor (entero)");
                var b = int.Parse(Console.ReadLine());

                Console.WriteLine("Escriba el tercer valor (entero)");
                var c = int.Parse(Console.ReadLine());

                int mayor = 0;

                if (a > b)
                {
                    mayor = a;
                } else
                {
                    mayor = b;
                }

                if(c > mayor)
                {
                    mayor = c;
                }

                Console.WriteLine($"El mayor es {mayor}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Los valores deben ser enteros");
                Ejercicio3();
            }
        }

        static void Ejercicio4()
        {
            // Realizar un algoritmo que dado un número entero, visualice en pantalla si es par o impar. En el caso de ser 0, debe visualizar “el número no es par ni impar” (para que un número sea par, se debe dividir entre dos y que su resto sea 0).
            try
            {
                var numero = int.Parse(Console.ReadLine());

                Console.WriteLine((numero % 2 == 0 ? "Es par" : "Es impar"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Los valores deben ser enteros");
                Ejercicio4();
            }
        }
    }
}
