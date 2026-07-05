using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinaria.Models
{
    public class Mascota
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public string Color { get; set; }
        public string Sexo { get; set; }
        public string EstadoSalud { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public void Caminar()
        {
            Console.WriteLine($"{Nombre} está caminando.");
        }
        
        public void Comer()
        {
            Console.WriteLine($"{Nombre} está comiendo.");
        }
        
        public void Dormir()
        {
            Console.WriteLine($"{Nombre} está durmiendo.");
        }
        
        
    }   
}
