using Domain.Entities.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : IdentityUser<Guid>
    {
        public virtual Image? Avatar { get; set; }
        public virtual Image? Background { get; set; }
        public virtual ICollection<Game>? Games { get; set; }
        public virtual ICollection<GameStuff>? GameStuffs { get; set; }
        public virtual ICollection<Invitation>? InvitationsSend { get; set; }
        public virtual ICollection<Invitation>? InvitationsReceive { get; set; }

        public User()
        {
            Games = new List<Game>();
            GameStuffs = new List<GameStuff>();
            InvitationsSend = new List<Invitation>();
            InvitationsReceive = new List<Invitation>();
        }
    }
}
