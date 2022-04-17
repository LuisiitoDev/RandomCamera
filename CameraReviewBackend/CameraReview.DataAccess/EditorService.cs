using CameraReview.Models.CameraReviewSetting;
using CameraReview.Models.Editor;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CameraReview.DataAccess
{
    public class EditorService
    {
        private const string COLLECTION_NAME = "Editor";
        private readonly IMongoCollection<IEditor> _editorsCollection;

        public EditorService(IOptions<CameraReviewDataBaseSetting> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);

            _editorsCollection = database.GetCollection<IEditor>(COLLECTION_NAME);
        }

        /// <summary>
        /// it allows to get all editores stored
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<IEditor>> GetEditorsAsync() =>
            await _editorsCollection.Find(_ => true).ToListAsync();

        /// <summary>
        /// it allows to get an editor by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IEditor> GetEditorAsync(string id) =>
            await _editorsCollection.Find(editor => editor.EditorId == id).FirstOrDefaultAsync();

        /// <summary>
        /// it allows to create an editor
        /// </summary>
        /// <param name="editor"></param>
        /// <returns></returns>
        public async Task CreateAsync(IEditor editor) =>
            await _editorsCollection.InsertOneAsync(editor);

        /// <summary>
        /// it allows to update an editor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="editorIn"></param>
        /// <returns></returns>
        public async Task UpdateAsync(string id, IEditor editorIn) =>
            await _editorsCollection.ReplaceOneAsync(editor => editor.EditorId == id, editorIn);

        /// <summary>
        /// it allows to remove an editor
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task RemoveAsync(string id) =>
            await _editorsCollection.DeleteOneAsync(editor => editor.EditorId == id);
    }
}
