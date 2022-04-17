using CameraReview.Models.Editor;
using CameraReview.Models.Product;

namespace CameraReview.Models.Review
{
    public interface IReview
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public IEditor Editor { get; set; }
        public IProduct Product { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
