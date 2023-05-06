using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Message
    {
        [Key]
        public Guid Id { get; set; }
        public string Content { get; set; }  
        public DateTime SendDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeleteDate { get; set; }
        public bool IsReported { get; set; }
        public ICollection<Image>? Images { get; set; }
        public User? Owner { get; set; }

        public Message()
        {
            Images = new List<Image>();
            SendDate = DateTime.Now;
            IsDeleted = false;
        }
        public Message(string content, ICollection<Image> images, User? owner = null) : this()
        {
            Content = content;
            Images = images;
            Owner = owner;
        }
    }
}
