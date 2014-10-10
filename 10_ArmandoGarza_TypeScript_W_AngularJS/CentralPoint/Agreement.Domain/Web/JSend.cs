using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Agreement.Domain.Web
{
    public class JSend
    {
        public static string Success()
        {
            var result = new
            {
                status = "success"
            };
            return JsonConvert.SerializeObject(result);
        }


        public static string Success<T>(T data)
        {
            var result = new
            {
                status = "success",
                data
            };
            return JsonConvert.SerializeObject(result);
        }

        public static string Success<T>(T data, IEnumerable<JSendMessage> messages)
        {
            var result = new
            {
                status = "success",
                data,
                messages
            };
            return JsonConvert.SerializeObject(result);
        }


        public static string Error(string message)
        {
            var result = new
            {
                status = "error",
                message
            };
            return JsonConvert.SerializeObject(result);
        }

        public static string Fail(IDictionary<string, string> messages)
        {
            var builder = new StringBuilder();
            builder.Append("{\"status\":\"fail\",\"data\": {");

            var ndx = false;
            foreach (var message in messages)
            {
                if (ndx) builder.Append(",");
                builder.AppendFormat("\"{0}\":\"{1}\"", message.Key, message.Value);
                ndx = true;
            }
            builder.Append("}}");

            var result = builder.ToString();
            return result;
        }
    }


}
