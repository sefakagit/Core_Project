using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SocialMedia
    {
        [Key]
        public int SocialMediaID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; } //sosyal medya urlsi
        public string Icon { get; set; } //font-awesome'dan
        public bool Status { get; set; }
    }
}

