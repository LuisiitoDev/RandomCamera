using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraReview.Models.Product
{
    public class Product : IProduct
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public string SKU { get; set; }
        public List<Feature> Features { get; set; }
        public DateTime CreatedDate { get; set; }

        public string GetContent()
        {
            return "Product content";
        }
    }
}
