using CameraReview.Models.CameraReviewSetting;
using CameraReview.Models.Product.Camera;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CameraReview.DataAccess
{
    public class CameraService
    {
        private const string COLLECTION_NAME = "Camera";
        private readonly IMongoCollection<ICamera> _camerasCollection;

        public CameraService(IOptions<CameraReviewDataBaseSetting> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);

            _camerasCollection = database.GetCollection<ICamera>(COLLECTION_NAME);
        }

        /// <summary>
        /// it allows to get all cameras stored
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ICamera>> GetCamerasAsync() =>
            await _camerasCollection.Find(_ => true).ToListAsync();

        /// <summary>
        /// it allows to get an camera by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ICamera> GetCameraAsync(string id) =>
            await _camerasCollection.Find(editor => editor.ProductId == id).FirstOrDefaultAsync();

        /// <summary>
        /// it allows to create an camera
        /// </summary>
        /// <param name="editor"></param>
        /// <returns></returns>
        public async Task CreateAsync(ICamera editor) =>
            await _camerasCollection.InsertOneAsync(editor);

        /// <summary>
        /// it allows to update an camera
        /// </summary>
        /// <param name="id"></param>
        /// <param name="editorIn"></param>
        /// <returns></returns>
        public async Task UpdateAsync(string id, ICamera editorIn) =>
            await _camerasCollection.ReplaceOneAsync(editor => editor.ProductId == id, editorIn);

        /// <summary>
        /// it allows to remove an camera
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task RemoveAsync(string id) =>
            await _camerasCollection.DeleteOneAsync(editor => editor.ProductId == id);
    }
}
