using DeSerializationOfJson.Models;
using RestSharp;
using RestSharp.Deserializers;

namespace DeSerializationOfJson.Handlers
{
    /// <summary>
    /// Json deserialization handler
    /// </summary>
    internal class JsonDeserializationHandler
    {
        /// <summary>
        /// Gets the file collection model from json.
        /// </summary>
        /// <param name="jsonData">The json data.</param>
        /// <returns></returns>
        public FileCollectionModel GetFileCollectionModelFromJson(string jsonData)
        {
            var response = new RestResponse();
            response.Content = jsonData;
            response.ContentLength = jsonData.Length;
            response.ContentType = "text/json";
            var result = new JsonDeserializer().Deserialize<FileCollectionModel>(response);
            var tempList = new JsonDeserializer().Deserialize<TempObject>(response);
            foreach (var item in tempList.entries)
            {
                result.FileList.Add(new System.Tuple<string, FileItemModel>(item[0], new JsonDeserializer().Deserialize<FileItemModel>(new RestResponse() {Content=item[1], ContentType="text/json"})));
            }
            return result;
        }
    }
}