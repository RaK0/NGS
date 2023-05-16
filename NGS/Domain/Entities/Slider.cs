using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Slider
    {
        [Key]
        public Guid Id { get; set; }
        public virtual Image Image { get; set; }
        public string Url { get; set; }
        public virtual User Adder { get; set; }
        public DateTime CreateDate { get; set; }
        public int Position { get; set; }
        public DateTime? ShowAfter { get; set; }
        public DateTime? HideOn { get; set;}
        public bool OnlyLoggedInUsersCanSee { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        [NotMapped]
        public bool IsActive
        {
            get
            {
                if(IsDeleted) return false;
                if(ShowAfter.HasValue && HideOn.HasValue) 
                    return ShowAfter<DateTime.Now && DateTime.Now <= HideOn;
                if (ShowAfter.HasValue && !HideOn.HasValue) 
                    return ShowAfter < DateTime.Now;
                if(!ShowAfter.HasValue && HideOn.HasValue) return DateTime.Now < HideOn;
                return false;
            }
        }
        public Slider()
        {
            CreateDate = DateTime.Now;
            IsDeleted = false;
        }
        public Slider(Image image, string url, User adder, int position, DateTime? showAfter, DateTime? hideOn, bool onlyLoggedInUsers, DateTime? deletedTime) : this()
        {
            Image = image;
            Url = url;
            Adder = adder;
            Position = position;
            ShowAfter = showAfter;
            HideOn = hideOn;
            OnlyLoggedInUsersCanSee = onlyLoggedInUsers;
            DeletedTime = deletedTime;
        }
    }
}
