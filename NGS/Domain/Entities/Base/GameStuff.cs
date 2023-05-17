using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Base
{
    public class GameStuff
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual Image? Image { get; set; }
        public virtual bool IsConfirm { get; set; }
        public virtual ICollection<User>? Users { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}
