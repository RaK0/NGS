﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Base
{
    public class Invitation
    {
        [Key]
        public Guid Id { get; set; }
        public virtual User? UserInvited { get; set; }
        public virtual User? CreatorOfInvite { get; set; }
        public bool? Accepted { get; set; }
        public bool? PreventFromNextInvite { get; set; }
        public DateTime DateSend { get; set; }
    }
}
