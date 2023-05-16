using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GameTeamInvitation : Invitation
    {
        public virtual GameTeam Team { get; set; }
        public GameTeamInvitation()
        {
            DateSend = DateTime.Now;
        }

        public GameTeamInvitation(User inviting, User invited, GameTeam team) : this()
        {
            CreatorOfInvite = inviting;
            UserInvited = invited;
            Team = team;
        }
    }
}
