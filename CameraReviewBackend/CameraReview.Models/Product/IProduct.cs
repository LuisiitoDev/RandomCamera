namespace CameraReview.Models.Product
{
    public interface IProduct
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public string SKU { get; set; }
        public List<Feature> Features { get; set; }
        public DateTime CreatedDate { get; set; }
        public string GetContent()
        {
            return "";
        }
    }
}
