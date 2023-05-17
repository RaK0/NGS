using Domain.Consts;
using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GameRank : GameStuff
    {
        [MaxLength(1)]
        public override ICollection<Game> Games { get; set; }
        public GameRank()
        {
            IsConfirm = false;
            Users = new List<User>();
            Games = new List<Game>();
        }

        public GameRank(Game game, string rankName, string rankDescription, Image image) : this()
        {
            Games = new List<Game>
            {
                game
            };
            Name = rankName;
            Description = rankDescription;
            Image = image;

        }
        public GameRank(Game game, string rankName, string rankDescription, byte[] image) : this()
        {
            Games = new List<Game>
            {
                game
            };
            Name = rankName;
            Description = rankDescription;
            Image = new(image, ImageSourcePossibility.Icon);
        }
    }
}
