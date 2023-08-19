
using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Declaración de variables de tipo texto capturando desde consola
            string? nombre;
            string? apellido;

            //Declaración de variables de tipo texto desde código
            string? codigo_estudiantil = "U20231421";
            string? becado = "NO";

            //Declaración de variables de tipo enteras capturando desde consola
            int edad;

            //Declaración de variables de tipo enteras desde código
            int añoIngreso = 2023;
            int añoEgreso = 2024;

            //Declaración de variables de tipo double(decimales) capturando desde consola
            double mensualidad;

            //Declaración de variables de tipo double desde código
            double tranporte = 2.70;
            double alimentación = 2.50;

            //Declaración de variables de tipo time
            DateTime fechaActual = DateTime.Now;
            DateTime fechaEspecifica = new DateTime(2023, 8, 19 ,16, 20, 00);

            //Obtención de tados desde la terminal
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese su apellido: ");
            apellido = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese su mensualidad universitaria: ");
            mensualidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //Impresión de datos
            Console.WriteLine("****************************Fin de la impresión**********************************");
            Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("Su apellido es: " + apellido);
            Console.WriteLine("Su nombre codigo estudiantil es: " + codigo_estudiantil);
            Console.WriteLine("'¿Es becado?: " + becado);
            Console.WriteLine("Su edad es: " + edad);
            Console.WriteLine("Su año de ingreso fue: " + añoIngreso);
            Console.WriteLine("Su año de egreso sera: " + añoEgreso);
            Console.WriteLine("Su mensualidad universitaria es: " + mensualidad);
            Console.WriteLine("Su gasto diaro de transporte es: " + tranporte);
            Console.WriteLine("Su gasto diario de alimetación es: " + alimentación);
            Console.WriteLine("Fecha y tiempo de impreción de datos es: " + fechaActual);
            Console.WriteLine("La fecha que termina la prectica es: " + fechaEspecifica);
            Console.WriteLine("****************************Fin de la impresión**********************************");

           
            Console.WriteLine("****************FIN DE IMPRECIÓN******************");
            //APLICAIÓN DE FUNCIONES DE CADENA

            //Función de comparación cadenas de texto
            bool cadenaComparativa = nombre == apellido;

            //Función de minuscula
            string? funciónMinuscula1 = nombre.ToLower();
            string? funciónMinuscula2 = apellido.ToLower();

            //Función de mayuscula
            string? funciónMayuscula1 = nombre.ToUpper();
            string? funciónMayuscula2 = apellido.ToUpper();

            //Función de Concatenado 
            string? cadenaConcatenada = nombre + " " + apellido;

            //Función de tamaño de cadena
            int longitudCadeba1 = nombre.Length;
            int longitudCadena2 = apellido.Length;

            Console.WriteLine("Comparación: "+ cadenaComparativa);
            Console.WriteLine("Mayuscula Nombre y Apellido: " + funciónMayuscula1 + " " + funciónMayuscula2);
            Console.WriteLine("Minuscula Nombre y Apellido: " + funciónMinuscula1 + " " + funciónMinuscula2);
            Console.WriteLine("Concatenación: " + cadenaConcatenada);
            Console.WriteLine("La longitud de datos de nombre es: " + longitudCadeba1);
            Console.WriteLine("Longitud de datos de apelliod es: " + longitudCadena2);
            Console.WriteLine("****************FIN DE IMPRECIÓN******************");

        }
    }
}