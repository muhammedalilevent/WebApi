using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;

namespace _4_WebApi_XML_JSON_Serialize.Service
{
    public interface ISerializer<T> where T:class 
    {
        string Serialize<R>(MediaTypeFormatter formatter, T value) where R : class;

        T DeSerialize<R>(MediaTypeFormatter formatter, string value) where R : class;
           

    }
}
