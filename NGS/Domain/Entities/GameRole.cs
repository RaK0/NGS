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
    public class GameRole : GameStuff
    {
        [NotMapped]
        public override bool IsConfirm => true;
        /// <summary>
        /// Not in use, always null
        /// </summary>
        [NotMapped]
        public new static ICollection<Game>? Games => null;
        public GameRole() { }

        public GameRole(Game game, string roleName, string roleDescription, Image image)
        {
            Game = game;
            Name = roleName;
            Description = roleDescription;
            Image = image;
        }
        public GameRole(Game game, string roleName, string roleDescription, byte[] image)
        {
            Game = game;
            Name = roleName;
            Description = roleDescription;
            Image = new(image, ImageSourcePossibility.Icon);
        }
    }
}
