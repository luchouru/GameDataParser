public class GameDataParserApp
{
    private readonly IUserInteractor _userInteractor;
    private readonly IGamePrinter _gamePrinter;
    private readonly IVideoGamesDeserializer _videoGamesDeserializer;
    private readonly IFileReader _reader;
    public GameDataParserApp(IUserInteractor userInteractor, IGamePrinter gamePrinter, IVideoGamesDeserializer videoGamesDeserializer, IFileReader reader)
    {
        _userInteractor = userInteractor;
        _gamePrinter = gamePrinter;
        _videoGamesDeserializer = videoGamesDeserializer;
        _reader = reader;
    }
    public void run()
    {
        string nomArch = _userInteractor.ReadFilePath();
        var ContenidoArchivo = _reader.Read(nomArch);
        List<VideoGame> videoGames = _videoGamesDeserializer.DeserializeFrom(nomArch, ContenidoArchivo);
        _gamePrinter.Print(videoGames);
    }
    
}
