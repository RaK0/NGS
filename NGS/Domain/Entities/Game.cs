using Domain.Consts;
using Domain.Entities.Base;
using NGS.Shared.Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Game
    {
        [Key]
        public Guid Id { get; set; }
        public string GameName { get; set; }
        public string Description { get; set; }
        public Games GameType { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsDisabled { get; set; }
        public virtual Image? Icon { get; set; }
        public virtual ICollection<GameStuff>? Stuffs { get; set; }
        public virtual ICollection<User>? Users { get; set; }
        
        public Game()
        {
            CreateTime = DateTime.Now;
            IsDisabled = false;
            Stuffs = new List<GameStuff>();
            Users = new List<User>();
        }
        public Game(string gameName, string description, Games gameType, Image icon) : this()
        {
            GameName = gameName;
            Description = description;
            GameType = gameType;
            Icon = icon;
        }
        public Game(string gameName, string description, Games gameType, byte[] icon) : this()
        {
            GameName = gameName;
            Description = description;
            GameType = gameType;
            Icon = new(icon, ImageSourcePossibility.Icon);
        }
    }
}
