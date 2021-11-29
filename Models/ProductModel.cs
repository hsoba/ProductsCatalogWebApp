using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProductsCatalogWebApp.Models
{
    public class ProductModel
    {
        [DisplayName("ID Number")]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        public string Name { get; set; }

        [DisplayName("Regular Price")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [DisplayName("Product Description")]
        public string Description { get; set; }
    }
}
