using System.Collections.Generic;
using System.IO;
using System.Reflection;
using HyperWalletLibrary.Model;
using Newtonsoft.Json;

namespace HyperWalletLibrary.Components
{
    public static class JsonToEnumerableOfUserConverter
    {
        public static IEnumerable<User> Convert(string json)
        {
            List<User> list = new List<User>();
            JsonReader reader = new JsonTextReader(new StringReader(json));
            User user = new User();
            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.StartObject)
                {
                    user = new User();
                    continue;
                }
                else if (reader.TokenType == JsonToken.PropertyName)
                {
                    PropertyInfo property = typeof(User).GetProperty(reader.Value.ToString());
                    reader.Read();
                    if (reader.TokenType == JsonToken.StartArray)
                    {
                        //property.SetValue(user, new List<Link>());
                        //reader.Read();//reader.TokenType == JsonToken.StartObject
                        //reader.Read();//reader.TokenType == JsonToken.PropertyName
                        //PropertyInfo objectProperty = 
                        //continue;
                    }
                    property.SetValue(user, reader.Value);
                }
            }
            return list;
        }
    }
}
