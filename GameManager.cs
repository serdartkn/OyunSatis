using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatis
{
    class GameManager : IGameService
    {
        public void Sales(Gamer gamer, Game game)
        {
            Console.WriteLine("Sayın " + gamer.FirstName + " " + gamer.LastName + " " + game.GameName + " " + "Adlı Oyunu" + " " + game.GamePrice +"TL " + "Karşılığında Satın Aldınız.");
        }
    }
}
