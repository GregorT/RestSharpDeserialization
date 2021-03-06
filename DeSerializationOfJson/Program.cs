﻿using DeSerializationOfJson.Handlers;

namespace DeSerializationOfJson
{
    /// <summary>
    /// Startup class
    /// </summary>
    class Program
    {
        /// <summary>
        /// StartUp method
        /// </summary>
        static void Main()
        {
            var jsonData = "{\"has_title\":true,\"title\":\"GoodLuck\",\"entries\":[[\"/gettingstarted.pdf\",{\"thumb_exists\":false,\"path\":\"/GettingStarted.pdf\",\"client_mtime\":\"Wed, 08 Jan 2014 18:00:54+0000\",\"bytes\":249159}],[\"/task.jpg\",{\"thumb_exists\":true,\"path\":\"/Task.jpg\",\"client_mtime\":\"Tue, 14 Jan 2014 05:53:57+0000\",\"bytes\":207696}]]}";
            var jsonDeserializationHandler = new JsonDeserializationHandler();
            var result = jsonDeserializationHandler.GetFileCollectionModelFromJson(jsonData);
        }
    }
}
