using System.Text.Json;

public class VideoGamesDeserializer : IVideoGamesDeserializer
{
    private readonly IUserInteractor _userInteractor;

    public VideoGamesDeserializer(IUserInteractor userInteractor)
    {
        _userInteractor = userInteractor;
    }

    public List<VideoGame> DeserializeFrom(string nomArch, string ContenidoArchivo)
    {
        List<VideoGame> videoGames = default;

        try
        {
            videoGames = JsonSerializer.Deserialize<List<VideoGame>>(ContenidoArchivo);
        }
        catch (JsonException ex)
        {
            _userInteractor.ImprimirMensaje($"Json en el archivo {nomArch} no tiene el formato correcto");
            _userInteractor.ImprimirError(ContenidoArchivo);

        }

        return videoGames;
    }
}
