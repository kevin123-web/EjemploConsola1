﻿using System;

namespace MiPrimeraConsola1
{
    class Program
    {
        public static void Main(string[] args)
        {
            SaludoInicial(args);
            Console.WriteLine("Bienvenido");

            Console.Write("Ingrese su nombre: ");
            var nombre = Console.ReadLine();

            int edad = IngresarEdad();
            
            Console.Write("Ingrese su peso: ");
            float peso = float.Parse(Console.ReadLine());
          

            Console.Write("Ingrese su cedula: ");
            var cedula = Console.ReadLine();

            Console.Write("Ingrese su numero celular: ");
            string celular = Console.ReadLine();
            int celular1 = int.Parse(celular);

            Console.Write("Ingrese su altura: ");
            var altura = Console.ReadLine();

            Console.Write("Ingrese el numero de automoviles posee: ");
            string automoviles = Console.ReadLine();
            int automoviles1 = int.Parse(automoviles);

            Console.Write("Tienes hijos tienes? ");
            bool hijos = Console.ReadLine().ToUpper()=="SI";

            Console.Write("Cuantas mascotas tiene? ");
            string mascotas = Console.ReadLine();
            int mascotas1 = int.Parse(mascotas);

            Console.Write("Cuantas computadoras tiene?");
            string computadoras = Console.ReadLine();
            int computadoras1 = int.Parse(computadoras);

            var persona = new Persona
            {
                Nombre = nombre,
                edad = edad,
                peso = peso,
                cedula = cedula,
                celular = celular1,
                altura = altura,
                automoviles = automoviles1,
                hijos = hijos,
                mascotas = mascotas1,
                computadoras = computadoras1,
            };

            Console.WriteLine("Su información es la siguiente... ");
            Console.Write($"Nombre: {persona.Nombre} ");
            Console.Write($"Su edad es: {persona.edad} ");
            Console.Write($"Su Peso es: {persona.peso} ");
            Console.Write($"Su cédula es: {persona.cedula} ");
            Console.Write($"Su celular es: {persona.celular} ");
            Console.Write($"Su altura es: {persona.altura} ");
            Console.Write($"Su automoviles es: {persona.automoviles} ");
            Console.Write($"Tienes hijos?: {persona.hijos} ");
            Console.Write($"El numero de mascotas que tiene es: {persona.mascotas} " );
            Console.Write($"Su numero de computadoras es: {persona.computadoras} ");
            Console.Write("Muchas Gracias por su atención vuelva pronto , \nPrecione cualquier tecla para terminar. ");
            Console.ReadKey();
        }

        public static void SaludoInicial(string[] args)
        {

            if (args.Length > 0)
            {
                Console.WriteLine("hola {0} {1} {0} " + args[0], args[1]);
            }
            else
            {
                Console.WriteLine("Hola Desconocido ");
            }
            Console.WriteLine("Como estas?");
            var estado = Console.ReadLine();
            Console.WriteLine("mmmm, entiendo!");
            var date = new DateTime();
            Console.WriteLine(date);
        }

        static int IngresarEdad()
        {
            Console.Write("Ingrese su edad: ");
            int edad1;
            while (true)
            {
                string edad = Console.ReadLine();

                if (!int.TryParse(edad, out edad1))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };
            };
            return edad1;
        }
 
    }
}
