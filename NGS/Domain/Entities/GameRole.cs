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
        [MaxLength(1)]
        public override ICollection<Game> Games { get; set; }
        public GameRole()
        {
            Users = new List<User>();
            Games = new List<Game>();
        }

        public GameRole(Game game, string roleName, string roleDescription, Image image)
        {
            Games = new List<Game>
            {
                game
            };
            Name = roleName;
            Description = roleDescription;
            Image = image;
        }
        public GameRole(Game game, string roleName, string roleDescription, byte[] image)
        {
            Games = new List<Game>
            {
                game
            };
            Name = roleName;
            Description = roleDescription;
            Image = new(image, ImageSourcePossibility.Icon);
        }
    }
}
