public class GamePrinter : IGamePrinter
{
    private readonly IUserInteractor _userInteractor;

    public GamePrinter(IUserInteractor userInteractor)
    {
        this._userInteractor = userInteractor;
    }
    public void Print(List<VideoGame> videoGames)
    {
        if (videoGames != null)
        {
            _userInteractor.ImprimirMensaje(Environment.NewLine + "Los videojuegos cargados son: ");
            foreach (var videoGame in videoGames)
            {
                _userInteractor.ImprimirMensaje(videoGame.ToString());
            }
        }
        else
        {
            _userInteractor.ImprimirMensaje("No hay videojuegos en el archivo");
        }
    }
}
