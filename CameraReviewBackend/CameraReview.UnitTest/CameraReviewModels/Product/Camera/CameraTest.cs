using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraReview.UnitTest.CameraReviewModels.Product.Camera
{
    [TestClass]
    public class CameraTest
    {
        [TestMethod]
        public void Camera_Should_Return_A_Dictionary_Of_Features()
        {
            // Arrange
            var camera = new CameraReview.Models.Product.Camera.Camera()
            {
                Features = new List<Models.Product.Feature>()
                {
                    new Models.Product.Feature
                    {
                        Name = "Memory SD",
                        Description = "Memory from SD"
                    }
                }
            };

            // Act
            var result = camera.GetFeatures();

            // Assert
            Assert.IsInstanceOfType(result, typeof(Dictionary<string, string>));
        }
    }
}
