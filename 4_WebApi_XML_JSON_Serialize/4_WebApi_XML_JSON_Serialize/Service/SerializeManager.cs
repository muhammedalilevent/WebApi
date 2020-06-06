using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web;

namespace _4_WebApi_XML_JSON_Serialize.Service
{
    public class SerializeManager<T> : ISerializer<T> where T : class
    {
        public T DeSerialize<R>(MediaTypeFormatter formatter, string value) where R : class
        {
            Stream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(value);
            writer.Flush();
            stream.Position = 0;
            return formatter.ReadFromStreamAsync(typeof(T), stream, null, null).Result as T;
        }

        public string Serialize<R>(MediaTypeFormatter formatter, T value) where R : class
        {
            Stream stream = new MemoryStream();
            var content = new StreamContent(stream);
            formatter.WriteToStreamAsync(typeof(T), value, stream, content, null).Wait();
            stream.Position = 0;
            return content.ReadAsStringAsync().Result;
        }
    }
}