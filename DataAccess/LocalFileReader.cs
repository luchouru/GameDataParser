public class LocalFileReader : IFileReader
{
    public string Read(string nomArch)
    {
        return File.ReadAllText(nomArch);
    }
}
