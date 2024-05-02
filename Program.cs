using System.Collections.Generic;
var userInteractor = new ConsolaUsuario();
var app = new GameDataParserApp(userInteractor, new GamePrinter(userInteractor), 
    new VideoGamesDeserializer(userInteractor), new LocalFileReader());
var logger = new Logger("log.txt");

try
{
    app.run();
}
catch(Exception ex)
{
    Console.WriteLine("Ha ocurrido un error. La aplicacion debera cerrarse.");
}
