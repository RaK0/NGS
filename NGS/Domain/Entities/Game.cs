using NGS.Shared.Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        
        public Game()
        {
            CreateTime = DateTime.Now;
            IsDisabled = false;
        }
        public Game(string gameName, string description, Games gameType) : this()
        {
            GameName = gameName;
            Description = description;
            GameType = gameType;
        }
    }
}
