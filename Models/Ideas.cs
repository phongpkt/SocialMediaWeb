using System;
using System.ComponentModel.DataAnnotations;

namespace WebDemo.Models
{
    public class Ideas
    {
        public int IdeasId { get; set; }
        public string Publisher { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Published Date")]
        public DateTime PublishedDate { get; set; }

    }
}
