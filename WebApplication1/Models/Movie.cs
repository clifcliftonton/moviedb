using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        public Guid id { get; set; }
        [DefaultValue("")]
        public string Imageurl { get; set; }
        public string Title { get; set; }
        public string Releaseyear { get; set; }
        public string Rated { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Country { get; set; }
        public string Imdbrating { get; set; }
        public string Type { get; set; }
    }

}