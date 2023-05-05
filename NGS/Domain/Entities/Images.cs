using Domain.Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Images
    {
        [Key]
        public Guid Id { get; set; }
        public byte[]? Image { get; set; }
        public string? UploadName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeleteDate { get; set; }
        public DateTime AddDate { get; set; }
        public ImageSourcePossibility ImageSource { get; set; }

        public Images()
        {
            IsDeleted = false;
            AddDate = DateTime.Now;
        }

        public Images(byte[] image, ImageSourcePossibility imageSource):this()
        {
            Image = image;
            ImageSource = imageSource;
        }
    }
}
