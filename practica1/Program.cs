using System;

namespace Practica_nro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Crear un proyecto de consola.Net Framework.
            //2. Crear la clase Telefono(recordemos que una clase va en un archivo nuevo; click derecho en el proyecto, agregar, class).
            //3. Agregale los siguientes atributos:
            //Modelo string.
            //Marca string.
            //NumeroTelefonico string.
            //CodigoOperador int (1, 2 o 3).
            //4. Agregale las propiedades correspondientes.Podés hacer el formato largo o el corto.
            //Modelo: solo lectura. Es decir, solo get.
            //Marca: solo lectura.
            //NumeroTelefonico: lectura y escritura.
            //CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.
            //5. Agregar Constructor que reciba Modelo y Marca.
            //6. Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
            //7. Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
            //8. Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
            //9. Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.

            Telefono t1 = new Telefono("S22", "Samsung");
            //Telefono t2 = new Telefono("13", "Iphone");
            //Telefono t3 = new Telefono("2","Nothing");

            Console.WriteLine("Marca: " + t1.Marca);
            Console.WriteLine("Modelo: " + t1.Modelo);
            Console.WriteLine("Ingrese su numero de telefono: ");
            t1.NumeroTelefonico = Console.ReadLine();
            Console.WriteLine("Ingrese codigo de operador: ");
            t1.CodigoOperador = int.Parse(Console.ReadLine());

            //Console.WriteLine("Marca: " + t2.Marca);
            //Console.WriteLine("Modelo: " + t2.Modelo);
            //Console.WriteLine("Ingrese su numero de telefono: ");
            //t2.NumeroTelefonico = Console.ReadLine();
            //Console.WriteLine("Ingrese codigo de operador: ");
            //t2.CodigoOperador = int.Parse(Console.ReadLine());

            //Console.WriteLine("Marca: " + t3.Marca);
            //Console.WriteLine("Modelo: " + t3.Modelo);
            //Console.WriteLine("Ingrese su numero de telefono: ");
            //t2.NumeroTelefonico = Console.ReadLine();
            //Console.WriteLine("Ingrese codigo de operador: ");
            //t3.CodigoOperador = int.Parse(Console.ReadLine());
            Console.WriteLine("Desea llamar? (s/n)");
            char op = char.Parse(Console.ReadLine());
            if (op == 's')
            {
                Console.WriteLine("Desea llamar a un contacto en especifico? (s/n)");
                op = char.Parse(Console.ReadLine());
                if (op == 's')
                {
                    Console.WriteLine("Ingrese el nombre del contacto: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine(t1.Llamar(nombre));
                }
                Console.WriteLine(t1.Llamar());
            }
            Console.WriteLine("Desea ver sus datos telefonicos? (s/n)");
            op = char.Parse(Console.ReadLine());
            if (op == 's')
            {
                Console.WriteLine("Nro telefonico: " + t1.NumeroTelefonico + "\nCodigo de operador: " + t1.CodigoOperador);
            }

        }
    }
}
