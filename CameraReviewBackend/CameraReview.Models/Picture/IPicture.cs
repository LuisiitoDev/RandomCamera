using CameraReview.Models.Review;

namespace CameraReview.Models.Picture
{
    public interface IPicture
    {
        public long PictureId { get; set; }
        public IReview Review { get; set; }
        public Uri URL { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
