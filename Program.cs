using System;

namespace OyunSatis
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer serdar = new Gamer();
            serdar.FirstName = "Serdar";
            serdar.LastName = "Tekin";
            serdar.DateOfBirth = new DateTime(1996,9,13);
            serdar.IdNo = "01011010110";

            Game gtav = new Game();
            gtav.GameName = "GTA";
            gtav.GamePrice = 385;


            //GamerManager gamerManager = new GamerManager(new CheckRealGamer());
            //gamerManager.Add(serdar);

            GameManager gameManager = new GameManager();
            gameManager.Sales(serdar,gtav);
        }
    }
}
