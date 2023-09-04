using System.ComponentModel.DataAnnotations.Schema;

namespace NLayer.Core.Models
{
    public class Product : BaseEntity
    {

        public string Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        // navigation proporty 
        public ProductFeature ProductFeature { get; set; }
    }
}
