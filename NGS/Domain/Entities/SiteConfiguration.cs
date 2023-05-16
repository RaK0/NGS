using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SiteConfiguration
    {
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// How much items display under main Section
        /// </summary>
        public int ItemsDisplayedUnderMainSection { get; set; }
        /// <summary>
        /// If null load after x item
        /// </summary>
        public int? PostsInTopicDisplayed { get; set; }
        public int? PostsInTopicLoadAfter { get; set; }
        /// <summary>
        /// If null load after x item
        /// </summary>
        public int? MessagesDisplayedInConversation { get; set; }
        public int? MessageDisplayLoadAfter { get; set; }
        
        public SiteConfiguration() { }
    }
}
