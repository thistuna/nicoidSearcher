using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace nicoidSearch
{
    public class VideoInfo
    {
        public string id { get; set; }
        public string title { get; set; }
    }

    [DataContract]
    public class JsonInfo
    {
        [DataMember]
        public string videoTitle { get; set; }
    }

    static public class NicoidJson
    {

        static public VideoInfo Load(string path)
        {
            var jsonStr = System.IO.File.ReadAllText(path);
            JsonInfo jsonData = new JsonInfo();
            jsonData = System.Text.Json.JsonSerializer.Deserialize<JsonInfo>(jsonStr);

            var id = System.IO.Path.GetFileNameWithoutExtension(path);
            var title = jsonData.videoTitle;

            return new VideoInfo { id = id, title = title };
        }
    }
}
