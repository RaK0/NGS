using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Base
{
    public class Section
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsHidden { get; set; }
        public bool IsPined { get; set; }
        public Image Icon { get; set; }   
        //Under using for seting display position, if under null is first position 
        public Section? DisplayUnder { get; set; }
    }
}
