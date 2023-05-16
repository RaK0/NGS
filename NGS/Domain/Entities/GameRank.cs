using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GameRank : GameStuff
    {
        public GameRank() { }

        public GameRank(Game game, string rankName, string rankDescription, Image image)
        {
            Game = game;
            Name = rankName;
            Description = rankDescription;
            Image = image;
            IsConfirm = false;
        }
    }
}
