using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Entities.Concrete
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameKind { get; set; }
        public double Price { get; set; }
    }
}
