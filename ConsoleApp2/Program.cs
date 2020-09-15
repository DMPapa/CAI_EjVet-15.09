using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // NO SE HAN CONSIDERADO VALIDACIONES AL NO SER PARTE DE LA EJERCITACIÓN

            Veterinaria v = new Veterinaria("COPITOS DE PELO", "FALSA 123");

            List<Veterinarios> ListaVet = new List<Veterinarios>();
            
            ListaVet.Add(new Veterinarios("Ernesto Guevara", true, "mañana"));
            ListaVet.Add(new Veterinarios("Homero Simpson", true, "tarde"));
            ListaVet.Add(new Veterinarios("Paola Argento", true, "Vespertino"));

            List<Perros> ListaMascotas = new List<Perros>();
            ListaMascotas.Add(new Perros("Poochie", "mestizo", "Diego Papa"));
            ListaMascotas.Add(new Perros("Thor", "pitbull", "Mario Castañeda"));


            string Inicio = ("Bienvenido a la veterinaria " + v.GetName());
            Console.WriteLine(Inicio);
            Byte eleccion;
            do  {
                    string Inicio2 = ("\nseleccione opción (solo presione el número): \n\n1- Veterinarios \n2- Perros \n0- Salir \n");
                    Console.WriteLine(Inicio2);
                    eleccion = Convert.ToByte(Console.ReadLine());
                    Byte eleccion2;

                    switch (eleccion)
                    {
                        case 1:
                            Console.WriteLine("Seleccione que desea hacer: \n 1- Listar veterinarios \n 2- Agregar nuevo veterinario \n 3- Modificar estado \n 4- Modificar turno \n 5- Volver \n");
                            eleccion2 = Convert.ToByte(Console.ReadLine());
                            switch (eleccion2)
                            {
                                case 1:
                                    v.GetListaVet();
                                    break;
                                case 2:

                                    Veterinarios v1 = new Veterinarios("", true, "");
                                    Console.WriteLine("Ingrese Nombre del veterinario:");
                                    v1.Nombre = Console.ReadLine();
                                    Console.WriteLine("Ingrese turno: \n opciones: mañana - tarde - vespertino");
                                    v1.Horario = Console.ReadLine();
                                    ListaVet.Add(v1);
                                    break;
                                case 3:
                                    //horario
                                    break;
                                case 4:
                                    //turno
                                    break;
                                case 5:
                                break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("seleccione que desea hacer: \n 1- listar perros \n 2- Agregar nuevo perro \n 3- Agregar nueva visita \n 4- Volver \n");
                            eleccion2 = Convert.ToByte(Console.ReadLine());
                            switch (eleccion2)
                            {
                                case 1:
                                    Console.WriteLine(v.GetListaPerros());
                                    ;
                                    break;
                                case 2:

                                    Perros p1 = new Perros("", "", "");
                                    Console.WriteLine("\nIngrese nombre del perro:");
                                    p1.Nombre = Console.ReadLine();
                                    Console.WriteLine("\nIngrese raza:");
                                    p1.Raza = Console.ReadLine();
                                    Console.WriteLine("\nIngrese nombre del dueño:");
                                    p1.Dueño = Console.ReadLine();
                                    ListaMascotas.Add(p1);
                                    break;
                                case 3:
                                    Console.WriteLine("\nIngrese nombre del perro");
                                    string ingresousuario = Console.ReadLine();
                                    foreach (Perros perro in ListaMascotas)
                                    {
                                        if (perro.Nombre.ToUpper().Contains(ingresousuario.ToUpper()))
                                        {
                                            Console.WriteLine("\nIngrese comentarios de la visita: \nFormato: Fecha - Comentario");
                                            string ingresocomentario = Console.ReadLine();
                                            perro.NuevaVisita(ingresocomentario);
                                        }
                                    }
                                    break;
                                case 4:
                                break;
                            }
                            break;
                    }
                } while (eleccion != 0);
        }

    }
   
}


