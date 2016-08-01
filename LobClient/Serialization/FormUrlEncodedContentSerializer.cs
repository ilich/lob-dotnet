using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Lob.Serialization
{
    class FormUrlEncodedContentSerializer
    {
        public FormUrlEncodedContent Serialize<T>(T data)
        {
            var request = Convert(data);
            var content = new FormUrlEncodedContent(request);
            return content;
        }

        protected internal virtual IDictionary<string, string> Convert<T>(T data)
        {
            var result = new Dictionary<string, string>();

            var type = data.GetType();
            foreach(var property in type.GetProperties())
            {
                var formUrl = property.GetCustomAttributes(typeof(FormUrlAttribute), false).FirstOrDefault() as FormUrlAttribute;
                if (formUrl != null)
                {
                    var value = property.GetValue(data);
                    if (value != null)
                    {
                        result.Add(formUrl.Name, value.ToString());
                    }
                }
            }
            return result;
        }
    }
}
