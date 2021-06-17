using System;

namespace MiPrimeraConsola1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.Write("Ingrese su nombre: ");
            var nombre = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            string edad = Console.ReadLine();
            int edad1 = int.Parse(edad);
            Console.Write("Ingrese su peso: ");
            float peso = float.Parse(Console.ReadLine());
            var persona = new Persona();
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
            Console.Write("Cuantos hijos tienes? ");
            string hijos = Console.ReadLine();
            int hijos1 = int.Parse(hijos);
            Console.Write("Cuantas mascotas tiene? ");
            string mascotas = Console.ReadLine();
            int mascotas1 = int.Parse(mascotas);
            Console.Write("Cuantas computadoras tiene?");
            string computadoras = Console.ReadLine();
            int computadoras1 = int.Parse(computadoras);


            persona.nombre = nombre;
            persona.edad = edad1;
            persona.peso = peso;
            persona.cedula = cedula;
            persona.celular = celular1;
            persona.altura = altura;
            persona.automoviles = automoviles1;
            persona.hijos = hijos1;
            persona.mascotas = mascotas1;
            persona.computadoras = computadoras1;


            Console.WriteLine("Usted ingreso lo siguiente... ");
            Console.Write("Nombre: " + persona.nombre + "\n");
            Console.Write("Su edad es: " + persona.edad + "\n");
            Console.Write("Su Peso es : " + persona.peso + "\n");
            Console.Write("Su cédula es : " + persona.cedula + "\n");
            Console.Write("Su celular es : " + persona.celular + "\n");
            Console.Write("Su altura es : " + persona.altura + "\n");
            Console.Write("Su automoviles es : " + persona.automoviles + "\n");
            Console.Write("El numero de hijos que tiene es : " + persona.hijos + "\n");
            Console.Write("El numero de mascotas que tiene es : " + persona.mascotas + "\n");
            Console.Write("Su numero de computadoras es : " + persona.computadoras + "\n");
            Console.Write("Muchas Gracias por su atención vuelva pronto , \nPrecione cualquier tecla para terminar. ");
            Console.ReadKey();
        }
        public void Argumentos(string[] args)
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
        void SaludoInicial()
        {

        }
    }
}
