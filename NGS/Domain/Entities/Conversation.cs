using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Conversation
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public virtual User? Sender { get; set; }
        public virtual User? Receiver { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedDate { get;set; }
        public virtual ICollection<Message> Messages { get; set; }

        public Conversation()
        {
            Messages = new List<Message>();
            CreateDate = DateTime.Now;
            IsDeleted = false;
        }
        
        public Conversation(User sender, User receiver, Message message, string title):this()
        {            
            Sender = sender;
            Receiver = receiver;
            Messages.Add(message);            
            Title = string.IsNullOrEmpty(title) ? message?.Content.Length > 20 ? message?.Content[..19] : message?.Content : title;
        }
    }
}
