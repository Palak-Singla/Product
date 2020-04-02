
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GitHubProject.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int PId { get; set; }
        public string PName { get; set; }
        public string PDesc { get; set; }
        public int PPrice { get; set; }
    }
}
