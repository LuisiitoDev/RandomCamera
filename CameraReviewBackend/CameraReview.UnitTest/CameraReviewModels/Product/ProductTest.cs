using CameraReview.Models.Product;
using CameraReview.Models.Product.Camera;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CameraReview.UnitTest.CameraReviewModels.Product
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void Product_Should_Return_Content_Success()
        {
            // SET UP
            IProduct product = new Models.Product.Product()
            {
                Name = "Producto 1",
                SKU = "124",
                Manufacturer = "Company"
            }; // MOCK

            // EXECUTE
            string content = product.GetContent();

            // ASSERT
            Assert.IsTrue(!string.IsNullOrWhiteSpace(content), "Should return content but obtained null or white space");
        }

        [TestMethod]
        public void Camera_Should_Return_Content_That_Include_its_Features_Success()
        {
            // SET UP
            string type = "FullFrame";
            ICamera camera = new Models.Product.Camera.Camera()
            {
                Name = "Camera 1",
                type = type,
                cropFactor = 1
            }; // MOCK

            // EXECUTE
            string content = camera.GetContent();

            // ASSERT
            Assert.IsTrue(!string.IsNullOrWhiteSpace(content), "Should return content but obtained null or white space");
            Assert.IsTrue(content.Contains(type));
        }
    }
}
