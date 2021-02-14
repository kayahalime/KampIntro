using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun eklendi");
        }
    }
}
