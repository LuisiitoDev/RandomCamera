namespace CameraReview.Models.Editor
{
    public interface IEditor
    {
        public string EditorId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
