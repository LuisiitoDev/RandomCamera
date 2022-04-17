using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraReview.Models.Product.Camera
{
    public interface ICamera : IProduct
    {
        int maxISO { get; set; }
        string type { get; set; }
        int cropFactor { get; set; }
    }
}
