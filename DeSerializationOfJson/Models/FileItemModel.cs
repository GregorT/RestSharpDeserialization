using RestSharp.Deserializers;
using System;

namespace DeSerializationOfJson.Models
{
    /// <summary>
    /// File Item model
    /// </summary>
    public class FileItemModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether thumbnail exists.
        /// </summary>
        /// <value>
        ///   <c>true</c> if thumbnail exists; otherwise, <c>false</c>.
        /// </value>
        [DeserializeAs(Name = "thumb_exists")]
        public bool ThumbnailExists { get; set; }

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        [DeserializeAs(Name = "path")]
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the client modified time.
        /// </summary>
        /// <value>
        /// The client modified time.
        /// </value>
        [DeserializeAs(Name = "client_mtime")]
        public DateTime ClientModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets the size of the file.
        /// </summary>
        /// <value>
        /// The size of the file.
        /// </value>
        [DeserializeAs(Name = "bytes")]
        public int FileSize { get; set; }
    }
}