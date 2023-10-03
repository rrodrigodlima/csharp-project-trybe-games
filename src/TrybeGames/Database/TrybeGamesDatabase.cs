namespace TrybeGames;

public class TrybeGamesDatabase
{
    public List<Game> Games = new List<Game>();

    public List<GameStudio> GameStudios = new List<GameStudio>();

    public List<Player> Players = new List<Player>();

    // 4. Crie a funcionalidade de buscar jogos desenvolvidos por um estúdio de jogos
    public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
    {
        // implementar
        var gamesDevelopedByStudio = Games.Where(game => game.DeveloperStudio == gameStudio.Id).ToList();

        return gamesDevelopedByStudio;
    }

    // 5. Crie a funcionalidade de buscar jogos jogados por uma pessoa jogadora
    public List<Game> GetGamesPlayedBy(Player player)
    {
        // Implementar
        var gamesPlayedByPlayer = Games.Where(game => player.GamesOwned.Contains(game.Id)).ToList();

        return gamesPlayedByPlayer;
    }

    // 6. Crie a funcionalidade de buscar jogos comprados por uma pessoa jogadora
    public List<Game> GetGamesOwnedBy(Player playerEntry)
    {
        // Implementar
        var gamesOwnedByPlayer = Games.Where(game => playerEntry.GamesOwned.Contains(game.Id)).ToList();

        return gamesOwnedByPlayer;
    }


    // 7. Crie a funcionalidade de buscar todos os jogos junto do nome do estúdio desenvolvedor
    public List<GameWithStudio> GetGamesWithStudio()
    {
        // Implementar
        var gamesWithStudio = (from game in Games
                               join studio in GameStudios on game.DeveloperStudio equals studio.Id
                               select new GameWithStudio
                               {
                                   GameName = game.Name,
                                   StudioName = studio.Name,
                                   NumberOfPlayers = game.Players.Count
                               }).ToList();

        return gamesWithStudio;
    }

    // 8. Crie a funcionalidade de buscar todos os diferentes Tipos de jogos dentre os jogos cadastrados
    public List<GameType> GetGameTypes()
    {
        // Implementar
        throw new NotImplementedException();
    }

    // 9. Crie a funcionalidade de buscar todos os estúdios de jogos junto dos seus jogos desenvolvidos com suas pessoas jogadoras
    public List<StudioGamesPlayers> GetStudiosWithGamesAndPlayers()
    {
        // Implementar
        throw new NotImplementedException();
    }

}
