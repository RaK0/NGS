using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MainSection : Section
    {
        public MainSection()
        {
            IsDeleted = false;
            IsHidden = false;
        }
        public MainSection(string name, string descritpion, string longDesc, Image image) : this()
        {
            Name = name;
            Description = descritpion;
            LongDescription = longDesc;
            Icon = image;
        }
        public MainSection(string name, string descritpion, string longDesc, byte[] image) : this()
        {
            Name = name;
            Description = descritpion;
            LongDescription = longDesc;
            Icon = new(image, Consts.ImageSourcePossibility.Icon);
        }
    }
}
