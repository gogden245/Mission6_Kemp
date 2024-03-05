using System.ComponentModel.DataAnnotations;

namespace Mission6_Kemp.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
