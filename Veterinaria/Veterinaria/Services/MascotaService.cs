using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using Veterinaria.Models;

namespace Veterinaria.Services
{
    public class MascotaService
    {
        private List<Mascota> mascotas = new List<Mascota>();
        

        public void RegistrarMascota()
        {
            Mascota mascota = new Mascota();

            mascota.Id = Guid.NewGuid();

            Console.Write("Ingrese el nombre de la mascota:");
            mascota.Nombre = Console.ReadLine();

            Console.Write("Ingrese la Especie: ");
            mascota.Especie = Console.ReadLine();

            Console.Write("Ingrese la Raza: ");
            mascota.Raza = Console.ReadLine();

            Console.Write("Ingrese la Edad: ");
            mascota.Edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el Color: ");
            mascota.Color = Console.ReadLine();

            Console.Write("Ingrese el Sexo: ");
            mascota.Sexo = Console.ReadLine();

            Console.Write("Estado de salud: ");
            mascota.EstadoSalud = Console.ReadLine();

            Console.Write("Fecha de nacimiento (dd/mm/aaaa): ");
            DateTime fecha;
            mascota.FechaNacimiento = DateTime.Parse(Console.ReadLine());
          
            
            mascotas.Add(mascota);
            Console.WriteLine("Registro de mascota exitoso.");

        }
        public void MostrarMascota()
        {
            if (mascotas.Count == 0)
            {
                Console.WriteLine("No hay mascotas registradas.");
                return;
            }
            foreach (Mascota mascota in mascotas)
            {
                
               
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"Id: {mascota.Id}");
                    Console.WriteLine($"Nombre: {mascota.Nombre}");
                    Console.WriteLine($"Especie: {mascota.Especie}");
                    Console.WriteLine($"Raza: {mascota.Raza}");
                    Console.WriteLine($"Edad: {mascota.Edad}");
                    Console.WriteLine($"Color: {mascota.Color}");
                    Console.WriteLine($"Sexo: {mascota.Sexo}");
                    Console.WriteLine($"Estado de Salud: {mascota.EstadoSalud}");
                    Console.WriteLine($"Fecha de Nacimiento: {mascota.FechaNacimiento.ToShortDateString()}");
                    Console.WriteLine(" ");
                }
            }
        }

        public void EliminarMascota()
        {
            Console.Write("Ingrese el nombre de la Mascota:");
            String?nombre = Console.ReadLine();

            foreach (Mascota mascota in mascotas)
            {
                if (mascota.Nombre == nombre)
                {
                    mascotas.Remove(mascota);
                    Console.WriteLine("Mascota eliminada.");
                    return;
                }
            }
            Console.WriteLine("No se encontro la Mascota:"); 
        }

        public void Salir()
        {
            Console.WriteLine("Gracias por utilizar la APP de Justin:");
        }
    }  
}
