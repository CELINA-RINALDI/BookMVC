using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCBook.Models
{
    [Table("Book")]
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Author { get; set; }

        [Range(100, 10000)]
        public int PagesNumber { get; set; }

        [Column(TypeName = "varchar")]
        public string Publisher { get; set; }

        [Column(TypeName = "varchar")]
        [RegularExpression(@"^\d{4}(\-|\/|\.)\d{1,2}\1\d{1,2}$")]
        public string PublicationDate { get; set; }

        [Column(TypeName = "varchar")]
        public string Content { get; set; }

        [Column(TypeName = "Money")]
        public decimal Price { get; set; }

        [Column(TypeName = "Money")]
        [Compare("Price")]
        public decimal PriceConfirm { get; set; }

    }
}