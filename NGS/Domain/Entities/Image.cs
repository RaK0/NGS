using Domain.Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Image
    {
        [Key]
        public Guid Id { get; set; }
        public byte[]? ImageData { get; set; }
        public string UploadName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeleteDate { get; set; }
        public DateTime AddDate { get; set; }
        public ImageSourcePossibility ImageSource { get; set; }

        public Image()
        {
            IsDeleted = false;
            AddDate = DateTime.Now;
        }

        public Image(byte[] image, ImageSourcePossibility imageSource):this()
        {
            ImageData = image;
            ImageSource = imageSource;
        }
    }
}
