using Domain.Consts;
using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GameRank : GameStuff
    {
        /// <summary>
        /// Not in use, always null
        /// </summary>
        [NotMapped]
        public new static ICollection<Game>? Games => null;
        public ICollection<User> Users { get; set; }
        public GameRank()
        {
            IsConfirm = false;
            Users = new List<User>();
        }

        public GameRank(Game game, string rankName, string rankDescription, Image image) : this()
        {
            Game = game;
            Name = rankName;
            Description = rankDescription;
            Image = image;

        }
        public GameRank(Game game, string rankName, string rankDescription, byte[] image) : this()
        {
            Game = game;
            Name = rankName;
            Description = rankDescription;
            Image = new(image, ImageSourcePossibility.Icon);
        }
    }
}
