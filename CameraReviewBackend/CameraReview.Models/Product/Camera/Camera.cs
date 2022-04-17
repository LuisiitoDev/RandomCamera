using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraReview.Models.Product.Camera
{
    public class Camera : ICamera
    {
        public int maxISO { get; set; }
        public string type { get; set; }
        public int cropFactor { get; set; }
        public long ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public string SKU { get; set; }
        public List<Feature> Features { get; set; }
        public DateTime CreatedDate { get; set; }

        public string GetContent()
        {
            return $"Type: {type}\n" +
                   $"CropFactor: {cropFactor}\n";
        }

        public Dictionary<string, string> GetFeatures()
        {
            Dictionary<string, string> features = new Dictionary<string, string>();
            foreach (Feature feature in Features)
            {
                features.Add(feature.Name, feature.Description);
            }
            return features;
        }
    }
}
