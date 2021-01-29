using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
        public string GameType { get; set; }
        public string GameCategori { get; set; }
        public string GameEAN { get; set; }
    }
}
