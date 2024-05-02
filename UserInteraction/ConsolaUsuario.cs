public class ConsolaUsuario : IUserInteractor
{
    public void ImprimirError(string mensaje)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(mensaje);
        Console.BackgroundColor = ConsoleColor.Black;
    }

    public void ImprimirMensaje(string mensaje)
    {
        Console.WriteLine(mensaje);
    }

    public string ReadFilePath()
    {
        var nomArch = default(string);
        bool isFilePathValid = false;
        do
        {
            Console.WriteLine("Ingrese el nombre del archivo que desea leer: ");
            nomArch = Console.ReadLine();

            if (nomArch is null)
            {
                Console.WriteLine("El nombre del archivo no puede ser nulo");
            }
            else if (nomArch == string.Empty)
            {
                Console.WriteLine("El nombre no puede estar vacio");
            }
            else if (!File.Exists(nomArch))
            {
                Console.WriteLine("El archivo no existe");
            }
            else
            {
                isFilePathValid = true;
            }
        } while (!isFilePathValid);
        return nomArch;
    }
}
