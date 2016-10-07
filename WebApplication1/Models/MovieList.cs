using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("MovieList")]
    public class MovieList
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public ICollection<Movie> Movies { get; set; }
    }
    public class MovieDBContext : DbContext
    {
        public DbSet<MovieList> MovieLists { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }

}