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
        public GameRole() { }

        public GameRole(Game game, string roleName, string roleDescription, Image image)
        {
            Game = game;
            Name = roleName;
            Description = roleDescription;
            Image = image;
        }
    }
}
