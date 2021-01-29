using GameHomework.Abstract;
using GameHomework.Entities;
using System.Collections.Generic;

namespace GameHomework.Concrete
{
    public class GameManager : IGameService
    {
        List<Game> gameList = new List<Game>();
        public void Add(Game game)
        {
            System.Console.WriteLine(game.GameName + " oyunu eklendi.");
            gameList.Add(game);
        }

        public void Delete(Game game)
        {
            System.Console.WriteLine(game.GameName + " oyunu silindi.");
        }

        public void List()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Game game)
        {
            System.Console.WriteLine(game.GameName + " oyunu güncellendi.");
        }
    }
}
