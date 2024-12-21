using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookShopAPI.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        public string Genre { get; set; }
    }
}
