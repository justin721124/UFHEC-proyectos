using Spectre.Console;
using Veterinaria.Services;

MascotaService mascotaService = new MascotaService();

bool ejecutando = true;

while (ejecutando)
{
    Console.Clear();

    var opcion = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("[green]Seleccione una opción[/]")
            .AddChoices(
                "1. Registrar Mascota",
                "2. Mostrar Mascotas",
                "3. Eliminar Mascota",
                "4. Salir"));

    switch (opcion)
    {
        case "1. Registrar Mascota":
            mascotaService.RegistrarMascota();
            break;

        case "2. Mostrar Mascotas":
            mascotaService.MostrarMascota();
            break;

        case "3. Eliminar Mascota":
            mascotaService.EliminarMascota();
            break;

        case "4. Salir":
            ejecutando = false;
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

    if (ejecutando)
    {
        AnsiConsole.MarkupLine("\n[blue]Presione una tecla para continuar...[/]");
        Console.ReadKey();
    }
}