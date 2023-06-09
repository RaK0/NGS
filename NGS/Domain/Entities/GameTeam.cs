﻿using Domain.Consts;
using Domain.Entities.Base;
using NGS.Shared.Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GameTeam : GameStuff
    {
        public virtual User Creator { get; set; }
        public virtual ICollection<GameTeamInvitation> GameTeamInvitations { get; set; }                
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// Not in use, always null
        /// </summary>
        [NotMapped]
        public new static bool? IsConfirm => null;

        public GameTeam() 
        {
            CreateDate = DateTime.Now;
            Users = new List<User>();
            GameTeamInvitations = new List<GameTeamInvitation>();
            Games = new List<Game>();
        }
        public GameTeam(User creator, string name, string description, Image image): this()
        {
            Creator = creator;
            Name = name;
            Description = description;
            Image = image;            
        }
        public GameTeam(User creator, string name, string description, byte[] image) : this()
        {
            Creator = creator;
            Name = name;
            Description = description;
            Image = new(image, ImageSourcePossibility.Icon);
        }
    }
}
